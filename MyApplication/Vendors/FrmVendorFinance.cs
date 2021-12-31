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
namespace MyApplication.Vendors
{
    public partial class FrmVendorFinance : Form
    {
        int MyVendorID;
        string MySearchType;
        public FrmVendorFinance(int VendorID)
        {
            MyVendorID = VendorID;
            InitializeComponent();
        }

        private void FrmVendorFinance2_Load_1(object sender, EventArgs e)
        {
            MySearchType = "Load";

            //----------load vendor Data    
            TblVendorsData vv = new TblVendorsData();
            vv.LoadByPrimaryKey(MyVendorID);
            lblAddress.Text = vv.Vendor_Address;
            lblName.Text = vv.Vendor_Name;
            lblVendorPhone.Text = vv.Vendor_Phone;
            lblSender.Text = vv.Vendor_SenderName;
            lblSenderMobile.Text = vv.Vendor_SenderMobile;

            dataGridView1.Rows.Clear();
            //-------------------------------------------------------رصيد ما قبل البرنامج
            TblVendorsData cd = new TblVendorsData();
            cd.LoadByPrimaryKey(MyVendorID);
            dataGridView1.Rows.Add(0,0, cd.Vendor_RecentDate.Date, "رصيد سابق", 0, cd.Vendor_RecentMoney);
            

            //----------------------------------------------------load Bills
            TblVendorsBills bi = new TblVendorsBills();
            bi.Where.Bill_VendorId.Value = MyVendorID;
            if (bi.Query.Load())
            {
                do
                {
                    TblVendorsBillGoods gb = new TblVendorsBillGoods();
                    gb.Where.Bill_id.Value = bi.Bill_ID;
                    if (gb.Query.Load())
                    {
                        ClassVendorBillTotal bibi = new ClassVendorBillTotal(bi.Bill_ID);

                        double Pay = 0;
                        if (bi.Bill_PayType.Contains("كاش"))
                        {
                            Pay = bibi.BillTotalAfterDiscount;
                        }

                        if (bi.Bill_PayType.Contains("مرتجعات"))
                        {
                            dataGridView1.Rows.Add(bi.Bill_ID, bi.Bill_VendorNumber, bi.Bill_Date.Date, bi.Bill_PayType, bibi.BillTotalAfterDiscount, Pay);
                        }
                        else
                        {                          
                            dataGridView1.Rows.Add(bi.Bill_ID, bi.Bill_VendorNumber, bi.Bill_Date.Date, bi.Bill_PayType, Pay, bibi.BillTotalAfterDiscount);
                        }
                    }
                    else
                    {
                        gb.MarkAsDeleted();
                        gb.Save();
                    }
                } while (bi.MoveNext());
            }

            //-------------------------------------------------------------------------------------load Paying
            TblVendorsPaying vp = new TblVendorsPaying();
            vp.Where.Vendor_Id.Value = MyVendorID;
            if (vp.Query.Load())
            {
                do
                {

                    dataGridView1.Rows.Add(vp.Ven_PayID, vp.Pay_Wasl, vp.Ven_PayDate, "سند صرف" + " - " + vp.Ven_PayDetails,
                        vp.Ven_PayMoney, 0);
                } while (vp.MoveNext());
            }


            //----------------------------------------------------------
            this.dataGridView1.Sort(dataGridView1.Columns["Column7"], ListSortDirection.Ascending);

            double total = 0;


            double AllBacks = 0, AllBill = 0, AllPay = 0, AllRest = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                total += double.Parse(item.Cells["ColumnDaen"].Value.ToString()) - double.Parse(item.Cells["ColumnMadyn"].Value.ToString());
                item.Cells["ColumnRaseed"].Value = total.ToString("0,0.00"); ;

                string date = item.Cells["Column7"].Value.ToString();
                item.Cells["Column7"].Value = DateTime.Parse(date).ToShortDateString();

                if (item.Cells["Column3"].Value.ToString().Contains("مرتجعات"))
                {
                    item.DefaultCellStyle.BackColor = Color.Yellow;
                    AllBacks += double.Parse(item.Cells["ColumnMadyn"].Value.ToString());
                    if (item.Cells["Column3"].Value.ToString().Contains("كاش"))
                    {
                        AllPay -= double.Parse(item.Cells["ColumnMadyn"].Value.ToString());
                    }
                }
                else if (item.Cells["Column3"].Value.ToString().Contains("مشتريات"))
                {
                    AllBill += double.Parse(item.Cells["ColumnDaen"].Value.ToString());
                    if (item.Cells["Column3"].Value.ToString().Contains("كاش"))
                    {
                        AllPay += double.Parse(item.Cells["ColumnMadyn"].Value.ToString());
                    }
                }
                else if (item.Cells["Column3"].Value.ToString().Contains("سند صرف"))
                {
                    item.DefaultCellStyle.BackColor = Color.LightGreen;
                    AllPay += double.Parse(item.Cells["ColumnMadyn"].Value.ToString());
                }
                else
                {
                    AllRest += double.Parse(item.Cells["ColumnDaen"].Value.ToString());
                }
            }
            //-----------------------------------------------------------
            lblAllbills.Text = AllBill.ToString("0,0.00");
            lblBacks.Text = AllBacks.ToString("0,0.00");
            lblAllPaying.Text = AllPay.ToString("0,0.00");
            lblLast.Text = AllRest.ToString("0,0.00");

