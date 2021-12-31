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

namespace MyApplication.Employees
{
    public partial class DialogAddSalary : Form
    {
        public DialogAddSalary()
        {
            InitializeComponent();
            txtMonth.Text = DateTime.Now.Month.ToString();
            txtYear.Text = DateTime.Now.Year.ToString();
        }

        private void DialogAddSalary_Load(object sender, EventArgs e)
        {
            TblEmployeesData obj = new TblEmployeesData();
            obj.Where.Emp_Archive.Value = "لا";
            if (obj.Query.Load())
            {
                do
                {
                    dataGridView1.Rows.Add(obj.Emp_ID, dataGridView1.Rows.Count + 1, obj.Emp_Name);
                } while (obj.MoveNext());
            }
        }

        private void BtnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["ColumnCheak"].Value = true;
            }
        }

        private void BtnNotSelect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["ColumnCheak"].Value = false;
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
            txtDetails.Text = "راتب شهر " + txtMonth.Text + " / " + txtYear.Text;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtMonth.Text) >= 1 && int.Parse(txtMonth.Text) <= 12 && int.Parse(txtYear.Text) >= 2016)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["ColumnCheak"].Value) == true)
                    {
                        TblEmployeesSalary sa = new TblEmployeesSalary();
                        sa.Where.Salary_Month.Value = int.Parse(txtMonth.Text);
                        sa.Where.Salary_Year.Value = int.Parse(txtYear.Text);
                        sa.Where.Emp_Id.Value = int.Parse(row.Cells["ColumnID"].Value.ToString());
                        if (!sa.Query.Load())
                        {
                            TblEmployeesData x = new TblEmployeesData();
                            x.LoadByPrimaryKey(int.Parse(row.Cells["ColumnID"].Value.ToString()));

                            sa.AddNew();
                            sa.Salary_Month = int.Parse(txtMonth.Text);
                            sa.Salary_Year = int.Parse(txtYear.Text);
                            sa.Emp_Id = int.Parse(row.Cells["ColumnID"].Value.ToString());
                            sa.Salary_Money = x.Emp_Salary;
                            sa.Salary_House = x.Emp_House;                                                     
                            sa.Salary_Details = txtDetails.Text;
                            sa.Salary_Date = DateTime.Parse(dateTimePicker5.Text).Date;                          
                            sa.Save();
                        }


                    }
                }

                MessageBox.Show("تم الحفظ");

                this.Close();
            }
        }

        private void DialogAddSalary_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
