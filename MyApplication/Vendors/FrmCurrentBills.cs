using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPro;
using MyGeneration.dOOdads;

namespace MyApplication.Vendors
{
    public partial class FrmCurrentBills : Form
    {
        string MySearchType;
        public FrmCurrentBills()
        {
            InitializeComponent();
        }

        private void FrmCurrentBills_Load(object sender, EventArgs e)
        {
            MySearchType = "date";
            FillMyGrid();           
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 32);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            ListViewItem item = listView1.SelectedItems[0];
            int id = int.Parse(item.SubItems[0].Text);
            DialogBillDetails ff = new DialogBillDetails(id);
            ff.ShowDialog();
            if (ff.DialogResult == DialogResult.OK)
            {
                FillMyGrid();
            }            
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            MySearchType = "date";
            FillMyGrid();
        }

        private void FillMyGrid()
        {
            double AllBuys = 0, AllBacks = 0;
            ListViewItem lv;
            listView1.Items.Clear();

            double Total1 = 0, Total2 = 0, Total3 = 0;

            ViewVendorsBills obj = new ViewVendorsBills();
            if (MySearchType == "date")
            {
                obj.Where.Bill_Date.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text);
                obj.Where.Bill_Date.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text);
                obj.Where.Bill_Date.Operator = WhereParameter.Operand.Between;
            }
            else if (MySearchType == "number")
            {
                obj.Where.Bill_VendorNumber.Value = txtNumber.Text;
            }
            else if (MySearchType == "name")
            {
                obj.Where.Vendor_Name.Value = "%" + txtVendorName.Text + "%";
                obj.Where.Vendor_Name.Operator = WhereParameter.Operand.Like;
            }
            if (obj.Query.Load())
            {
                obj.Sort = ViewVendorsBills.ColumnNames.Bill_Date + " ASC";
                int g = 0;
                do
                {
                    ClassVendorBillTotal cs = new ClassVendorBillTotal(obj.Bill_ID);                   
                    ++g;
                    lv = new ListViewItem(obj.Bill_ID.ToString());
                    lv.SubItems.Add(g.ToString());
                    lv.SubItems.Add(obj.Bill_Date.ToShortDateString());
                    lv.SubItems.Add(obj.Bill_PayType);
                    lv.SubItems.Add(obj.Vendor_Name);
                    lv.SubItems.Add(obj.Bill_VendorNumber);
                    lv.SubItems.Add(cs.BillTotalWithOutVat.ToString("0,0.00"));
                    lv.SubItems.Add(cs.BillVat.ToString("0,0.00"));
                    lv.SubItems.Add(cs.BillTotalAfterDiscount.ToString("0,0.00"));
                    lv.SubItems.Add(obj.Bill_Details);
                    lv.SubItems.Add(obj.User_Name);
                    if (obj.Bill_PayType.Contains("مرتجعات"))
                    {
                        Total1 -= cs.BillTotalWithOutVat;
                        Total2 -= cs.BillVat;
                        Total3 -= cs.BillTotalAfterDiscount;

                        AllBacks += cs.BillTotalAfterDiscount;
                        lv.BackColor = Color.Yellow;
                    }
                    else
                    {
                        Total1 += cs.BillTotalWithOutVat;
                        Total2 += cs.BillVat;
                        Total3 += cs.BillTotalAfterDiscount;

                        if (obj.Bill_PayType == "فاتورة مشتريات كاش")
                        {
                            lv.BackColor = Color.Lime;
                        }
                        AllBuys += cs.BillTotalAfterDiscount;
                    }
                  

                    listView1.Items.Add(lv);
                } while (obj.MoveNext());
            }

            lblTotal1.Text = Total1.ToString("0,0.00");
            lblTotal2.Text = Total2.ToString("0,0.00");
            lblTotal3.Text = Total3.ToString("0,0.00");

            lblBuys.Text = AllBuys.ToString("0,0.00");
            lblBacks.Text = AllBacks.ToString("0,0.00");
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //------------------------------------------------------------
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 )
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && txtNumber.Text != "")
            {                
                    MySearchType = "number";
                    FillMyGrid();                
            }
        }

        private void txtVendorName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtVendorName.Text != "")
            {
                MySearchType = "name";
                FillMyGrid();
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            btnSearchByDate_Click(sender, e);

            if (listView1.Items.Count > 0)
            {
                TblPrint pr = new TblPrint();
                pr.LoadAll();
                pr.DeleteAll();
                pr.Save();
              

                foreach (ListViewItem item in listView1.Items)
                {
                    TblPrint obj = new TblPrint();
                    obj.AddNew();
                    obj.Column1 = item.SubItems[2].Text;
                    obj.Column2 = item.SubItems[3].Text;
                    obj.Column3 = item.SubItems[4].Text;
                    obj.Column4 = item.SubItems[5].Text;
                    obj.Column6 = item.SubItems[6].Text;
                    obj.Column7 = item.SubItems[7].Text;
                    obj.Column8 = item.SubItems[8].Text;
                    obj.Column9 = "تقرير عن المشتريات خلال المدة من: " + dateTimePicker1.Text + " إلى: " + dateTimePicker2.Text;

                    ViewVendorsBills bb = new ViewVendorsBills();
                    bb.Where.Bill_ID.Value = int.Parse(item.SubItems[0].Text);
                    bb.Query.Load();

                    obj.Column10 = bb.Vendor_Email;

                    obj.Column11 = lblTotal1.Text;
                    obj.Column12 = lblTotal2.Text;
                    obj.Column13 = lblTotal3.Text;
                    obj.Save();
                }

                FrmPrintBuys x = new FrmPrintBuys();
                x.ShowDialog();
            }
        }
    }
}
