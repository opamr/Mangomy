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
namespace MyApplication.Customers
{
    public partial class FrmCustomerFinance : Form
    {
        int MyCustomerID;
        string MySearchType;
        public FrmCustomerFinance(int Customer)
        {
            MyCustomerID = Customer;
            InitializeComponent();
        }

        private void FrmCustomerFinance2_Load(object sender, EventArgs e)
        {
            MySearchType = "Load";

            //----------load vendor Data    
            TblCustomersData vv = new TblCustomersData();
            vv.LoadByPrimaryKey(MyCustomerID);
            lblAddress.Text = vv.Customer_Address;
            lblName.Text = vv.Customer_Name;
            lblPhone1.Text = vv.Customer_Mobile;
            lblPhone2.Text = vv.Customer_VatNumber;            

            dataGridView1.Rows.Clear();

            //-------------------------------------------------------رصيد ما قبل البرنامج
            TblCustomersData cd = new TblCustomersData();
            cd.LoadByPrimaryKey(MyCustomerID);
            if (cd.Recent_money != 0)
            {
                dataGridView1.Rows.Add(0, cd.RecentDate, "رصيد سابق", cd.Recent_money.ToString("0,0.00"), 0);
            }


            //----------------------------------------------------load Bills
            TblCustomersBills bi = new TblCustomersBills();
            bi.Where.Customer_Id.Value = MyCustomerID;
            if (bi.Query.Load())
            {
                do
                {
                    
                        ClassCustomerBillTotal cs = new ClassCustomerBillTotal(bi.Bill_ID);
                        
                        if (bi.Bill_Type == "فاتورة مرتجعات")
                        {                                                   
                            dataGridView1.Rows.Add(bi.Bill_ID, bi.Bill_Date, bi.Bill_Type,cs.AllPay.ToString("0,0.00"), cs.BillTotalAfterVat.ToString("0,0.00"));
                        }
                        else if (bi.Bill_Type.Contains("فاتورة مبيعات"))
                        {
                            dataGridView1.Rows.Add(bi.Bill_ID, bi.Bill_Date, bi.Bill_Type, cs.BillTotalAfterVat.ToString("0,0.00"), cs.AllPay.ToString("0,0.00"));
                        }
                   
                } while (bi.MoveNext());
            }

            //-------------------------------------------------------------------------------------load Paying
            TblCustomersPaying vp = new TblCustomersPaying();
            vp.Where.Customer_Id.Value = MyCustomerID;
            if (vp.Query.Load())
            {
                do
                {
                    if (vp.Pay_Type == "سند صرف")
                    {
                        dataGridView1.Rows.Add(vp.Pay_ID, vp.Pay_Date, vp.Pay_Type + " - " + vp.Pay_Details, vp.Pay_Money.ToString("0,0.00"), 0);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(vp.Pay_ID, vp.Pay_Date, vp.Pay_Type + " - " + vp.Pay_Details, 0, vp.Pay_Money.ToString("0,0.00"));
                    }
                } while (vp.MoveNext());
            }


            //----------------------------------------------------------
            this.dataGridView1.Sort(dataGridView1.Columns["Column7"], ListSortDirection.Ascending);

            double total2 = 0;


            double AllBacks = 0, AllBill = 0, AllPay = 0, AllRest = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                total2 += double.Parse(item.Cells["ColumnMadyn"].Value.ToString()) 
                    - double.Parse(item.Cells["ColumnDaen"].Value.ToString());
                item.Cells["ColumnRaseed"].Value = total2.ToString("0,0.00");

                string date = item.Cells["Column7"].Value.ToString();
                item.Cells["Column7"].Value = DateTime.Parse(date).ToShortDateString();

                if (item.Cells["Column3"].Value.ToString() == "فاتورة مرتجعات")
                {
                    item.DefaultCellStyle.BackColor = Color.Yellow;
                    AllBacks += double.Parse(item.Cells["ColumnDaen"].Value.ToString());
                    AllPay -= double.Parse(item.Cells["ColumnMadyn"].Value.ToString());
                }
                else if (item.Cells["Column3"].Value.ToString().Contains("فاتورة مبيعات"))
                {
                    AllBill += double.Parse(item.Cells["ColumnMadyn"].Value.ToString());
                    AllPay += double.Parse(item.Cells["ColumnDaen"].Value.ToString());
                }
                else if (item.Cells["Column3"].Value.ToString().Contains("سند قبض"))
                {
                    item.DefaultCellStyle.BackColor = Color.LightGreen;
                    AllPay += double.Parse(item.Cells["ColumnDaen"].Value.ToString());
                }
                else if (item.Cells["Column3"].Value.ToString().Contains("سند صرف"))
                {
                    item.DefaultCellStyle.BackColor = Color.Tomato;
                    AllPay -= double.Parse(item.Cells["ColumnMadyn"].Value.ToString());
                }
                else if (item.Cells["Column3"].Value.ToString().Contains("خصم عام"))
                {
                    item.DefaultCellStyle.BackColor = Color.LightBlue;
                    AllPay += double.Parse(item.Cells["ColumnDaen"].Value.ToString());
                }
                else
                {
                    AllRest += double.Parse(item.Cells["ColumnMadyn"].Value.ToString());
                }

                //if (item.Cells["Column3"].Value.ToString() == "فاتورة مبيعات كاش")
                //{
                //    item.DefaultCellStyle.BackColor = Color.Orange;
                //    AllPay += double.Parse(item.Cells["ColumnDaen"].Value.ToString());
                //}
               
            }
            //-----------------------------------------------------------
            lblAllbills.Text = AllBill.ToString("0,0.00");
            lblBacks.Text = AllBacks.ToString("0,0.00");
            lblAllPaying.Text = AllPay.ToString("0,0.00");
            lblLast.Text = AllRest.ToString("0,0.00");

