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
namespace MyApplication.Goods
{
    public partial class DialogFollowDetails : Form
    {
        int MyGoodID;
        public DialogFollowDetails(int goodID)
        {
            MyGoodID = goodID;
            InitializeComponent();
        }

        private void FillCalcilation()
        {
            TblGoodsTitles obj = new TblGoodsTitles();
            obj.LoadByPrimaryKey(MyGoodID);
            double FirstStoke = obj.FirstStore_Amount0 + obj.FirstStore_Amount1 + obj.FirstStore_Amount2;


            TblGoodsBarcode x = new TblGoodsBarcode();
            x.Where.Titel_Id.Value = MyGoodID;
            if (x.Query.Load())
            {
                dataGridView2.Rows.Clear();
                int g = 0;
                do
                {
                    double FirstByUnit = 0;
                    double BacksToVendor = 0, Buys = 0, Payments = 0, BacksFromCustomer = 0, StoreReview=0, CurrentCount = 0;
                    if (FirstStoke != 0)
                    {
                        FirstByUnit = FirstStoke / double.Parse(x.Barcode_Count);
                    }
                    FirstByUnit = Math.Round(FirstByUnit, 2);

                    //------------------------------------------------------3
                    ViewVendorsGoods gb = new ViewVendorsGoods();
                    gb.Where.Titel_Id.Value = x.Titel_Id;
                    if (gb.Query.Load())
                    {
                        do
                        {
                            double CountByUnit = gb.Good_Count * double.Parse(gb.Barcode_Count);
                            if (gb.Bill_PayType.Contains("فاتورة مرتجعات"))
                            {
                                BacksToVendor += CountByUnit;
                            }
                            else
                            {
                                Buys += CountByUnit;
                            }

                        } while (gb.MoveNext());

                        BacksToVendor = BacksToVendor / double.Parse(x.Barcode_Count);
                        Buys = Buys / double.Parse(x.Barcode_Count);
                    }

                    //--------------------------------------------------------------4
                    ViewCustomerPayments py = new ViewCustomerPayments();
                    py.Where.Titel_Id.Value = x.Titel_Id;
                    if (py.Query.Load())
                    {
                        do
                        {
                            double CountByUnit = py.PayCount * double.Parse(py.Barcode_Count);
                            if (py.Bill_Type == "فاتورة مرتجعات")
                            {
                                BacksFromCustomer += CountByUnit;
                            }
                            else if (py.Bill_Type.Contains("مبيعات"))
                            {
                                Payments += CountByUnit;
                            }

                        } while (py.MoveNext());

                        Payments = Payments / double.Parse(x.Barcode_Count);
                        BacksFromCustomer = BacksFromCustomer / double.Parse(x.Barcode_Count);
                    }

                    ViewStoreReviewSummary tt = new ViewStoreReviewSummary();
                    tt.Where.Title_Id.Value = x.Titel_Id;
                    if (tt.Query.Load())
                    {
                        do
                        {
                            double CountByUnit = tt.Detail_Difference * double.Parse(x.Barcode_Count);

                            if (tt.Detail_Type == "زيادة")
                            {
                                StoreReview += tt.Detail_Difference;
                            }
                            else if (tt.Detail_Type == "عجز")
                            {
                                StoreReview -= tt.Detail_Difference;
                            }
                        } while (tt.MoveNext());

                        StoreReview = StoreReview / double.Parse(x.Barcode_Count);

                    }


                    CurrentCount = FirstByUnit + Buys + BacksFromCustomer - Payments - BacksToVendor + StoreReview;

                    ++g;
                    dataGridView3.Rows.Add(x.Barcode_ID, dataGridView2.Rows.Count + 1, x.Barcode_Unit, x.Barcode_Count, x.Barcode_Code,
                        FirstByUnit.ToString("0.00"), Buys.ToString("0.00"), BacksFromCustomer.ToString("0.00"),
                        Payments.ToString("0.00"), BacksToVendor.ToString("0.00"), StoreReview.ToString("0.00"), CurrentCount.ToString("0.00"));
                } while (x.MoveNext());
            }
        }

