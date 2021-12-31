using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPro;
using MyGeneration.dOOdads;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace MyApplication
{
    class ClassCustomerBillTotal
    {
        public double BillTotal;
        public double BillTotalAfterDiscount;
        public double BillTotalAfterVat;
        public double KashPay;
        public double BankPay;
        public double AllPay = 0;
        public double BillRest = 0;

        public string BillCustomerName;
        public string BillCustomerPhone;
        public string BillVatNumber;
        public string BillAddress;


        public double BillProfit = 0;

        public ClassCustomerBillTotal(int BillID)
        {
            TblCustomersBills cs = new TblCustomersBills();
            cs.LoadByPrimaryKey(BillID);
            KashPay = cs.Pay_Cash;
            BankPay = cs.Pay_Bank;

            AllPay = KashPay + BankPay;

            if (cs.Customer_Id ==1)
            {
                BillCustomerName = cs.Bill_CustomerName;
                BillCustomerPhone = cs.Bill_CustomerPhone;
                BillVatNumber = cs.Bill_VatNumber;
                BillAddress = cs.Bill_Details;
            }
            else
            {
                TblCustomersData nb = new TblCustomersData();
                nb.LoadByPrimaryKey(cs.Customer_Id);

                BillCustomerName = nb.Customer_Name;
                BillCustomerPhone = nb.Customer_Mobile;
                BillVatNumber = nb.Customer_VatNumber;
                BillAddress = nb.Customer_Address;
            }

            ViewCustomerPayments obj = new ViewCustomerPayments();            
            obj.Where.CustomerBill_Id.Value = BillID;
            obj.Aggregate.Pay_Total.Function = AggregateParameter.Func.Sum;
            obj.Aggregate.Pay_Profit.Function = AggregateParameter.Func.Sum;
            if (obj.Query.Load() && obj.s_Pay_Total != "")
            {
                BillTotal += double.Parse(obj.s_Pay_Total);
                BillProfit += double.Parse(obj.s_Pay_Profit);
               
            }

            BillProfit -= cs.Bill_DiscountMoney;

            //BillProfit -= cs.Bill_Vat;

            BillTotalAfterDiscount = BillTotal - cs.Bill_DiscountMoney;
            BillTotalAfterVat = BillTotalAfterDiscount + cs.Bill_Vat;

            BillRest = BillTotalAfterVat - KashPay - BankPay;

            if (cs.Bill_Type == "عرض سعر")
            {
                BillRest = 0;
            }          
        }
    }
}