            lblNow.Text = (AllBill + AllRest - AllBacks - AllPay).ToString("0,0.00");

            dataGridView1.ClearSelection();
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            MySearchType = "Duration";

            //-----------------------------------
            double Last = 0;
            dataGridView1.Rows.Clear();
            //-------------------------------------------------------رصيد ما قبل البرنامج
            TblCustomersData cd = new TblCustomersData();
            cd.LoadByPrimaryKey(MyCustomerID);

            if (cd.Recent_money != 0 && cd.RecentDate.Date >= DateTime.Parse(dateTimePicker1.Text) && cd.RecentDate.Date <= DateTime.Parse(dateTimePicker2.Text))
            {
                dataGridView1.Rows.Add(0, cd.RecentDate.Date, "رصيد قبل البرنامج", cd.Recent_money.ToString("0,0.00"), 0);
            }
            else if (cd.RecentDate.Date < DateTime.Parse(dateTimePicker1.Text))
            {
                Last += cd.Recent_money;
            }


            //----------------------------------------------------load Bills
            TblCustomersBills bi = new TblCustomersBills();
            bi.Where.Customer_Id.Value = MyCustomerID;
            if (bi.Query.Load())
            {
                do
                {
                    if (bi.Bill_Date >= DateTime.Parse(dateTimePicker1.Text) && bi.Bill_Date <= DateTime.Parse(dateTimePicker2.Text))
                    {
                       
                            ClassCustomerBillTotal cs = new ClassCustomerBillTotal(bi.Bill_ID);

                            if (bi.Bill_Type == "فاتورة مرتجعات")
                            {
                                dataGridView1.Rows.Add(bi.Bill_ID, bi.Bill_Date.Date, bi.Bill_Type, cs.AllPay.ToString("0,0.00"), cs.BillTotalAfterVat.ToString("0,0.00"));
                            }
                            else if (bi.Bill_Type.Contains("فاتورة مبيعات"))
                            {
                                dataGridView1.Rows.Add(bi.Bill_ID, bi.Bill_Date.Date, bi.Bill_Type, cs.BillTotalAfterVat.ToString("0,0.00"), cs.AllPay.ToString("0,0.00"));
                            }
                       
                    }
                    else if (bi.Bill_Date < DateTime.Parse(dateTimePicker1.Text))
                    {
                        ClassCustomerBillTotal cs = new ClassCustomerBillTotal(bi.Bill_ID);
                        if (bi.Bill_Type == "فاتورة مرتجعات")
                        {
                            Last -= cs.BillRest;
                        }
                        else if (bi.Bill_Type.Contains("فاتورة مبيعات"))
                        {
                            Last += cs.BillRest;
                        }
                    }
                } while (bi.MoveNext());
            }

