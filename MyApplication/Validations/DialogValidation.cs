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
    public partial class DialogValidation : Form
    {
        int MyUserID;
        public DialogValidation(int user)
        {
            MyUserID = user;
            InitializeComponent();
        }

        private void DialogValidation_Load(object sender, EventArgs e)
        {            
            TblValidations obj = new TblValidations();
            obj.LoadAll();
            if (obj.RowCount >0)
            {
               
                obj.Sort = TblValidations.ColumnNames.Validation_Name + " ASC";
                int g = 0;
                do
                {
                    ++g;
                    TblValidationForUsers x = new TblValidationForUsers();
                    x.Where.User_ID.Value = MyUserID;
                    x.Where.Validation_ID.Value = obj.Validation_ID;
                    if (x.Query.Load())
                    {
                        dataGridView1.Rows.Add(obj.Validation_ID, g, obj.Validation_Name,true);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(obj.Validation_ID, g, obj.Validation_Name, false);
                    }
                    
                } while (obj.MoveNext());
            }
        }

        private void BtnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Column2"].Value = true;
            }
        }

        private void btnRemoveSelection_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Column2"].Value = false;
            }
        }

        private void BtnsaveEdit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Column2"].Value) == true)
                {
                    TblValidationForUsers obj = new TblValidationForUsers();
                    obj.Where.User_ID.Value = MyUserID;
                    obj.Where.Validation_ID.Value = int.Parse(row.Cells["Column1"].Value.ToString());
                    if (obj.Query.Load())
                    {
                        //------do nothing
                    }
                    else
                    {
                        obj.AddNew();
                        obj.Validation_ID = int.Parse(row.Cells["Column1"].Value.ToString());
                        obj.User_ID = MyUserID;
                        obj.Save();
                    }
                }
                else
                {
                    TblValidationForUsers obj = new TblValidationForUsers();
                    obj.Where.User_ID.Value = MyUserID;
                    obj.Where.Validation_ID.Value = int.Parse(row.Cells["Column1"].Value.ToString());
                    if (obj.Query.Load())
                    {
                        obj.MarkAsDeleted();
                        obj.Save();
                    }                    
                }
            }

            MessageBox.Show("تم الحفظ");
            this.Close();
        }
    }
}


//ClassValidation vv = new ClassValidation(GlobalVar.user_Id, );
//            if (vv.Allow == "yes")
//            {

//            }
//            else
//            {
//                MessageBox.Show("غير مسموح لك فتح هذه الشاشة");

//            }           