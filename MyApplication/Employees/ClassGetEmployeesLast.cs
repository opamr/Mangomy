using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPro;
using MyGeneration.dOOdads;

namespace MyApplication.Employees
{
    class ClassGetEmployeesLast
    {
        int MyMonth = DateTime.Now.Month;
        int MyYear = DateTime.Now.Month;

        public double Last = 0;

        public ClassGetEmployeesLast(int SalaryID, int EmpID)
        {
            //ViewEmployeesSalary sc = new ViewEmployeesSalary();


            ViewEmployeesSalary obj = new ViewEmployeesSalary();
            obj.Where.Emp_Id.Value = EmpID;      
            obj.Where.Salary_ID.Value = SalaryID;
            obj.Where.Salary_ID.Operator = WhereParameter.Operand.NotEqual;           
            if (obj.Query.Load())
            {
                do
                {
                   
                    ClassEmployeesFinance cs = new ClassEmployeesFinance(obj.Emp_Id, obj.Salary_Month, obj.Salary_Year);
                    Last += cs.RestMoney;

                } while (obj.MoveNext());
            }
        }
    }
}
