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
    public partial class DialogEmployeesArchive : Form
    {
        string MySearchType;
        public DialogEmployeesArchive()
        {
            InitializeComponent();
        }

        private void DialogEmployeesArchive_Load(object sender, EventArgs e)
        {
            MySearchType = "all";
            FillMyGrid();
        }

        private void FillMyGrid()
        {
            dataGridView1.Rows.Clear();
            TblEmployeesData obj = new TblEmployeesData();
            obj.Where.Emp_Archive.Value = "نعم";
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
                    dataGridView1.Rows.Add(obj.Emp_ID, g, obj.Emp_Name, obj.Emp_Special,  obj.Emp_ArchiveDate.ToShortDateString(), obj.EmpArchiveReson,"حسابات", "تفاصيل", "إرجاع");
                } while (obj.MoveNext());
            }
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
                        Employees.DialogAddEmploee obj = new Employees.DialogAddEmploee(RowID);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            FillMyGrid();
                        }
                    }
                    else if (e.ColumnIndex == dataGridView1.Columns["ColumnBack"].Index)
                    {
                        DialogResult d = MessageBox.Show(" تأكيد رجوع الموظف إلى العمل ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (d == DialogResult.OK)
                        {
                            TblEmployeesData obj = new TblEmployeesData();
                            obj.LoadByPrimaryKey(RowID);
                            obj.Emp_Archive = "لا";
                            obj.Save();

                            MessageBox.Show("تم الحفظ");
                        }
                    }
                    else if (e.ColumnIndex == dataGridView1.Columns["Column6"].Index)
                    {
                        Employees.DialogEmployeesFinanceDetails obj = new Employees.DialogEmployeesFinanceDetails(RowID);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            FillMyGrid();
                        }
                    }
                }
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
