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
    public partial class DialogAddVendor : Form
    {
        int MyVendorID;
        public DialogAddVendor(int VendorID)
        {
            MyVendorID = VendorID;
            InitializeComponent();
        }

        private void DialogAddVendor_Load(object sender, EventArgs e)
        {
            if (MyVendorID != 0)
            {
                this.Text = "تعديل بيانات المورد";
                btnDelete.Visible = true;

                TblVendorsData obj = new TblVendorsData();
                obj.LoadByPrimaryKey(MyVendorID);
                txtName.Text = obj.Vendor_Name;
                txtPhone.Text = obj.Vendor_Phone;
                txtAddress.Text = obj.Vendor_Address;
                txtFax.Text = obj.Vendor_Fax;
                txtBankNumber.Text = obj.Vendor_BankNumber;
                txtbankType.Text = obj.Vendor_BankType;
                txtVat.Text = obj.Vendor_Email;
                txtRecentMoney.Text = obj.Vendor_RecentMoney.ToString();
                dateTimePicker1.Text = obj.Vendor_RecentDate.ToShortDateString();
                txtDetails.Text = obj.Vendor_Details;
                txtSender.Text = obj.Vendor_SenderName;
                txtSenderMobil.Text = obj.Vendor_SenderMobile;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtRecentMoney.Text != "")
            {

                if (MyVendorID != 0)
                {
                    TblVendorsData obj = new TblVendorsData();
                    obj.LoadByPrimaryKey(MyVendorID);
                    obj.Vendor_Name = txtName.Text;
                    obj.Vendor_Phone = txtPhone.Text;
                    obj.Vendor_Address = txtAddress.Text;
                    obj.Vendor_Fax = txtFax.Text;
                    obj.Vendor_BankNumber = txtBankNumber.Text;
                    obj.Vendor_BankType = txtbankType.Text;
                    obj.Vendor_Email = txtVat.Text;
                    obj.Vendor_RecentMoney = double.Parse(txtRecentMoney.Text);
                    obj.Vendor_RecentDate = DateTime.Parse(dateTimePicker1.Text).Date;
                    obj.Vendor_Details = txtDetails.Text;
                    obj.Vendor_SenderName = txtSender.Text;
                    obj.Vendor_SenderMobile = txtSenderMobil.Text;
                    obj.Save();

                    this.Close();
                }
                else   //-------------------الإضافة
                {
                    TblVendorsData cust = new TblVendorsData();
                    cust.Where.Vendor_Name.Value = txtName.Text;
                    if (cust.Query.Load())
                    {
                        MessageBox.Show("هذا المورد موجود من قبل", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        TblVendorsData obj = new TblVendorsData();
                        obj.AddNew();                      
                        obj.Vendor_Name = txtName.Text;
                        obj.Vendor_Phone = txtPhone.Text;
                        obj.Vendor_Address = txtAddress.Text;
                        obj.Vendor_Fax = txtFax.Text;
                        obj.Vendor_BankNumber = txtBankNumber.Text;
                        obj.Vendor_BankType = txtbankType.Text;
                        obj.Vendor_Email = txtVat.Text;
                        obj.Vendor_RecentMoney = double.Parse(txtRecentMoney.Text);
                        obj.Vendor_RecentDate = DateTime.Parse(dateTimePicker1.Text).Date;
                        obj.Vendor_Details = txtDetails.Text;
                        obj.Vendor_SenderName = txtSender.Text;
                        obj.Vendor_SenderMobile = txtSenderMobil.Text;
                        obj.Save();

                        this.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("تأكد من كتابة اسم المورد والرصيد قبل البرنامج");
            }
        }

        private void txtPoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }      

        private void DialogAddVendor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TblVendorsPaying yy = new TblVendorsPaying();
            yy.Where.Vendor_Id.Value = MyVendorID;
            if (yy.Query.Load())
            {
                MessageBox.Show("لا يمكن حذف المورد لوجود سندات مسجلة عليه");
                return;
            }

            TblVendorsBills bb = new TblVendorsBills();
            bb.Where.Bill_VendorId.Value = MyVendorID;
            if (bb.Query.Load())
            {
                MessageBox.Show("لا يمكن حذف المورد لوجود فواتير مسجلة عليه");
                return;
            }

            DialogResult d = MessageBox.Show(" تأكيد الحذف ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.Cancel)
            {
                return;
            }

            TblVendorsData obj = new TblVendorsData();
            obj.LoadByPrimaryKey(MyVendorID);
            obj.MarkAsDeleted();
            obj.Save();

            this.Close();
        }      
    }
}