        private void DialogFollowDetails_Load(object sender, EventArgs e)
        {
            FillCalcilation();

            ClassFollowGood p = new ClassFollowGood(MyGoodID);
            lblFirst.Text = p.StartCount.ToString();
            lblBuys.Text = p.Buys.ToString();
            lblCustomerBack.Text = p.BacksFromCustomer.ToString();
            lblPayments.Text = p.Payments.ToString();
            lblVendorBack.Text = p.BacksToVendor.ToString();            
            lblCurrent.Text = p.CurrentCount.ToString();
            lblStoreReview.Text = p.StoreReview.ToString();

            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Clear();
            TblStores sa = new TblStores();
            sa.LoadAll();
            if (sa.RowCount >0)
            {
                int g = 0;
                do
                {
                    ClassFollowGood cs = new ClassFollowGood(MyGoodID, sa.Store_ID);
                    ++g;
                    dataGridView2.Rows.Add(sa.Store_ID, g, sa.Store_Name, cs.CurrentCount);
                } while (sa.MoveNext());
            }

            ViewGoods obj = new ViewGoods();
            obj.Where.Titel_Id.Value = MyGoodID;
            if (obj.Query.Load())
            {
                lblGoodName.Text = obj.Good_TraidName;
                //------------------------------------------------------1
                double FirstStore = obj.FirstStore_Amount0 + obj.FirstStore_Amount1 + obj.FirstStore_Amount2;

                if (FirstStore != 0)
                {
                    dataGridView1.Rows.Add(0, "رصيد أول الفترة", "رصيد أول الفترة", 0, DateTime.Now.AddYears(-10),obj.Barcode_Unit,
                        FirstStore, 0, 0);                    
                }


                ViewStoreReviewSummary dr = new ViewStoreReviewSummary();
                dr.Where.Detail_Difference.Value = 0;
                dr.Where.Detail_Difference.Operator = WhereParameter.Operand.NotEqual;
                dr.Where.Title_Id.Value = MyGoodID;
                dr.Query.AddResultColumn(ViewStoreReviewSummary.ColumnNames.Summary_ID);
                dr.Query.Distinct = true;
                if (dr.Query.Load())
                {
                    do
                    {
                        ViewStoreReviewSummary xy = new ViewStoreReviewSummary();
                        xy.Where.Summary_ID.Value = dr.Summary_ID;
                        if (xy.Query.Load())
                        {

                            if (xy.Detail_Type == "عجز")
                            {
                                dataGridView1.Rows.Add(xy.Review_Id, "عجز جرد", "عجز جرد", xy.Review_Id, xy.Review_Date.Date, obj.Barcode_Unit, 0, xy.Detail_Difference, 0);
                            }
                            else if (xy.Detail_Type == "زيادة")
                            {
                                dataGridView1.Rows.Add(xy.Review_Id, "زيادات جرد", "زيادات جرد", xy.Review_Id, xy.Review_Date.Date, obj.Barcode_Unit, xy.Detail_Difference, 0, 0);
                            }
                        }
                    } while (dr.MoveNext());
                }


                //------------------------------------------------------3
                ViewVendorsGoods gb = new ViewVendorsGoods();
                gb.Where.Titel_Id.Value = MyGoodID;
                if (gb.Query.Load())
                {
                    do
                    {
                        if (gb.Bill_PayType == "مرتجعات")
                        {
                            dataGridView1.Rows.Add(gb.Bill_id, "مرتجعات للمورد", gb.Vendor_Name, gb.Bill_VendorNumber, gb.Bill_Date.Date, gb.Barcode_Unit + " * " + gb.Barcode_Count, 0,
                                (gb.Good_Count * double.Parse(gb.Barcode_Count)).ToString("0.00"), 0);
                        }
                        else
                        {
                            dataGridView1.Rows.Add(gb.Bill_id, "فاتورة مشتريات", gb.Vendor_Name, gb.Bill_VendorNumber, gb.Bill_Date.Date, gb.Barcode_Unit + " * " + gb.Barcode_Count,
                                (gb.Good_Count * double.Parse(gb.Barcode_Count)).ToString("0.00"), 0, 0);
                        }
                    } while (gb.MoveNext());
                }

                //--------------------------------------------------------------4
                ViewCustomerPayments py = new ViewCustomerPayments();
                py.Where.Titel_Id.Value = MyGoodID;
                if (py.Query.Load())
                {
                    do
                    {
                        if (py.Bill_Type == "فاتورة مرتجعات")
                        {
                            dataGridView1.Rows.Add(py.CustomerBill_Id, "مرتجعات من العميل", py.Bill_CustomerName, py.CustomerBill_Id, py.Bill_Date.Date, py.Barcode_Unit + " * " + py.Barcode_Count,
                                (py.PayCount * double.Parse(py.Barcode_Count)).ToString("0.00"), 0, 0);
                        }
                        else if (py.Bill_Type.Contains("فاتورة مبيعات"))
                        {
                            dataGridView1.Rows.Add(py.CustomerBill_Id, py.Bill_Type, py.Bill_CustomerName, py.CustomerBill_Id, py.Bill_Date.Date, py.Barcode_Unit + " * " + py.Barcode_Count,
                                0, (py.PayCount * double.Parse(py.Barcode_Count)).ToString("0.00"), 0);
                        }
                    } while (py.MoveNext());
                }
            }

            
            //----------------------------------------------------------------------------
            this.dataGridView1.Sort(dataGridView1.Columns["Column5"], ListSortDirection.Ascending);

            double total2 = 0;
           
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                total2 += double.Parse(item.Cells["Column9"].Value.ToString()) - double.Parse(item.Cells["Column6"].Value.ToString());
                item.Cells["Column10"].Value = total2;

                string date = item.Cells["Column5"].Value.ToString();
                item.Cells["Column5"].Value = DateTime.Parse(date).ToShortDateString();

                if (item.Cells["Column3"].Value.ToString() == "مرتجعات للمورد" || item.Cells["Column3"].Value.ToString().Contains("فاتورة مبيعات"))
                {
                    item.Cells["Column6"].Style.BackColor = Color.Yellow;
                }
            }

