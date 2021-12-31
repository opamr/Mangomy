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

namespace MyApplication.Vendors
{
    public partial class DialogAddVendorPaying : Form
    {
        int MyVendorID, MyWaslID;    
        public DialogAddVendorPaying(int vendor1, int wasl1)
        {
            MyVendorID = vendor1;          
            MyWaslID = wasl1;
            InitializeComponent();
        }

        private void FrmAddVendorPaying_Load(object sender, EventArgs e)
        {
            TblBanks y = new TblBanks();
            y.LoadAll();
            if (y.RowCount > 0)
            {
                comboBanks.DisplayMember = TblBanks.ColumnNames.Bank_Name;
                comboBanks.ValueMember = TblBanks.ColumnNames.Bank_ID;
                comboBanks.DataSource = y.DefaultView;
            }
            else
            {
                MessageBox.Show("تأكد من تسجيل بيانات الأرصدة");
                this.Close();
            }

            TblVendorsData x = new TblVendorsData();
            x.LoadAll();
            if (x.RowCount > 0)
            {
                comboVendors.DisplayMember = TblVendorsData.ColumnNames.Vendor_Name;
                comboVendors.ValueMember = TblVendorsData.ColumnNames.Vendor_ID;
                comboVendors.DataSource = x.DefaultView;

                if (MyVendorID != 0)
                {
                    comboVendors.SelectedValue = MyVendorID;
                }
            }
            else
            {
                MessageBox.Show("تأكد من تسجيل بيانات الموردين");
                this.Close();
            }

            if (MyWaslID != 0)
            {
                this.Text = "تعديل سند الصرف";                
                btnDelete.Visible = true;

                TblVendorsPaying obj = new TblVendorsPaying();
                obj.LoadByPrimaryKey(MyWaslID);
                comboVendors.SelectedValue = obj.Vendor_Id;
                dateTimePicker1.Text = obj.Ven_PayDate.ToShortDateString();
                txtMoney.Text = obj.Ven_PayMoney.ToString();
                txtsender.Text = obj.Vendor_Sendor;
                txtDetails.Text = obj.Ven_PayDetails;
                comboBanks.SelectedValue = obj.Bank_Id;
                txtWasl.Text = obj.Pay_Wasl;
                txtNots.Text = obj.Pay_Nots;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMoney.Text == "" || txtMoney.Text == "0")
            {
                MessageBox.Show("تأكد من كتابة المبلغ بشكل صحيح");
                return;
            }

            if (txtWasl.Text == "")
            {
                MessageBox.Show("تأكد من كتابة رقم السند بشكل صحيح");
                return;
            }

            DialogResult d = MessageBox.Show(" تأكيد الحفظ ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.Cancel)
            {
                return;
            }

            TblVendorsPaying obj = new TblVendorsPaying();
            if (MyWaslID == 0)
            {
                obj.AddNew();
            }
            else
            {
                obj.LoadByPrimaryKey(MyWaslID);
            }
            obj.Bill_Id = 0;
            obj.Vendor_Id = int.Parse(comboVendors.SelectedValue.ToString());
            obj.Ven_PayDate = DateTime.Parse(dateTimePicker1.Text);
            obj.Ven_PayMoney = double.Parse(txtMoney.Text);
            obj.Vendor_Sendor = txtsender.Text;
            obj.Ven_PayDetails = txtDetails.Text;
            obj.Bank_Id = int.Parse(comboBanks.SelectedValue.ToString());
            obj.User_Id = GlobalVar.user_Id;
            obj.Pay_Wasl = txtWasl.Text;
            obj.Pay_Nots = txtNots.Text;
            obj.Save();

            //FrmPrintSnadSarf x = new FrmPrintSnadSarf(obj.Ven_PayID);
            //x.Show();

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("هل تريد بالتأكيد حذف هذا السند", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {
                TblVendorsPaying obj = new TblVendorsPaying();
                obj.LoadByPrimaryKey(MyWaslID);
                obj.MarkAsDeleted();
                obj.Save();
            }
        }

        public void DialogAddVendorPaying_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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
                    btnAdd.Enabled = true;
                }
                else
                {
                    (sender as TextBox).BackColor = Color.Red;
                    (sender as TextBox).Focus();
                    btnAdd.Enabled = false;
                }
            }
        }
    }
}
