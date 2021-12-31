using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPro;
using MyGeneration.dOOdads;

namespace MyApplication
{
    class ClassCustomerFinance
    {
        public double CustomerFinance = 0;        
                              
        public ClassCustomerFinance(int CustomerID)
        {
            if (CustomerID == 1)
            {
                return;
            }
                TblCustomersData hh = new TblCustomersData();
                hh.LoadByPrimaryKey(CustomerID);
                CustomerFinance += hh.Recent_money;                                
                    

            TblCustomersBills obj = new TblCustomersBills();
            obj.Where.Customer_Id.Value = CustomerID;
            if (obj.Query.Load())
            {                

                do
                {
                    ClassCustomerBillTotal cs = new ClassCustomerBillTotal(obj.Bill_ID);

                    if (obj.Bill_Type == "فاتورة مرتجعات")
                    {
                        CustomerFinance -= cs.BillRest;
                    }
                    else if (obj.Bill_Type.Contains("فاتورة مبيعات"))
                    {
                        CustomerFinance += cs.BillRest;
                    }
                } while (obj.MoveNext());               
            }

            

            TblCustomersPaying mm = new TblCustomersPaying();
            mm.Where.Customer_Id.Value = CustomerID;
            mm.Where.Pay_Type.Value = "سند صرف";
            mm.Aggregate.Pay_Money.Function = AggregateParameter.Func.Sum;
            if (mm.Query.Load() && mm.s_Pay_Money != "")
            {
                CustomerFinance += double.Parse(mm.s_Pay_Money);
            }

            mm = new TblCustomersPaying();
            mm.Where.Customer_Id.Value = CustomerID;
            mm.Where.Pay_Type.Value = "سند صرف";
            mm.Where.Pay_Type.Operator = WhereParameter.Operand.NotEqual;
            mm.Aggregate.Pay_Money.Function = AggregateParameter.Func.Sum;
            if (mm.Query.Load() && mm.s_Pay_Money != "")
            {
                CustomerFinance -= double.Parse(mm.s_Pay_Money);
            }

        }
    }
}
