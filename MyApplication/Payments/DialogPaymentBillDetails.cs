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
namespace MyApplication.Payments
{
    public partial class DialogPaymentBillDetails : Form
    {
        int MyBillID;
        public DialogPaymentBillDetails(int Bill)
        {
            MyBillID = Bill;
            InitializeComponent();            
        }

        private void DialogPaymentBillDetails_Load(object sender, EventArgs e)
        {
            TblCustomersBills obj = new TblCustomersBills();
            obj.LoadByPrimaryKey(MyBillID);
            lblType.Text = obj.Bill_Type;
            lblBillNumber.Text = obj.Bill_ID.ToString();
            lblBillDate.Text = obj.Bill_Date.ToShortDateString();
            lblTime.Text = obj.Bill_Time;
            lblPayCash.Text = obj.Pay_Cash.ToString("0,0.00");
            LblPayBank.Text = obj.Pay_Bank.ToString("0,0.00");

            lblVatType.Text = "الضريبة " + obj.s_Bill_Vat_Value + " % : ";        

            ClassCustomerBillTotal cs = new ClassCustomerBillTotal(MyBillID);
            lblTotal.Text = cs.BillTotal.ToString("0,0.00");
            LblDiscount.Text = obj.Bill_DiscountMoney.ToString("0,0.00");
            lblAfterVat.Text = cs.BillTotalAfterVat.ToString("0,0.00");
            lblRest.Text = cs.BillRest.ToString("0,0.00");
            lblCustomerName.Text = cs.BillCustomerName;
            lblMobile.Text = cs.BillCustomerPhone;
            lblVat.Text = obj.Bill_Vat.ToString("0,0.00");
            lblTotalAfterDiscount.Text = cs.BillTotalAfterDiscount.ToString("0,0.00");

            TblUsers uu = new TblUsers();
            uu.LoadByPrimaryKey(obj.User_Id);
            lblUser.Text = uu.User_Name;

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

                    lv.SubItems.Add(py.Pay_Total.ToString());
                    lv.SubItems.Add(py.PayTotalAfterVat.ToString("0,0.00"));

                    listView1.Items.Add(lv);

                } while (py.MoveNext());
            }           
        }      

        private void DialogPaymentBillDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 20);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            DialogResult d = MessageBox.Show("هل تريد التعديل على  الفاتورة", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {              
                DialogNewOrder obj = new DialogNewOrder(MyBillID);
                obj.ShowDialog();
                if (obj.DialogResult == DialogResult.OK)
                {
                    TblCustomersBills x = new TblCustomersBills();
                    x.Where.Bill_ID.Value = MyBillID;
                    if (x.Query.Load())
                    {
                        DialogPaymentBillDetails_Load(sender, e);
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }      
        
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            FrmPrintBillA4 pp = new FrmPrintBillA4(MyBillID);
            pp.ShowDialog();
        }

        private void BtnPrintKashir_Click(object sender, EventArgs e)
        {
            FrmPrintBillEpson pp = new FrmPrintBillEpson(MyBillID);
            pp.ShowDialog();
        }

        private void BtnPrintSmall_Click(object sender, EventArgs e)
        {
            //PrintDocument pd2 = new PrintDocument();
            //pd2.DefaultPageSettings.PrinterSettings.Copies = 1;
            //pd2.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            //pd2.Print();

            //PrintPreviewDialog pv = new PrintPreviewDialog();
            //pv.Document = pd2;
            //pv.Width = 1300;
            //pv.Height = 900;
            //pv.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            ClassPrintCashirBill cs = new ClassPrintCashirBill();
            cs.printDocument1_PrintPage(sender, e, MyBillID);
        }
    }
}
