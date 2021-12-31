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

namespace MyApplication.Banks
{
    public partial class DialogConvertMoney : Form
    {
        int ConvertFrom;
        int MyID;
     
        public DialogConvertMoney(int from,  int id)
        {
            ConvertFrom = from;           
            MyID = id;          
            InitializeComponent();
        }

        private void DialogConvertMoney_Load(object sender, EventArgs e)
        {
            if (ConvertFrom ==0)
            {
                lblConvertFrom.Text = "اضافة رصيد خارجي";
            }
            else
            {
                TblBanks bb = new TblBanks();
                bb.LoadByPrimaryKey(ConvertFrom);
                lblConvertFrom.Text = bb.Bank_Name;

                ClassSafe cs = new ClassSafe(ConvertFrom);
                lblNow.Text = cs.MyBankNow.ToString("0,0.00");
            }           

            TblBanks x = new TblBanks();
            x.Where.Bank_ID.Value = ConvertFrom;
            x.Where.Bank_ID.Operator = WhereParameter.Operand.NotEqual;
            if (x.Query.Load())
            {
                comboBox1.DisplayMember = TblBanks.ColumnNames.Bank_Name;
                comboBox1.ValueMember = TblBanks.ColumnNames.Bank_ID;
                comboBox1.DataSource = x.DefaultView;
            }         

            if (MyID != 0)
            {                
                BtnDelete.Visible = true;
                this.Text = "تعديل";

                TblBankOperation obj = new TblBankOperation();
                obj.LoadByPrimaryKey(MyID);
                txtMoney.Text = obj.Operate_Money.ToString();
                txtDetails.Text = obj.Operate_Details;
                dateTimePicker1.Text = obj.Operate_Date.ToShortDateString();                
                comboBox1.SelectedValue = obj.Operate_ConvertTo;
            }
        }

        private void BtnAddPay_Click(object sender, EventArgs e)
        {
            if (txtMoney.Text != "" && txtMoney.Text != "0" && txtMoney.Text != ".")
            {
                TblBankOperation obj = new TblBankOperation();
                if (MyID == 0)
                {
                    obj.AddNew();                   
                }
                else
                {
                    obj.LoadByPrimaryKey(MyID);
                }

                obj.Operate_Money = double.Parse(txtMoney.Text);
                obj.Operate_Details = txtDetails.Text;
                obj.Operate_Date = DateTime.Parse(dateTimePicker1.Text);                
                obj.Operate_ConvertTo = int.Parse(comboBox1.SelectedValue.ToString());
                obj.Operate_ConvertFrom = ConvertFrom;
                obj.User_Id = GlobalVar.user_Id;
                obj.Save();               

                this.Close();
              
            }
            else
            {
                MessageBox.Show("تأكد من كتابة المبلغ المحول بشكل صحيح");
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("هل تريد بالتأكيد حذف هذا البند", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {
                TblBankOperation obj = new TblBankOperation();
                obj.LoadByPrimaryKey(MyID);
                obj.MarkAsDeleted();
                obj.Save();

                this.Close();
            }
        }

        private void DialogConvertMoney_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDetails.Text = "تحويل من حساب : " +lblConvertFrom.Text + " إلى حساب : " + comboBox1.Text;
        }
    }
}
