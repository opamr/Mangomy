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

namespace MyApplication.Vendors
{
    public partial class DialogNewBill : Form
    {        
        int MyBillID;      
        public DialogNewBill(int BillId)
        {
            MyBillID = BillId;
            InitializeComponent();
            comboType.SelectedIndex = 0;

            TblBanks y = new TblBanks();
            y.LoadAll();
            if (y.RowCount > 0)
            {
                comboBanks.DisplayMember = TblBanks.ColumnNames.Bank_Name;
                comboBanks.ValueMember = TblBanks.ColumnNames.Bank_ID;
                comboBanks.DataSource = y.DefaultView;
            }
        }

        double VatValue = 0;

        private void FrmNewGoods_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;   //---------------- لتفعيل الإختصارات

            ////-----------------------------load Vendors
            TblVendorsData vv = new TblVendorsData();
            vv.LoadAll();
            if (vv.Query.Load())
            {
                comboVendors.ValueMember = TblVendorsData.ColumnNames.Vendor_ID;
                comboVendors.DisplayMember = TblVendorsData.ColumnNames.Vendor_Name;
                comboVendors.DataSource = vv.DefaultView;
            }
            else
            {
                MessageBox.Show("يجب إضافة موردين قبل تسجيل الفاتورة");
                this.Close();
            }           

            ////-----------------------------load combo CurrentGoods
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

                BtnAddToBill.Enabled = true;
            }
            else
            {
                BtnAddToBill.Enabled = false;
            }

            //-----------------------------------------------تحميل الفاتورة
            if (MyBillID != 0)
            {
                BtnDeleteBill.Visible = true;

                //-----------------------------------------------------إنشاء الفاتورة
                TblVendorsBills obj = new TblVendorsBills();
                obj.LoadByPrimaryKey(MyBillID);

                lblVatType.Text = "الضريبة " + obj.s_Bill_Vat_Value + " % : ";
                VatValue = obj.Bill_Vat_Value;

                comboType.Text = obj.Bill_PayType;
                comboVendors.SelectedValue = obj.Bill_VendorId;
                txtSender.Text = obj.Bill_Sender;
                txtDetails.Text = obj.Bill_Details;
                txtVendorBillNumber.Text = obj.Bill_VendorNumber;
                dateTimePicker1.Text = obj.Bill_Date.ToShortDateString();
                lblDiscount.Text = obj.Bill_Discount_Money.ToString();
                txtDiscount.Text = obj.Bill_Discount.ToString();
                txtVat.Text = obj.Bill_Vat.ToString();
                comboBanks.SelectedValue = obj.Bank_Id;
                if (obj.Bill_DiscountType == "مبلغ")
                {
                    chekbxMoney.Checked = true;
                }
                else
                {
                    chekBoxPercent.Checked = true;
                }

                if (txtVat.Text != "0")
                {
                    checkBox1.Checked = true;
                }

                ViewVendorsGoods py = new ViewVendorsGoods();
                py.Where.Bill_id.Value = MyBillID;
                if (py.Query.Load())
                {
                    do
                    {
                        dataGridView1.Rows.Add(py.Good_id, py.Titel_Id, py.Barcode_Id, dataGridView1.Rows.Count + 1, py.Barcode_Code,
                            py.Good_TraidName, py.Barcode_Unit, py.Good_Count, py.Good_Price.ToString("0.000"), py.Good_Total.ToString("0.000"),
                            py.Good_FreeBones, py.Barcode_PayPrice, py.Barcode_BuyPrice, "X");
                    } while (py.MoveNext());
                }
            }
            else
            {
                TblVat qq = new TblVat();
                qq.LoadByPrimaryKey(1);
                lblVatType.Text = "الضريبة " + qq.s_Vat_Value + " % : ";
                VatValue = qq.Vat_Value;
            }

            GetBillTotal();            

