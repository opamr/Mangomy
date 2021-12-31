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
     
    public partial class FrmEmployeesData : Form
    {
        string MySearchType;
        public FrmEmployeesData()
        {
            InitializeComponent();          
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {           
            MySearchType = "all";
            FillMyGrid();
        }

        private void FillMyGrid()
        {
            dataGridView2.Rows.Clear();
            TblEmployeesData obj = new TblEmployeesData();
            obj.Where.Emp_Archive.Value = "لا";
            if (MySearchType == "name")
            {
                obj.Where.Emp_Name.Value = "%" + txtName.Text + "%";
                obj.Where.Emp_Name.Operator = WhereParameter.Operand.Like;
            }
            if (obj.Query.Load())
            {
                obj.Sort = TblEmployeesData.ColumnNames.Emp_Name + " ASC";
                int g = 0;
                do
                {
                    ++g;
                    dataGridView2.Rows.Add(obj.Emp_ID, g, obj.Emp_Name, obj.Emp_Special, obj.Emp_Mobile, obj.Emp_Nationality, obj.Emp_Identity,
                        obj.Emp_IdentityDate.ToShortDateString(), "تعديل بيانات");
                } while (obj.MoveNext());
            }
        }

        private void BtnAddEmp_Click(object sender, EventArgs e)
        {
            Employees.DialogAddEmploee obj = new Employees.DialogAddEmploee(0);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                FillMyGrid();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                if (e.RowIndex >= 0)
                {
                    int Id = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["ColumnID"].Value.ToString());

                    if (e.ColumnIndex == dataGridView2.Columns["Column5"].Index)
                    {
                        Employees.DialogAddEmploee obj = new Employees.DialogAddEmploee(Id);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            FillMyGrid();
                        }       
                    }
                    else if (e.ColumnIndex == dataGridView2.Columns["Column7"].Index)
                    {
                        //FrmPrintEmplyeesCards obj = new FrmPrintEmplyeesCards(Id);
                        //obj.ShowDialog();
                    }
                }
            }
        }

        private void dataGridView2_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            TblEmployeesData obj = new TblEmployeesData();
            obj.LoadByPrimaryKey(id);

            //DateTime identity = obj.Emp_IdentityDate.AddMonths(3);

            if (obj.Emp_IdentityDate <= DateTime.Now.Date)
            {
                dataGridView2.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Salmon;
            }
            else if (obj.Emp_IdentityDate <= DateTime.Now.Date.AddMonths(3))
            {
                dataGridView2.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
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
