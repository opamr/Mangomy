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

namespace MyApplication.Payments
{
    public partial class DialogAdvancedSearchPayments : Form
    {
        public DialogAdvancedSearchPayments()
        {
            InitializeComponent();
        }

        private void DialogAdvancedSearchPayments_Load(object sender, EventArgs e)
        {
          
            //--------------------------------------------------------load category
            TblGoodsCategory x = new TblGoodsCategory();
            x.LoadAll();
            if (x.RowCount > 0)
            {
                x.Sort = TblGoodsCategory.ColumnNames.Category_Name + " ASC";

                combocategory.ValueMember = TblGoodsCategory.ColumnNames.Ctaegory_ID;
                combocategory.DisplayMember = TblGoodsCategory.ColumnNames.Category_Name;
                combocategory.DataSource = x.DefaultView;
            }
            //------------------------


            TblGoodsTitles gg = new TblGoodsTitles();
            gg.LoadAll();
            if (gg.RowCount > 0)
            {
                gg.Sort = TblGoodsTitles.ColumnNames.Good_TraidName + " ASC";
                comboGoods.ValueMember = TblGoodsTitles.ColumnNames.Title_ID;
                comboGoods.DisplayMember = TblGoodsTitles.ColumnNames.Good_TraidName;
                comboGoods.DataSource = gg.DefaultView;                
            }

        }

        private void FillMyGrid()
        {
            dataGridView1.Rows.Clear();

            double TotalCount = 0, TotalPayments = 0, TotalProfits = 0;

            ViewCustomerPayments obj = new ViewCustomerPayments();
            obj.Where.Bill_Date.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text);
            obj.Where.Bill_Date.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text);
            obj.Where.Bill_Date.Operator = WhereParameter.Operand.Between;
            if (radioGoods.Checked == true)
            {
                obj.Where.Titel_Id.Value = int.Parse(comboGoods.SelectedValue.ToString());
            }
            else if (radioCategory.Checked == true)
            {
                obj.Where.Category_Id.Value = int.Parse(combocategory.SelectedValue.ToString());
            }         
            if (obj.Query.Load())
            {
                do
                {
                    if (obj.Bill_Type != "عرض سعر")
                    {
                        if (obj.Bill_Type == "فاتورة مرتجعات")
                        {
                            TotalCount -= obj.PayCount;
                            TotalPayments -= obj.Pay_Total;
                            TotalProfits -= obj.Pay_Profit;                           
                        }
                        else
                        {
                            TotalCount += obj.PayCount;
                            TotalPayments += obj.Pay_Total;
                            TotalProfits += obj.Pay_Profit;
                        }                      

                        dataGridView1.Rows.Add(obj.Pay_ID, dataGridView1.Rows.Count + 1, obj.Bill_Date.ToShortDateString(),
                     obj.Bill_Type, obj.CustomerBill_Id, obj.Good_TraidName, obj.Barcode_Unit, obj.PayCount,
                     obj.Pay_Price, obj.Pay_Total.ToString("0,0.00"), obj.Pay_Profit.ToString("0,0.00"), obj.User_Name);
                    }                                                         
                } while (obj.MoveNext());
            }

            lblTotalCount.Text = TotalCount.ToString("0,0.00");
            lblTotalPayments.Text = TotalPayments.ToString("0,0.00");
            lblTotalProfits.Text = TotalProfits.ToString("0,0.00");
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            FillMyGrid();
        }
    }
}
