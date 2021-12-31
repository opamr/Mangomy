using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGeneration.dOOdads;
using MyPro;

namespace MyApplication.Vendors
{
    public partial class DialogGoodsReport : Form
    {
        int MyVendorID;
        public DialogGoodsReport(int VendorId)
        {
            MyVendorID = VendorId;
            InitializeComponent();
        }

        private void DialogGoodsReport_Load(object sender, EventArgs e)
        {
            TblVendorsData vv = new TblVendorsData();
            vv.LoadByPrimaryKey(MyVendorID);
            lblVendorName.Text = vv.Vendor_Name;
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            ViewVendorsGoods obj = new ViewVendorsGoods();
            obj.Where.Bill_VendorId.Value = MyVendorID;
            obj.Query.AddResultColumn(ViewVendorsGoods.ColumnNames.Titel_Id);
            obj.Query.Distinct = true;
            if (obj.Query.Load())
            {
                int g = 0;
                do
                {
                    double BuysCount = 0;
                    double PaysCount = 0;
                    string PayPrice = "";

                    ViewCustomerPayments py = new ViewCustomerPayments();
                    py.Where.Titel_Id.Value = obj.Titel_Id;
                    py.Where.Bill_Date.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text);
                    py.Where.Bill_Date.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text);
                    py.Where.Bill_Date.Operator = WhereParameter.Operand.Between;
                    if (py.Query.Load())
                    {
                        do
                        {
                            PaysCount += py.PayCount;

                            PayPrice = py.Pay_Price.ToString();
                        } while (py.MoveNext());
                    }

                    ViewVendorsGoods x = new ViewVendorsGoods();
                    x.Where.Titel_Id.Value = obj.Titel_Id;
                    x.Where.Bill_VendorId.Value = MyVendorID;
                    x.Where.Bill_Date.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text);
                    x.Where.Bill_Date.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text);
                    x.Where.Bill_Date.Operator = WhereParameter.Operand.Between;
                    if (x.Query.Load())
                    {
                        do
                        {
                            BuysCount += x.Good_Count;
                        } while (x.MoveNext());

                        ++g;
                        dataGridView1.Rows.Add(x.Titel_Id, g, x.Good_TraidName, BuysCount, PaysCount,x.Good_Price,PayPrice);
                    }
                                  
                } while (obj.MoveNext());
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                TblPrint pr = new TblPrint();
                pr.LoadAll();
                pr.DeleteAll();
                pr.Save();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    TblPrint obj = new TblPrint();
                    obj.AddNew();
                    obj.Column1 = Convert.ToString(row.Cells["Column1"].Value);
                    obj.Column2 = Convert.ToString(row.Cells["Column2"].Value);
                    obj.Column3 = Convert.ToString(row.Cells["Column3"].Value);
                    obj.Column4 = Convert.ToString(row.Cells["Column4"].Value);
                    obj.Column5 = Convert.ToString(row.Cells["Column5"].Value);
                    obj.Column6 = lblVendorName.Text;
                    obj.Column7 = "تقرير عن أصناف المورد خلال الفترة من : " + dateTimePicker1.Text + " إلى : " + dateTimePicker2.Text;
                    obj.Save();
                }

                FrmPrintGoodsReport x = new FrmPrintGoodsReport();
                x.ShowDialog();
            }
        }
    }
}
