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
    public partial class FrmEmployeesSalary : Form
    {
        string MySearchType = "";
        public FrmEmployeesSalary()
        {
            InitializeComponent();
            txtMonth.Text = DateTime.Now.Month.ToString();
            txtYear.Text = DateTime.Now.Year.ToString();            
            comboArchive.SelectedIndex = 0;
        }

        private void FrmEnployeesSalary_Load(object sender, EventArgs e)
        {           
           
        }

        private void FillMyGrid()
        {
            double TotalLast = 0;

            double TotalSalary = 0;
            double TotalPay = 0;
            double TotalCurrentRest = 0;
            double TotalRest = 0;

            dataGridView1.Rows.Clear();          
            TblEmployeesData y = new TblEmployeesData();
           
                if (comboArchive.Text == "الحالي")
                {
                    y.Where.Emp_Archive.Value = "لا";
                }
                else if (comboArchive.Text == "الأرشيف")
                {
                    y.Where.Emp_Archive.Value = "نعم";
                }
                             

            if (MySearchType == "name")
            {
                y.Where.Emp_Name.Value = "%" + txtName.Text + "%";
                y.Where.Emp_Name.Operator = WhereParameter.Operand.Like;
            }

            if (y.Query.Load())
            {
                y.Sort = TblEmployeesData.ColumnNames.Emp_Name + " ASC";

                do
                {
                    ClassEmployeesFinance cs = new ClassEmployeesFinance(y.Emp_ID, int.Parse(txtMonth.Text), int.Parse(txtYear.Text));
                    ClassGetEmployeesLast x = new ClassGetEmployeesLast(cs.MySalaryID, y.Emp_ID);

                    TotalSalary += cs.NetSalary;
                    TotalPay += cs.TotalTakeMoney;
                    TotalCurrentRest += cs.RestMoney;

                    TotalLast += x.Last;


                    double EmpRest = cs.RestMoney + x.Last;

                    TotalRest += EmpRest;


                    //if (EmpRest != 0)
                    //{
                    dataGridView1.Rows.Add(y.Emp_ID, dataGridView1.Rows.Count + 1, y.Emp_Name, x.Last.ToString("0,0"), cs.NetSalary.ToString("0,0"), cs.TotalTakeMoney.ToString("0,0"), cs.RestMoney.ToString("0,0"), EmpRest.ToString("0,0"), "عرض التفاصيل", "تقرير حسابات");
                    //}

                } while (y.MoveNext());
            }

           

            lblTotalCurrentRest.Text = TotalCurrentRest.ToString("0,0");
            lblTotalSalary.Text = TotalSalary.ToString("0,0");
            lblTotalPay.Text = TotalPay.ToString("0,0");
            lblTotalLast.Text = TotalLast.ToString("0,0"); 
            lblTotalRest.Text = TotalRest.ToString("0,0");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtMonth.Text) >= 1 && int.Parse(txtMonth.Text) <= 12 && int.Parse(txtYear.Text) >= 2016)
            {
                MySearchType = "";
                FillMyGrid();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (e.RowIndex >= 0)
                {
                    int RowID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnID"].Value.ToString());
                    if (e.ColumnIndex == dataGridView1.Columns["ColumnReport"].Index)
                    {

                        DialogEmployeesFinanceDetails obj = new DialogEmployeesFinanceDetails(RowID);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            FillMyGrid();
                        }
                    }
                }
            }
        }

        private void BtnAddSalary_Click(object sender, EventArgs e)
        {
            Employees.DialogAddSalary obj = new DialogAddSalary();
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                FillMyGrid();
            }
        }
  
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtName.Text != "")
            {
                MySearchType = "name";
                FillMyGrid();
            }          
        }
     
    }
}
