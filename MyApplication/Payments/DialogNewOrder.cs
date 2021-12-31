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
using System.Drawing.Printing;
using System.IO;
using System.Drawing.Imaging;
namespace MyApplication
{
    public partial class DialogNewOrder : Form
    {        
        int MyBillID;        
        public DialogNewOrder(int CustBillID)
        {
            MyBillID = CustBillID;            
            
            InitializeComponent();
            comboCustomerType.SelectedIndex = comboBillType.SelectedIndex = comboBanks.SelectedIndex = 0;

            TblVat m = new TblVat();
            m.LoadByPrimaryKey(1);
            lblVatType.Text = "الضريبة " + m.s_Vat_Value + " % : ";
            VatValue = m.Vat_Value;
            VatPercent = m.Vat_Percent;


            TblGoodsCategory vv = new TblGoodsCategory();
            vv.LoadAll();
            if (vv.Query.Load())
            {
                comboCategory.ValueMember = TblGoodsCategory.ColumnNames.Ctaegory_ID;
                comboCategory.DisplayMember = TblGoodsCategory.ColumnNames.Category_Name;
                comboCategory.DataSource = vv.DefaultView;
            }
        }

        public void FillGoodsCombo()
        {
            TblGoodsTitles gt = new TblGoodsTitles();
            gt.LoadAll();
            if (gt.RowCount > 0)
            {
                gt.Sort = TblGoodsTitles.ColumnNames.Good_TraidName + " ASC";
                comboGoods.DisplayMember = TblGoodsTitles.ColumnNames.Good_TraidName;
                comboGoods.ValueMember = TblGoodsTitles.ColumnNames.Title_ID;
                comboGoods.DataSource = gt.DefaultView;

                if (GlobalVar.title_Id != 0)
                {
                    comboGoods.SelectedValue = GlobalVar.title_Id;
                    GlobalVar.title_Id = 0;
                }
            }
            else
            {
                MessageBox.Show("يجب إضافة أصناف قبل تسجيل الفاتورة");
                this.Close();
            }
        }

        double VatValue = 0;
        double VatPercent = 0;

        private void FrmNewOrder_Load(object sender, EventArgs e)
        {           
            ClassValidation qq = new ClassValidation(GlobalVar.user_Id, 21);
            if (qq.Allow == "no")
            {
                txtDiscount.Enabled = false;
            }

            ClassValidation kk = new ClassValidation(GlobalVar.user_Id, 41);
            if (kk.Allow == "no")
            {
                txtPayPrice.Enabled = false;
            }

            if (GlobalVar.user_Id == 1)
            {
                dateTimePicker1.Enabled = true;
            }


            FillGoodsCombo();
            comboPrice.SelectedIndex = 0;

            this.KeyPreview = true;

            lblBillNumber.Text = MyBillID.ToString();           
                     

            if (MyBillID != 0)
            {                
                TblCustomersBills obj = new TblCustomersBills();
                obj.LoadByPrimaryKey(MyBillID);
                txtNotes.Text = obj.Bill_Notes;

                lblVatType.Text = "الضريبة " + obj.s_Bill_Vat_Value + " % : ";
                VatValue = obj.Bill_Vat_Value;
                VatPercent = obj.Bill_Vat_Value / 100;

                txtPayBank.Text = obj.Pay_Bank.ToString();
                txtPayCash.Text = obj.Pay_Cash.ToString();
                dateTimePicker1.Text = obj.Bill_Date.ToShortDateString();
                comboBanks.Text = obj.Pay_Bank_Type;
                txtRefrence.Text = obj.Back_Refrence;



                if (obj.Customer_Id == 1)
                {
                    comboCustomerName.Text = obj.Bill_CustomerName;
                    txtMobile.Text = obj.Bill_CustomerPhone;
                    txtVatNumber.Text = obj.Bill_VatNumber;
                    txtAddress.Text = obj.Bill_Details;
                }
                else
                {
                    comboCustomerType.SelectedIndex = 1;
                    comboCustomerType_SelectedIndexChanged(sender, e);
                    comboCustomerName.SelectedValue = obj.Customer_Id;
                    txtMobile.Enabled = txtVatNumber.Enabled = txtAddress.Enabled = false;
                }

                comboBillType.Text = obj.Bill_Type;


                double Total = 0;
                ViewCustomerPayments py = new ViewCustomerPayments();
                py.Where.CustomerBill_Id.Value = MyBillID;
                if (py.Query.Load())
                {
                    do
                    {
                        Total += py.Pay_Total;
                        dataGridView1.Rows.Add(dataGridView1.RowCount + 1, py.Pay_ID, py.Barcode_Id, dataGridView1.Rows.Count + 1, py.Good_TraidName,
                  py.Barcode_Unit, py.PayCount, py.Pay_Price, py.Pay_Total, py.PayTotalAfterVat, py.Pay_Profit, "حذف");
                    } while (py.MoveNext());
                }

                lblBillTotal.Text = Total.ToString();

                ////---------------------------------load discount
                if (obj.Bill_DiscountType == "مبلغ")
                {
                    chekbxMoney.Checked = true;
                }
                else
                {
                    chekBoxPercent.Checked = true;
                }

                txtDiscount.Text = obj.Bill_Discount;
            }
            else
            {              
                dataGridView1.Rows.Clear();
                txtPayCash.Text = txtPayBank.Text = lblBillTotal.Text = lblRest.Text = txtDiscount.Text = lblTotalAfterVat.Text = lblVat.Text = lblTotalAfterDiscount.Text = "0";
                txtSearchGood.Focus();
            }

            GetBillTotal();

        }

