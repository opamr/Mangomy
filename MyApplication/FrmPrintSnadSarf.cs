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
    public partial class FrmPrintSnadSarf : Form
    {
        int MyID;
        public FrmPrintSnadSarf(int id1)
        {
            MyID = id1;
            InitializeComponent();
        }

        private void FrmPrintWasl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AbodaDBDataSet1.TblVendorsPaying' table. You can move, or remove it, as needed.
            this.TblVendorsPayingTableAdapter.Fill(this.AbodaDBDataSet1.TblVendorsPaying);

            this.reportViewer1.RefreshReport();

            TblVendorsPaying obj = new TblVendorsPaying();
            obj.LoadByPrimaryKey(MyID);

            ReportParameter[] param = new ReportParameter[5];
            param[0] = new ReportParameter("reciveName", obj.Vendor_Sendor);
            param[1] = new ReportParameter("date", obj.Ven_PayDate.ToString("yyyy/MM/dd"));
            param[2] = new ReportParameter("money", obj.Ven_PayMoney.ToString());

            TblUsers u = new TblUsers();
            u.LoadByPrimaryKey(obj.User_Id);
            param[3] = new ReportParameter("user", u.User_Name);
            param[4] = new ReportParameter("WaslNumber", obj.Ven_PayID.ToString());
            reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
        }
    }
}