            dataGridView1.ClearSelection();
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            double last = 0;
            ViewGoods obj = new ViewGoods();
            obj.Where.Titel_Id.Value = MyGoodID;
            if (obj.Query.Load())
            {
                lblGoodName.Text = obj.Good_TraidName;
                //------------------------------------------------------1
                //dataGridView1.Rows.Add(0, "رصيد أول الفترة", 0, DateTime.Now.AddYears(-10), double.Parse(obj.FirstStore_Amount), 0, 0);

                last = obj.FirstStore_Amount0 + obj.FirstStore_Amount1 + obj.FirstStore_Amount2;


                //------------------------------------------------------3
                ViewVendorsGoods gb = new ViewVendorsGoods();
                gb.Where.Titel_Id.Value = MyGoodID;
                if (gb.Query.Load())
                {
                    do
                    {
                        if (gb.Bill_Date >= DateTime.Parse(dateTimePicker1.Text) && gb.Bill_Date <= DateTime.Parse(dateTimePicker2.Text))
                        {
                            if (gb.Bill_PayType == "مرتجعات")
                            {
                                dataGridView1.Rows.Add(gb.Bill_id, "مرتجعات للمورد", gb.Vendor_Name, gb.Bill_VendorNumber, gb.Bill_Date.Date, gb.Barcode_Unit + " * " + gb.Barcode_Count,
                                    0, (gb.Good_Count * double.Parse(gb.Barcode_Count)).ToString("0.00"), 0);
                            }
                            else
                            {
                                dataGridView1.Rows.Add(gb.Bill_id, "فاتورة مشتريات", gb.Vendor_Name, gb.Bill_VendorNumber, gb.Bill_Date.Date, gb.Barcode_Unit + " * " + gb.Barcode_Count,
                                    (gb.Good_Count * double.Parse(gb.Barcode_Count)).ToString("0.00"), 0, 0);
                            }
                        }
                        else if (gb.Bill_Date < DateTime.Parse(dateTimePicker1.Text))
                        {
                            if (gb.Bill_PayType == "مرتجعات")
                            {
                                last -= (gb.Good_Count * double.Parse(gb.Barcode_Count));
                            }
                            else
                            {
                                last += (gb.Good_Count * double.Parse(gb.Barcode_Count));
                            }
                        }

                    } while (gb.MoveNext());

                }

                //--------------------------------------------------------------4
                ViewCustomerPayments py = new ViewCustomerPayments();
                py.Where.Titel_Id.Value = MyGoodID;
                if (py.Query.Load())
                {
                    do
                    {
                        if (py.Bill_Date >= DateTime.Parse(dateTimePicker1.Text) && py.Bill_Date <= DateTime.Parse(dateTimePicker2.Text))
                        {
                            if (py.Bill_Type == "فاتورة مرتجعات")
                            {
                                dataGridView1.Rows.Add(py.CustomerBill_Id, "مرتجعات من العميل", py.Bill_CustomerName, py.CustomerBill_Id, py.Bill_Date.Date, py.Barcode_Unit + " * " + py.Barcode_Count,
                                     (py.PayCount * double.Parse(py.Barcode_Count)).ToString("0.00"), 0, 0);
                            }
                            else if (py.Bill_Type.Contains("فاتورة مبيعات"))
                            {
                                dataGridView1.Rows.Add(py.CustomerBill_Id, py.Bill_Type, py.Bill_CustomerName, py.CustomerBill_Id, py.Bill_Date.Date, py.Barcode_Unit + " * " + py.Barcode_Count,
                                    0, (py.PayCount * double.Parse(py.Barcode_Count)).ToString("0.00"), 0);
                            }
                        }
                        else if (py.Bill_Date < DateTime.Parse(dateTimePicker1.Text))
                        {
                            if (py.Bill_Type == "فاتورة مرتجعات")
                            {
                                last += (py.PayCount * double.Parse(py.Barcode_Count));
                            }
                            else if (py.Bill_Type.Contains("فاتورة مبيعات"))
                            {
                                last -= (py.PayCount * double.Parse(py.Barcode_Count));
                            }
                        }
                    } while (py.MoveNext());
                }

                if (last < 0)
                {
                    last = last * -1;
                    dataGridView1.Rows.Add(0, "رصيد سابق", "رصيد سابق", 0, DateTime.Parse(dateTimePicker1.Text).AddDays(-1), obj.Barcode_Unit, 0, last, 0);
                }
                else if (last > 0)
                {
                    dataGridView1.Rows.Add(0, "رصيد سابق", "رصيد سابق", 0, DateTime.Parse(dateTimePicker1.Text).AddDays(-1), obj.Barcode_Unit, last, 0, 0);
                }
            }

            

