using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPro;
using MyGeneration.dOOdads;
namespace MyApplication
{
    class ClassVendorBillTotal
    {
        public double BillTotal = 0;
        public double BillVat = 0;
        public double BillDiscount = 0;
        public double BillTotalWithOutVat = 0;
        public double BillTotalAfterDiscount = 0;

        public ClassVendorBillTotal(int BillID)
        {
            ViewVendorsGoods obj = new ViewVendorsGoods();
            obj.Where.Bill_id.Value = BillID;
            obj.Aggregate.Good_Total.Function = AggregateParameter.Func.Sum;
            if (obj.Query.Load() && obj.s_Good_Total != "")
            {
                BillTotal = double.Parse(obj.s_Good_Total);
            }

            TblVendorsBills bi = new TblVendorsBills();
            bi.LoadByPrimaryKey(BillID);
            BillVat = bi.Bill_Vat;
            BillDiscount = bi.Bill_Discount_Money;

            BillTotalWithOutVat = BillTotal - BillDiscount;
            BillTotalAfterDiscount = BillTotal - BillDiscount + bi.Bill_Vat;         
        }              
    }
}