            txtBarcode.Text = "";
            txtBarcode.Focus();
            
        }
        private void BtnNewGood_Click(object sender, EventArgs e)
        {
            DialogAddGood obj = new DialogAddGood(0);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                FrmNewGoods_Load(sender, e);
            }
        }      

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtUnitPrice.Text = txtCount.Text = txtPayPrice.Text = "";
        }

        private void BtnAddToBill_Click(object sender, EventArgs e)
        {
            if (txtCount.Text =="0" || txtUnitPrice.Text == "0" )
            {
                txtCount.Focus();
                return;
            }

            if (comboGoods.SelectedValue == null)
            {
                MessageBox.Show("الصنف غير مسجل - تأكد من كتابة الصنف بشكل صحيح");
                return;
            }

            dataGridView1.Rows.Add(0,comboGoods.SelectedValue, comboUnits.SelectedValue, dataGridView1.Rows.Count+1, txtBarcode.Text, comboGoods.Text,
                comboUnits.Text, txtCount.Text, txtUnitPrice.Text, lblGoodTotal.Text, txtBones.Text, txtPayPrice.Text, txtAverge.Text, "X");

            lblBillTotal.Text = (double.Parse(lblBillTotal.Text) + double.Parse(lblGoodTotal.Text)).ToString();

            txtDiscount_TextChanged_1(sender, e);

            txtCount.Text = txtUnitPrice.Text = "0";
            txtBarcode.Text = "";
            txtBarcode.Focus();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {           
            TblGoodsBarcode obj = new TblGoodsBarcode();
            obj.Where.Titel_Id.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnTitleID"].Value.ToString());
            if (obj.Query.Load())
            {               
                BindingList<string> lists = new BindingList<string>();

                do
                {
                    lists.Add(obj.Barcode_Unit);
                } while (obj.MoveNext());

                DataGridViewComboBoxCell box = dataGridView1.Rows[e.RowIndex].Cells["ColumnType"] as DataGridViewComboBoxCell;
                box.DataSource = lists;               
            }
        }      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboGoods.Items.Count > 0)
            {
                TblGoodsBarcode obj = new TblGoodsBarcode();
                obj.Where.Titel_Id.Value = int.Parse(comboGoods.SelectedValue.ToString());
                if (obj.Query.Load())
                {
                    comboUnits.DisplayMember = TblGoodsBarcode.ColumnNames.Barcode_Unit;
                    comboUnits.ValueMember = TblGoodsBarcode.ColumnNames.Barcode_ID;
                    comboUnits.DataSource = obj.DefaultView;

                    ClassFollowGood cs = new ClassFollowGood(obj.Titel_Id);
                    lblCurrentRest.Text = cs.CurrentCount.ToString();
                }              
            }
                  
        }                    

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            var text = txtCount.Text;

            double num;
            double.TryParse(text, out num);

            if (num.ToString() == "0")
            {
                return;
            }

            if (txtCount.Text != "" && txtUnitPrice.Text != "" && txtBones.Text != "")
            {
                lblGoodTotal.Text = (double.Parse(txtCount.Text) * double.Parse(txtUnitPrice.Text)).ToString();

                //---------Averge
                double last = double.Parse(lblCurrentRest.Text) * double.Parse(lblGoodBuy.Text);
                double now = double.Parse(txtCount.Text) * double.Parse(txtUnitPrice.Text);

                double z1 = last + now;
                double z2 = double.Parse(txtCount.Text) + double.Parse(lblCurrentRest.Text) + double.Parse(txtBones.Text);

                if (z1 == 0 || z2 == 0)
                {
                    txtAverge.Text =txtUnitPrice.Text;
                }
                else
                {
                    txtAverge.Text = (z1 / z2).ToString("0.00");
                }

            }
            else
            {
                lblGoodTotal.Text = "0";
                txtAverge.Text = "";
            }          
        }       
      
        private void chekbxMoney_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text != "")
            {
                GetBillTotal();
            }
        }

        private void chekBoxPercent_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text != "")
            {               
                GetBillTotal();
            }
        }

        private void txtDiscount_TextChanged_1(object sender, EventArgs e)
        {
            if (txtDiscount.Text != "")
            {
                GetBillTotal();
            }
        }

        private void GetBillTotal()
        {
            double BillTotal = 0;
            double Discount = 0;
            double BillTotalAfterDiscount = 0;
            double Vat = 0;            

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                BillTotal += double.Parse(row.Cells["ColumnTotal"].Value.ToString());
            }

            if (chekbxMoney.Checked == true)
            {
                if (txtDiscount.Text != "")
                {                    
                    Discount = double.Parse(txtDiscount.Text);                 
                }

            }
            else if (chekBoxPercent.Checked == true)
            {
                if (txtDiscount.Text != "")
                {                                        
                    Discount = BillTotal * (double.Parse(txtDiscount.Text) / 100);                  
                }
            }

            BillTotalAfterDiscount = BillTotal - Discount;
            Vat = BillTotalAfterDiscount * (VatValue / 100);

            lblBillTotal.Text = BillTotal.ToString("0,0.00");
            lblDiscount.Text = Discount.ToString("0,0.00");
            lblTotalAfterDiscount.Text = BillTotalAfterDiscount.ToString("0,0.00");
            lblVat.Text = Vat.ToString("0,0.00");

            if (checkBox1.Checked == true)
            {
                txtVat.Text = lblVat.Text;
            }

            lblAfterVat.Text = (BillTotalAfterDiscount + double.Parse(txtVat.Text)).ToString("0,0.00");
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            if (txtDiscount.Text == "")
            {
                txtDiscount.Text = "0";
                GetBillTotal();
            }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtBarcode.Text != "")
                {
                    ViewGoods obj = new ViewGoods();
                    obj.Where.Barcode_Code.Value = txtBarcode.Text;
                    if (obj.Query.Load())
                    {
                        comboGoods.SelectedValue = obj.Titel_Id;
                        comboBox1_SelectedIndexChanged(sender, e);

                        comboUnits.SelectedValue = obj.Barcode_ID;
                        comboBox2_SelectedIndexChanged(sender, e);
                        
                        txtCount.Focus();
                    }
                    else
                    {
                        MessageBox.Show("رقم غير موجود");
                        txtBarcode.Text = "";
                        txtBarcode.Focus();
                    }
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TblGoodsBarcode bb = new TblGoodsBarcode();
            bb.LoadByPrimaryKey(int.Parse(comboUnits.SelectedValue.ToString()));
            lblGoodBuy.Text = txtUnitPrice.Text = bb.Barcode_BuyPrice;
            txtPayPrice.Text = bb.Barcode_PayPrice;
            txtBarcode.Text = bb.Barcode_Code;
        }

        private void comboVendors_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (comboVendors.Text != "")
                {
                    comboVendors.DataSource = null;

                    TblVendorsData obj = new TblVendorsData();
                    obj.Where.Vendor_Name.Value = "%" + comboVendors.Text + "%";
                    obj.Where.Vendor_Name.Operator = WhereParameter.Operand.Like;
                    if (obj.Query.Load())
                    {                        
                        comboVendors.ValueMember = TblVendorsData.ColumnNames.Vendor_ID;
                        comboVendors.DisplayMember = TblVendorsData.ColumnNames.Vendor_Name;
                        comboVendors.DataSource = obj.DefaultView;
                    }
                }
            }
        }

        private void comboVendors_Leave(object sender, EventArgs e)
        {
            TblVendorsData obj = new TblVendorsData();
            obj.Where.Vendor_Name.Value = comboVendors.Text;
            if (obj.Query.Load())
            {
                BtnSaveBill.Enabled = true;
                txtSender.Text = obj.Vendor_SenderName;
                comboVendors.BackColor = Color.White;
            }
            else
            {
                BtnSaveBill.Enabled = false;
                txtSender.Text = "";
                comboVendors.BackColor = Color.Red;
            }
        }

        private void txtCount_Leave(object sender, EventArgs e)
        {
            var text = (sender as TextBox).Text;

            if (sender is TextBox && text != "0")
            {                
                double num;
                double.TryParse(text, out num);

                if (num.ToString() != "0")
                {
                    (sender as TextBox).BackColor = Color.Yellow;
                    BtnAddToBill.Enabled = true;
                }
                else
                {
                    (sender as TextBox).BackColor = Color.Red;
                    (sender as TextBox).Focus();
                    BtnAddToBill.Enabled = false;
                }
            }
        }

        private void BtnDeleteBill_Click(object sender, EventArgs e)
        {           
            DialogResult d = MessageBox.Show("هل تريد بالتأكيد حذف الفاتورة بكامل محتوياتها", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {
                TblVendorsBillGoods obj = new TblVendorsBillGoods();
                obj.Where.Bill_id.Value = MyBillID;
                if (obj.Query.Load())
                {
                    obj.DeleteAll();
                    obj.Save();
                }

                TblVendorsBills bb = new TblVendorsBills();
                bb.LoadByPrimaryKey(MyBillID);
                bb.MarkAsDeleted();
                bb.Save();

                this.Close();
            }
        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        private void DialogNewBill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5 && BtnAddToBill.Enabled == true)
            {
                BtnAddToBill_Click(sender, e);
            }        
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

            if (text != "0" && e.ColumnIndex != 6)
            {
                double num;
                double.TryParse(text, out num);

                if (num.ToString() == "0")
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0";
                }
            }

            double BillTotal = 0;

            string Count = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ColumnCount"].Value);
            string UnitPrice = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ColumnUnitPrice"].Value);

            double total = double.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnCount"].Value.ToString()) * double.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnUnitPrice"].Value.ToString());
            BillTotal += total;
            lblBillTotal.Text = BillTotal.ToString("0.00");

            dataGridView1.Rows[e.RowIndex].Cells["ColumnTotal"].Value = total.ToString();

            string Type = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ColumnType"].Value);

            string Bones = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ColumnBones"].Value);

            TblGoodsBarcode gg = new TblGoodsBarcode();
            gg.Where.Barcode_Unit.Value = Type;
            gg.Where.Titel_Id.Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ColumnTitleID"].Value);
            if (gg.Query.Load())
            {
                dataGridView1.Rows[e.RowIndex].Cells["ColumnBarcodeID"].Value = gg.Barcode_ID;
                dataGridView1.Rows[e.RowIndex].Cells["ColumnBarcode"].Value = gg.Barcode_Code;

                //---------Averge
                double last = double.Parse(lblCurrentRest.Text) * double.Parse(gg.Barcode_BuyPrice);
                double now = double.Parse(Count) * double.Parse(UnitPrice);

                double z1 = last + now;
                double z2 = double.Parse(Count) + double.Parse(lblCurrentRest.Text) + double.Parse(Bones);

                dataGridView1.Rows[e.RowIndex].Cells["ColumnAverge"].Value = (z1 / z2).ToString("0.00");
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }            
        }           

        private void BtnSaveBill_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count ==0)
            {
                MessageBox.Show("لا يمكن حفظ الفاتورة لأنها لا تحتوي على أصناف");
                return;
            }

            if (txtVendorBillNumber.Text == "")
            {
                 MessageBox.Show("تأكد من كتابة رقم فاتورة المورد");
                return;
            }

            DialogResult d = MessageBox.Show(" تأكيد حفظ الفاتورة ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {

                //-----------------------------------------------------إنشاء الفاتورة
                TblVendorsBills obj = new TblVendorsBills();
                if (MyBillID == 0)
                {
                    obj.AddNew();
                }
                else
                {
                    obj.LoadByPrimaryKey(MyBillID);
                }
                obj.Bill_PayType = comboType.Text;
                obj.Bill_VendorId = int.Parse(comboVendors.SelectedValue.ToString());
                obj.Bill_Sender = txtSender.Text;
                obj.Bill_Details = txtDetails.Text;
                obj.Bill_VendorNumber = txtVendorBillNumber.Text;
                obj.Bill_Date = DateTime.Parse(dateTimePicker1.Text);
                obj.Bill_Discount_Money = Math.Round(double.Parse(lblDiscount.Text), 2);
                obj.Bill_Discount = double.Parse(txtDiscount.Text);
                if (chekbxMoney.Checked == true)
                {
                    obj.Bill_DiscountType = "مبلغ";
                }
                else
                {
                    obj.Bill_DiscountType = "نسبة";
                }
                obj.User_Id = GlobalVar.user_Id;
                obj.Bank_Id = int.Parse(comboBanks.SelectedValue.ToString());
                obj.Bill_Vat = double.Parse(txtVat.Text);
                obj.Bill_Vat_Value = VatValue;
                obj.Store_Id = 1;
                obj.Save();

                MyBillID = obj.Bill_ID;

                //--------------------------------------------------------حفظ الفاتورة
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    TblVendorsBillGoods py = new TblVendorsBillGoods();
                    if (row.Cells["ColumnID"].Value.ToString() == "0")
                    {
                        py.AddNew();                      
                    }
                    else
                    {
                        py.LoadByPrimaryKey(int.Parse(row.Cells["ColumnID"].Value.ToString()));
                    }

                    py.Good_Count = double.Parse(row.Cells["ColumnCount"].Value.ToString());
                    py.Good_Price = double.Parse(row.Cells["ColumnUnitPrice"].Value.ToString());                    
                    py.Good_FreeBones = double.Parse(row.Cells["ColumnBones"].Value.ToString());
                    py.Barcode_Id = int.Parse(row.Cells["ColumnBarcodeID"].Value.ToString());
                    py.Bill_id = MyBillID;

                    TblGoodsBarcode gr = new TblGoodsBarcode();
                    gr.LoadByPrimaryKey(int.Parse(row.Cells["ColumnBarcodeID"].Value.ToString()));
                    gr.Barcode_PayPrice = row.Cells["ColumnPayPrice"].Value.ToString();
                    gr.Barcode_BuyPrice = row.Cells["ColumnAverge"].Value.ToString();
                    gr.Save();

                    py.Save();                  
                }

                FrmPrintVendorBill bn = new FrmPrintVendorBill(MyBillID);
                bn.ShowDialog();

                MessageBox.Show("تم الحفظ");
                this.Close();
            }
           
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboType.Text == "فاتورة مرتجعات")
            {
                ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 7);
                if (xx.Allow == "no")
                {
                    comboType.SelectedIndex = 0;
                    return;
                }

                groupBox6.Enabled = false;
                txtDiscount.Text = "0";
                chekbxMoney.Checked = true;

                txtDiscount_TextChanged_1(sender, e);
                comboBanks.Enabled = false;
            }
            else
            {
                groupBox6.Enabled = true;

                if (comboType.Text == "فاتورة مشتريات كاش")
                {
                    comboBanks.Enabled = true;
                }
                else
                {
                    comboBanks.Enabled = false;
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             DialogResult d = MessageBox.Show("هل تريد بالتأكيد حذف هذا البند من الفاتورة", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
             if (d == DialogResult.OK)
             {

                 if (dataGridView1.Rows.Count > 0)
                 {
                     if (e.RowIndex >= 0)
                     {
                         int RowID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnID"].Value.ToString());
                         if (e.ColumnIndex == dataGridView1.Columns["ColumnDelete"].Index)
                         {
                             if (RowID != 0)
                             {
                                TblVendorsBillGoods gg = new TblVendorsBillGoods();
                                 gg.LoadByPrimaryKey(RowID);
                                 gg.MarkAsDeleted();
                                 gg.Save();
                             }

                             dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);

                             GetBillTotal();
                             txtDiscount_TextChanged_1(sender, e);
                         }
                     }
                 }
             }
        }

        private void DialogNewBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtVat_TextChanged(object sender, EventArgs e)
        {
            if (txtVat.Text != "")
            {
                GetBillTotal();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtVat.Text = lblVat.Text;
            }
        }
    }
}
