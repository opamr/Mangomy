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
namespace MyApplication
{
    public partial class FrmProfitBills : Form
    {
        string MySearchType;
        public FrmProfitBills()
        {
            InitializeComponent();
        }

        private void FrmProfitBills_Load(object sender, EventArgs e)
        {
            MySearchType = "date";
        }

        private void FillMyGrid()
        {
            double ALLTOTAL = 0;
            double AllProfits = 0;

            ListViewItem lv1;
            listView1.Items.Clear();

            ViewCustomerBills obj = new ViewCustomerBills();
            obj.Where.Bill_Type.Value = "عرض سعر";
            obj.Where.Bill_Type.Operator = WhereParameter.Operand.NotEqual;
            if (MySearchType == "date")
            {
                obj.Where.Bill_Date.BetweenBeginValue = DateTime.Parse(dtpfrom.Text);
                obj.Where.Bill_Date.BetweenEndValue = DateTime.Parse(dtpto.Text);
                obj.Where.Bill_Date.Operator = WhereParameter.Operand.Between;
            }
            else if (MySearchType == "id")
            {
                obj.Where.Bill_ID.Value = int.Parse(txtNumber.Text);
            }
            else if (MySearchType == "mobile")
            {
                obj.Where.Bill_CustomerPhone.Value = txtMobile.Text;
            }
            if (obj.Query.Load())
            {
                int r = 0;
                do
                {
                    ClassCustomerBillTotal cs = new ClassCustomerBillTotal(obj.Bill_ID);
                    ++r;
                    lv1 = new ListViewItem(obj.Bill_ID.ToString());
                    lv1.SubItems.Add(r.ToString());
                    lv1.SubItems.Add(obj.Bill_Date.ToShortDateString());                   
                    lv1.SubItems.Add(cs.BillCustomerName);
                    lv1.SubItems.Add(cs.BillCustomerPhone);
                    if (obj.Bill_Type == "فاتورة مرتجعات")
                    {
                        lv1.BackColor = Color.Yellow;
                        ALLTOTAL -= cs.BillTotalAfterDiscount;
                        AllProfits -= cs.BillProfit;
                    }
                    else
                    {
                        ALLTOTAL += cs.BillTotalAfterDiscount;
                        AllProfits += cs.BillProfit;
                    }
                    lv1.SubItems.Add(cs.BillTotalAfterDiscount.ToString());
                    lv1.SubItems.Add(cs.BillProfit.ToString());
                    lv1.SubItems.Add(obj.User_Name);
                    listView1.Items.Add(lv1);
                } while (obj.MoveNext());
            }
            lblAllBills.Text = ALLTOTAL.ToString("0,0.00");
            lblProfit.Text = AllProfits.ToString("0,0.00");         
        }

        private void BtnSearchMonth_Click(object sender, EventArgs e)
        {
            MySearchType = "date";
            FillMyGrid();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && txtNumber.Text != "")
            {
                MySearchType = "id";
                FillMyGrid();
            }
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && txtMobile.Text != "")
            {
                MySearchType = "mobile";
                FillMyGrid();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            int RowID = int.Parse(item.SubItems[0].Text);

            Finance.DialogBillProfitDetails obj = new Finance.DialogBillProfitDetails(RowID);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                FrmProfitBills_Load(sender, e);
            }
        }
    }
}
