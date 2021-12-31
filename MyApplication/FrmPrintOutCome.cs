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
    public partial class FrmPrintOutCome : Form
    {
        DateTime MyFrom, MyTo;
        string MyTotal;
        public FrmPrintOutCome(DateTime from , DateTime to , string total)
        {
            MyFrom = from;
            MyTo = to;
            MyTotal = total;
            InitializeComponent();
        }

        private void FrmPrintOutCome_Load(object sender, EventArgs e)
        {          

            // TODO: This line of code loads data into the 'PharmacyDBDataSet1.OutComeView' table. You can move, or remove it, as needed.
            this.OutComeViewTableAdapter.Fill(this.PharmacyDBDataSet1.OutComeView, MyFrom, MyTo);

            this.reportViewer1.RefreshReport();

            string title = "إجمالي المصروفات خلال المدة من " + MyFrom.ToString("yyyy/MM/dd") + " إلى " + MyTo.ToString("yyyy/MM/dd");

            ReportParameter[] param = new ReportParameter[2];
            param[0] = new ReportParameter("Total", MyTotal);
            param[1] = new ReportParameter("Date", title);
            reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();

        }
    }
}
