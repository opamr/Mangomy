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

namespace MyApplication
{
    public partial class FrmVendorsData : Form
    {        
        string MySearchType;
        public FrmVendorsData()
        {
            InitializeComponent();
        }

        private void FrmVendorsData_Load(object sender, EventArgs e)
        {                                   
                    
        }

        private void FillMyList()
        {
            dataGridView1.Rows.Clear();

            int g = 0;
            TblVendorsData obj = new TblVendorsData();
            obj.Where.Vendor_ID.Value = 0;
            obj.Where.Vendor_ID.Operator = WhereParameter.Operand.NotEqual;

            if (MySearchType == "sender")
            {
                obj.Where.Vendor_SenderName.Value = "%" + txtSender.Text + "%";
                obj.Where.Vendor_SenderName.Operator = WhereParameter.Operand.Like;
            }
            else if (MySearchType == "name")
            {                
                obj.Where.Vendor_Name.Value = "%" + txtName.Text + "%";
                obj.Where.Vendor_Name.Operator = WhereParameter.Operand.Like;
            }
            if (obj.Query.Load())
            {                
                do
                {
                    ClassVendorFinance cc = new ClassVendorFinance(obj.Vendor_ID);

                    ++g;
                    dataGridView1.Rows.Add(obj.Vendor_ID, g, obj.Vendor_Name, obj.Vendor_Address, obj.Vendor_SenderName,
                        obj.Vendor_SenderMobile, cc.VendorRest.ToString("0,0.00"));                
                } while (obj.MoveNext());
            }
        }    

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 3);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            } 
            
            Vendors.DialogAddVendor obj = new Vendors.DialogAddVendor(0);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                FrmVendorsData_Load(sender, e);
            }
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSender.Text == "")
            {
                return;
            }
           

            if (e.KeyChar == (char)Keys.Enter)
            {
                MySearchType = "sender";
                FillMyList();
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtName.Text == "")
            {
                return;
            }           

            if (e.KeyChar == (char)Keys.Enter)
            {                
                MySearchType = "name";
                FillMyList();
            }
        }       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (e.RowIndex >= 0)
                {
                    int RowID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnID"].Value.ToString());
                    if (e.ColumnIndex == dataGridView1.Columns["ColumnEdit"].Index)
                    {
                        ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 4);
                        if (xx.Allow == "no")
                        {
                            MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                            return;
                        }

                        Vendors.DialogAddVendor obj = new Vendors.DialogAddVendor(RowID);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            FillMyList();
                        }
                    }
                    else if (e.ColumnIndex == dataGridView1.Columns["ColumnFinance"].Index)
                    {
                        ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 5);
                        if (xx.Allow == "no")
                        {
                            MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                            return;
                        }

                      
                        Vendors.FrmVendorFinance obj1 = new Vendors.FrmVendorFinance(RowID);                        
                        obj1.MdiParent = FrmMain.ActiveForm;
                        obj1.Show();
                    }                  
                }
            }
        }

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            MySearchType = "all";
            FillMyList();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-sa"));
        }
    }
}
