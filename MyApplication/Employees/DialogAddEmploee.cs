using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGeneration.dOOdads;
using MyPro;
using System.IO;
using System.Globalization;

namespace MyApplication.Employees
{
    public partial class DialogAddEmploee : Form
    {        
        string MyExtention = "";

        int MyEmpID;
        public DialogAddEmploee(int EmpId)
        {
            MyEmpID = EmpId;
            InitializeComponent();            
        }

        private void DialogAddEmploee_Load(object sender, EventArgs e)
        {                      
            if (MyEmpID != 0)
            {
                this.Text = "تعديل";
                BtnAdToArchive.Visible  = true;
                BtnDelete.Visible = true;

                TblEmployeesData obj = new TblEmployeesData();
                obj.LoadByPrimaryKey(MyEmpID);
                txtName.Text = obj.Emp_Name;
                txtMobile.Text = obj.Emp_Mobile;
                dateTimePickerStartWork.Text = obj.Emp_StartDate.ToShortDateString();                
                txtSpecial.Text = obj.Emp_Special;
                txtNationality.Text = obj.Emp_Nationality;
                txtAddress.Text = obj.Emp_Address;
                txtIdentity.Text = obj.Emp_Identity;
                dateTimePickerIdentity.Text = obj.Emp_IdentityDate.ToShortDateString();
                txtSalary.Text = obj.Emp_Salary.ToString();
                txtHouse.Text = obj.Emp_House.ToString();                     
            }            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtSalary.Text !="" && txtHouse.Text != "" && txtName.Text != "")
            {
                TblEmployeesData obj = new TblEmployeesData();
                if (MyEmpID == 0)
                {
                    obj.AddNew();
                    obj.Emp_Archive = "لا";
                }
                else
                {
                    obj.LoadByPrimaryKey(MyEmpID);
                }

                obj.Emp_Name = txtName.Text;
                obj.Emp_Mobile = txtMobile.Text;
                obj.Emp_StartDate = DateTime.Parse(dateTimePickerStartWork.Text);                
                obj.Emp_Special = txtSpecial.Text;
                obj.Emp_Nationality = txtNationality.Text;
                obj.Emp_Address = txtAddress.Text;
                obj.Emp_Identity = txtIdentity.Text;
                obj.Emp_IdentityDate = DateTime.Parse(dateTimePickerIdentity.Text);
                obj.Emp_Salary = int.Parse(txtSalary.Text);
                obj.Emp_House = int.Parse(txtHouse.Text);               
                obj.Save();
              
                this.Close();               
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }      
        private void DialogAddEmploee_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnAdToArchive_Click(object sender, EventArgs e)
        {
            Employees.DialogAddEmpToArchive obj = new DialogAddEmpToArchive(MyEmpID);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                TblEmployeesData x = new TblEmployeesData();
                x.LoadByPrimaryKey(MyEmpID);
                if (x.Emp_Archive == "نعم")
                {
                    this.Close();
                }
                
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //if (GlobalVar.user_Id != 5)
            //{
            //    return;
            //}

            //DialogResult d = MessageBox.Show(" تأكيد الحفظ ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (d == DialogResult.OK)
            //{
            //    TblEmployeesData obj = new TblEmployeesData();
            //    obj.LoadByPrimaryKey(MyEmpID);
            //    obj.MarkAsDeleted();
            //    obj.Save();

            //    this.Close();
            //}
        }

        private void dateTimePickerIdentity_ValueChanged(object sender, EventArgs e)
        {
            DateTime MyDate = DateTime.Parse(dateTimePickerIdentity.Text);
            UmAlQuraCalendar higr = new UmAlQuraCalendar();
            lblHigrDate.Text = higr.GetYear(MyDate) + " / " + higr.GetMonth(MyDate) + " / " + higr.GetDayOfMonth(MyDate);
        }
    }
}
