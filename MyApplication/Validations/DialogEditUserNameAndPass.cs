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
namespace MyApplication.Validations
{
    public partial class DialogEditUserNameAndPass : Form
    {
        int MyUserID;
        public DialogEditUserNameAndPass(int UserID)
        {
            MyUserID = UserID;
            InitializeComponent();
        }

        private void DialogEditUserNameAndPass_Load(object sender, EventArgs e)
        {
            if (MyUserID != 0)
            {
                this.Text = "تعديل المستخدم";

                TblUsers uu = new TblUsers();
                uu.LoadByPrimaryKey(MyUserID);
                txtUser.Text = uu.User_Name;
                txtPass.Text = uu.User_Pass; 
            }           
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "" && txtPass.Text != "")
            {
                TblUsers uu = new TblUsers();
                if (MyUserID != 0)
                {
                    uu.LoadByPrimaryKey(MyUserID);
                }
                else
                {
                    uu.AddNew();
                }
                
                uu.User_Name = txtUser.Text;
                uu.User_Pass = txtPass.Text;
                uu.Save();

                MessageBox.Show("تم الحفظ");
                this.Close();
            }
            else
            {
                MessageBox.Show("تأكد من كتابة اسم المستخدم وكلمة المرور بشكل صحيح");
            }
        }

        private void DialogEditUserNameAndPass_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
