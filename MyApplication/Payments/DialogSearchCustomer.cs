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
using System.Globalization;

namespace MyApplication.Payments
{
    public partial class DialogSearchCustomer : Form
    {
        string MySearchType;
        public DialogSearchCustomer()
        {
            InitializeComponent();
        }

        private void DialogSearchCustomer_Load(object sender, EventArgs e)
        {

        }

        private void FillMyGrid()
        {
            dataGridView1.Rows.Clear();

            //---------------------------------------------------------العميل الدائم
            TblCustomersData obj = new TblCustomersData();           
            if (MySearchType == "name")
            {
                obj.Where.Customer_Name.Value = "%" + txtName.Text + "%";
                obj.Where.Customer_Name.Operator = WhereParameter.Operand.Like;
            }
            else if (MySearchType == "id")
            {
                obj.Where.Customer_ID.Value = Convert.ToInt32(txtCode.Text);
            }
            else if (MySearchType == "mobile")
            {
                obj.Where.Customer_Mobile.Value = txtmobile.Text;
            }
            
            if (obj.Query.Load())
            {                
                do
                {
                    double CustomerFinance = 0;
                    if (obj.Customer_ID != 1)
                    {
                        ClassCustomerFinance cs = new ClassCustomerFinance(obj.Customer_ID);
                        CustomerFinance = cs.CustomerFinance;
                    }

                    dataGridView1.Rows.Add(0, dataGridView1.Rows.Count + 1, obj.Customer_Name, obj.Customer_Mobile, obj.Customer_ID, CustomerFinance.ToString("0,0.00"), "إختيار");
                } while (obj.MoveNext());
            }

            //int result = 0;
            ////----------------------------------العميل النقدي او الكاش
            //TblCustomersBills cb = new TblCustomersBills();
            //cb.Where.Customer_Id.Value = 1;
            //if (MySearchType == "name")
            //{               
            //    cb.Where.Bill_CustomerName.Value = "%" + txtName.Text + "%";
            //    cb.Where.Bill_CustomerName.Operator = WhereParameter.Operand.Like;
            //    if (cb.Query.Load())
            //    {
            //        result = 1;
            //    }
            //}
            //else if (MySearchType == "mobile")
            //{                
            //    cb.Where.Customer_Id.Value = 1;
            //    cb.Where.Bill_CustomerPhone.Value = txtmobile.Text;
            //    if (cb.Query.Load())
            //    {
            //        result = 1;
            //    }
            //}
            //if (result == 1)
            //{                
            //    do
            //    {
            //        //ClassCustomerBillTotal cs = new ClassCustomerBillTotal(cb.Bill_ID);
            //        dataGridView1.Rows.Add(cb.Bill_ID ,dataGridView1.Rows.Count + 1, cb.Bill_CustomerName, cb.Bill_CustomerPhone, cb.Customer_Id, 0, "تفاصيل الحساب", "إختيار");
            //    } while (cb.MoveNext());
            //}

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtName.Text != "")
                {
                    MySearchType = "name";
                    FillMyGrid();
                }              
            }
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtCode.Text != "")
                {
                    MySearchType = "id";
                    FillMyGrid();
                }     
            }
        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
            

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtmobile.Text != "")
                {
                    MySearchType = "mobile";
                    FillMyGrid();
                }     
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (e.RowIndex >= 0)
                {
                    int Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnID"].Value.ToString());
                    int BillId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnBillID"].Value.ToString());

                    if (e.ColumnIndex == dataGridView1.Columns["ColumnChoose"].Index)
                    {
                        GlobalVar.Customer_Id = Id;
                        this.Close();
                    }
                }
            }
        }

        private void DialogSearchCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-sa"));
        }

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            MySearchType = "all";
            FillMyGrid();
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            Customers.DialogAddCustomer obj = new Customers.DialogAddCustomer(0);
            obj.ShowDialog();           
        }
    }
}
