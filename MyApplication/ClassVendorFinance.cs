using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPro;
using MyGeneration.dOOdads;

namespace MyApplication
{
    class ClassVendorFinance
    {
        public double VendorRest = 0;
        public ClassVendorFinance(int MyVendorID)
        {
            TblVendorsData vv = new TblVendorsData();
            vv.LoadByPrimaryKey(MyVendorID);
            VendorRest += vv.Vendor_RecentMoney;

            TblVendorsPaying py = new TblVendorsPaying();
            py.Where.Vendor_Id.Value = MyVendorID;
            py.Aggregate.Ven_PayMoney.Function = AggregateParameter.Func.Sum;
            if (py.Query.Load() && py.s_Ven_PayMoney != "")
            {                
                VendorRest -= double.Parse(py.s_Ven_PayMoney);
            }

            TblVendorsBills bb = new TblVendorsBills();
            bb.Where.Bill_VendorId.Value = MyVendorID;
            if (bb.Query.Load())
            {
                do
                {
                    ClassVendorBillTotal cs = new ClassVendorBillTotal(bb.Bill_ID);                    
                    if (bb.Bill_PayType.Contains("مرتجعات"))
                    {
                        VendorRest -= cs.BillTotalAfterDiscount;
                    }
                    else if (bb.Bill_PayType.Contains("آجل"))
                    {
                        VendorRest += cs.BillTotalAfterDiscount;
                    }

                } while (bb.MoveNext());
            }
        }
    }
}
