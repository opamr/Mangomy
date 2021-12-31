using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGeneration.dOOdads;
using MyPro;

namespace MyApplication.Banks
{
    public partial class DialogBankFinance : Form
    {
        int MyBankID;
        string MySearchType;
        public DialogBankFinance(int BankId)
        {
            MyBankID = BankId;
            InitializeComponent();
        }

        private void DialogBankFinance_Load(object sender, EventArgs e)
        {
            TblBanks bb = new TblBanks();
            bb.LoadByPrimaryKey(MyBankID);
            lblName.Text = bb.Bank_Name;

            MySearchType = "load";

            FillGrid();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Banks.DialogAddBank obj = new DialogAddBank(MyBankID);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                DialogBankFinance_Load(sender, e);
            }
        }

        private void FillGrid()
        {
            double Last = 0;
            dataGridView1.Rows.Clear();
            TblBanks bb = new TblBanks();
            bb.LoadByPrimaryKey(MyBankID);

            if (bb.Bank_FisrtDate.Date >= DateTime.Parse(dateTimePicker1.Text) && bb.Bank_FisrtDate.Date <= DateTime.Parse(dateTimePicker2.Text) && bb.Bank_FirstPeriod != 0)
            {
                dataGridView1.Rows.Add("رصيد بدائي", 0, bb.Bank_FisrtDate.Date, "", bb.Bank_FirstPeriod.ToString("0,0.00"), 0);
            }
            else if (bb.Bank_FisrtDate.Date < DateTime.Parse(dateTimePicker1.Text))
            {
                Last += bb.Bank_FirstPeriod;
            }

            //--------------------------------------------مبيعات كاش وشبكة
            #region مبيعات كاش وشبكة
            if (MyBankID == 1)
            {
                TblCustomersBills xd;
                xd = new TblCustomersBills();
                xd.Where.Pay_Cash.Value = 0;
                xd.Where.Pay_Cash.Operator = WhereParameter.Operand.GreaterThan;
                if (xd.Query.Load())
                {
                    do
                    {
                        if (xd.Bill_Date.Date >= DateTime.Parse(dateTimePicker1.Text) && xd.Bill_Date.Date <= DateTime.Parse(dateTimePicker2.Text))
                        {
                            if (xd.Bill_Type.Contains("فاتورة مبيعات"))
                            {
                                dataGridView1.Rows.Add("مبيعات كاش", xd.Bill_ID, xd.Bill_Date.Date, "مبيعات كاش", xd.Pay_Cash.ToString("0,0.00"), 0);
                            }
                            else if (xd.Bill_Type.Contains("فاتورة مرتجعات"))
                            {
                                dataGridView1.Rows.Add("مرتجعات كاش", xd.Bill_ID, xd.Bill_Date.Date, "مرتجعات كاش", 0, xd.Pay_Cash.ToString("0,0.00"));
                            }
                        }
                        else if (xd.Bill_Date.Date < DateTime.Parse(dateTimePicker1.Text))
                        {
                            if (xd.Bill_Type.Contains("فاتورة مبيعات"))
                            {
                                Last += xd.Pay_Cash;
                            }
                            else if (xd.Bill_Type.Contains("فاتورة مرتجعات"))
                            {
                                Last -= xd.Pay_Cash;
                            }
                        }
                    } while (xd.MoveNext());
                    
                }
            }
            else if (MyBankID == 2)
            {
                TblCustomersBills xd;
                xd = new TblCustomersBills();
                xd.Where.Pay_Bank.Value = 0;
                xd.Where.Pay_Bank.Operator = WhereParameter.Operand.GreaterThan;
                if (xd.Query.Load())
                {
                    do
                    {
                        if (xd.Bill_Date.Date >= DateTime.Parse(dateTimePicker1.Text) && xd.Bill_Date.Date <= DateTime.Parse(dateTimePicker2.Text))
                        {
                            if (xd.Bill_Type.Contains("فاتورة مبيعات"))
                            {
                                dataGridView1.Rows.Add("مبيعات شبكة", xd.Bill_ID, xd.Bill_Date.Date, "مبيعات شبكة", xd.Pay_Bank.ToString("0,0.00"), xd.Pay_Bank_Fees.ToString("0.00"));
                            }
                            else if (xd.Bill_Type.Contains("فاتورة مرتجعات"))
                            {
                                dataGridView1.Rows.Add("مرتجعات شبكة", xd.Bill_ID, xd.Bill_Date.Date, "مرتجعات شبكة", xd.Pay_Bank_Fees.ToString("0.00"), xd.Pay_Bank.ToString("0,0.00"));
                            }
                        }
                        else if (xd.Bill_Date.Date < DateTime.Parse(dateTimePicker1.Text))
                        {
                            if (xd.Bill_Type.Contains("فاتورة مبيعات"))
                            {
                                Last += xd.Pay_Bank;
                                Last -= xd.Pay_Bank_Fees;
                            }
                            else if (xd.Bill_Type.Contains("فاتورة مرتجعات"))
                            {
                                Last -= xd.Pay_Bank;
                                Last += xd.Pay_Bank_Fees;
                            }
                        }
                    } while (xd.MoveNext());
                }
            }
           
            #endregion

            #region الوارد من العملاء
            ViewCustomerPaying cp = new ViewCustomerPaying();            
            cp.Where.Bank_Id.Value = MyBankID;
            if (cp.Query.Load())
            {
                do
                {
                    if (cp.Pay_Date.Date >= DateTime.Parse(dateTimePicker1.Text) && cp.Pay_Date.Date <= DateTime.Parse(dateTimePicker2.Text))
                    {
                        if (cp.Pay_Type == "سند قبض")
                        {
                            dataGridView1.Rows.Add("مدفوعات عملاء", cp.Pay_ID, cp.Pay_Date.Date, cp.Pay_Type + " - " + cp.Customer_Name + " - "+ cp.Pay_Details, cp.Pay_Money.ToString("0,0.00"), 0);
                        }
                        else if (cp.Pay_Type == "سند صرف")
                        {
                            dataGridView1.Rows.Add("مدفوعات عملاء", cp.Pay_ID, cp.Pay_Date.Date,cp.Pay_Type + " - "+ cp.Customer_Name + " - " + cp.Pay_Details, 0, cp.Pay_Money.ToString("0,0.00"));
                        }
                    }
                    else if (cp.Pay_Date.Date < DateTime.Parse(dateTimePicker1.Text))
                    {
                        if (cp.Pay_Type == "سند قبض")
                        {
                            Last += cp.Pay_Money;
                        }
                        else if (cp.Pay_Type == "سند صرف")
                        {
                            Last -= cp.Pay_Money;
                        }
                    }

                } while (cp.MoveNext());
            }
            #endregion

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
                    if (rt.Bill_Date.Date >= DateTime.Parse(dateTimePicker1.Text) && rt.Bill_Date.Date <= DateTime.Parse(dateTimePicker2.Text))
                    {
                        if (rt.Bill_PayType == "فاتورة مشتريات كاش")
                        {
                            dataGridView1.Rows.Add(rt.Bill_PayType, Convert.ToDouble(rt.Bill_VendorNumber), rt.Bill_Date.Date, rt.Vendor_Name,
                           0, cs.BillTotalAfterDiscount.ToString("0,0.00"), 0, rt.Bill_ID);
                        }
                        else
                        {
                            dataGridView1.Rows.Add(rt.Bill_PayType, Convert.ToDouble(rt.Bill_VendorNumber), rt.Bill_Date.Date, rt.Vendor_Name,
                            cs.BillTotalAfterDiscount.ToString("0,0.00"), 0, 0, rt.Bill_ID);
                        }

                    }
                    else if (rt.Bill_Date.Date < DateTime.Parse(dateTimePicker1.Text))
                    {
                        if (rt.Bill_PayType == "فاتورة مشتريات كاش")
                        {
                            Last -= cs.BillTotalAfterDiscount;
                        }
                        else
                        {
                            Last += cs.BillTotalAfterDiscount;
                        }
                    }
                } while (rt.MoveNext());
            }


            TblVendorsPaying vv = new TblVendorsPaying();            
            vv.Where.Bank_Id.Value = MyBankID;
            if (vv.Query.Load())
            {
                do
                {
                    if (vv.Ven_PayDate.Date >= DateTime.Parse(dateTimePicker1.Text) && vv.Ven_PayDate.Date <= DateTime.Parse(dateTimePicker2.Text))
                    {
                        TblVendorsData hh = new TblVendorsData();
                        hh.LoadByPrimaryKey(vv.Vendor_Id);
                        string details = vv.Ven_PayDetails + " - " + hh.Vendor_Name;
                        dataGridView1.Rows.Add("مدفوعات للموردين", vv.Ven_PayID, vv.Ven_PayDate.Date, details, 0, vv.Ven_PayMoney.ToString("0,0.00"));
                    }
                    else if (vv.Ven_PayDate.Date < DateTime.Parse(dateTimePicker1.Text))
                    {
                        Last -= vv.Ven_PayMoney;
                    }
                } while (vv.MoveNext());
            }

            #endregion

            #region صرف رواتب
            ViewEmployeesSalaryPaying sq = new ViewEmployeesSalaryPaying();
            sq.Where.Bank_Id.Value = MyBankID;
            if (sq.Query.Load())
            {
                do
                {
                    if (sq.Pay_Date.Date >= DateTime.Parse(dateTimePicker1.Text) && sq.Pay_Date.Date <= DateTime.Parse(dateTimePicker2.Text))
                    {
                        dataGridView1.Rows.Add("صرف رواتب", sq.Pay_ID, sq.Pay_Date.Date,
                             sq.Emp_Name + " - " + sq.Salary_Details + " - " + sq.Pay_Details, 0, sq.Pay_Money.ToString("0,0.00"));
                    }
                    else if (sq.Pay_Date.Date < DateTime.Parse(dateTimePicker1.Text))
                    {
                        Last -= sq.Pay_Money;
                    }
                } while (sq.MoveNext());
            }
            #endregion

            //------------------------------------------------------------------تحميل المصروفات
            #region المصروفات
            TblOutComings ou = new TblOutComings();            
            ou.Where.Bank_Id.Value = MyBankID;
            if (ou.Query.Load())
            {
                do
                {
                    if (ou.Out_Date.Date >= DateTime.Parse(dateTimePicker1.Text) && ou.Out_Date.Date <= DateTime.Parse(dateTimePicker2.Text))
                    {
                        dataGridView1.Rows.Add("مصروفات يومية", ou.Out_ID, ou.Out_Date.Date, ou.Out_Details, 0, ou.Out_Money.ToString("0,0.00"));
                    }
                    else if (ou.Out_Date.Date < DateTime.Parse(dateTimePicker1.Text))
                    {
                        Last -= ou.Out_Money;
                    }
                } while (ou.MoveNext());
            }

            #endregion
           
            //---------------------------------------------------------------------------تحميل التحويلات
            #region التحويلات
            TblBankOperation mm = new TblBankOperation();
            mm.LoadAll();
            if (mm.RowCount > 0)
            {
                do
                {
                    if (mm.Operate_Date.Date >= DateTime.Parse(dateTimePicker1.Text) && mm.Operate_Date.Date <= DateTime.Parse(dateTimePicker2.Text))
                    {
                        if (mm.Operate_ConvertFrom == MyBankID)
                        {
                            dataGridView1.Rows.Add("تحويلات", mm.Operate_ID, mm.Operate_Date.Date, mm.Operate_Details, 0, mm.Operate_Money.ToString("0,0.00"));
                        }
                        else if (mm.Operate_ConvertTo == MyBankID)
                        {
                            dataGridView1.Rows.Add("تحويلات", mm.Operate_ID, mm.Operate_Date.Date, mm.Operate_Details, mm.Operate_Money.ToString("0,0.00"), 0);
                        }
                    }
                    else if (mm.Operate_Date.Date < DateTime.Parse(dateTimePicker1.Text))
                    {
                        if (mm.Operate_ConvertFrom == MyBankID)
                        {
                            Last -= mm.Operate_Money;
                        }
                        else if (mm.Operate_ConvertTo == MyBankID)
                        {
                            Last += mm.Operate_Money;
                        }
                    }

                } while (mm.MoveNext());
            }

            #endregion

            if (Last < 0)
            {
                Last *= -1;
                dataGridView1.Rows.Add("رصيد سابق", -1, DateTime.Parse(dateTimePicker1.Text).AddDays(-1), "", 0, Last.ToString("0,0.00"));
            }
            else if (Last > 0)
            {
                dataGridView1.Rows.Add("رصيد سابق", -1, DateTime.Parse(dateTimePicker1.Text).AddDays(-1), "", Last.ToString("0,0.00"), 0);
            }

            this.dataGridView1.Sort(dataGridView1.Columns["Column7"], ListSortDirection.Ascending);
            double total = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                total += double.Parse(item.Cells["ColumnMadyn"].Value.ToString()) - double.Parse(item.Cells["ColumnDaen"].Value.ToString());
                item.Cells["ColumnRaseed"].Value = total.ToString("0,0.00");

                string date = item.Cells["Column7"].Value.ToString();
                item.Cells["Column7"].Value = DateTime.Parse(date).ToShortDateString();

                if (Convert.ToDouble(item.Cells["ColumnDaen"].Value) > 0)
                {
                    item.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }

            dataGridView1.ClearSelection();
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            MySearchType = "time";

            FillGrid();
        }   

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                return;
            }

            TblPrint pr = new TblPrint();
            pr.LoadAll();
            pr.DeleteAll();
            pr.Save();

            string title = "كشف حساب كامل ل / " + lblName.Text;
            if (MySearchType == "time")
            {
                title = "كشف حساب ل / " + lblName.Text + " خلال المدة من : " + dateTimePicker1.Text + " إلى: " + dateTimePicker2.Text;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                TblPrint obj = new TblPrint();
                obj.AddNew();
                obj.Column1 = row.Cells["Column2"].Value.ToString();
                obj.Column2 = row.Cells["Column7"].Value.ToString();
                obj.Column3 = row.Cells["Column3"].Value.ToString();
                obj.Column4 = row.Cells["ColumnMadyn"].Value.ToString();
                obj.Column5 = row.Cells["ColumnDaen"].Value.ToString();
                obj.Column6 = row.Cells["ColumnRaseed"].Value.ToString();
                obj.Column7 = title;
                obj.Column8 = row.Cells["Column1"].Value.ToString();
                obj.Save();
            }

            FrmPrintBankFinance fr = new FrmPrintBankFinance();
            fr.ShowDialog();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = int.Parse(dataGridView1["Column1", dataGridView1.CurrentRow.Index].Value.ToString());
                string Type = dataGridView1["Column2", dataGridView1.CurrentRow.Index].Value.ToString();
                if (Type.Contains("تحويلات"))
                {
                    ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 30);
                    if (xx.Allow == "no")
                    {
                        MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                        return;
                    }

                    TblBankOperation mm = new TblBankOperation();
                    mm.Where.Operate_ID.Value = id;
                    if (mm.Query.Load())
                    {
                        Banks.DialogConvertMoney obj = new DialogConvertMoney(mm.Operate_ConvertFrom, mm.Operate_ID);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            DialogBankFinance_Load(sender, e);
                        }
                    }
                }
                else if (Type == "فاتورة مشتريات كاش" || Type == "فاتورة مرتجعات كاش")
                {
                    int ID2 = int.Parse(dataGridView1["Column4", dataGridView1.CurrentRow.Index].Value.ToString());
                    Vendors.DialogBillDetails ff = new Vendors.DialogBillDetails(ID2);
                    ff.Show();
                }
                else if (Type == "مبيعات كاش" || Type == "مبيعات شبكة" || Type == "مرتجعات كاش")
                {
                    Payments.DialogPaymentBillDetails obj = new Payments.DialogPaymentBillDetails(id);
                    obj.Show();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
