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

namespace MyApplication.Customers
{
    public partial class DialogAddCustomerPaying : Form
    {
        int MyCustomerID;
        int MyWaslID;
        string MyPayType;
        public DialogAddCustomerPaying(int customer, int wasl,string PayType)
        {
            MyCustomerID = customer;
            MyWaslID = wasl;
            MyPayType = PayType;
            InitializeComponent();
        }

        private void FrmAddCustomerPaying_Load(object sender, EventArgs e)
        {
            TblBanks y = new TblBanks();
            y.LoadAll();
            if (y.RowCount > 0)
            {
                comboBanks.DisplayMember = TblBanks.ColumnNames.Bank_Name;
                comboBanks.ValueMember = TblBanks.ColumnNames.Bank_ID;
                comboBanks.DataSource = y.DefaultView;
            }            

            TblCustomersData x = new TblCustomersData();
            x.Where.Customer_ID.Value = 1;
            x.Where.Customer_ID.Operator = WhereParameter.Operand.NotEqual;
            if (x.Query.Load())
            {
                comboCustomers.DisplayMember = TblCustomersData.ColumnNames.Customer_Name;
                comboCustomers.ValueMember = TblCustomersData.ColumnNames.Customer_ID;
                comboCustomers.DataSource = x.DefaultView;

                if (MyCustomerID != 0)
                {
                    comboCustomers.SelectedValue = MyCustomerID;
                }
            }
            else
            {
                MessageBox.Show("تأكد من تسجيل بيانات العملاء");
                this.Close();
            }

            if (MyPayType == "خصم عام")
            {
                comboBanks.Enabled = false;
            }

            this.Text = "اضافة " + MyPayType;

            if (MyWaslID != 0)
            {
                this.Text = "تعديل " + MyPayType;
                BtnDelete.Visible = true;

                TblCustomersPaying obj = new TblCustomersPaying();
                obj.LoadByPrimaryKey(MyWaslID);
                comboCustomers.SelectedValue = obj.Customer_Id;
                dateTimePicker1.Text = obj.Pay_Date.ToShortDateString();
                txtMoney.Text = obj.Pay_Money.ToString();                
                txtDetails.Text = obj.Pay_Details;
                comboBanks.SelectedValue = obj.Bank_Id;
            }
        }

        private void BtnAddPay_Click(object sender, EventArgs e)
        {
            if (txtMoney.Text == "")
            {
                MessageBox.Show("تأكد من كتابة المبلغ بشكل صحيح");
                return;
            }

            DialogResult d = MessageBox.Show(" تأكيد الحفظ ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.Cancel)
            {
                return;
            }

            TblCustomersPaying obj = new TblCustomersPaying();
            if (MyWaslID == 0)
            {
                obj.AddNew();
            }
            else
            {
                obj.LoadByPrimaryKey(MyWaslID);
            }
            obj.Customer_Id = int.Parse(comboCustomers.SelectedValue.ToString());
            obj.Pay_Date = DateTime.Parse(dateTimePicker1.Text);
            obj.Pay_Money = double.Parse(txtMoney.Text);
            obj.Pay_Details = txtDetails.Text;
            obj.Bank_Id = int.Parse(comboBanks.SelectedValue.ToString());
            obj.User_Id = GlobalVar.user_Id;
            obj.Pay_Type = MyPayType;
            obj.Save();

            if (MyPayType != "خصم عام")
            {
                FrmPrintSnadKapd pr = new FrmPrintSnadKapd(obj.Pay_ID);
                pr.ShowDialog();
            }

            this.Close();
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
            DialogResult d = MessageBox.Show("هل تريد بالتأكيد حذف هذا السند", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {
                TblCustomersPaying obj = new TblCustomersPaying();
                obj.LoadByPrimaryKey(MyWaslID);
                obj.MarkAsDeleted();
                obj.Save();
            }
        }

        private void txtMoney_Leave(object sender, EventArgs e)
        {
            var text = (sender as TextBox).Text;

            if (sender is TextBox && text != "0")
            {
                double num;
                double.TryParse(text, out num);

                if (num.ToString() != "0")
                {
                    (sender as TextBox).BackColor = Color.Yellow;
                    BtnAddPay.Enabled = true;
                }
                else
                {
                    (sender as TextBox).BackColor = Color.Red;
                    (sender as TextBox).Focus();
                    BtnAddPay.Enabled = false;
                }
            }
        }
    }
}
