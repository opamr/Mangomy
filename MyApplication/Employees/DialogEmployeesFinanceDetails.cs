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
    public partial class DialogEmployeesFinanceDetails : Form
    {
        int MyEmpID;
        public DialogEmployeesFinanceDetails(int EmpID)
        {
            MyEmpID = EmpID;
            InitializeComponent();
        }

        private void DialogEmployeesFinanceDetails_Load(object sender, EventArgs e)
        {
            TblEmployeesData sa = new TblEmployeesData();
            sa.LoadByPrimaryKey(MyEmpID);
            lblName.Text = sa.Emp_Name;



            double Rest = 0;
            dataGridView1.Rows.Clear();

            TblEmployeesSalary obj = new TblEmployeesSalary();
            obj.Where.Emp_Id.Value = MyEmpID;
            if (obj.Query.Load())
            {
                obj.Sort = TblEmployeesSalary.ColumnNames.Salary_Date + " ASC";

                int g = 0;
                do
                {
                    ClassEmployeesFinance cs = new ClassEmployeesFinance(obj.Emp_Id,obj.Salary_Month,obj.Salary_Year);
                    Rest += cs.RestMoney;

                    ++g;
                    dataGridView1.Rows.Add(obj.Salary_ID, g, obj.Salary_Details, cs.NetSalary.ToString("0,0"), cs.TotalTakeMoney.ToString("0,0"),
                        cs.RestMoney.ToString("0,0"), "عرض التفاصيل", cs.RememberMessgae);
                } while (obj.MoveNext());
            }

            lblTotalRest.Text = Rest.ToString("0,0");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (e.RowIndex >= 0)
                {
                    int RowID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnID"].Value.ToString());
                    if (e.ColumnIndex == dataGridView1.Columns["ColumnDetails"].Index)
                    {
                        DialogSalaryDetails obj = new DialogSalaryDetails(RowID);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            DialogEmployeesFinanceDetails_Load(sender, e);
                        }
                    }                  
                }
            }
        }       

        private void DialogEmployeesFinanceDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }       
    }
}
