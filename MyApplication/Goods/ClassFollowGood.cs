using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPro;
using MyGeneration.dOOdads;
namespace MyApplication
{
    class ClassFollowGood
    {
        public string CategoryName = "";

        public double StartCount = 0;
        public double Buys = 0;
        public double BacksFromCustomer = 0;        

        public double Payments = 0;
        
        public double BacksToVendor = 0;

        public double StoreReview = 0;

        public double CurrentCount = 0;

        public double CurrentCost = 0;

        public double StoreConverts;

        public double PayPrice = 0;

        public ClassFollowGood(int GoodID)
        {
            ViewGoods obj = new ViewGoods();
            obj.Where.Titel_Id.Value = GoodID;
            if (obj.Query.Load())
            {
                PayPrice = double.Parse(obj.Barcode_PayPrice);
                //------------------------------------------------------1
                StartCount = obj.FirstStore_Amount0 + obj.FirstStore_Amount1 + obj.FirstStore_Amount2;

                //------------------------------------------------------2
                TblGoodsCategory cc = new TblGoodsCategory();
                cc.Where.Ctaegory_ID.Value = obj.Category_Id;
                if (cc.Query.Load())
                {
                    CategoryName = cc.Category_Name;
                }

                ViewStoreReviewSummary tt = new ViewStoreReviewSummary();
                //tt.Where.Review_Status.Value = "انتهى";
                tt.Where.Title_Id.Value = GoodID;
                if (tt.Query.Load())
                {
                    do
                    {
                        if (tt.Detail_Type == "زيادة")
                        {
                            StoreReview += tt.Detail_Difference;
                        }
                        else if (tt.Detail_Type == "عجز")
                        {
                            StoreReview -= tt.Detail_Difference;
                        }
                    } while (tt.MoveNext());
                }

                //------------------------------------------------------3
                ViewVendorsGoods gb = new ViewVendorsGoods();
                gb.Where.Titel_Id.Value = GoodID;
                if (gb.Query.Load())
                {
                    do
                    {
                        double CountByUnit = gb.Good_Count * double.Parse(gb.Barcode_Count);
                        if (gb.Bill_PayType.Contains( "مرتجعات"))
                        {
                            BacksToVendor += CountByUnit;
                        }
                        else 
                        {
                            Buys += CountByUnit;
                        }

                    } while (gb.MoveNext());

                }

                //--------------------------------------------------------------4
                ViewCustomerPayments py = new ViewCustomerPayments();
                py.Where.Titel_Id.Value = GoodID;
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
                }

                CurrentCount = StartCount + Buys + BacksFromCustomer - Payments - BacksToVendor + StoreReview;

                CurrentCost = CurrentCount * double.Parse(obj.Barcode_Count) * double.Parse(obj.Barcode_BuyPrice);

                TblGoodsTitles sx = new TblGoodsTitles();
                sx.LoadByPrimaryKey(GoodID);
                sx.Good_CurrentCount = CurrentCount;
                sx.Save();
            }
        }

        public ClassFollowGood(int GoodID,int StoreID)
        {
            ViewGoods obj = new ViewGoods();
            obj.Where.Titel_Id.Value = GoodID;
            if (obj.Query.Load())
            {
                //------------------------------------------------------1
                if (StoreID == 1)
                {
                    StartCount = obj.FirstStore_Amount0;               
                }
                else if (StoreID == 2)
                {
                    StartCount = obj.FirstStore_Amount1;
                }
                else if (StoreID == 3)
                {
                    StartCount = obj.FirstStore_Amount2;
                }


                ViewStoreReviewSummary tt = new ViewStoreReviewSummary();
                //tt.Where.Review_Status.Value = "انتهى";
                tt.Where.Title_Id.Value = GoodID;
                if (StoreID == 1 && tt.Query.Load())
                {
                    do
                    {
                        if (tt.Detail_Type == "زيادة")
                        {
                            StoreReview += tt.Detail_Difference;
                        }
                        else if (tt.Detail_Type == "عجز")
                        {
                            StoreReview -= tt.Detail_Difference;
                        }
                    } while (tt.MoveNext());
                }


                //------------------------------------------------------2
                TblGoodsCategory cc = new TblGoodsCategory();
                cc.Where.Ctaegory_ID.Value = obj.Category_Id;
                if (cc.Query.Load())
                {
                    CategoryName = cc.Category_Name;
                }


                ViewStoreConvertDetails po = new ViewStoreConvertDetails();
                po.Where.Titel_Id.Value = GoodID;
                if (po.Query.Load())
                {
                    do
                    {
                        double CountByUnit = po.Detail_Count * double.Parse(po.Barcode_Count);
                        if (po.Convert_From == StoreID)
                        {
                            StoreConverts -= CountByUnit;
                        }
                        else if (po.Convert_To == StoreID)
                        {
                            StoreConverts += CountByUnit;
                        }

                    } while (po.MoveNext());
                }
                

                //------------------------------------------------------3
                ViewVendorsGoods gb = new ViewVendorsGoods();
                gb.Where.Titel_Id.Value = GoodID;
                gb.Where.Store_Id.Value = StoreID;
                if (gb.Query.Load())
                {
                    do
                    {
                        double CountByUnit = gb.Good_Count * double.Parse(gb.Barcode_Count);
                        if (gb.Bill_PayType.Contains( "مرتجعات"))
                        {
                            BacksToVendor += CountByUnit;
                        }
                        else
                        {
                            Buys += CountByUnit;
                        }

                    } while (gb.MoveNext());

                }

                //--------------------------------------------------------------4
                ViewCustomerPayments py = new ViewCustomerPayments();
                py.Where.Titel_Id.Value = GoodID;                
                if (py.Query.Load() && StoreID == 1)
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
                }

                CurrentCount = StartCount + Buys + BacksFromCustomer - Payments - BacksToVendor + StoreConverts + StoreReview;

                CurrentCost = CurrentCount * double.Parse(obj.Barcode_Count) * double.Parse(obj.Barcode_BuyPrice);
            }
        }
    }
}
