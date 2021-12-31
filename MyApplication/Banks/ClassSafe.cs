using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPro;
using MyGeneration.dOOdads;

namespace MyApplication
{
    class ClassSafe
    {
        public double MyBankNow = 0;             

        public double MySafeLast = 0;    

        public ClassSafe(int MyBankID)
        {
            TblBanks bb = new TblBanks();
            bb.LoadByPrimaryKey(MyBankID);
            MyBankNow = bb.Bank_FirstPeriod;

            //---------------------------------------تحميل الوارد من العملاء
            #region الوارد من العملاء
            TblCustomersPaying cp = new TblCustomersPaying();
            cp.Where.Pay_Type.Value = "سند قبض";
            cp.Where.Bank_Id.Value = MyBankID;
            cp.Aggregate.Pay_Money.Function = AggregateParameter.Func.Sum;
            if (cp.Query.Load() && cp.s_Pay_Money != "")
            {
                MyBankNow += double.Parse(cp.s_Pay_Money);
            }

            cp = new TblCustomersPaying();
            cp.Where.Pay_Type.Value = "سند صرف";
            cp.Where.Bank_Id.Value = MyBankID;
            cp.Aggregate.Pay_Money.Function = AggregateParameter.Func.Sum;
            if (cp.Query.Load() && cp.s_Pay_Money != "")
            {
                MyBankNow -= double.Parse(cp.s_Pay_Money);
            }
            #endregion

            //--------------------------------------------مبيعات كاش وشبكة
            #region مبيعات كاش وشبكة
            TblCustomersBills xd;
            xd = new TblCustomersBills();
            xd.Where.Bill_Type.Value = "%" + "فاتورة مبيعات" + "%";
            xd.Where.Bill_Type.Operator = WhereParameter.Operand.Like;         
            if (MyBankID == 1)
            {
                xd.Aggregate.Pay_Cash.Function = AggregateParameter.Func.Sum;
                if (xd.Query.Load() && xd.s_Pay_Cash != "")
                {
                    MyBankNow += double.Parse(xd.s_Pay_Cash);
                }
            }
            else if (MyBankID == 2)
            {
                xd.Aggregate.Pay_Bank.Function = AggregateParameter.Func.Sum;
                xd.Aggregate.Pay_Bank_Fees.Function = AggregateParameter.Func.Sum;
                if (xd.Query.Load() && xd.s_Pay_Bank != "")
                {
                    MyBankNow += double.Parse(xd.s_Pay_Bank);
                    MyBankNow -= double.Parse(xd.s_Pay_Bank_Fees);
                }               
            }
            

            xd = new TblCustomersBills();
            xd.Where.Bill_Type.Value = "فاتورة مرتجعات";
            if (MyBankID == 1)
            {
                xd.Aggregate.Pay_Cash.Function = AggregateParameter.Func.Sum;
                if (xd.Query.Load() && xd.s_Pay_Cash != "")
                {
                    MyBankNow -= double.Parse(xd.s_Pay_Cash);
                }
            }
            else if (MyBankID == 2)
            {
                xd.Aggregate.Pay_Bank.Function = AggregateParameter.Func.Sum;
                xd.Aggregate.Pay_Bank_Fees.Function = AggregateParameter.Func.Sum;
                if (xd.Query.Load() && xd.s_Pay_Bank != "")
                {
                    MyBankNow -= double.Parse(xd.s_Pay_Bank);
                    MyBankNow += double.Parse(xd.s_Pay_Bank_Fees);
                }
            }       
            #endregion

            #region صرف رواتب
            ViewEmployeesSalaryPaying sq = new ViewEmployeesSalaryPaying();
            sq.Where.Bank_Id.Value = MyBankID;
            sq.Aggregate.Pay_Money.Function = AggregateParameter.Func.Sum;
            if (sq.Query.Load() && sq.s_Pay_Money != "")
            {
                MyBankNow -= double.Parse(sq.s_Pay_Money);
            }
            #endregion           

            //--------------------------------------------------------------------------تحميل مدفوعات الموردين
            #region مدفوعات إلى الموردين
            ViewVendorsBills rt = new ViewVendorsBills();           
            rt.Where.Bill_PayType.Value = "%" + "كاش" + "%";
            rt.Where.Bill_PayType.Operator = WhereParameter.Operand.Like;
            rt.Where.Bank_Id.Value = MyBankID;
            if (rt.Query.Load())
            {
                do
                {
                    ClassVendorBillTotal cs = new ClassVendorBillTotal(rt.Bill_ID);
                    if (rt.Bill_PayType == "فاتورة مشتريات كاش")
                    {
                        MyBankNow -= cs.BillTotalAfterDiscount;
                    }
                    else
                    {
                        MyBankNow += cs.BillTotalAfterDiscount;
                    }

                } while (rt.MoveNext());
            }

            TblVendorsPaying vv = new TblVendorsPaying();          
            vv.Where.Bank_Id.Value = MyBankID;
            vv.Aggregate.Ven_PayMoney.Function = AggregateParameter.Func.Sum;
            if (vv.Query.Load() && vv.s_Ven_PayMoney != "")
            {
                MyBankNow -= double.Parse(vv.s_Ven_PayMoney);
            }
            #endregion

            //------------------------------------------------------------------تحميل المصروفات
            #region المصروفات
            TblOutComings ou = new TblOutComings();           
            ou.Where.Bank_Id.Value = MyBankID;
            ou.Aggregate.Out_Money.Function = AggregateParameter.Func.Sum;
            if (ou.Query.Load() && ou.s_Out_Money != "")
            {
                MyBankNow -= double.Parse(ou.s_Out_Money);
            }

            #endregion

            //---------------------------------------------------------------------------تحميل التحويلات
            #region التحويلات
            TblBankOperation mm = new TblBankOperation();
            mm.LoadAll();
            if (mm.Query.Load())
            {
                do
                {
                    if (mm.Operate_ConvertFrom == MyBankID) // تحويل من الخزينة إلى البنك
                    {
                        MyBankNow -=mm.Operate_Money;
                    }
                    else if (mm.Operate_ConvertTo == MyBankID)
                    {
                        MyBankNow += mm.Operate_Money;
                    }

                } while (mm.MoveNext());
            }

            #endregion           
        }

