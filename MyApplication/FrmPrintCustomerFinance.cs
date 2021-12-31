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
namespace MyApplication.Customers
{
    public partial class FrmPrintCustomerFinance : Form
    {
        int MyID;
        string MyTitle;
        public FrmPrintCustomerFinance(int vendor, string title)
        {
            MyTitle = title;
            MyID = vendor;
            InitializeComponent();
        }

        private void FrmPrintCustomerFinance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PharmacyDBDataSet2.TblPrint' table. You can move, or remove it, as needed.
            this.TblPrintTableAdapter.Fill(this.PharmacyDBDataSet2.TblPrint);
            this.reportViewer1.RefreshReport();

            TblCustomersData obj = new TblCustomersData();
            obj.LoadByPrimaryKey(MyID);

            ReportParameter[] param = new ReportParameter[3];
            param[0] = new ReportParameter("Name", obj.Customer_Name);
            param[1] = new ReportParameter("CustomerID", obj.Customer_ID.ToString());
            param[2] = new ReportParameter("Title", MyTitle);
            reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
        }
    }
}
