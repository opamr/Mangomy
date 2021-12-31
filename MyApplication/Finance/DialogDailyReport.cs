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

namespace MyApplication.Finance
{
    public partial class DialogDailyReport : Form
    {
        public DialogDailyReport()
        {
            InitializeComponent();
        }

        private void DialogDailyReport_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "تقرير يومي عن يوم : " + dateTimePicker5.Text;
         
            dataGridView1.Rows.Clear();


            TblBanks uu = new TblBanks();
            uu.LoadAll();
            if (uu.RowCount > 0)
            {
                int g = 0;
                do
                {

                    double Payments = 0, Backs = 0, Fees = 0;  
                    #region المبيعات
                    ViewCustomerBills obj = new ViewCustomerBills();
                    obj.Where.Bill_Date.Value = DateTime.Parse(dateTimePicker5.Text);
                    if (obj.Query.Load())
                    {
                        do
                        {
                            ClassCustomerBillTotal cs1 = new ClassCustomerBillTotal(obj.Bill_ID);
                            if (obj.Bill_Type.Contains("فاتورة مبيعات"))
                            {
                                if (uu.Bank_ID == 1)
                                {
                                    Payments += cs1.KashPay;
                                }
                                else if (uu.Bank_ID == 2)
                                {
                                    Payments += cs1.BankPay;
                                    Fees += obj.Pay_Bank_Fees;
                                }                               
                            }
                            else if (obj.Bill_Type == "فاتورة مرتجعات")
                            {
                                if (uu.Bank_ID == 1)
                                {
                                    Backs += cs1.KashPay;
                                }
                                else if (uu.Bank_ID == 2)
                                {
                                    Backs += cs1.BankPay;
                                    Fees -= obj.Pay_Bank_Fees;
                                }
                            }
                        } while (obj.MoveNext());
                    }
                    #endregion

                    double CustomersKash = 0;
                    #region العملاء الأجل
                    TblCustomersPaying pp = new TblCustomersPaying();
                    pp.Where.Bank_Id.Value = uu.Bank_ID;
                    pp.Where.Pay_Date.Value = DateTime.Parse(dateTimePicker5.Text);
                    if (pp.Query.Load())
                    {
                        do
                        {
                            if (pp.Pay_Type == "سند قبض")
                            {
                                CustomersKash += pp.Pay_Money;
                            }
                            else if (pp.Pay_Type == "سند صرف")
                            {
                                CustomersKash -= pp.Pay_Money;
                            }

                        } while (pp.MoveNext());
                    }
                    #endregion

                    double Vendors = 0;
                    #region الموردين
                    TblVendorsPaying Ven = new TblVendorsPaying();
                    Ven.Where.Bank_Id.Value = uu.Bank_ID;
                    Ven.Where.Ven_PayDate.Value = DateTime.Parse(dateTimePicker5.Text);
                    if (Ven.Query.Load())
                    {
                        do
                        {
                            Vendors += Ven.Ven_PayMoney;
                        } while (Ven.MoveNext());
                    }


                    ViewVendorsBills rt2 = new ViewVendorsBills();
                    rt2.Where.Bank_Id.Value = uu.Bank_ID;
                    rt2.Where.Bill_Date.Value = DateTime.Parse(dateTimePicker5.Text);
                    rt2.Where.Bill_PayType.Value = "%" + "كاش" + "%";
                    rt2.Where.Bill_PayType.Operator = WhereParameter.Operand.Like;
                    if (rt2.Query.Load())
                    {
                        do
                        {
                            ClassVendorBillTotal tr = new ClassVendorBillTotal(rt2.Bill_ID);
                            if (rt2.Bill_PayType == "فاتورة مشتريات كاش")
                            {
                                Vendors += tr.BillTotalAfterDiscount;
                            }
                            else
                            {
                                Vendors -= tr.BillTotalAfterDiscount;
                            }
                        } while (rt2.MoveNext());
                    }
                    #endregion

                    double Employees = 0;
                    #region المصروفات
                    ViewEmployeesSalaryPaying emp = new ViewEmployeesSalaryPaying();
                    emp.Where.Bank_Id.Value = uu.Bank_ID;
                    emp.Where.Pay_Date.Value = DateTime.Parse(dateTimePicker5.Text);
                    if (emp.Query.Load())
                    {
                        do
                        {
                            Employees += emp.Pay_Money;
                        } while (emp.MoveNext());
                    }
                    #endregion

                    double OutCome = 0;
                    #region المصروفات
                    ViewOutComing tbl = new ViewOutComing();
                    tbl.Where.Bank_Id.Value = uu.Bank_ID;
                    tbl.Where.Out_Date.Value = DateTime.Parse(dateTimePicker5.Text);
                    if (tbl.Query.Load())
                    {
                        do
                        {
                            OutCome += tbl.Out_Money;
                        } while (tbl.MoveNext());
                    }
                    #endregion

                    double Converts = 0;
                    #region التحويلات
                    TblBankOperation mm = new TblBankOperation();
                    mm.Where.Operate_Date.Value = dateTimePicker5.Value.Date;
                    if (mm.Query.Load())
                    {
                        do
                        {
                            if (mm.Operate_ConvertFrom == uu.Bank_ID) // تحويل من الخزينة إلى البنك
                            {
                                Converts -= mm.Operate_Money;
                            }
                            else if (mm.Operate_ConvertTo == uu.Bank_ID)
                            {
                                Converts += mm.Operate_Money;
                            }

                        } while (mm.MoveNext());
                    }

                    #endregion

                    ClassSafe cs = new ClassSafe(uu.Bank_ID, DateTime.Parse(dateTimePicker5.Text));

                    double TotalDay = Payments + CustomersKash + Converts - Backs - OutCome - Vendors - Fees - Employees;

                    dataGridView1.Rows.Add(0, dataGridView1.Rows.Count + 1, uu.Bank_Name,
                       Payments.ToString("0,0.00"), CustomersKash.ToString("0,0.00"), Backs.ToString("0,0.00"),
                       OutCome.ToString("0,0.00"), Vendors.ToString("0,0.00"), Employees.ToString("0,0.00"), 
                       Fees.ToString("0,0.00"), Converts.ToString("0,0.00"),
                       TotalDay.ToString("0,0.00"), cs.MyBankNow.ToString("0,0.00"), (cs.MyBankNow + TotalDay).ToString("0,0.00"));

                } while (uu.MoveNext());
            }