            lblNow.Text = lblNow2.Text = (AllBill + AllRest - AllBacks - AllPay).ToString("0,0.00");

            dataGridView1.ClearSelection();
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            MySearchType = "Duration";

            //-----------------------------------
            double Last = 0;
            dataGridView1.Rows.Clear();
            //-------------------------------------------------------رصيد ما قبل البرنامج
            TblVendorsData cd = new TblVendorsData();
            cd.LoadByPrimaryKey(MyVendorID);

            if (cd.Vendor_RecentDate >= DateTime.Parse(dateTimePicker1.Text) && cd.Vendor_RecentDate <= DateTime.Parse(dateTimePicker2.Text))
            {
                dataGridView1.Rows.Add(0, 0, cd.Vendor_RecentDate.Date, "رصيد قبل البرنامج", 0, cd.Vendor_RecentMoney);
            }
            else if (cd.Vendor_RecentDate < DateTime.Parse(dateTimePicker1.Text))
            {
                Last += cd.Vendor_RecentMoney;
            }
            

            //----------------------------------------------------load Bills
                TblVendorsBills bi = new TblVendorsBills();
            bi.Where.Bill_VendorId.Value = MyVendorID;
            if (bi.Query.Load())
            {
                do
                {
                    if (bi.Bill_Date >= DateTime.Parse(dateTimePicker1.Text) && bi.Bill_Date <= DateTime.Parse(dateTimePicker2.Text))
                    {                       
                        TblVendorsBillGoods gb = new TblVendorsBillGoods();
                        gb.Where.Bill_id.Value = bi.Bill_ID;
                        if (gb.Query.Load())
                        {
                            ClassVendorBillTotal bibi = new ClassVendorBillTotal(bi.Bill_ID);

                            double Pay = 0;
                            if (bi.Bill_PayType.Contains("كاش"))
                            {
                                Pay = bibi.BillTotalAfterDiscount;
                            }

                            if (bi.Bill_PayType.Contains("مرتجعات"))
                            {
                                dataGridView1.Rows.Add(bi.Bill_ID, bi.Bill_VendorNumber, bi.Bill_Date, bi.Bill_PayType, bibi.BillTotalAfterDiscount, Pay);
                            }
                            else
                            {
                               
                                dataGridView1.Rows.Add(bi.Bill_ID, bi.Bill_VendorNumber, bi.Bill_Date.Date, bi.Bill_PayType, Pay, bibi.BillTotalAfterDiscount);
                            }
                        }
                        else
                        {
                            gb.MarkAsDeleted();
                            gb.Save();
                        }
                    }
                    else if (bi.Bill_Date < DateTime.Parse(dateTimePicker1.Text))
                    {
                        ClassVendorBillTotal bibi = new ClassVendorBillTotal(bi.Bill_ID); 
                        if (bi.Bill_PayType == "فاتورة مرتجعات")
                        {
                            Last -= bibi.BillTotalAfterDiscount;
                        }
                        else
                        {
                            if (bi.Bill_PayType.Contains("آجل"))
                            {
                                Last += bibi.BillTotalAfterDiscount;
                            }
                        }
                    }
                } while (bi.MoveNext());
            }

            //-------------------------------------------------------------------------------------load Paying
            TblVendorsPaying vp = new TblVendorsPaying();
            vp.Where.Vendor_Id.Value = MyVendorID;
            if (vp.Query.Load())
            {
                do
                {
                    if (vp.Ven_PayDate.Date >= DateTime.Parse(dateTimePicker1.Text) && vp.Ven_PayDate.Date <= DateTime.Parse(dateTimePicker2.Text))
                    {
                        dataGridView1.Rows.Add(vp.Ven_PayID, vp.Pay_Wasl, vp.Ven_PayDate.Date,
                            "سند صرف" + " - " + vp.Ven_PayDetails, vp.Ven_PayMoney, 0);
                    }
                    else if (vp.Ven_PayDate.Date < DateTime.Parse(dateTimePicker1.Text))
                    {
                        Last -= vp.Ven_PayMoney;
                    }
                } while (vp.MoveNext());
            }
            //--------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------
            if (Last < 0)
            {
                Last *= -1;
                dataGridView1.Rows.Add(0, -1, DateTime.Parse(dateTimePicker1.Text).AddDays(-1), "رصيد سابق", Last, 0);
            }
            else if (Last > 0)
            {
                dataGridView1.Rows.Add(0, -1, DateTime.Parse(dateTimePicker1.Text).AddDays(-1), "رصيد سابق", 0, Last);
            }
            //----------------------------------------------------------
            this.dataGridView1.Sort(dataGridView1.Columns["Column7"], ListSortDirection.Ascending);

