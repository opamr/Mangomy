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

namespace MyApplication.Banks
{
    public partial class DialogAddBank : Form
    {
        int MyBankID;
        public DialogAddBank(int BankId)
        {
            MyBankID = BankId;
            InitializeComponent();
        }

        private void DialogAddBank_Load(object sender, EventArgs e)
        {
            if (MyBankID !=0 )
            {
                TblBanks obj = new TblBanks();
                obj.LoadByPrimaryKey(MyBankID);
                txtName.Text = obj.Bank_Name;
                txtMoney.Text = obj.Bank_FirstPeriod.ToString();
                dateTimePicker5.Text = obj.Bank_FisrtDate.ToShortDateString();
                txtFees.Text = obj.Bank_Fees.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMoney.Text != "" && txtMoney.Text != "." && txtFees.Text != "" && txtFees.Text != ".")
            {
                TblBanks obj = new TblBanks();
                if (MyBankID == 0)
                {
                    obj.AddNew();
                }
                else
                {
                    obj.LoadByPrimaryKey(MyBankID);
                }
              
                obj.Bank_Name = txtName.Text;
                obj.Bank_FirstPeriod = double.Parse(txtMoney.Text);
                obj.Bank_Fees = double.Parse(txtFees.Text);
                obj.Bank_FisrtDate = DateTime.Parse(dateTimePicker5.Text).Date;
                obj.Save();

                MessageBox.Show("تم الحفظ");
                this.Close();
            }
            else
            {
                MessageBox.Show("تأكد من إدخال البيانات بشكل صحيح");
            }
        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        private void DialogAddBank_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
       
    }
}