            double Total1 = 0, Total2 = 0, Total3 = 0, Total4 = 0, Total5 = 0, Total6 = 0, Total7 = 0, Total8 = 0, Total9 = 0, Total10 = 0, Total11 = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Total1 += double.Parse(Convert.ToString(row.Cells["Column2"].Value));
                Total2 += double.Parse(Convert.ToString(row.Cells["Column3"].Value));
                Total3 += double.Parse(Convert.ToString(row.Cells["Column4"].Value));
                Total4 += double.Parse(Convert.ToString(row.Cells["Column5"].Value));
                Total5 += double.Parse(Convert.ToString(row.Cells["Column6"].Value));
                Total6 += double.Parse(Convert.ToString(row.Cells["Column7"].Value));
                Total7 += double.Parse(Convert.ToString(row.Cells["Column8"].Value));
                Total8 += double.Parse(Convert.ToString(row.Cells["Column9"].Value));
                Total9 += double.Parse(Convert.ToString(row.Cells["Column10"].Value));
                Total10 += double.Parse(Convert.ToString(row.Cells["Column11"].Value));
                Total11 += double.Parse(Convert.ToString(row.Cells["Column12"].Value));
            }

            dataGridView1.Rows.Add(0, dataGridView1.Rows.Count + 1, "الإجمالي",
                Total1.ToString("0,0.00"), Total2.ToString("0,0.00"), Total3.ToString("0,0.00"),
                Total4.ToString("0,0.00"), Total5.ToString("0,0.00"), Total6.ToString("0,0.00"),
                Total7.ToString("0,0.00"), Total8.ToString("0,0.00"), Total9.ToString("0,0.00")
                , Total10.ToString("0,0.00"), Total11.ToString("0,0.00"));


        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            DialogDailyReport_Load(sender, e);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

            btnSearchByDate_Click(sender, e);

            if (dataGridView1.Rows.Count > 0)
            {
                TblPrint pr = new TblPrint();
                pr.LoadAll();
                pr.DeleteAll();
                pr.Save();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    TblPrint obj = new TblPrint();
                    obj.AddNew();
                    obj.Column1 = Convert.ToString(row.Cells["Column1"].Value);
                    obj.Column2 = Convert.ToString(row.Cells["Column2"].Value);
                    obj.Column3 = Convert.ToString(row.Cells["Column3"].Value);
                    obj.Column4 = Convert.ToString(row.Cells["Column4"].Value);
                    obj.Column5 = Convert.ToString(row.Cells["Column5"].Value);
                    obj.Column6 = Convert.ToString(row.Cells["Column6"].Value);
                    obj.Column7 = Convert.ToString(row.Cells["Column7"].Value);
                    obj.Column8 = Convert.ToString(row.Cells["Column8"].Value);
                    obj.Column9 = Convert.ToString(row.Cells["Column9"].Value);
                    obj.Column10 = Convert.ToString(row.Cells["Column10"].Value);
                    obj.Column11 = Convert.ToString(row.Cells["Column11"].Value);
                    obj.Column12 = Convert.ToString(row.Cells["Column12"].Value);
                    obj.Column13 = "التقرير اليومي عن يوم : " + dateTimePicker5.Text;
                    obj.Column20 = "Numbers";
                    obj.Save();
                }