        private void GetBillTotal()
        {
            double Vat = 0;
            double BillTotal = 0;
            double BillProfit = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                TblGoodsBarcode tt = new TblGoodsBarcode();
                tt.LoadByPrimaryKey(Convert.ToInt32(row.Cells["ColumnGoodID"].Value));

                double Total = Convert.ToDouble(row.Cells["ColumnPrice"].Value) * Convert.ToDouble(row.Cells["ColumnCount"].Value);
                row.Cells["ColumnTotal"].Value = Total.ToString("0.00");
                BillTotal += Total;
                row.Cells["ColumnAfterVat"].Value = (Total + (Total * VatPercent)).ToString("0.00");

                double Profit = Total - (double.Parse(tt.Barcode_BuyPrice) * Convert.ToDouble(row.Cells["ColumnCount"].Value));
                row.Cells["ColumnProfit"].Value = Profit.ToString("0.00");
                BillProfit += Convert.ToDouble(row.Cells["ColumnProfit"].Value);
            }
            lblBillTotal.Text = BillTotal.ToString("0,0.00");
            lblTotalProfit.Text = BillProfit.ToString("0,0.00");

            double TotalAfterDiscount = BillTotal - double.Parse(lblDiscount.Text);
            lblTotalAfterDiscount.Text = (TotalAfterDiscount).ToString("0,0.00");

            Vat = TotalAfterDiscount * (VatValue/100);
            
            lblVat.Text = Vat.ToString("0,0.00");

            lblTotalAfterVat.Text = (TotalAfterDiscount + Vat).ToString("0,0.00");

            if (txtPayBank.Text != "" && txtPayCash.Text != "" && txtPayBank.Text != "." && txtPayCash.Text != ".")
            {
                lblRest.Text = (double.Parse(lblTotalAfterVat.Text) - double.Parse(txtPayCash.Text) - double.Parse(txtPayBank.Text)).ToString("0,0.00");
            }
            else
            {
                lblRest.Text = "0";
            }
        }      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {                     
            TblGoodsBarcode obj = new TblGoodsBarcode();
            obj.Where.Titel_Id.Value = int.Parse(comboGoods.SelectedValue.ToString());
            if (obj.Query.Load())
            {
                obj.Sort = TblGoodsBarcode.ColumnNames.Barcode_Unit + " ASC";
                comboUnits.DisplayMember = TblGoodsBarcode.ColumnNames.Barcode_Unit;
                comboUnits.ValueMember = TblGoodsBarcode.ColumnNames.Barcode_ID;
                comboUnits.DataSource = obj.DefaultView;
            }                    
        }

        private void comboUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            TblGoodsBarcode bb = new TblGoodsBarcode();
            bb.LoadByPrimaryKey(int.Parse(comboUnits.SelectedValue.ToString()));
            BtnAddToBill.Visible = true;