            //-------------------------------------------------------------------------------------load Paying
            TblCustomersPaying vp = new TblCustomersPaying();
            vp.Where.Customer_Id.Value = MyCustomerID;
            if (vp.Query.Load())
            {
                do
                {
                    if (vp.Pay_Date >= DateTime.Parse(dateTimePicker1.Text) && vp.Pay_Date <= DateTime.Parse(dateTimePicker2.Text))
                    {
                        if (vp.Pay_Type == "سند صرف")
                        {
                            dataGridView1.Rows.Add(vp.Customer_Id, vp.Pay_Date, vp.Pay_Type + " - " + vp.Pay_Details, vp.Pay_Money.ToString("0,0.00"), 0);                            
                        }
                        else
                        {
                            dataGridView1.Rows.Add(vp.Customer_Id, vp.Pay_Date, vp.Pay_Type + " - " + vp.Pay_Details, 0, vp.Pay_Money.ToString("0,0.00"));
                        }
                    }
                    else if (vp.Pay_Date < DateTime.Parse(dateTimePicker1.Text))
                    {
                        if (vp.Pay_Type == "سند صرف")
                        {
                            Last += vp.Pay_Money;                            
                        }
                        else
                        {
                            Last -= vp.Pay_Money;
                        }
                    }
                } while (vp.MoveNext());
            }
            //--------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------
            if (Last < 0)
            {
                Last = Last * -1;
                dataGridView1.Rows.Add(-1, DateTime.Parse(dateTimePicker1.Text).AddDays(-1), "رصيد سابق", 0, Last.ToString("0,0.00"));
            }
            else if (Last > 0)
            {
                dataGridView1.Rows.Add(-1, DateTime.Parse(dateTimePicker1.Text).AddDays(-1), "رصيد سابق", Last.ToString("0,0.00"), 0);
            }
            //----------------------------------------------------------
            this.dataGridView1.Sort(dataGridView1.Columns["Column7"], ListSortDirection.Ascending);

            double total2 = 0;

            double AllBacks = 0, AllBill = 0, AllPay = 0, AllRest = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                total2 += double.Parse(item.Cells["ColumnMadyn"].Value.ToString())
                    - double.Parse(item.Cells["ColumnDaen"].Value.ToString());
                item.Cells["ColumnRaseed"].Value = total2.ToString("0,0.00");

                string date = item.Cells["Column7"].Value.ToString();
                item.Cells["Column7"].Value = DateTime.Parse(date).ToShortDateString();

                if (item.Cells["Column3"].Value.ToString() == "فاتورة مرتجعات")
                {
                    item.DefaultCellStyle.BackColor = Color.Yellow;
                    AllBacks += double.Parse(item.Cells["ColumnDaen"].Value.ToString());
                    AllPay -= double.Parse(item.Cells["ColumnMadyn"].Value.ToString());
                }
                else if (item.Cells["Column3"].Value.ToString().Contains("فاتورة مبيعات"))
                {
                    AllBill += double.Parse(item.Cells["ColumnMadyn"].Value.ToString());
                    AllPay += double.Parse(item.Cells["ColumnDaen"].Value.ToString());
                }
                else if (item.Cells["Column3"].Value.ToString().Contains("سند قبض"))
                {
                    item.DefaultCellStyle.BackColor = Color.LightGreen;
                    AllPay += double.Parse(item.Cells["ColumnDaen"].Value.ToString());
                }
                else if (item.Cells["Column3"].Value.ToString().Contains("سند صرف"))
                {
                    item.DefaultCellStyle.BackColor = Color.Tomato;
                    AllPay -= double.Parse(item.Cells["ColumnMadyn"].Value.ToString());
                }
                else if (item.Cells["Column3"].Value.ToString().Contains("خصم عام"))
                {
                    item.DefaultCellStyle.BackColor = Color.LightBlue;
                    AllPay += double.Parse(item.Cells["ColumnDaen"].Value.ToString());
                }
                else
                {
                    AllRest += double.Parse(item.Cells["ColumnMadyn"].Value.ToString());
                }              
            }
            //-----------------------------------------------------------
            lblAllbills.Text = AllBill.ToString("0,0.00");
            lblBacks.Text = AllBacks.ToString("0,0.00");
            lblAllPaying.Text = AllPay.ToString("0,0.00");
            lblLast.Text = AllRest.ToString("0,0.00");

