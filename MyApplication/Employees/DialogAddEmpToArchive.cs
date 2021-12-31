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

namespace MyApplication.Employees
{
    public partial class DialogAddEmpToArchive : Form
    {
        int MyEmpID;
        public DialogAddEmpToArchive(int EmpID)
        {
            MyEmpID = EmpID;
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show(" تأكيد الحفظ في الأرشيف ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {
                TblEmployeesData obj = new TblEmployeesData();
                obj.LoadByPrimaryKey(MyEmpID);
                obj.Emp_Archive = "نعم";
                obj.Emp_ArchiveDate = DateTime.Parse(dateTimePicker5.Text).Date;
                obj.EmpArchiveReson = txtArchiveReson.Text;
                obj.Save();

                this.Close();
            }

               
        }

        private void DialogAddEmpToArchive_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void DialogAddEmpToArchive_Load(object sender, EventArgs e)
        {

        }
    }
}
