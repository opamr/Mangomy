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
    public partial class FrmUsers : Form
    {       
        public FrmUsers()
        {
            InitializeComponent();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();
         
            TblUsers obj = new TblUsers();
            obj.LoadAll();
            if (obj.RowCount > 0)
            {
                int g = 0;
                do
                {
                    ++g;
                    dataGridView1.Rows.Add(obj.User_ID, g, obj.User_Name, "الصلاحيات", "تعديل");

                } while (obj.MoveNext());
            }
        }             
       
        private void IconAdd_Click(object sender, EventArgs e)
        {
            Validations.DialogEditUserNameAndPass obj = new DialogEditUserNameAndPass(0);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                FrmUsers_Load(sender, e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (e.RowIndex >= 0)
                {
                    int Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnID"].Value.ToString());

                    if (e.ColumnIndex == dataGridView1.Columns["ColumnValidation"].Index)
                    {
                        if (Id == 1)
                        {
                            return;
                        }

                        Validations.DialogValidation obj = new Validations.DialogValidation(Id);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            FrmUsers_Load(sender, e);
                        }
                    }
                    else if (e.ColumnIndex == dataGridView1.Columns["ColumnEdit"].Index)
                    {
                        Validations.DialogEditUserNameAndPass obj = new DialogEditUserNameAndPass(Id);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            FrmUsers_Load(sender, e);
                        }
                    }
                }
            }
        }
    }
}
