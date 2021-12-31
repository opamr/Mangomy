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

namespace MyApplication
{
    public partial class FrmPrintDailyReport : Form
    {        
        public FrmPrintDailyReport()
        {          
            InitializeComponent();
        }

        private void FrmPrintDailyReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PharmacyDBDataSet2.TblPrint14' table. You can move, or remove it, as needed.
            this.TblPrint14TableAdapter.Fill(this.PharmacyDBDataSet2.TblPrint14);
            // TODO: This line of code loads data into the 'PharmacyDBDataSet2.TblPrint1' table. You can move, or remove it, as needed.
            this.TblPrint1TableAdapter.Fill(this.PharmacyDBDataSet2.TblPrint1);
            // TODO: This line of code loads data into the 'PharmacyDBDataSet2.TblPrint11' table. You can move, or remove it, as needed.
            this.TblPrint11TableAdapter.Fill(this.PharmacyDBDataSet2.TblPrint11);
            // TODO: This line of code loads data into the 'PharmacyDBDataSet2.TblPrint12' table. You can move, or remove it, as needed.
            this.TblPrint12TableAdapter.Fill(this.PharmacyDBDataSet2.TblPrint12);
            // TODO: This line of code loads data into the 'PharmacyDBDataSet2.TblPrint13' table. You can move, or remove it, as needed.
            this.TblPrint13TableAdapter.Fill(this.PharmacyDBDataSet2.TblPrint13);
            // TODO: This line of code loads data into the 'PharmacyDBDataSet2.TblPrint' table. You can move, or remove it, as needed.
            this.TblPrintTableAdapter.Fill(this.PharmacyDBDataSet2.TblPrint);

            this.reportViewer1.RefreshReport();
          
        }
    }
}