            double total = 0;

            double AllBacks = 0, AllBill = 0, AllPay = 0, AllRest = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                total += double.Parse(item.Cells["ColumnDaen"].Value.ToString()) - double.Parse(item.Cells["ColumnMadyn"].Value.ToString());
                item.Cells["ColumnRaseed"].Value = total.ToString("0,0.00"); ;

                string date = item.Cells["Column7"].Value.ToString();
                item.Cells["Column7"].Value = DateTime.Parse(date).ToShortDateString();

                if (item.Cells["Column3"].Value.ToString().Contains("مرتجعات"))
                {
                    item.DefaultCellStyle.BackColor = Color.Yellow;
                    AllBacks += double.Parse(item.Cells["ColumnMadyn"].Value.ToString());
                    if (item.Cells["Column3"].Value.ToString().Contains("كاش"))
                    {
                        AllPay -= double.Parse(item.Cells["ColumnMadyn"].Value.ToString());
                    }
                }
                else if (item.Cells["Column3"].Value.ToString().Contains("مشتريات"))
                {
                    AllBill += double.Parse(item.Cells["ColumnDaen"].Value.ToString());
                    if (item.Cells["Column3"].Value.ToString().Contains("كاش"))
                    {
                        AllPay += double.Parse(item.Cells["ColumnMadyn"].Value.ToString());
                    }
                }
                else if (item.Cells["Column3"].Value.ToString().Contains("سند صرف"))
                {
                    item.DefaultCellStyle.BackColor = Color.LightGreen;
                    AllPay += double.Parse(item.Cells["ColumnMadyn"].Value.ToString());
                }
                else
                {
                    AllRest += double.Parse(item.Cells["ColumnDaen"].Value.ToString());
                }
            }
            //-----------------------------------------------------------
            lblAllbills.Text = AllBill.ToString("0,0.00");
            lblBacks.Text = AllBacks.ToString("0,0.00");
            lblAllPaying.Text = AllPay.ToString("0,0.00");
            lblLast.Text = AllRest.ToString("0,0.00");

            lblNow.Text =lblNow2.Text= (AllBill + AllRest - AllBacks - AllPay).ToString("0,0.00");
            dataGridView1.ClearSelection();
            //-----------------------------------------------------------
        }       

        private void BtnPayMoney_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 6);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            DialogAddVendorPaying obj = new DialogAddVendorPaying(MyVendorID, 0);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                if (MySearchType == "Load")
                {
                    FrmVendorFinance2_Load_1(sender, e);
                }
                else
                {
                    btnSearchByDate_Click(sender, e);
                }
            }
        }            

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = int.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                string Type = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                if (id > 0)
                {
                    if (Type.Contains("سند صرف"))
                    {
                        ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 11);
                        if (xx.Allow == "no")
                        {
                            MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                            return;
                        }

                        DialogAddVendorPaying vv = new DialogAddVendorPaying(MyVendorID, id);
                        vv.ShowDialog();                       
                        if (vv.DialogResult == DialogResult.OK)
                        {
                            if (MySearchType == "Load")
                            {
                                FrmVendorFinance2_Load_1(sender, e);
                            }
                            else
                            {
                                btnSearchByDate_Click(sender, e);
                            }
                        }
                    }
                    else
                    {
                        DialogBillDetails obj = new DialogBillDetails(id);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            if (MySearchType == "Load")
                            {
                                FrmVendorFinance2_Load_1(sender, e);
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
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 12);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            if (dataGridView1.Rows.Count > 0)
            {
                TblPrint pr = new TblPrint();
                pr.LoadAll();
                pr.DeleteAll();
                pr.Save();

                DialogResult d = MessageBox.Show("هل تريد بالتأكيد طباعة كشف الحساب الحالي", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (d == DialogResult.OK)
                {
                    string title = "كشف حساب المورد في المدة من " + dateTimePicker1.Text + " إلى " + dateTimePicker2.Text;
                    if (MySearchType == "Load")
                    {
                        title = "كشف حساب كامل للمورد";
                    }

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
                        obj.Column8 = MyVendorID.ToString();
                        obj.Column9 = title;
                        obj.Save();
                    }                   

                    FrmPrintVendorFinance x = new FrmPrintVendorFinance();
                    x.Show();
                }
            }
            else
            {
                MessageBox.Show("لا يوجد بيانات للطباعة");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

