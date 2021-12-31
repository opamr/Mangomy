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
    public partial class FrmPrintVendorBill : Form
    {
        int MyBillID;
        public FrmPrintVendorBill(int billId)
        {
            MyBillID = billId;
            InitializeComponent();
        }

        private void FrmPrintVendorBill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FaysalNewDBDataSet.ViewVendorGoods' table. You can move, or remove it, as needed.
            this.ViewVendorGoodsTableAdapter.Fill(this.FaysalNewDBDataSet.ViewVendorGoods, MyBillID);

            this.reportViewer1.RefreshReport();
        }
    }
}
