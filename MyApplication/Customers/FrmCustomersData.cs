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

namespace MyApplication
{
    public partial class FrmCustomersData : Form
    {       
        string MySearchType;
        public FrmCustomersData()
        {
            InitializeComponent();
        }

        private void FrmNewCustomer_Load(object sender, EventArgs e)
        {
            
        }             

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 14);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            } 
            
            Customers.DialogAddCustomer obj = new Customers.DialogAddCustomer(0);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                FrmNewCustomer_Load(sender, e);
            }
        }

        private void FillMyList()
        {            
            dataGridView1.Rows.Clear();            
            int g = 0;
            TblCustomersData obj = new TblCustomersData();
            obj.Where.Customer_ID.Value = 1;
            obj.Where.Customer_ID.Operator = WhereParameter.Operand.NotEqual;
            if (MySearchType == "mobile")
            {
                obj.Where.Customer_Mobile.Value = txtphone.Text;
            }
            else if (MySearchType == "name")
            {              
                obj.Where.Customer_Name.Value = "%" + txtName.Text + "%";
                obj.Where.Customer_Name.Operator = WhereParameter.Operand.Like;   
            }           
            else if (MySearchType == "id")
            {
                obj.Where.Customer_Name.Value = int.Parse(txtID.Text);
            }

            if (obj.Query.Load())
            {
                obj.Sort = TblCustomersData.ColumnNames.Customer_Name + " ASC";
                obj.Query.Top = 10;
                do
                {                    
                        ClassCustomerFinance cs = new ClassCustomerFinance(obj.Customer_ID);
                        ++g;
                        dataGridView1.Rows.Add( g, obj.Customer_ID, obj.Customer_Name, obj.Customer_Mobile, obj.Customer_Address, obj.Customer_VatNumber,
                            obj.Customer_SenderName, obj.Customer_SenderMobile, cs.CustomerFinance.ToString("0,0.00"), "تعديل بيانات", "حسابات");
                                                      
                } while (obj.MoveNext());

            }
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {            
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtphone.Text != "")
                {
                    MySearchType = "mobile";
                    FillMyList();
                }
                else
                {
                    dataGridView1.Rows.Clear();
                }
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtName.Text == "")
                {
                    dataGridView1.Rows.Clear();
                }
                else
                {
                    MySearchType = "name";
                    FillMyList();                   
                }
              
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
                        ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 16);
                        if (xx.Allow == "no")
                        {
                            MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                            return;
                        }

                        Customers.FrmCustomerFinance obj1 = new Customers.FrmCustomerFinance(RowID);
                        obj1.MdiParent = FrmMain.ActiveForm;
                        obj1.Show();
                    }
                    else if (e.ColumnIndex == dataGridView1.Columns["ColumnEdit"].Index)
                    {
                        ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 15);
                        if (xx.Allow == "no")
                        {
                            MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                            return;
                        }

                        Customers.DialogAddCustomer obj = new Customers.DialogAddCustomer(RowID);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            FillMyList();
                        }
                    }
                }
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtID.Text != "")
                {
                    if (txtID.Text != "1")
                    {
                        MySearchType = "id";
                        FillMyList();
                    }                   
                }
                else
                {
                    dataGridView1.Rows.Clear();
                }
            }
        }       

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            MySearchType = "all";
            FillMyList();
        }
    }
}
