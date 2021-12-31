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
    public partial class FrmVendorsMoney : Form
    {
        public FrmVendorsMoney()
        {
            InitializeComponent();
        }

        private void FrmVendorsMoney_Load(object sender, EventArgs e)
        {
            double VendorsMoney = 0;
            double CustomersMoney = 0;
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            ListViewItem lv;
            TblVendorsData ve = new TblVendorsData();
            ve.LoadAll();
            if (ve.RowCount > 0)
            {
                ve.Sort = TblVendorsData.ColumnNames.Vendor_Name + " ASC";
                int g = 0;
                do
                {
                    ClassVendorFinance cs = new ClassVendorFinance(ve.Vendor_ID);

                    VendorsMoney += cs.VendorRest;
                    ++g;
                    dataGridView1.Rows.Add(ve.Vendor_ID, g, ve.Vendor_Name, cs.VendorRest.ToString("0,0.00"));

                } while (ve.MoveNext());
            }
            lblVendorsRest.Text = VendorsMoney.ToString("0,0.00");
            //---------------------------------------------------------------------------------------------
            //**********************************************************************************************
            //------------------------------------------
            TblCustomersData cu = new TblCustomersData();
            cu.Where.Customer_ID.Value = 1;
            cu.Where.Customer_ID.Operator = WhereParameter.Operand.NotEqual;
            if (cu.Query.Load())
            {
                cu.Sort = TblCustomersData.ColumnNames.Customer_Name + " ASC";
                int r = 0;
                do
                {
                    ClassCustomerFinance cs = new ClassCustomerFinance(cu.Customer_ID);
                    if (cs.CustomerFinance>0)
                    {
                        ++r;
                        CustomersMoney += cs.CustomerFinance;
                        dataGridView2.Rows.Add(r, cu.Customer_Name, cu.Customer_ID, cs.CustomerFinance.ToString("0.00"), "تسديد مبلغ");  
                    }                   
                } while (cu.MoveNext());
            }
            lblCustomers.Text = CustomersMoney.ToString("0,0.00");
        }       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (e.RowIndex >= 0)
                {
                    int RowID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnVendorID"].Value.ToString());

                    if (e.ColumnIndex == dataGridView1.Columns["ColumnDetails"].Index)
                    {
                        Vendors.DialogAddVendorPaying obj = new Vendors.DialogAddVendorPaying(RowID, 0);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            ClassVendorFinance cs = new ClassVendorFinance(RowID);
                            dataGridView1.Rows[e.RowIndex].Cells["ColumnVendorMoney"].Value = cs.VendorRest.ToString("0,0.00");
                        }
                    }
                    if (e.ColumnIndex == dataGridView1.Columns["ColumnFinance"].Index)
                    {
                        Vendors.FrmVendorFinance obj = new Vendors.FrmVendorFinance(RowID);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            ClassVendorFinance cs = new ClassVendorFinance(RowID);
                            dataGridView1.Rows[e.RowIndex].Cells["ColumnVendorMoney"].Value = cs.VendorRest.ToString("0,0.00");
                        }
                    }
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                if (e.RowIndex >= 0)
                {
                    int RowID = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["ColumnCustomerID"].Value.ToString());

                    if (e.ColumnIndex == dataGridView2.Columns["ColumnCustomer"].Index)
                    {
                        Customers.DialogAddCustomerPaying obj = new Customers.DialogAddCustomerPaying(RowID, 0, "سند قبض");
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            FrmVendorsMoney_Load(sender, e);
                        }
                    }
                }
            }
        }

        private void BtnPrintVendors_Click_1(object sender, EventArgs e)
        {
            TblPrint pr = new TblPrint();
            pr.LoadAll();
            pr.DeleteAll();
            pr.Save();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                TblPrint x = new TblPrint();
                x.AddNew();
                x.Column1 = row.Cells["ColumnVendorName"].Value.ToString();
                x.Column2 = row.Cells["ColumnVendorID"].Value.ToString();
                x.Column3 = row.Cells["ColumnVendorMoney"].Value.ToString();
                x.Column4 = lblVendorsRest.Text;
                x.Column5 = "تقرير حسابات الموردين";
                x.Save();
            }

            FrmPrintRestMoney obj = new FrmPrintRestMoney();
            obj.ShowDialog();
        }

        private void BtnPrintCustomer_Click(object sender, EventArgs e)
        {
            TblPrint pr = new TblPrint();
            pr.LoadAll();
            pr.DeleteAll();
            pr.Save();

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                TblPrint x = new TblPrint();
                x.AddNew();
                x.Column1 = row.Cells["ColumnCustomerName"].Value.ToString();
                x.Column2 = row.Cells["ColumnCustomerID"].Value.ToString();
                x.Column3 = row.Cells["ColumnCustomerMoney"].Value.ToString();
                x.Column4 = lblCustomers.Text;
                x.Column5 = "تقرير حسابات العملاء";
                x.Save();
            }

            FrmPrintRestMoney obj = new FrmPrintRestMoney();
            obj.ShowDialog();
        }
    }
}
