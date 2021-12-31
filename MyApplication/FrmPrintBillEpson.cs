using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MyPro;
using MyGeneration.dOOdads;

namespace MyApplication
{
    public partial class FrmPrintBillEpson : Form
    {
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();
        int MyBillId;
        public FrmPrintBillEpson(int id)
        {
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia));

            MyBillId = id;
            InitializeComponent();
        }

        private void FrmPrintBillEpson_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NewDataSet.ViewCustomerPayments' table. You can move, or remove it, as needed.
            this.ViewCustomerPaymentsTableAdapter.Fill(this.NewDataSet.ViewCustomerPayments, MyBillId);

            this.reportViewer1.RefreshReport();

            ClassCustomerBillTotal cs = new ClassCustomerBillTotal(MyBillId);

            ToWord toWord = new ToWord(Convert.ToDecimal(cs.BillTotalAfterVat), currencies[0]);


            ReportParameter[] param = new ReportParameter[7];
            param[0] = new ReportParameter("Name", cs.BillCustomerName);
            param[1] = new ReportParameter("AfterVat", cs.BillTotalAfterVat.ToString("0,0.00"));
            param[2] = new ReportParameter("AfterDiscount", cs.BillTotalAfterDiscount.ToString("0,0.00"));
            param[3] = new ReportParameter("Payes", cs.AllPay.ToString("0,0.00"));
            param[4] = new ReportParameter("Rest", cs.BillRest.ToString("0,0.00"));
            param[5] = new ReportParameter("Mobile", cs.BillCustomerPhone);
            param[6] = new ReportParameter("MoneyWrite", toWord.ConvertToArabic());

            reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
        }
    }
}