                #region المصروفات
                ViewOutComing tbl = new ViewOutComing();
                tbl.Where.Out_Date.Value = DateTime.Parse(dateTimePicker5.Text);
                if (tbl.Query.Load())
                {
                    do
                    {
                        TblPrint obj = new TblPrint();
                        obj.AddNew();
                        obj.Column1 = "مصروفات يومية";
                        obj.Column2 = tbl.Item_name + " - " + tbl.Out_Details;
                        obj.Column3 = tbl.Out_Money.ToString("0,0.00");
                        obj.Column4 = tbl.Bank_Name;
                        obj.Column5 = tbl.User_Name;
                        obj.Column20 = "OutCome";
                        obj.Save();
                    } while (tbl.MoveNext());
                }
                #endregion

                #region الوراتب                
                ViewEmployeesSalaryPaying Emp = new ViewEmployeesSalaryPaying();
                Emp.Where.Pay_Date.Value = dateTimePicker5.Value.Date;
                if (Emp.Query.Load())
                {
                    do
                    {                        
                        TblPrint obj = new TblPrint();
                        obj.AddNew();
                        obj.Column1 = Emp.Emp_Name;
                        obj.Column2 = Emp.Salary_Details + " - " + Emp.Pay_Details;
                        obj.Column3 = Emp.Pay_Money.ToString("0,0.00");
                        obj.Column4 = Emp.Bank_Name;
                        obj.Column5 = Emp.User_Name;
                        obj.Column20 = "Emp";
                        obj.Save();
                    } while (Emp.MoveNext());
                }
                #endregion

                #region العملاء
                double TotalCustomer = 0;
                ViewCustomerPaying pp = new ViewCustomerPaying();
                pp.Where.Pay_Type.Value = "خصم عام";
                pp.Where.Pay_Type.Operator = WhereParameter.Operand.NotEqual;
                pp.Where.Pay_Date.Value = dateTimePicker5.Value.Date;
                if (pp.Query.Load())
                {
                    do
                    {
                        if (pp.Pay_Type == "سند قبض")
                        {
                            TotalCustomer += pp.Pay_Money;
                        }
                        else
                        {
                            TotalCustomer -= pp.Pay_Money;
                        }

                        TblPrint obj = new TblPrint();
                        obj.AddNew();
                        obj.Column1 = pp.Pay_Type;
                        obj.Column2 = pp.Customer_Name + " - " + pp.Pay_Details;
                        obj.Column3 = pp.Pay_Money.ToString("0,0.00");
                        obj.Column4 = pp.Bank_Name;
                        obj.Column5 = pp.User_Name;
                        obj.Column6 = TotalCustomer.ToString("0,0.00");
                        obj.Column20 = "Customers";
                        obj.Save();
                    } while (pp.MoveNext());
                }
                #endregion

                #region الموردين
                ViewVendorsBills kk = new ViewVendorsBills();
                kk.Where.Bill_Date.Value = dateTimePicker5.Value.Date;
                kk.Where.Bill_PayType.Value = "%" + "كاش" + "%";
                kk.Where.Bill_PayType.Operator = WhereParameter.Operand.Like;
                if (kk.Query.Load())
                {
                    do
                    {
                        TblBanks bb = new TblBanks();
                        bb.LoadByPrimaryKey(kk.Bank_Id);

                        ClassVendorBillTotal cs = new ClassVendorBillTotal(kk.Bill_ID);

                        TblPrint obj = new TblPrint();
                        obj.AddNew();
                        obj.Column1 = kk.Bill_PayType;
                        obj.Column2 = kk.Vendor_Name + " - " + kk.Bill_Details;
                        obj.Column3 = cs.BillTotalAfterDiscount.ToString("0,0.00");
                        obj.Column4 = bb.Bank_Name;
                        obj.Column5 = kk.User_Name;
                        obj.Column20 = "Vendors";
                        obj.Save();
                    } while (kk.MoveNext());
                }

                ViewVendorPaying v = new ViewVendorPaying();
                //v.Where.Pay_Type.Value = "سند صرف";
                v.Where.Ven_PayDate.Value = dateTimePicker5.Value.Date;
                if (v.Query.Load())
                {
                    do
                    {
                        TblPrint obj = new TblPrint();
                        obj.AddNew();
                        obj.Column1 = "سند صرف";
                        obj.Column2 = v.Vendor_Name + " - " + v.Ven_PayDetails;
                        obj.Column3 = v.Ven_PayMoney.ToString("0,0.00");
                        obj.Column4 = v.Bank_Name;
                        obj.Column5 = v.User_Name;
                        obj.Column20 = "Vendors";
                        obj.Save();
                    } while (v.MoveNext());
                }
                #endregion

            }

            FrmPrintDailyReport x = new FrmPrintDailyReport();
            x.ShowDialog();
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString() == "رصيد سابق")
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }

            if (dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString() == "الإجمالي")
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            Finance.DialogPayDetails obj = new Finance.DialogPayDetails("سداد عملاء",dateTimePicker5.Value.Date);
            obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Finance.DialogPayDetails obj = new Finance.DialogPayDetails("سداد الموردين", dateTimePicker5.Value.Date);
            obj.ShowDialog();
        }
    }
}
