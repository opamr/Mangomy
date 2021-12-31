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

namespace MyApplication.Finance
{
    public partial class DialogPayDetails : Form
    {
        string MyType;
        DateTime MyDate;
        public DialogPayDetails(string Type1,DateTime date1)
        {
            MyDate = date1;
            MyType = Type1;
            InitializeComponent();

            dateTimePicker1.Value = dateTimePicker2.Value = MyDate.Date;

            TblBanks BB = new TblBanks();
            BB.LoadAll();
            if (BB.RowCount > 0)
            {
                comboBanks.DisplayMember = TblBanks.ColumnNames.Bank_Name;
                comboBanks.ValueMember = TblBanks.ColumnNames.Bank_ID;
                comboBanks.DataSource = BB.DefaultView;
            }
        }

        private void DialogVendorPayes_Load(object sender, EventArgs e)
        {
            this.Text = "تفاصيل " + MyType;

            ListViewItem lv;
            listView1.Items.Clear();
            double Total = 0;

           

            if (MyType == "سداد الموردين")
            {
                ViewVendorPaying obj = new ViewVendorPaying();
                //obj.Where.Pay_Type.Value = "سند صرف";
                obj.Where.Ven_PayDate.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text);
                obj.Where.Ven_PayDate.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text);
                obj.Where.Ven_PayDate.Operator = WhereParameter.Operand.Between;

                if (checkBox4.Checked == true)
                {
                    obj.Where.Bank_Id.Value = int.Parse(comboBanks.SelectedValue.ToString());
                }

                if (obj.Query.Load())
                {
                    int g = 0;
                    do
                    {
                        Total += obj.Ven_PayMoney;
                        ++g;
                        lv = new ListViewItem(obj.Ven_PayID.ToString());
                        lv.SubItems.Add(g.ToString());
                        lv.SubItems.Add(obj.Vendor_Name);
                        lv.SubItems.Add(obj.Ven_PayDate.ToShortDateString());
                        lv.SubItems.Add("سند صرف");
                        lv.SubItems.Add(obj.Ven_PayMoney.ToString("0,0.00"));
                        lv.SubItems.Add(obj.Bank_Name);
                        lv.SubItems.Add(obj.User_Name);
                        listView1.Items.Add(lv);
                    } while (obj.MoveNext());
                }

                dataGridView1.Rows.Clear();
                groupBox2.Visible = true;
                double TotalBills = 0;

                ViewVendorsBills kk = new ViewVendorsBills();
                kk.Where.Bill_Date.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text);
                kk.Where.Bill_Date.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text);
                kk.Where.Bill_Date.Operator = WhereParameter.Operand.Between;
                kk.Where.Bill_PayType.Value = "%" + "كاش" + "%";
                kk.Where.Bill_PayType.Operator = WhereParameter.Operand.Like;

                if (checkBox4.Checked == true)
                {
                    kk.Where.Bank_Id.Value = int.Parse(comboBanks.SelectedValue.ToString());
                }
                if (kk.Query.Load())
                {
                    do
                    {
                        TblBanks bb = new TblBanks();
                        bb.LoadByPrimaryKey(kk.Bank_Id);

                        ClassVendorBillTotal cs = new ClassVendorBillTotal(kk.Bill_ID);

                        if (kk.Bill_PayType.Contains("مرتجعات"))
                        {
                            TotalBills -= cs.BillTotalAfterDiscount;
                        }
                        else
                        {
                            TotalBills += cs.BillTotalAfterDiscount;
                        }

                        dataGridView1.Rows.Add(kk.Bill_ID,dataGridView1.Rows.Count+1,kk.Vendor_Name,kk.Bill_PayType,cs.BillTotalAfterDiscount.ToString("0,0.00"),
                            bb.Bank_Name,kk.User_Name);
                    } while (kk.MoveNext());
                }

                lblTotalBills.Text = TotalBills.ToString("0,0.00");
                lblNet.Text = (TotalBills + Total).ToString("0,0.00");
            }
            else if (MyType == "سداد عملاء")
            {
                ViewCustomerPaying obj = new ViewCustomerPaying();
                obj.Where.Pay_Type.Value = "خصم عام";
                obj.Where.Pay_Type.Operator = WhereParameter.Operand.NotEqual;
                obj.Where.Pay_Date.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text);
                obj.Where.Pay_Date.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text);
                obj.Where.Pay_Date.Operator = WhereParameter.Operand.Between;

                if (checkBox4.Checked == true)
                {
                    obj.Where.Bank_Id.Value = int.Parse(comboBanks.SelectedValue.ToString());
                }

                if (obj.Query.Load())
                {
                    int g = 0;
                    do
                    {                        
                        ++g;
                        lv = new ListViewItem(obj.Pay_ID.ToString());
                        lv.SubItems.Add(g.ToString());
                        lv.SubItems.Add(obj.Customer_Name);
                        lv.SubItems.Add(obj.Pay_Date.ToShortDateString());
                        lv.SubItems.Add(obj.Pay_Type);
                        lv.SubItems.Add(obj.Pay_Money.ToString("0,0.00"));
                        lv.SubItems.Add(obj.Bank_Name);
                        lv.SubItems.Add(obj.User_Name);

                        if (obj.Pay_Type == "سند قبض")
                        {
                            Total += obj.Pay_Money;
                        }
                        else
                        {
                            lv.BackColor = Color.Tomato;
                            Total -= obj.Pay_Money;
                        }

                        listView1.Items.Add(lv);

                    } while (obj.MoveNext());
                }
            }

            lblTotal.Text = Total.ToString("0,0.00");
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            int id = int.Parse(item.SubItems[0].Text);

            if (MyType == "سداد الموردين")
            {
                ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 11);
                if (xx.Allow == "no")
                {
                    MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                    return;
                }

                ViewVendorPaying pp = new ViewVendorPaying();
                pp.Where.Ven_PayID.Value = id;
                pp.Query.Load();

                Vendors.DialogAddVendorPaying obj = new Vendors.DialogAddVendorPaying(pp.Vendor_Id, pp.Ven_PayID);
                obj.ShowDialog();
                if (obj.DialogResult == DialogResult.OK)
                {
                    DialogVendorPayes_Load(sender, e);
                }
            }
            else if (MyType == "سداد عملاء")
            {
                ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 18);
                if (xx.Allow == "no")
                {
                    MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                    return;
                }

                ViewCustomerPaying pp = new ViewCustomerPaying();
                pp.Where.Pay_ID.Value = id;
                pp.Query.Load();

                Customers.DialogAddCustomerPaying vv = new Customers.DialogAddCustomerPaying(pp.Customer_Id, id,pp.Pay_Type);
                vv.ShowDialog();
                if (vv.DialogResult == DialogResult.OK)
                {
                    DialogVendorPayes_Load(sender, e);
                }
            }
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            DialogVendorPayes_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (e.RowIndex >= 0)
                {
                    int RowID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnID"].Value.ToString());
                    if (e.ColumnIndex == dataGridView1.Columns["ColumnDetails"].Index)
                    {
                        Vendors.DialogBillDetails ff = new Vendors.DialogBillDetails(RowID);
                        ff.Show();                      
                    }
                }
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value.ToString().Contains("مرتجعات"))
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }
    }
}