            //TblCustomersData x = new TblCustomersData();
            //x.LoadByPrimaryKey(MyCustomerID);
            if (comboPrice.Text == "نقدي")
            {
                txtPayPrice.Text = bb.Barcode_PayPrice;
            }
            else
            {
                txtPayPrice.Text = bb.Barcode_PaySpecial;
            }

            if (comboCustomerType.Text== "عميل مسجل" && comboCustomerName.SelectedValue != null)
            {
                ViewCustomerPayments pp = new ViewCustomerPayments();
                pp.Where.Customer_Id.Value = comboCustomerName.SelectedValue;
                pp.Where.Barcode_Id.Value = bb.Barcode_ID;
                if (pp.Query.Load())
                {
                    pp.Sort = ViewCustomerPayments.ColumnNames.Bill_Date + " DESC";
                    txtPayPrice.Text = pp.s_Pay_Price;
                }
            }

            txtPayPrice_Leave(sender, e);

            txtCount.BackColor = Color.Lime;
            txtCount.Text = "1";
            lblInsideCount.Text = "العدد الداخلي : " + bb.Barcode_Count;
            lblBuy.Text = bb.Barcode_BuyPrice;

            ClassFollowGood cs = new ClassFollowGood(bb.Titel_Id);
            double currentcount = 0;
            if (cs.CurrentCount != 0)
            {
                currentcount = cs.CurrentCount / double.Parse(bb.Barcode_Count);
            }
            lblCurrentCount.Text = "رصيد الصنف : " + currentcount.ToString("0.00");

