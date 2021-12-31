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

namespace MyApplication.Finance
{
    public partial class DialogVatValue : Form
    {
        public DialogVatValue()
        {
            InitializeComponent();
        }

        private void DialogVatValue_Load(object sender, EventArgs e)
        {
            TblVat obj = new TblVat();
            obj.LoadByPrimaryKey(1);
            txtValue.Text = obj.s_Vat_Value;
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "" || txtValue.Text == ".")
            {
                MessageBox.Show("تأكد من كتابة قيمة الضريبة");
                return;
            }

            DialogResult d = MessageBox.Show(" تأكيد الحفظ ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.Cancel)
            {
                return;
            }

            TblVat obj = new TblVat();
            obj.LoadByPrimaryKey(1);
            obj.s_Vat_Value = txtValue.Text;
            obj.Vat_Percent = double.Parse(txtValue.Text) / 100;
            obj.Save();

            MessageBox.Show("تم الحفظ");
            this.Close();
        }
    }
}
