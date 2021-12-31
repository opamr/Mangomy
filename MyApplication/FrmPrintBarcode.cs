using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class FrmPrintBarcode : Form
    {
        public FrmPrintBarcode()
        {
            InitializeComponent();
        }

        private void FrmPrintBarcode_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SaferHealthDB2DataSet1.TblBarcodeCountPrint' table. You can move, or remove it, as needed.
            this.TblBarcodeCountPrintTableAdapter.Fill(this.SaferHealthDB2DataSet1.TblBarcodeCountPrint);

            this.reportViewer1.RefreshReport();
        }
    }
}