            if (currentcount > 0)
            {
                lblCurrentCount.BackColor = Color.Khaki;
            }
            else
            {
                lblCurrentCount.BackColor = Color.Tomato;

            }
        }

        private void txtPayPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnAddToBill_Click(sender, e);
            }
        }       

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtBarcode.Text != "")
                {
                    ViewGoods obj1 = new ViewGoods();
                    obj1.Where.Barcode_Code.Value = txtBarcode.Text;
                    if (obj1.Query.Load())
                    {
                        comboCategory.SelectedValue = obj1.Category_Id;        
                        comboGoods.SelectedValue = obj1.Titel_Id;
                        comboUnits.SelectedValue = obj1.Barcode_ID;                        

                        BtnAddToBill.Visible = true;

                        TblCustomersData x = new TblCustomersData();
                        x.LoadByPrimaryKey(MyCustomerID);
                        if (x.Customer_Type == "نقدي")
                        {
                            txtPayPrice.Text = obj1.Barcode_PayPrice;
                        }
                        else
                        {
                            txtPayPrice.Text = obj1.Barcode_PaySpecial;
                        }
                        txtCount.Text = "1";
                        

                        BtnAddToBill_Click(sender, e);
                        txtBarcode.Text = "";
                        txtBarcode.Focus();
                    }                
                }
            }
        }

        private void BtnAddToBill_Click(object sender, EventArgs e)
        {
            if (txtCount.Text != "" && txtPayPrice.Text != "" && txtCount.Text != "." && txtPayPrice.Text != "." && txtCount.Text != "0" && txtPayPrice.Text != "0" )
            {
                if (comboGoods.SelectedValue == null)
                {
                    MessageBox.Show("الصنف غير مسجل - تأكد من كتابة الصنف بشكل صحيح");
                    return;
                }

                if (comboBillType.Text == "فاتورة مرتجعات")
                {
                    if (txtRefrence.Text == "")
                    {
                        MessageBox.Show("تأكد من كتابة رقم المرجع");
                        return;
                    }

                    if (txtRefrence.Text != "0")
                    {
                        TblCustomerBillsPayments obj = new TblCustomerBillsPayments();
                        obj.Where.CustomerBill_Id.Value = int.Parse(txtRefrence.Text);
                        obj.Where.Barcode_Id.Value = int.Parse(comboUnits.SelectedValue.ToString());
                        obj.Where.Pay_Price.Value = txtPayPrice.Text;
                        if (obj.Query.Load())
                        {
                            if (double.Parse(txtCount.Text) > obj.PayCount)
                            {
                                MessageBox.Show("العدد المرتجع أكبر من العدد المباع");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("الصنف المرتجع غير موجود في فاتورة المبيعات");
                            return;
                        }
                    }

                }


                TblGoodsBarcode tt = new TblGoodsBarcode();
                tt.LoadByPrimaryKey(int.Parse(comboUnits.SelectedValue.ToString()));

                double total = double.Parse(txtPayPrice.Text) * double.Parse(txtCount.Text);
                double Profit = 0;
               
                     Profit = total - (double.Parse(tt.Barcode_BuyPrice) * double.Parse(txtCount.Text));

                dataGridView1.Rows.Add(dataGridView1.RowCount + 1, 0, tt.Barcode_ID, dataGridView1.Rows.Count + 1, comboGoods.Text,
                    tt.Barcode_Unit, txtCount.Text, txtPayPrice.Text, total, 0, Profit);

                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["ColumnCount"];
                dataGridView1.Focus();

                GetBillTotal();

                txtSearchGood.Text = "";
                comboGoods.Focus();
                txtCount.Text = "0";
            }
            else
            {
                MessageBox.Show("تأكد من كتابة بيانات الصنف بشكل صحيح");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (e.RowIndex >= 0)
                {
                    int RowID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnID"].Value.ToString());
                    if (e.ColumnIndex == dataGridView1.Columns["ColumnDelete"].Index)
                    {
                        if (RowID == 0)
                        {
                            dataGridView1.Rows.RemoveAt(e.RowIndex);

                            GetBillTotal();
                        }
                        else
                        {
                            DialogResult d = MessageBox.Show(" تأكيد الحذف ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (d == DialogResult.OK)
                            {

                                TblCustomerBillsPayments py = new TblCustomerBillsPayments();
                                py.LoadByPrimaryKey(RowID);
                                py.MarkAsDeleted();
                                py.Save();

                                dataGridView1.Rows.RemoveAt(e.RowIndex);

                                GetBillTotal();
                            }
                        }

                        int g = 0;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            ++g;
                            row.Cells["ColumnIndex"].Value = g.ToString();
                        }

                        this.dataGridView1.Sort(dataGridView1.Columns["ColumnIndex"], ListSortDirection.Descending);
                    }
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ColumnCount"].Value) == "" ||
                Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ColumnCount"].Value) == "." ||
                Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ColumnCount"].Value) == "0")
            {
                dataGridView1.Rows[e.RowIndex].Cells["ColumnCount"].Value = "1";
            }


            double count = double.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnCount"].Value.ToString());
            double PayPrice = double.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnPrice"].Value.ToString());

            TblGoodsBarcode tt = new TblGoodsBarcode();
            tt.LoadByPrimaryKey(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnGoodID"].Value.ToString()));

            double total = PayPrice * count;
            double Profit = total - (double.Parse(tt.Barcode_BuyPrice) * count);

            dataGridView1.Rows[e.RowIndex].Cells["ColumnTotal"].Value = total.ToString();
            dataGridView1.Rows[e.RowIndex].Cells["ColumnProfit"].Value = Profit.ToString();

            GetBillTotal();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;
            txt.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPayCash_TextChanged(object sender, EventArgs e)
        {
            if (txtPayBank.Text != "" && txtPayCash.Text != "" && txtPayBank.Text != "." && txtPayCash.Text != ".")
            {
                lblRest.Text = (double.Parse(lblTotalAfterVat.Text) - double.Parse(txtPayCash.Text) - double.Parse(txtPayBank.Text)).ToString("0,0.00");
            }
            else
            {
                lblRest.Text = "0";
            }
        }

        private void DialogNewOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                BtnSaveBill_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                BtnA4_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                BtnEpson_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F4)
            {
                txtDiscount.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                if (dataGridView1.Focus())
                {
                    SendKeys.SendWait("{ENTER}");
                    GetBillTotal();
                }
                txtPayCash.Text = (double.Parse(lblTotalAfterVat.Text) - double.Parse(txtPayBank.Text)).ToString();
                txtPayCash.Focus();
            }
            else if (e.KeyCode == Keys.F6)
            {
                e.SuppressKeyPress = true;

                if (dataGridView1.Focus())
                {
                    SendKeys.SendWait("{ENTER}");
                    GetBillTotal();
                }

                //txtPayCash.Text = "0";
                txtPayBank.Text = (double.Parse(lblTotalAfterVat.Text) - double.Parse(txtPayCash.Text)).ToString();
                txtPayBank.Focus();
            }
            else if (e.KeyCode == Keys.F7)
            {
                DialogNewOrder obj = new DialogNewOrder(0);
                obj.Show();
            }
            else if (e.KeyCode == Keys.F8)
            {
                if (lblTotalProfit.Visible == true)
                {
                    lblTotalProfit.Visible = false;
                }
                else
                {
                    lblTotalProfit.Visible = true;
                }
            }
        }      

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (chekbxMoney.Checked == true)
            {
                if (txtDiscount.Text != "" && txtDiscount.Text != ".")
                {
                    double total = double.Parse(lblBillTotal.Text);
                    double discount = double.Parse(txtDiscount.Text);

                    lblDiscount.Text = discount.ToString();

                    total -= double.Parse(lblDiscount.Text);

                    lblTotalAfterVat.Text = total.ToString();
                }

            }
            else if (chekBoxPercent.Checked == true)
            {
                if (txtDiscount.Text != "" && txtDiscount.Text != ".")
                {
                    double total = double.Parse(lblBillTotal.Text);
                    double percent = double.Parse(txtDiscount.Text) / 100;

                    percent = total * percent;
                    lblDiscount.Text = ((int)Math.Ceiling(percent)).ToString();

                    total -= double.Parse(lblDiscount.Text);

                    lblTotalAfterVat.Text = total.ToString();
                }
            }

            GetBillTotal();

            txtPayCash_TextChanged(sender, e);
        }

        private void DialogNewOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }     

        int MyCustomerID;
        private void comboCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCustomerType.Text == "عميل نقدي")
            {
                TblCustomersData obj = new TblCustomersData();
                obj.Where.Customer_ID.Value = 1;                
                if (obj.Query.Load())
                {
                    obj.Sort = TblCustomersData.ColumnNames.Customer_Name + " ASC";

                    comboCustomerName.DisplayMember = TblCustomersData.ColumnNames.Customer_Name;
                    comboCustomerName.ValueMember = TblCustomersData.ColumnNames.Customer_ID;
                    comboCustomerName.DataSource = obj.DefaultView;
                }

                MyCustomerID = 1;
                comboCustomerName.Enabled = txtMobile.Enabled = txtVatNumber.Enabled=txtAddress.Enabled= true;
                if (MyBillID == 0)
                {
                    comboCustomerName.Text = txtMobile.Text =txtAddress.Text= txtVatNumber.Text= "";
                }                
            }
            else
            {
                TblCustomersData obj = new TblCustomersData();
                obj.Where.Customer_ID.Value = 1;
                obj.Where.Customer_ID.Operator = WhereParameter.Operand.NotEqual;
                if (obj.Query.Load())
                {
                    obj.Sort = TblCustomersData.ColumnNames.Customer_Name + " ASC";

                    comboCustomerName.DisplayMember = TblCustomersData.ColumnNames.Customer_Name;
                    comboCustomerName.ValueMember = TblCustomersData.ColumnNames.Customer_ID;
                    comboCustomerName.DataSource = obj.DefaultView;
                }

                txtMobile.Enabled = txtVatNumber.Enabled=txtAddress.Enabled= false;
            }
        }

        private void comboBillType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBillType.Text == "فاتورة مرتجعات")
            {
                this.BackColor = Color.Khaki;
                txtRefrence.Enabled = true;
            }
            else if (comboBillType.Text == "عرض سعر")
            {
                this.BackColor = Color.PaleGreen;
                txtRefrence.Enabled = false;
            }
            else
            {
                this.BackColor = Color.White;
                txtRefrence.Enabled = false;
            }

            if (comboCustomerType.SelectedIndex == 0 && comboBillType.SelectedIndex == 1)
            {
                comboBillType.SelectedIndex = 0;
            }

            if (comboBillType.Text == "عرض سعر")
            {
                txtPayBank.Enabled = txtPayCash.Enabled = false;
                txtPayBank.Text = txtPayCash.Text = "0";
            }
            else
            {
                txtPayBank.Enabled = txtPayCash.Enabled = true;
            }
        }

        private void comboCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCustomerType.SelectedIndex == 1)
            {
                TblCustomersData obj = new TblCustomersData();
                obj.LoadByPrimaryKey(int.Parse( comboCustomerName.SelectedValue.ToString()));
                txtMobile.Text = obj.Customer_Mobile;
                txtAddress.Text = obj.Customer_Address;
                txtVatNumber.Text = obj.Customer_VatNumber;
                MyCustomerID = obj.Customer_ID;
            }
        }

        private void lnkDeleteBill_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (GlobalVar.user_Id != 1)
            {
                MessageBox.Show("غير مسموح لك حذف الفاتورة");
                return;
            }

            DialogResult d = MessageBox.Show(" تأكيد الحذف ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {
                TblCustomerBillsPayments obj = new TblCustomerBillsPayments();
                obj.Where.CustomerBill_Id.Value = MyBillID;
                if (obj.Query.Load())
                {
                    obj.DeleteAll();
                    obj.Save();
                }

                TblCustomersBills cs = new TblCustomersBills();
                cs.LoadByPrimaryKey(MyBillID);
                cs.MarkAsDeleted();
                cs.Save();

                MessageBox.Show("تم الحذف");
                this.Close();
            }
        }

        private void txtSearchGood_TextChanged(object sender, EventArgs e)
        {
            TblGoodsTitles obj = new TblGoodsTitles();
            if (txtSearchGood.Text != "")
            {
                obj.Where.Good_TraidName.Value = "%" + txtSearchGood.Text + "%";
                obj.Where.Good_TraidName.Operator = WhereParameter.Operand.Like;
            }
            if (obj.Query.Load())
            {
                obj.Sort = TblGoodsTitles.ColumnNames.Good_TraidName + " ASC";
                comboGoods.ValueMember = TblGoodsTitles.ColumnNames.Title_ID;
                comboGoods.DisplayMember = TblGoodsTitles.ColumnNames.Good_TraidName;
                comboGoods.DataSource = obj.DefaultView;

                if (comboGoods.Items.Count <= 15)
                {
                    comboGoods.DroppedDown = true;
                }
            }

            comboBox1_SelectedIndexChanged(sender, e);
        }

        private void BtnSeachCustomer_Click(object sender, EventArgs e)
        {
            Payments.DialogSearchCustomer obj = new Payments.DialogSearchCustomer();
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                comboCustomerType_SelectedIndexChanged(sender, e);
            }
        }

        private void txtSearchGood_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox cb = (ComboBox)sender;
            //if (!cb.Focused)
            //{
            //    return;
            //}

            TblGoodsTitles gt = new TblGoodsTitles();
            if (int.Parse(comboCategory.SelectedValue.ToString()) != 1)
            {
                gt.Where.Category_Id.Value = int.Parse(comboCategory.SelectedValue.ToString());
            }
            if (gt.Query.Load())
            {
                gt.Sort = TblGoodsTitles.ColumnNames.Good_TraidName + " ASC";
                comboGoods.DisplayMember = TblGoodsTitles.ColumnNames.Good_TraidName;
                comboGoods.ValueMember = TblGoodsTitles.ColumnNames.Title_ID;
                comboGoods.DataSource = gt.DefaultView;

                if (GlobalVar.title_Id != 0)
                {
                    comboGoods.SelectedValue = GlobalVar.title_Id;
                    GlobalVar.title_Id = 0;
                }
            }
        }

        private void BtnNewGood_Click(object sender, EventArgs e)
        {
            DialogAddGood obj = new DialogAddGood(0);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                FillGoodsCombo();
                txtCount.Focus();
            }
        }

        private void txtAfterVat_TextChanged(object sender, EventArgs e)
        {
            if (txtAfterVat.Text != "" && txtAfterVat.Text != "0")
            {
                chekbxMoney.Checked = true;

                double BillTotalAfterVat = double.Parse(txtAfterVat.Text);
                double BeforeVat = BillTotalAfterVat / (1 + VatPercent);
                double Vat = BillTotalAfterVat - BeforeVat;

                lblVat.Text = Vat.ToString("0.000");
                lblTotalAfterDiscount.Text = BeforeVat.ToString("0.000");

                lblDiscount.Text = txtDiscount.Text = (double.Parse(lblBillTotal.Text) - double.Parse(lblTotalAfterDiscount.Text)).ToString("0.000");

                lblTotalAfterVat.Text = (double.Parse(lblTotalAfterDiscount.Text) + double.Parse(lblVat.Text)).ToString("0,0.000");

                //lblRest.Text = (double.Parse(lblTotalAfterVat.Text) - double.Parse(lblPay.Text)).ToString("0,0.00");
            }
            else
            {
                lblDiscount.Text = "0";
                GetBillTotal();
            }
        }

        private void SaveBill(string PrintType)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }

            if (comboCustomerType.SelectedIndex == 1 && comboCustomerName.SelectedValue ==  null)
            {
                MessageBox.Show("تأكد من كتابة اسم العميل بشكل صحيح");
                return;
            }

            if (txtPayBank.Text == "" && txtPayCash.Text == "" && txtPayBank.Text == "." && txtPayCash.Text == ".")
            {
                MessageBox.Show("تأكد من كتابة المبلغ المدفوع بشكل صحيح");
                return;
            }

            double pays = double.Parse(txtPayBank.Text) + double.Parse(txtPayCash.Text);
            if ((double.Parse(lblTotalAfterVat.Text) - pays) > 1)
            {
                if (comboBillType.SelectedIndex == 0 && comboBillType.Text != "عرض سعر") // فاتورة نقداً
                {
                    MessageBox.Show("تأكد من كتابة المبلغ المدفوع بشكل صحيح");
                    return;
                }

                if (comboCustomerType.SelectedIndex == 0 && comboBillType.Text != "عرض سعر") // عميل نقدي
                {
                    MessageBox.Show("تأكد من كتابة المبلغ المدفوع بشكل صحيح");
                    return;
                }

            }

            if (double.Parse(txtPayBank.Text) > double.Parse(lblTotalAfterVat.Text))
            {
                MessageBox.Show("تأكد من كتابة المبلغ المدفوع بشكل صحيح");
                return;
            }


            TblCustomersBills obj = new TblCustomersBills();

            if (MyBillID == 0)
            {
                obj.AddNew();
                ClassGetBillNumber cs = new ClassGetBillNumber();
                obj.Bill_ID = cs.MyBillNumber;
            }
            else
            {
                obj.LoadByPrimaryKey(MyBillID);
            }
            obj.Bill_CustomerName = comboCustomerName.Text;
            obj.Bill_CustomerPhone = txtMobile.Text;
            obj.Bill_VatNumber = txtVatNumber.Text;

            obj.User_Id = GlobalVar.user_Id;
            obj.Customer_Id = MyCustomerID;
            obj.Bill_Date = DateTime.Parse(dateTimePicker1.Text).Date;
            obj.Bill_Time = DateTime.Now.ToShortTimeString();
            obj.Bill_Type = comboBillType.Text;
            obj.Bill_DiscountType = "مبلغ";

            if (comboCustomerType.SelectedIndex == 0 && comboBillType.Text != "عرض سعر") // عميل نقدي
            {
                obj.Pay_Cash = double.Parse(lblTotalAfterVat.Text) - double.Parse(txtPayBank.Text);
                obj.Pay_Bank = double.Parse(txtPayBank.Text);
            }
            else
            {
                obj.Pay_Cash = double.Parse(txtPayCash.Text);
                obj.Pay_Bank = double.Parse(txtPayBank.Text);
            }


            obj.Bill_DiscountMoney = double.Parse(lblDiscount.Text);
            obj.Bill_Discount = txtDiscount.Text;
            if (chekbxMoney.Checked == true)
            {
                obj.Bill_DiscountType = "مبلغ";
            }
            else
            {
                obj.Bill_DiscountType = "نسبة";
            }
            obj.Bill_Notes = txtNotes.Text;
            obj.Bill_Vat = double.Parse(lblVat.Text);
            obj.Bill_Details = txtAddress.Text;
            obj.Bill_Vat_Value = VatValue;
            obj.Pay_Bank_Type = comboBanks.Text;
            obj.Customer_Pay = txtPayCash.Text;
            obj.Customer_Rest = (double.Parse(lblRest.Text) * -1).ToString();
            obj.Back_Refrence = txtRefrence.Text;
            obj.Save();

            double Fees = 0;
            if (comboBanks.SelectedIndex == 0)
            {
                Fees = 0.008 * obj.Pay_Bank;
                Fees = Fees + (Fees * (obj.Bill_Vat_Value / 100));
            }
            else if (comboBanks.SelectedIndex == 1)
            {
                Fees = 0.025 * obj.Pay_Bank;
                Fees = Fees + (Fees * (obj.Bill_Vat_Value / 100));
            }

            obj.Pay_Bank_Fees = Fees;
            obj.Save();


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                TblCustomerBillsPayments py = new TblCustomerBillsPayments();
                if (row.Cells["ColumnID"].Value.ToString() == "0")
                {
                    py.AddNew();
                }
                else
                {
                    py.LoadByPrimaryKey(int.Parse(row.Cells["ColumnID"].Value.ToString()));
                }
                py.CustomerBill_Id = obj.Bill_ID;
                py.Barcode_Id = int.Parse(row.Cells["ColumnGoodID"].Value.ToString());
                py.Pay_Price = double.Parse(row.Cells["ColumnPrice"].Value.ToString());
                py.PayCount = double.Parse(row.Cells["ColumnCount"].Value.ToString());
                py.Pay_Profit = double.Parse(row.Cells["ColumnProfit"].Value.ToString());
                py.Save();

                TblGoodsBarcode bb = new TblGoodsBarcode();
                bb.LoadByPrimaryKey(py.Barcode_Id);

                ClassFollowGood cs = new ClassFollowGood(bb.Titel_Id);
            }


            if (PrintType == "A4")
            {
                FrmPrintBillA4 pp = new FrmPrintBillA4(obj.Bill_ID);
                pp.ShowDialog();
            }
            else if (PrintType == "Epson")
            {
                //FrmPrintBillEpson pp = new FrmPrintBillEpson(obj.Bill_ID);
                //pp.ShowDialog();

                //MyBillID = obj.Bill_ID;

                //PrintDocument pd2 = new PrintDocument();
                //pd2.DefaultPageSettings.PrinterSettings.Copies = 1;
                //pd2.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                //pd2.Print();

                //PrintPreviewDialog pv = new PrintPreviewDialog();
                //pv.Document = pd2;
                //pv.Width = 1300;
                //pv.Height = 900;
                //pv.ShowDialog();
            }

            this.Close();


            //DialogNewOrder yy = new DialogNewOrder(0);
            //yy.Show();

        }

        private void BtnSaveBill_Click(object sender, EventArgs e)
        {
            SaveBill("none");
        }

        private void BtnA4_Click(object sender, EventArgs e)
        {
            SaveBill("A4");
        }

        private void BtnEpson_Click(object sender, EventArgs e)
        {
            //SaveBill("Epson");
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            ClassPrintCashirBill cs = new ClassPrintCashirBill();
            cs.printDocument1_PrintPage(sender, e, MyBillID);
        }

        private void txtPayPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPayPrice.Text != "" && txtCount.Text != "" && txtPayPrice.Text != "." && txtCount.Text != ".")
            {
                lblGoodTotal.Text = (double.Parse(txtCount.Text) * double.Parse(txtPayPrice.Text)).ToString("0.000");
                lblGoodAfterVat.Text = (double.Parse(lblGoodTotal.Text) + double.Parse(lblGoodTotal.Text) * VatPercent).ToString("0.000");
            }
        }

        private void txtPayPrice_Leave(object sender, EventArgs e)
        {
            if (txtPayPrice.Text != "" && txtCount.Text != "" && txtPayPrice.Text != "." && txtCount.Text != ".")
            {
               txtPayAfterVat.Text =( double.Parse(txtPayPrice.Text) + VatPercent * double.Parse(txtPayPrice.Text)).ToString("0.000");
            }
        }

        private void txtPayAfterVat_TextChanged(object sender, EventArgs e)
        {
            if (txtPayPrice.Text != "" && txtCount.Text != "" && txtPayPrice.Text != "." && txtCount.Text != ".")
            {
                txtPayPrice.Text = (double.Parse(txtPayAfterVat.Text) / (1 + VatPercent)).ToString("0.000");
            }
        }

        private void txtRefrence_TextChanged(object sender, EventArgs e)
        {
            if (MyBillID == 0)
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void txtRefrence_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
