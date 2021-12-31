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
    public partial class FrmPrintAllGoods : Form
    {
        public FrmPrintAllGoods()
        {
            InitializeComponent();
        }

        private void FrmPrintAllGoods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AbodaDBDataSet.TblGoodsTitles' table. You can move, or remove it, as needed.
            this.TblGoodsTitlesTableAdapter.Fill(this.AbodaDBDataSet.TblGoodsTitles);

            this.reportViewer1.RefreshReport();
        }
    }
}