            lblNow.Text = (AllBill + AllRest - AllBacks - AllPay).ToString("0,0.00");
            dataGridView1.ClearSelection();
            //-----------------------------------------------------------
        }        

        private void BtnPayMoney_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 17);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            } 

            DialogAddCustomerPaying obj = new DialogAddCustomerPaying(MyCustomerID, 0,"سند قبض");
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                if (MySearchType == "Load")
                {
                    FrmCustomerFinance2_Load(sender, e);
                }
                else
                {
                    btnSearchByDate_Click(sender, e);
                }
            }
        }         

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 18);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            } 
            
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = int.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                string Type = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                if (id > 0)
                {
                    if (Type.Substring(0,6).Contains("فاتورة"))
                    {
                        Payments.DialogPaymentBillDetails order = new Payments.DialogPaymentBillDetails(id);
                        order.ShowDialog();
                        if (order.DialogResult == DialogResult.OK)
                        {
                            if (MySearchType == "Load")
                            {
                                FrmCustomerFinance2_Load(sender, e);
                            }
                            else
                            {
                                btnSearchByDate_Click(sender, e);
                            }
                        }
                    }
                    else if (Type.Contains("سند قبض") || Type.Contains("سند صرف") || Type.Contains("خصم عام"))
                    {
                        TblCustomersPaying pp = new TblCustomersPaying();
                        pp.LoadByPrimaryKey(id);

                        DialogAddCustomerPaying vv = new DialogAddCustomerPaying(MyCustomerID, id,pp.Pay_Type);
                        vv.ShowDialog();
                        if (vv.DialogResult == DialogResult.OK)
                        {
                            if (MySearchType == "Load")
                            {
                                FrmCustomerFinance2_Load(sender, e);
                            }
                            else
                            {
                                btnSearchByDate_Click(sender, e);
                            }
                        }
                    }
                 
                }
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                TblPrint pr = new TblPrint();
                pr.LoadAll();
                pr.DeleteAll();
                pr.Save();

                DialogResult d = MessageBox.Show("هل تريد بالتأكيد طباعة كشف الحساب الحالي", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (d == DialogResult.OK)
                {
                    string title = "";
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        TblPrint obj = new TblPrint();
                        obj.AddNew();
                        obj.Column1 = row.Cells["Column1"].Value.ToString();
                        obj.Column2 = row.Cells["Column7"].Value.ToString();
                        obj.Column3 = row.Cells["Column3"].Value.ToString();
                        obj.Column4 = row.Cells["ColumnMadyn"].Value.ToString();
                        obj.Column5 = row.Cells["ColumnDaen"].Value.ToString();
                        obj.Column6 = row.Cells["ColumnRaseed"].Value.ToString();
                        obj.Column7 = lblName.Text;
                        obj.Column8 = MyCustomerID.ToString();
                        title = "كشف حساب العميل في المدة من " + dateTimePicker1.Text + " إلى " + dateTimePicker2.Text;
                        if (MySearchType == "Load")
                        {
                            title = "كشف حساب كامل للعميل";
                        }
                        obj.Column9 = title;
                        obj.Save();
                    }


                    FrmPrintCustomerFinance x = new FrmPrintCustomerFinance(MyCustomerID, title);
                    x.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("لا يوجد بيانات للطباعة");
            }
        }

        private void BtnSnadSarf_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 17);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            DialogAddCustomerPaying obj = new DialogAddCustomerPaying(MyCustomerID, 0, "سند صرف");
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                if (MySearchType == "Load")
                {
                    FrmCustomerFinance2_Load(sender, e);
                }
                else
                {
                    btnSearchByDate_Click(sender, e);
                }
            }
        }

        private void BtnAddDiscount_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 17);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            DialogAddCustomerPaying obj = new DialogAddCustomerPaying(MyCustomerID, 0, "خصم عام");
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                if (MySearchType == "Load")
                {
                    FrmCustomerFinance2_Load(sender, e);
                }
                else
                {
                    btnSearchByDate_Click(sender, e);
                }
            }
        }
    }
}
