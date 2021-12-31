using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPro;

namespace MyApplication
{
    class ClassGetBillNumber
    {
        public int MyBillNumber = 0;
        public ClassGetBillNumber()
        {
            //TblCustomersBills cc = new TblCustomersBills();
            //cc.LoadAll();
            //if (cc.RowCount > 0)
            //{
            //    do
            //    {
            //        TblCustomerBillsPayments py = new TblCustomerBillsPayments();
            //        py.Where.CustomerBill_Id.Value = cc.Bill_ID;
            //        if (py.Query.Load())
            //        {
            //            //--------------do nothing
            //        }
            //        else
            //        {
            //            cc.MarkAsDeleted();
            //            cc.Save();
            //        }
            //    } while (cc.MoveNext());
            //}


            TblCustomersBills obj = new TblCustomersBills();
            obj.LoadAll();
            if (obj.RowCount >0)
            {
                obj.Sort = TblCustomersBills.ColumnNames.Bill_ID + " DESC";
                MyBillNumber = obj.Bill_ID + 1;
            }
            else
            {
                ++MyBillNumber;
            }
        }
    }
}
