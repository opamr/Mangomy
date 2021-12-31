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
namespace MyApplication.Customers
{
    public partial class DialogAddCustomer : Form
    {
        int MyCustomerID;
        public DialogAddCustomer(int id1)
        {
            MyCustomerID = id1;
            InitializeComponent();
            comboBank1.SelectedIndex = comboBank2.SelectedIndex = comboCustomerType.SelectedIndex = 0;
        }

        private void DialogAddCustomer_Load(object sender, EventArgs e)
        {                             
            if (MyCustomerID != 0)
            {
                this.Text = "تعديل بيانات العميل";
                btnDelete.Visible = true;

                TblCustomersData obj = new TblCustomersData();
                obj.LoadByPrimaryKey(MyCustomerID);
                txtname.Text = obj.Customer_Name;
                txtMobile.Text = obj.Customer_Mobile;
                txtAdress.Text = obj.Customer_Address;
                txtPhone.Text = obj.Customer_VatNumber;
                txtRecentMoney.Text = obj.Recent_money.ToString();
                txtMaxValue.Text = obj.Customer_MaxMoney;
                txtSenderName.Text = obj.Customer_SenderName;
                txtSenderMobile.Text = obj.Customer_SenderMobile;
                dateTimePicker1.Text = obj.RecentDate.ToShortDateString();
                comboBank1.Text = obj.Customer_BankType1;
                comboBank2.Text = obj.Customer_BankType2;
                txtBankNumber1.Text = obj.Customer_BankNumber1;
                txtBankNumber2.Text = obj.Customer_BankNumber2;
                comboCustomerType.Text = obj.Customer_Type;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtRecentMoney.Text == "")
            {
                MessageBox.Show("تأكد من كتابة اسم العميل والرصيد قبل البرنامج");
                return;
            }

            if (txtMobile.Text.Length != 10)
            {
                MessageBox.Show("رقم الجوال يجب أن يكون 10 أرقام");
                return;
            }


            TblCustomersData obj = new TblCustomersData();
            if (MyCustomerID != 0)
            {
                obj.LoadByPrimaryKey(MyCustomerID);
            }
            else  
            {
                TblCustomersData cust = new TblCustomersData();
                cust.Where.Customer_Name.Value = txtname.Text;
                if (cust.Query.Load())
                {
                    MessageBox.Show("هذا العميل موجود من قبل", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                obj.AddNew();
            }

            obj.Customer_Name = txtname.Text;
            obj.Customer_Mobile = txtMobile.Text;
            obj.Customer_Address = txtAdress.Text;
            obj.Customer_VatNumber = txtPhone.Text;
            obj.Recent_money = double.Parse(txtRecentMoney.Text);
            obj.RecentDate = DateTime.Parse(dateTimePicker1.Text).Date;
            obj.Customer_MaxMoney = txtMaxValue.Text;
            obj.Customer_SenderName = txtSenderName.Text;
            obj.Customer_SenderMobile = txtSenderMobile.Text;
            obj.Customer_BankType1 = comboBank1.Text;
            obj.Customer_BankType2 = comboBank2.Text;
            obj.Customer_BankNumber1 = txtBankNumber1.Text;
            obj.Customer_BankNumber2 = txtBankNumber2.Text;
            obj.Customer_Type = comboCustomerType.Text;
            obj.Save();


            this.Close();
        }

        private void txtPoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }

        private void DialogAddCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TblCustomersPaying yy = new TblCustomersPaying();
            yy.Where.Customer_Id.Value = MyCustomerID;
            if (yy.Query.Load())
            {
                MessageBox.Show("لا يمكن حذف العميل لوجود سندات مسجلة عليه");
                return;
            }

            TblCustomersBills bb = new TblCustomersBills();
            bb.Where.Customer_Id.Value = MyCustomerID;
            if (bb.Query.Load())
            {
                MessageBox.Show("لا يمكن حذف العميل لوجود فواتير مسجلة عليه");
                return;
            }

            DialogResult d = MessageBox.Show(" تأكيد الحذف ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.Cancel)
            {
                return;
            }

            TblCustomersData obj = new TblCustomersData();
            obj.LoadByPrimaryKey(MyCustomerID);
            obj.MarkAsDeleted();
            obj.Save();

            this.Close();
        }
    }
}
