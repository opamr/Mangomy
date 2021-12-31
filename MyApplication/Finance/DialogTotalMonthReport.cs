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
    public partial class DialogTotalMonthReport : Form
    {
        public DialogTotalMonthReport()
        {
            InitializeComponent();
        }

        private void DialogTotalMonthReport_Load(object sender, EventArgs e)
        {
            double Kash = 0, Bank = 0;
            double Payments = 0, CustomerPayes = 0, OutCome = 0, KashBuy = 0, Vendors = 0, Employees = 0;

            double RestPayments = 0;
            double TotalVendors = 0;
            double RestBuys = 0;
            double PaymentProfits = 0;
            double BankFees = 0;

            #region المبيعات
            TblCustomersBills obj = new TblCustomersBills();
            obj.Where.Bill_Date.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text).Date;
            obj.Where.Bill_Date.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text).Date;
            obj.Where.Bill_Date.Operator = WhereParameter.Operand.Between;
            if (obj.Query.Load())
            {
                do
                {
                    ClassCustomerBillTotal cc = new ClassCustomerBillTotal(obj.Bill_ID);

                    if (obj.Bill_Type.Contains("مبيعات"))
                    {
                        Payments += cc.BillTotalAfterVat;
                        Kash += cc.KashPay;
                        Bank += cc.BankPay;
                        RestPayments += cc.BillRest;
                        PaymentProfits += (cc.BillProfit + obj.Bill_Vat);
                        BankFees += obj.Pay_Bank_Fees;
                    }
                    else if (obj.Bill_Type.Contains("مرتجعات"))
                    {
                        Payments -= cc.BillTotalAfterVat;
                        Kash -= cc.KashPay;
                        Bank -= cc.BankPay;
                        RestPayments -= cc.BillRest;
                        PaymentProfits -= (cc.BillProfit + obj.Bill_Vat);
                        BankFees -= obj.Pay_Bank_Fees;
                    }
                
                    

                } while (obj.MoveNext());
            }
            lblTotalPayments.Text = Payments.ToString("0,0.00");
            lblPaymentProfit.Text = PaymentProfits.ToString("0,0.00");
            lblKash.Text = Kash.ToString("0,0.00");
            lblBank.Text = Bank.ToString("0,0.00");
            lblRestPayments.Text = RestPayments.ToString("0,0.00");
            lblBankFees.Text = BankFees.ToString("0,0.00");
            #endregion

            lblNet.Text = (PaymentProfits - OutCome  - BankFees - Employees).ToString("0,0.00");

            #region المصروفات
            TblCustomersPaying cp = new TblCustomersPaying();
            cp.Where.Pay_Date.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text).Date;
            cp.Where.Pay_Date.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text).Date;
            cp.Where.Pay_Date.Operator = WhereParameter.Operand.Between;
            if (cp.Query.Load())
            {
                do
                {
                    CustomerPayes += cp.Pay_Money;
                } while (cp.MoveNext());
            }
            lblCustomerPayes.Text = CustomerPayes.ToString("0,0.00");
            #endregion           

            #region المصروفات
            TblOutComings ou = new TblOutComings();
            ou.Where.Out_Date.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text).Date;
            ou.Where.Out_Date.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text).Date;
            ou.Where.Out_Date.Operator = WhereParameter.Operand.Between;
            if (ou.Query.Load())
            {
                do
                {
                    OutCome += ou.Out_Money;
                } while (ou.MoveNext());
            }
            lblTotalOutcome.Text = OutCome.ToString("0,0.00");
            #endregion           

            #region مدفوعات إلى الموردين
            TblVendorsPaying vv = new TblVendorsPaying();
            vv.Where.Ven_PayDate.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text).Date;
            vv.Where.Ven_PayDate.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text).Date;
            vv.Where.Ven_PayDate.Operator = WhereParameter.Operand.Between;
            if (vv.Query.Load())
            {
                do
                {
                    Vendors += vv.Ven_PayMoney;
                } while (vv.MoveNext());
            }


            ViewVendorsBills rt2 = new ViewVendorsBills();
            rt2.Where.Bill_Date.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text).Date;
            rt2.Where.Bill_Date.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text).Date;
            rt2.Where.Bill_Date.Operator = WhereParameter.Operand.Between;           
            if (rt2.Query.Load())
            {
                do
                {
                    ClassVendorBillTotal cs = new ClassVendorBillTotal(rt2.Bill_ID);
                    if (rt2.Bill_PayType.Contains("فاتورة مشتريات"))
                    {
                        TotalVendors += cs.BillTotalAfterDiscount;
                        if (rt2.Bill_PayType.Contains("كاش"))
                        {
                            KashBuy += cs.BillTotalAfterDiscount;
                        }
                        else
                        {
                            RestBuys += cs.BillTotalAfterDiscount;
                        }                      
                    }
                    else
                    {
                        RestBuys -= cs.BillTotalAfterDiscount;

                        TotalVendors -= cs.BillTotalAfterDiscount;
                    }
                } while (rt2.MoveNext());
            }
            lblVendors.Text = Vendors.ToString("0,0.00");
            lblKashBuy.Text= KashBuy.ToString("0,0.00");
            lblTotalVendors.Text = TotalVendors.ToString("0,0.00");
            lblRestBuys.Text= RestBuys.ToString("0,0.00");
            #endregion

            #region الموظفين
            ViewEmployeesSalaryPaying za = new ViewEmployeesSalaryPaying();
            za.Where.Pay_Date.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text).Date;
            za.Where.Pay_Date.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text).Date;
            za.Where.Pay_Date.Operator = WhereParameter.Operand.Between;
            if (za.Query.Load())
            {
                do
                {
                    Employees += za.Pay_Money;
                } while (za.MoveNext());
            }
            lblEmployees.Text = Employees.ToString("0,0.00");
            #endregion


        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            DialogTotalMonthReport_Load(sender, e);
        }       

        private void BtnPrint_Click_1(object sender, EventArgs e)
        {
            btnSearchByDate_Click(sender, e);

            TblPrint pr = new TblPrint();
            pr.LoadAll();
            pr.DeleteAll();
            pr.Save();

            TblPrint obj = new TblPrint();
            obj.AddNew();
            obj.Column1 = lblTotalPayments.Text;
            obj.Column2 = lblTotalOutcome.Text;
            obj.Column3 = lblVendors.Text;
            obj.Column4 = lblEmployees.Text;
            obj.Column5 = lblNet.Text;
            obj.Column6 = "تقرير رقمي خلال المدة من : " + dateTimePicker1.Text + " إلى: " + dateTimePicker2.Text;
            obj.Column7 = lblKash.Text;
            obj.Column8 = lblBank.Text;
            obj.Column9 = lblCustomerPayes.Text;
            obj.Column10 = lblRestPayments.Text;
            obj.Column11 = lblTotalVendors.Text;
            obj.Column12 = lblKashBuy.Text;
            obj.Column13 = lblRestBuys.Text;
            obj.Column14 = lblPaymentProfit.Text;
            obj.Column15 = lblBankFees.Text;
            obj.Save();

            FrmPrintMonthReport x = new FrmPrintMonthReport();
            x.ShowDialog();
        }
    }
}