            //----------------------------------------------------------------------------
            this.dataGridView1.Sort(dataGridView1.Columns["Column5"], ListSortDirection.Ascending);

            double total2 = 0;

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                total2 += double.Parse(item.Cells["Column9"].Value.ToString()) - double.Parse(item.Cells["Column6"].Value.ToString());
                item.Cells["Column10"].Value = total2;

                string date = item.Cells["Column5"].Value.ToString();
                item.Cells["Column5"].Value = DateTime.Parse(date).ToShortDateString();

                if (item.Cells["Column3"].Value.ToString() == "مرتجعات للمورد" || item.Cells["Column3"].Value.ToString().Contains("فاتورة مبيعات"))
                {
                    item.Cells["Column6"].Style.BackColor = Color.Yellow;
                }
            }

            dataGridView1.ClearSelection();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = int.Parse(dataGridView1["Column1", dataGridView1.CurrentRow.Index].Value.ToString());
                string MyType = dataGridView1["Column3", dataGridView1.CurrentRow.Index].Value.ToString();
                if (MyType.Contains("فاتورة مبيعات") || MyType == "مرتجعات من العميل")
                {
                    Payments.DialogPaymentBillDetails obj = new Payments.DialogPaymentBillDetails(id);
                    obj.ShowDialog();
                }
                else if (MyType == "فاتورة مشتريات" || MyType == "مرتجعات للمورد")
                {
                    Vendors.DialogBillDetails ff = new Vendors.DialogBillDetails(id);
                    ff.ShowDialog();
                    if (ff.DialogResult == DialogResult.OK)
                    {
                        DialogFollowDetails_Load(sender, e);
                    }
                }
            }
        }
    }
}
