using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPro;
using MyGeneration.dOOdads;

namespace MyApplication.Employees
{
    class ClassEmployeesFinance
    {
        public double BasicSalary = 0;
        public double LastMoney = 0;
        public double TotalBones = 0;
        public double TotalDiscount = 0;
     
        public double TotalTakeMoney = 0;
        public double RestMoney = 0;
        public double NetSalary = 0;
        public int MySalaryID = 0;

        public string RememberMessgae = "لم يتم";

        public ClassEmployeesFinance(int MyEmpID,int Month,int Year)
        {            
            TblEmployeesSalary obj = new TblEmployeesSalary();
            obj.Where.Emp_Id.Value = MyEmpID;
            obj.Where.Salary_Month.Value = Month;
            obj.Where.Salary_Year.Value = Year;
            if (obj.Query.Load())
            {             
                MySalaryID = obj.Salary_ID;

                //---------------------------------------------------------
                TblEmployeesBones bb = new TblEmployeesBones();
                bb.Where.Salary_Id.Value = obj.Salary_ID;
                if (bb.Query.Load())
                {
                    do
                    {
                        if (bb.Bones_Type == "خصم")
                        {
                            TotalDiscount += bb.Bones_Money;
                        }
                        else
                        {
                            TotalBones += bb.Bones_Money;
                        }
                    } while (bb.MoveNext());
                }

                //-----------------------------------------------------------------------------
                TblEmployeesSalaryPaying sa = new TblEmployeesSalaryPaying();
                sa.Where.Salary_Id.Value = obj.Salary_ID;
                if (sa.Query.Load())
                {
                    do
                    {
                        TotalTakeMoney += sa.Pay_Money;
                    } while (sa.MoveNext());
                }

                BasicSalary = obj.Salary_Money;

                NetSalary = obj.Salary_Money +  + obj.Salary_House + 
                    TotalBones - TotalDiscount;

                RestMoney = NetSalary - TotalTakeMoney;              
            }                                           
        }       
    }
}
