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
using System.Globalization;
using System.IO;
using System.Net;
using System.Web;

namespace MyApplication.Employees
{
    public partial class DialogTakeSalary : Form
    {
        int MySalayID, MyPayID;
        public DialogTakeSalary(int SalaryId, int PayID)
        {
            MySalayID = SalaryId;
            MyPayID = PayID;
            InitializeComponent();

            TblEmployeesData obj = new TblEmployeesData();
            if (MyPayID == 0)
            {
                obj.Where.Emp_Archive.Value = "لا";
            }
            if (obj.Query.Load())
            {
                comboBoxEmployees.DisplayMember = TblEmployeesData.ColumnNames.Emp_Name;
                comboBoxEmployees.ValueMember = TblEmployeesData.ColumnNames.Emp_ID;
                comboBoxEmployees.DataSource = obj.DefaultView;
            }         

            TblBanks BB = new TblBanks();
            BB.LoadAll();
            if (BB.RowCount > 0)
            {
                comboBanks.DisplayMember = TblBanks.ColumnNames.Bank_Name;
                comboBanks.ValueMember = TblBanks.ColumnNames.Bank_ID;
                comboBanks.DataSource = BB.DefaultView;
            }
        }        

        private void DialogTakeSalary_Load(object sender, EventArgs e)
        {
            if (MySalayID != 0)
            {
                TblEmployeesSalary sa = new TblEmployeesSalary();
                sa.LoadByPrimaryKey(MySalayID);
                comboBoxEmployees.SelectedValue = sa.Emp_Id;
                comboSalary.SelectedValue = MySalayID;
            }

            if (MyPayID != 0)
            {
                TblEmployeesSalaryPaying obj = new TblEmployeesSalaryPaying();
                obj.LoadByPrimaryKey(MyPayID);
                txtMoney.Text = obj.Pay_Money.ToString();
                dateTimePicker5.Text = obj.Pay_Date.ToShortDateString();                
                txtDetails.Text = obj.Pay_Details;
                comboBanks.SelectedValue = obj.Bank_Id;
                //comboSalary.SelectedIndex = obj.Salary_Id;


                BtnDelete.Visible = true;
                this.Text = "تعديل";
            }

            txtMoney_TextChanged(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show(" تأكيد الحذف ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {
                TblEmployeesSalaryPaying obj = new TblEmployeesSalaryPaying();
                obj.LoadByPrimaryKey(MyPayID);
                obj.MarkAsDeleted();
                obj.Save();
                
                this.Close();
            }
        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            var text = (sender as TextBox).Text;

            if (sender is TextBox && text != "0")
            {
                double num;
                double.TryParse(text, out num);

                if (num.ToString() != "0")
                {
                    (sender as TextBox).BackColor = Color.Yellow;
                    BtnSave.Enabled = true;
                }
                else
                {
                    (sender as TextBox).BackColor = Color.Red;
                    (sender as TextBox).Focus();
                    BtnSave.Enabled = false;
                }
            }
        }

        private void DialogTakeSalary_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtDetails.Text == "")
            {
                MessageBox.Show("تأكد من كتابة التفاصيل");
                return;
            }

            if (comboBoxEmployees.SelectedValue == null)
            {
                MessageBox.Show("تأكد من كتابة اسم الموظف بشكل صحيح");
                return;
            }

            TblEmployeesSalaryPaying obj = new TblEmployeesSalaryPaying();
            if (MyPayID != 0)
            {
                obj.LoadByPrimaryKey(MyPayID);
            }
            else
            {
                obj.AddNew();
            }
            obj.s_Salary_Id = comboSalary.SelectedValue.ToString();
            obj.User_Id = GlobalVar.user_Id;
            obj.Pay_Money = double.Parse(txtMoney.Text);
            obj.Pay_Date = DateTime.Parse(dateTimePicker5.Text);
            obj.Pay_Details = txtDetails.Text;
            obj.Bank_Id = int.Parse(comboBanks.SelectedValue.ToString());
            obj.Save();

            //FrmPrintTakeSalary x = new FrmPrintTakeSalary(obj.Pay_ID);
            //x.ShowDialog();

            this.Close();
        }

        private void comboBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {           
            TblEmployeesSalary ss = new TblEmployeesSalary();
            ss.Where.Emp_Id.Value = comboBoxEmployees.SelectedValue;
            if (ss.Query.Load())
            {
                ss.Sort = TblEmployeesSalary.ColumnNames.Salary_ID + " DESC";

                comboSalary.DisplayMember = TblEmployeesSalary.ColumnNames.Salary_Details;
                comboSalary.ValueMember = TblEmployeesSalary.ColumnNames.Salary_ID;
                comboSalary.DataSource = ss.DefaultView;                
            }           
        }

        private void comboSalary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
           
        }             
    }
}
