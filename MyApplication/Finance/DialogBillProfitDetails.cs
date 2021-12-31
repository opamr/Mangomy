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
using System.Drawing.Printing;
namespace MyApplication.Finance
{
    public partial class DialogBillProfitDetails : Form
    {
        int MyBillID;
        public DialogBillProfitDetails(int BillId)
        {
            MyBillID = BillId;
            InitializeComponent();
        }

        private void DialogbillProfitDetails_Load(object sender, EventArgs e)
        {
            TblCustomersBills obj = new TblCustomersBills();
            obj.LoadByPrimaryKey(MyBillID);            
            lblBillNumber.Text = obj.Bill_ID.ToString();
            lblBillDate.Text = obj.Bill_Date.ToShortDateString();
            lblTime.Text = obj.Bill_Time;
            lblPayCash.Text = obj.Pay_Cash.ToString("0,0.00");
            LblPayBank.Text = obj.Pay_Bank.ToString("0,0.00");
            lblType.Text = obj.Bill_Type;

            ClassCustomerBillTotal cs = new ClassCustomerBillTotal(MyBillID);
            lblTotal.Text = cs.BillTotal.ToString("0,0.00");
            LblDiscount.Text = obj.Bill_DiscountMoney.ToString("0.00");
            lblAfterDiscount.Text = cs.BillTotalAfterDiscount.ToString("0,0.00");
            lblRest.Text = cs.BillRest.ToString("0,0.00");
            lblCustomerName.Text = cs.BillCustomerName;
            lblVat.Text = obj.Bill_Vat.ToString("0,0.00");
            lblTotalAfterVat.Text = cs.BillTotalAfterVat.ToString("0,0.00");

            TblUsers uu = new TblUsers();
            uu.LoadByPrimaryKey(obj.User_Id);
            lblUser.Text = uu.User_Name;

            double Profits = 0;

            ListViewItem lv;
            listView1.Items.Clear();
            ViewCustomerPayments py = new ViewCustomerPayments();
            py.Where.CustomerBill_Id.Value = MyBillID;
            if (py.Query.Load())
            {
                int g = 0;
                do
                {
                    ++g;
                    lv = new ListViewItem(py.Pay_ID.ToString());
                    lv.SubItems.Add(g.ToString());
                    lv.SubItems.Add(py.Good_TraidName);
                    lv.SubItems.Add(py.Barcode_Unit);
                    lv.SubItems.Add(py.PayCount.ToString());
                    lv.SubItems.Add(py.Pay_Price.ToString());

                    lv.SubItems.Add(py.Pay_Total.ToString("0,0.00"));
                    lv.SubItems.Add(py.Barcode_BuyPrice);
                    lv.SubItems.Add(py.Pay_Profit.ToString("0,0.00"));
                    listView1.Items.Add(lv);

                    Profits += py.Pay_Profit;

                } while (py.MoveNext());
            }

            lbltotalProfit.Text = Profits.ToString("0,0.00");
            lblNetProfit.Text = (Profits - obj.Bill_DiscountMoney).ToString("0,0.00");
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            DialogChooseBill x = new DialogChooseBill(MyBillID);
            x.ShowDialog();
        }      

        private void btnEditBill_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 20);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            DialogNewOrder obj = new DialogNewOrder(MyBillID);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                TblCustomersBills x = new TblCustomersBills();
                x.Where.Bill_ID.Value = MyBillID;
                if (x.Query.Load())
                {
                    DialogbillProfitDetails_Load(sender, e);
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
