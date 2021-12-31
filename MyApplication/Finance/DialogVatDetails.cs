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
    public partial class DialogVatDetails : Form
    {
        public DialogVatDetails()
        {
            InitializeComponent();
        }

        private void DialogVatDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            #region المبيعات
            double Payments = 0, Backs = 0;
            double PaymentsVat = 0, BacksVat = 0;

            double NetPayments = 0, BuysWithOut = 0;
            double TotalIncomeVat = 0, BuysVat = 0;

            TblCustomersBills obj = new TblCustomersBills();
            obj.Where.Bill_Date.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text);
            obj.Where.Bill_Date.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text);
            obj.Where.Bill_Date.Operator = WhereParameter.Operand.Between;
            if (obj.Query.Load())
            {
                do
                {
                    ClassCustomerBillTotal cs = new ClassCustomerBillTotal(obj.Bill_ID);
                    if (obj.Bill_Type.Contains("مبيعات"))
                    {
                        Payments += cs.BillTotalAfterDiscount;
                        PaymentsVat += obj.Bill_Vat;

                        NetPayments += cs.BillTotalAfterDiscount;
                        TotalIncomeVat += obj.Bill_Vat;
                    }
                    else if (obj.Bill_Type.Contains("مرتجعات"))
                    {
                        Backs += cs.BillTotalAfterDiscount;
                        BacksVat += obj.Bill_Vat;

                        NetPayments -= cs.BillTotalAfterDiscount;
                        TotalIncomeVat -= obj.Bill_Vat;
                    }

                } while (obj.MoveNext());
            }

            lblPayemntsWithOut.Text = Payments.ToString("0,0.00");
            lblBacksWithOut.Text = Backs.ToString("0,0.00");

            lblPaymentsVat.Text = PaymentsVat.ToString("0,0.00");
            lblBacksVat.Text = BacksVat.ToString("0,0.00");

            lblPayments.Text = (double.Parse(lblPayemntsWithOut.Text) + double.Parse(lblPaymentsVat.Text)).ToString("0,0.00");
            lblBacks.Text = (double.Parse(lblBacksWithOut.Text) + double.Parse(lblBacksVat.Text)).ToString("0,0.00");


            lblTotalPayemntsWithout.Text = NetPayments.ToString("0,0.00");
            lblTotalPaymentsVat.Text = TotalIncomeVat.ToString("0,0.00");
            lblTotalPayments.Text = (NetPayments + TotalIncomeVat).ToString("0,0.00");
            #endregion

            double OutCome = 0, OutComeVat = 0, OutComeWithOutVat = 0;
            #region المصروفات
            TblOutComings kp = new TblOutComings();
            kp.Where.Out_Vat.Value = 0;
            kp.Where.Out_Vat.Operator = WhereParameter.Operand.NotEqual;
            kp.Where.Out_Date.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text);
            kp.Where.Out_Date.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text);
            kp.Where.Out_Date.Operator = WhereParameter.Operand.Between;
            if (kp.Query.Load())
            {
                do
                {
                    OutCome += kp.Out_Money;
                    OutComeVat += kp.Out_Vat;
                    OutComeWithOutVat += kp.Out_BeforeVat;
                } while (kp.MoveNext());
            }
            lblOutCome.Text = OutCome.ToString("0,0.00");
            lblOutComeVat.Text = OutComeVat.ToString("0,0.00");
            lblOutComeWithOutVat.Text = OutComeWithOutVat.ToString("0,0.00");
            #endregion

            #region المشتريات
            TblVendorsBills x = new TblVendorsBills();
            x.Where.Bill_Vat.Value = 0;
            x.Where.Bill_Vat.Operator = WhereParameter.Operand.NotEqual;
            x.Where.Bill_Date.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text);
            x.Where.Bill_Date.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text);
            x.Where.Bill_Date.Operator = WhereParameter.Operand.Between;
            if (x.Query.Load())
            {
                do
                {
                    ClassVendorBillTotal cs = new ClassVendorBillTotal(x.Bill_ID);
                    if (x.Bill_PayType.Contains("مشتريات"))
                    {
                        BuysWithOut += cs.BillTotalWithOutVat;
                        BuysVat += x.Bill_Vat;
                    }
                    else
                    {
                        BuysWithOut -= cs.BillTotalWithOutVat;
                        BuysVat -= x.Bill_Vat;
                    }

                } while (x.MoveNext());
            }

            lblBuysVat.Text = BuysVat.ToString("0,0.00");
            lblBuysWithout.Text = BuysWithOut.ToString("0,0.00");
            lblBuys.Text = (BuysVat + BuysWithOut).ToString("0,0.00");
            #endregion

            lblTotalOutCome.Text= (double.Parse(lblBuys.Text) + double.Parse(lblOutCome.Text)).ToString("0,0.00");
            lblTotalOutComeWithOut.Text = (double.Parse(lblBuysWithout.Text) + double.Parse(lblOutComeWithOutVat.Text)).ToString("0,0.00");
            lblTotalOutComeVat.Text= (double.Parse(lblBuysVat.Text) + double.Parse(lblOutComeVat.Text)).ToString("0,0.00");

            lblNet.Text = (double.Parse(lblTotalPaymentsVat.Text) - double.Parse(lblTotalOutComeVat.Text)).ToString("0,0.00");            
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            btnSearchByDate_Click(sender, e);

            TblPrint h = new TblPrint();
            h.LoadAll();
            h.DeleteAll();
            h.Save();

            TblPrint pr = new TblPrint();
            pr.AddNew();
            pr.ColumnDate = DateTime.Parse(dateTimePicker1.Text);
            pr.ColumnDate2 = DateTime.Parse(dateTimePicker2.Text);

            pr.Column1 = lblPayments.Text;
            pr.Column2 = lblPayemntsWithOut.Text;
            pr.Column3 = lblPaymentsVat.Text;

            pr.Column4 = lblBacks.Text;
            pr.Column5 = lblBacksWithOut.Text;
            pr.Column6 = lblBacksVat.Text;

            pr.Column7 = lblTotalPayments.Text;
            pr.Column8 = lblTotalPayemntsWithout.Text;
            pr.Column9 = lblTotalPaymentsVat.Text;


            pr.Column10 = lblBuys.Text;
            pr.Column11 = lblBuysWithout.Text;
            pr.Column12 = lblBuysVat.Text;

            pr.Column13 = lblOutCome.Text;
            pr.Column14 = lblOutComeWithOutVat.Text;
            pr.Column15 = lblOutComeVat.Text;

            pr.Column16 = lblTotalOutCome.Text;
            pr.Column17 = lblTotalOutComeWithOut.Text;
            pr.Column18 = lblTotalOutComeVat.Text;

            pr.Column19 = lblNet.Text;
            pr.Save();

            FrmPrintVatReport obj = new FrmPrintVatReport();
            obj.ShowDialog();
        }
    }
}
