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
using MyGeneration.dOOdads;
using System.Drawing.Printing;

namespace MyApplication
{
    public partial class DialogChooseBill : Form
    {
        int MyBillID;
        public DialogChooseBill(int billId)
        {
            MyBillID = billId;
            InitializeComponent();
        }

        private void DialogChooseBill_Load(object sender, EventArgs e)
        {

        }

        private void DialogChooseBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnPrint1_Click(object sender, EventArgs e)
        {
            FrmPrintBillA4 pp = new FrmPrintBillA4(MyBillID);
            pp.ShowDialog();
            if (pp.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void BtnPrint2_Click(object sender, EventArgs e)
        {
            FrmPrintBillEpson pp = new FrmPrintBillEpson(MyBillID);
            pp.ShowDialog();
            if (pp.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }       
     
    }
}
