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
using Microsoft.Reporting.WinForms;

namespace MyApplication
{
    public partial class FrmPrintSnadKapd : Form
    {
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();

        int MyID;
        public FrmPrintSnadKapd(int id1)
        {
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia));
            MyID = id1;
            InitializeComponent();
        }

        private void FrmPrintWaslCust_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AbodaDBDataSet2.TblCustomersPaying' table. You can move, or remove it, as needed.
            this.TblCustomersPayingTableAdapter.Fill(this.AbodaDBDataSet2.TblCustomersPaying, MyID);

            this.reportViewer1.RefreshReport();

            TblCustomersPaying obj = new TblCustomersPaying();
            obj.LoadByPrimaryKey(MyID);

            ToWord toWord = new ToWord(Convert.ToDecimal(obj.Pay_Money), currencies[0]);

            ReportParameter[] param = new ReportParameter[1];
            param[0] = new ReportParameter("MoneyWrite", toWord.ConvertToArabic());         
            reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
        }
    }
}
