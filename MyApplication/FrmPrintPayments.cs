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
    public partial class FrmPrintPayments : Form
    {
        public FrmPrintPayments()
        {
            InitializeComponent();
        }

        private void FrmPrintPayments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PharmacyDBDataSet2.TblPrint' table. You can move, or remove it, as needed.
            this.TblPrintTableAdapter.Fill(this.PharmacyDBDataSet2.TblPrint);

            this.reportViewer1.RefreshReport();
        }
    }
}