        public ClassSafe(int MyBankID, DateTime Mydate)
        {
            TblBanks bb = new TblBanks();
            bb.LoadByPrimaryKey(MyBankID);
            if (bb.Bank_FisrtDate < Mydate)
            {
                MyBankNow = bb.Bank_FirstPeriod;
            }

            #region الوارد من العملاء
            TblCustomersPaying cp = new TblCustomersPaying();
            cp.Where.Pay_Type.Value = "سند قبض";
            cp.Where.Pay_Date.Value = Mydate;
            cp.Where.Pay_Date.Operator = WhereParameter.Operand.LessThan;
            cp.Where.Bank_Id.Value = MyBankID;
            cp.Aggregate.Pay_Money.Function = AggregateParameter.Func.Sum;
            if (cp.Query.Load() && cp.s_Pay_Money != "")
            {
                MyBankNow += double.Parse(cp.s_Pay_Money);
            }

            cp = new TblCustomersPaying();
            cp.Where.Pay_Type.Value = "سند صرف";
            cp.Where.Pay_Date.Value = Mydate;
            cp.Where.Pay_Date.Operator = WhereParameter.Operand.LessThan;
            cp.Where.Bank_Id.Value = MyBankID;
            cp.Aggregate.Pay_Money.Function = AggregateParameter.Func.Sum;
            if (cp.Query.Load() && cp.s_Pay_Money != "")
            {
                MyBankNow -= double.Parse(cp.s_Pay_Money);
            }
            #endregion        

            #region مبيعات كاش وشبكة
            TblCustomersBills xd;
            xd = new TblCustomersBills();
            xd.Where.Bill_Date.Value = Mydate;
            xd.Where.Bill_Date.Operator = WhereParameter.Operand.LessThan;
            xd.Where.Bill_Type.Value = "%" + "فاتورة مبيعات" + "%";
            xd.Where.Bill_Type.Operator = WhereParameter.Operand.Like;            
            if (MyBankID == 1)
            {
                xd.Aggregate.Pay_Cash.Function = AggregateParameter.Func.Sum;
                if (xd.Query.Load() && xd.s_Pay_Cash != "")
                {
                    MyBankNow += double.Parse(xd.s_Pay_Cash);
                }
            }
            else if (MyBankID == 2)
            {
                xd.Aggregate.Pay_Bank.Function = AggregateParameter.Func.Sum;
                xd.Aggregate.Pay_Bank_Fees.Function = AggregateParameter.Func.Sum;
                if (xd.Query.Load() && xd.s_Pay_Bank != "")
                {
                    MyBankNow += double.Parse(xd.s_Pay_Bank);
                    MyBankNow -= double.Parse(xd.s_Pay_Bank_Fees);
                }
            }


            xd = new TblCustomersBills();
            xd.Where.Bill_Date.Value = Mydate;
            xd.Where.Bill_Date.Operator = WhereParameter.Operand.LessThan;
            xd.Where.Bill_Type.Value = "فاتورة مرتجعات";
            if (MyBankID == 1)
            {
                xd.Aggregate.Pay_Cash.Function = AggregateParameter.Func.Sum;
                if (xd.Query.Load() && xd.s_Pay_Cash != "")
                {
                    MyBankNow -= double.Parse(xd.s_Pay_Cash);
                }
            }
            else if (MyBankID == 2)
            {
                xd.Aggregate.Pay_Bank.Function = AggregateParameter.Func.Sum;
                xd.Aggregate.Pay_Bank_Fees.Function = AggregateParameter.Func.Sum;
                if (xd.Query.Load() && xd.s_Pay_Bank != "")
                {
                    MyBankNow -= double.Parse(xd.s_Pay_Bank);
                    MyBankNow += double.Parse(xd.s_Pay_Bank_Fees);
                }
            }
            #endregion

            #region صرف رواتب
            ViewEmployeesSalaryPaying sq = new ViewEmployeesSalaryPaying();
            sq.Where.Pay_Date.Value = Mydate;
            sq.Where.Pay_Date.Operator = WhereParameter.Operand.LessThan;
            sq.Where.Bank_Id.Value = MyBankID;
            sq.Aggregate.Pay_Money.Function = AggregateParameter.Func.Sum;
            if (sq.Query.Load() && sq.s_Pay_Money != "")
            {
                MyBankNow -= double.Parse(sq.s_Pay_Money);
            }
            #endregion           

            #region مدفوعات إلى الموردين
            ViewVendorsBills rt = new ViewVendorsBills();
            rt.Where.Bill_Date.Value = Mydate;
            rt.Where.Bill_Date.Operator = WhereParameter.Operand.LessThan;
            rt.Where.Bill_PayType.Value = "%" + "كاش" + "%";
            rt.Where.Bill_PayType.Operator = WhereParameter.Operand.Like;
            rt.Where.Bank_Id.Value = MyBankID;
            if (rt.Query.Load())
            {
                do
                {
                    ClassVendorBillTotal cs = new ClassVendorBillTotal(rt.Bill_ID);
                    if (rt.Bill_PayType == "فاتورة مشتريات كاش")
                    {
                        MyBankNow -= cs.BillTotalAfterDiscount;
                    }
                    else
                    {
                        MyBankNow += cs.BillTotalAfterDiscount;
                    }

                } while (rt.MoveNext());
            }


            TblVendorsPaying vv = new TblVendorsPaying();
            vv.Where.Ven_PayDate.Value = Mydate;
            vv.Where.Ven_PayDate.Operator = WhereParameter.Operand.LessThan;
            vv.Where.Bank_Id.Value = MyBankID;
            vv.Aggregate.Ven_PayMoney.Function = AggregateParameter.Func.Sum;
            if (vv.Query.Load() && vv.s_Ven_PayMoney != "")
            {
                MyBankNow -= double.Parse(vv.s_Ven_PayMoney);
            }

            #endregion

            #region المصروفات
            TblOutComings ou = new TblOutComings();
            ou.Where.Out_Date.Value = Mydate;
            ou.Where.Out_Date.Operator = WhereParameter.Operand.LessThan;
            ou.Where.Bank_Id.Value = MyBankID;
            ou.Aggregate.Out_Money.Function = AggregateParameter.Func.Sum;
            if (ou.Query.Load() && ou.s_Out_Money != "")
            {
                MyBankNow -= double.Parse(ou.s_Out_Money);
            }

            #endregion

            #region التحويلات
            TblBankOperation mm = new TblBankOperation();
            mm.Where.Operate_Date.Value = Mydate;
            mm.Where.Operate_Date.Operator = WhereParameter.Operand.LessThan;
            if (mm.Query.Load())
            {
                do
                {
                    if (mm.Operate_ConvertFrom == MyBankID) // تحويل من الخزينة إلى البنك
                    {
                        MyBankNow -= mm.Operate_Money;
                    }
                    else if (mm.Operate_ConvertTo == MyBankID)
                    {
                        MyBankNow += mm.Operate_Money;
                    }

                } while (mm.MoveNext());
            }

            #endregion           
        }
    }
}
