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
namespace MyApplication
{
    public partial class FrmSearchPayments : Form
    {
        string MySearchType;
       
        public FrmSearchPayments()
        {
            InitializeComponent();
        }

        private void BtnSearchByDay_Click(object sender, EventArgs e)
        {
            MySearchType = "date";
            FillMyGrid();
        }

        private void FrmSearchPayments_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            TblUsers zz = new TblUsers();
            zz.LoadAll();
            if (zz.RowCount > 0)
            {
                ComboUser.DisplayMember = TblUsers.ColumnNames.User_Name;
                ComboUser.ValueMember = TblUsers.ColumnNames.User_ID;
                ComboUser.DataSource = zz.DefaultView;
            }
            MySearchType = "date";
            FillMyGrid();            
        }

        private void FillMyGrid()
        {
            dataGridView1.Rows.Clear();

            double TotalKash = 0, TotalBank = 0;
            double Payments = 0, PaymentsVat = 0, TotalPayments = 0;
            double Backs = 0, BacksVat = 0, TotalBacks = 0;
           
            ViewCustomerBills obj = new ViewCustomerBills();
            if (MySearchType == "date")
            {
                obj.Where.Bill_Date.BetweenBeginValue = DateTime.Parse(dtpfrom.Text);
                obj.Where.Bill_Date.BetweenEndValue = DateTime.Parse(dtpto.Text);
                obj.Where.Bill_Date.Operator = WhereParameter.Operand.Between;

                if (checkBox2.Checked == true)
                {
                    obj.Where.User_Id.Value = int.Parse(ComboUser.SelectedValue.ToString());
                }
            }
            else if (MySearchType == "id")
            {
                obj.Where.Bill_ID.Value = int.Parse(txtBillNumber.Text);
            }
            else if (MySearchType == "mobile")
            {
                obj.Where.Bill_CustomerPhone.Value = txtMobile.Text;
            }
            else if (MySearchType == "name")
            {
                obj.Where.Bill_CustomerName.Value = "%" + txtName.Text + "%";
                obj.Where.Bill_CustomerName.Operator = WhereParameter.Operand.Like;
            }
            if (obj.Query.Load())
            {
                int g = 0;
                do
                {
                    ClassCustomerBillTotal cs = new ClassCustomerBillTotal(obj.Bill_ID);
                    if (obj.Bill_Type.Contains("فاتورة مبيعات"))
                    {
                        TotalKash += cs.KashPay;
                        TotalBank += cs.BankPay;

                        Payments += cs.BillTotalAfterDiscount;
                        PaymentsVat += obj.Bill_Vat;
                        TotalPayments += cs.BillTotalAfterVat;
                    }
                    else if (obj.Bill_Type.Contains("فاتورة مرتجعات"))
                    {
                        TotalKash -= cs.KashPay;
                        Backs += cs.BillTotalAfterDiscount;
                        BacksVat += obj.Bill_Vat;
                        TotalBacks += cs.BillTotalAfterVat;
                    }
                    ++g;
                    dataGridView1.Rows.Add(g, obj.Bill_Date.ToShortDateString(), obj.Bill_Type, obj.Bill_ID, cs.BillCustomerName,

                        cs.BillTotalAfterDiscount.ToString("0,0.00"), obj.Bill_Vat.ToString("0,0.00"),
                        cs.BillTotalAfterVat.ToString("0,0.00"), obj.Pay_Cash.ToString("0,0.00"), obj.Pay_Bank.ToString("0,0.00"),
                        cs.BillRest.ToString("0,0.00"), obj.User_Name, "عرض التفاصيل");
                } while (obj.MoveNext());
            }

            lblTotalKash.Text = TotalKash.ToString("0,0.00");
            lblTotalBank.Text = TotalBank.ToString("0,0.00");

            lblPayments.Text = Payments.ToString("0,0.00");
            lblPaymentsVat.Text = PaymentsVat.ToString("0,0.00");
            lblPaymentsTotal.Text = TotalPayments.ToString("0,0.00");

            lblBacks.Text = Backs.ToString("0,0.00");
            lblBacksVat.Text = BacksVat.ToString("0,0.00");
            lblBackTotal.Text = TotalBacks.ToString("0,0.00");

            lblTotal1.Text = (Payments-Backs).ToString("0,0.00");
            lblTotal2.Text = (PaymentsVat - BacksVat).ToString("0,0.00");
            lblTotal3.Text = (TotalPayments - TotalBacks).ToString("0,0.00");

            dataGridView1.ClearSelection();
        }    
       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && txtBillNumber.Text != "")
            {
                MySearchType = "id";
                FillMyGrid();
            }
        }       

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Column7"].Value);
            TblCustomersBills obj = new TblCustomersBills();
            obj.Where.Bill_ID.Value = id;
            if (obj.Query.Load())
            {
                if (obj.Bill_Type == "فاتورة مرتجعات")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (obj.Bill_Type == "عرض سعر")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleGreen;
                }               
            }

            if (Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["Column12"].Value) > 1)
            {
                dataGridView1.Rows[e.RowIndex].Cells["Column12"].Style.BackColor = Color.Tomato;                
            }

            if (Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["Column5"].Value) > 1)
            {
                dataGridView1.Rows[e.RowIndex].Cells["Column5"].Style.BackColor = Color.Lime;
            }
        }      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (e.RowIndex >= 0)
                {
                    int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column7"].Value.ToString());
                    if (e.ColumnIndex == dataGridView1.Columns["Column9"].Index)  // عرض التفاصيل
                    {
                        Payments.DialogPaymentBillDetails obj = new Payments.DialogPaymentBillDetails(id);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            FillMyGrid();
                        }
                    }                    
                }
            }
        }

        private void BtnNewBill_Click(object sender, EventArgs e)
        {
            DialogNewOrder x = new DialogNewOrder(0);
            x.Show();
        }

        private void FrmSearchPayments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                BtnNewBill_Click(sender, e);
            }
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtMobile.Text != "")
            {
                MySearchType = "mobile";
                FillMyGrid();
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            BtnSearchByDay_Click(sender, e);

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
                    obj.Column1 = Convert.ToString(row.Cells["Column4"].Value);
                    obj.Column2 = Convert.ToString(row.Cells["Column11"].Value);
                    obj.Column3 = Convert.ToString(row.Cells["Column7"].Value);
                    obj.Column4 = Convert.ToString(row.Cells["Column13"].Value);
                    obj.Column5 = Convert.ToString(row.Cells["Column8"].Value);
                    obj.Column6 = Convert.ToString(row.Cells["Column6"].Value);
                    obj.Column7 = Convert.ToString(row.Cells["Column10"].Value);
                    obj.Column8 = "تقرير عن المبيعات خلال الفترة من : " + dtpfrom.Text + " إلى: " + dtpto.Text;

                    if (checkBox2.Checked == true)
                    {
                        obj.Column8 += " للمستخدم: " + ComboUser.Text;
                    }

                    obj.Column9 = lblPayments.Text;
                    obj.Column10 = lblPaymentsVat.Text;
                    obj.Column11 = lblPaymentsTotal.Text;

                    obj.Column12 = lblBacks.Text;
                    obj.Column13 = lblBacksVat.Text;
                    obj.Column14 = lblBackTotal.Text;

                    obj.Column15 = lblTotal1.Text;
                    obj.Column16 = lblTotal2.Text;
                    obj.Column17 = lblTotal3.Text;
                    obj.Save();
                }

                FrmPrintPayments x = new FrmPrintPayments();
                x.ShowDialog();
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtName.Text != "")
            {
                MySearchType = "name";
                FillMyGrid();
            }
        }
    }
}
