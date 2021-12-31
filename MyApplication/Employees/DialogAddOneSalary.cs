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
    public partial class DialogAddOneSalary : Form
    {
        int MySalaryID;
        public DialogAddOneSalary(int SalaryID)
        {
            MySalaryID = SalaryID;
            InitializeComponent();            
        }

        private void DialogAddOneSalary_Load(object sender, EventArgs e)
        {
            TblEmployeesData obj = new TblEmployeesData();           
            obj.LoadAll();
            if (obj.RowCount > 0)
            {
                comboBoxEmployees.DisplayMember = TblEmployeesData.ColumnNames.Emp_Name;
                comboBoxEmployees.ValueMember = TblEmployeesData.ColumnNames.Emp_ID;
                comboBoxEmployees.DataSource = obj.DefaultView;
            }

            if (MySalaryID != 0)
            {
                TblEmployeesSalary sa = new TblEmployeesSalary();
                sa.LoadByPrimaryKey(MySalaryID);
                txtMonth.Text = sa.Salary_Month.ToString();
                txtYear.Text = sa.Salary_Year.ToString();
                comboBoxEmployees.SelectedValue = sa.Emp_Id;
                txtSalary.Text = sa.Salary_Money.ToString();
                txtHouse.Text = sa.Salary_House.ToString();
              
                txtDetails.Text = sa.Salary_Details;
                dateTimePicker5.Text = sa.Salary_Date.ToShortDateString();
              

               BtnDelete.Visible = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           

            if (int.Parse(txtMonth.Text) >= 1 && int.Parse(txtMonth.Text) <= 12 && int.Parse(txtYear.Text) >= 2016)
            {
                TblEmployeesSalary sa = new TblEmployeesSalary();
                if (MySalaryID == 0)
                {
                    TblEmployeesSalary x = new TblEmployeesSalary();
                    x.Where.Salary_Month.Value= int.Parse(txtMonth.Text);
                    x.Where.Salary_Year.Value= int.Parse(txtYear.Text);
                    x.Where.Emp_Id.Value= int.Parse(comboBoxEmployees.SelectedValue.ToString());
                    if (x.Query.Load())
                    {
                        MessageBox.Show("هذا الشهر مسجل من قبل لنفس الموظف");
                        return;
                    }
                    else
                    {
                        sa.AddNew();                        
                    }
                }
                else
                {
                    sa.LoadByPrimaryKey(MySalaryID);
                }

                sa.Salary_Month = int.Parse(txtMonth.Text);
                sa.Salary_Year = int.Parse(txtYear.Text);
                sa.Emp_Id = int.Parse(comboBoxEmployees.SelectedValue.ToString());
                sa.Salary_Money = double.Parse(txtSalary.Text);
                sa.Salary_House = double.Parse(txtHouse.Text);
             
                sa.Salary_Details = txtDetails.Text;
                sa.Salary_Date = DateTime.Parse(dateTimePicker5.Text).Date;
              
                sa.Save();

                MessageBox.Show("تم الحفظ");

                this.Close();
            }
        }

        private void txtMonth_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MySalaryID == 0)
            {
                TblEmployeesData obj = new TblEmployeesData();
                obj.LoadByPrimaryKey(int.Parse(comboBoxEmployees.SelectedValue.ToString()));
                txtSalary.Text = obj.Emp_Salary.ToString();
                txtHouse.Text = obj.Emp_House.ToString();
              
            }
           
        }

        private void DialogAddOneSalary_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show(" تأكيد الحذف ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {
                TblEmployeesSalaryPaying ww = new TblEmployeesSalaryPaying();
                ww.Where.Salary_Id.Value = MySalaryID;
                if (ww.Query.Load())
                {
                    ww.DeleteAll();
                    ww.Save();
                }

                TblEmployeesBones bb = new TblEmployeesBones();
                bb.Where.Salary_Id.Value = MySalaryID;
                if (bb.Query.Load())
                {
                    bb.DeleteAll();
                    bb.Save();
                }

                TblEmployeesSalary obj = new TblEmployeesSalary();
                obj.LoadByPrimaryKey(MySalaryID);
                obj.MarkAsDeleted();
                obj.Save();

                this.Close();
            }
        }
    }
}
