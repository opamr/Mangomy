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
using System.Globalization;
using MyGeneration.dOOdads;
using System.IO;

namespace MyApplication
{
    public partial class DialogAddGood : Form
    {
        int MyID;      

        public DialogAddGood(int id1)
        {
            MyID = id1;
            InitializeComponent();

            TblGoodUnits gg = new TblGoodUnits();
            gg.LoadAll();
            if (gg.RowCount > 0)
            {
                comboUnitMain.ValueMember = TblGoodUnits.ColumnNames.Unit_ID;
                comboUnitMain.DisplayMember = TblGoodUnits.ColumnNames.Unit_Name;
                comboUnitMain.DataSource = gg.DefaultView;
            }

            gg = new TblGoodUnits();
            gg.LoadAll();
            if (gg.RowCount > 0)
            {
                comboUnit2.ValueMember = TblGoodUnits.ColumnNames.Unit_ID;
                comboUnit2.DisplayMember = TblGoodUnits.ColumnNames.Unit_Name;
                comboUnit2.DataSource = gg.DefaultView;
            }
        }

        double VatPercent = 0;

        private void DialogAddGood_Load(object sender, EventArgs e)
        {
            TblVat vv = new TblVat();
            vv.LoadByPrimaryKey(1);
            VatPercent = vv.Vat_Percent;

            this.KeyPreview = true;

            TblGoodsCategory gg = new TblGoodsCategory();
            gg.LoadAll();
            if (gg.RowCount > 0)
            {
                comboCategory.ValueMember = TblGoodsCategory.ColumnNames.Ctaegory_ID;
                comboCategory.DisplayMember = TblGoodsCategory.ColumnNames.Category_Name;
                comboCategory.DataSource = gg.DefaultView;
            }
            else
            {
                MessageBox.Show("يجب تسجيل الفئات اولاً");
                this.Close();
            }          

            dataGridView1.Rows.Clear();
            //----------------------------------------------------
            if (MyID != 0)
            {
                this.Text = "تعديل بيانات صنف";
                btnDelete.Visible = true;


                TblGoodsTitles obj = new TblGoodsTitles();
                obj.LoadByPrimaryKey(MyID);
                comboCategory.SelectedValue = obj.Category_Id;
                txtTraidName.Text = obj.Good_TraidName;
                txtFirstStore0.Text = obj.s_FirstStore_Amount0;
                txtFirstStore1.Text = obj.s_FirstStore_Amount1;
                txtFirstStore2.Text = obj.s_FirstStore_Amount2;

                dateTimePicker5.Text = obj.Good_FirstDate.ToShortDateString();

                txtMinimumMain.Text = obj.Good_MinimumCount.ToString();

                TblGoodsBarcode bb = new TblGoodsBarcode();
                bb.Where.Titel_Id.Value = MyID;
                if (bb.Query.Load())
                {
                    //lblFirstID.Text = bb.Barcode_ID.ToString();

                    comboUnitMain.Text = bb.Barcode_Unit;
                    txtPaySpecial1.Text = bb.Barcode_PaySpecial;
                    txtPayPriceMain.Text = bb.Barcode_PayPrice;
                    txtBuyMain.Text = bb.Barcode_BuyPrice;
                    txtBarcodeMain.Text = bb.Barcode_Code;

                    TblGoodsBarcode b2 = new TblGoodsBarcode();
                    b2.Where.Titel_Id.Value = MyID;
                    b2.Where.Barcode_ID.Value = bb.Barcode_ID;
                    b2.Where.Barcode_ID.Operator = WhereParameter.Operand.GreaterThan;
                    if (b2.Query.Load())
                    {
                        int g = 0;
                        do
                        {
                            ++g;
                            dataGridView1.Rows.Add(b2.Barcode_ID, g, b2.Barcode_Code, b2.Barcode_Unit, b2.Barcode_BuyPrice, b2.Barcode_PayPrice,b2.Barcode_PaySpecial,  b2.Barcode_Count,"X");
                        } while (b2.MoveNext());
                    }
                }
               
            }           
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtTraidName.Text == ""  || txtBuyMain.Text == ""  || txtMinimumMain.Text == "" || txtPayPriceMain.Text == "" || txtPaySpecial1.Text == "" ||
                txtFirstStore0.Text == "" || txtFirstStore1.Text == "" || txtFirstStore2.Text == "")
            {
                MessageBox.Show("تأكد من كتابة بيانات الصنف بشكل صحيح");
                return;
            }
           
            TblGoodsTitles obj = new TblGoodsTitles();
                if (MyID == 0)
                {
                    obj.AddNew();

                    obj.Category_Id = int.Parse(comboCategory.SelectedValue.ToString());
                    obj.Good_TraidName = txtTraidName.Text;

                    obj.Good_FirstDate = DateTime.Parse(dateTimePicker5.Text);

                    obj.s_FirstStore_Amount0 = txtFirstStore0.Text;
                    obj.s_FirstStore_Amount1 = txtFirstStore1.Text;
                    obj.s_FirstStore_Amount2 = txtFirstStore2.Text;

                    obj.Good_MinimumCount = int.Parse(txtMinimumMain.Text);
                    obj.Save();                    


                    TblGoodsBarcode bb = new TblGoodsBarcode();
                    bb.AddNew();
                    bb.Titel_Id = obj.Title_ID;
                    bb.Barcode_Unit = comboUnitMain.Text;
                    bb.Barcode_PayPrice = txtPayPriceMain.Text;
                    bb.Barcode_PaySpecial = txtPaySpecial1.Text;
                    bb.Barcode_BuyPrice = txtBuyMain.Text;
                    bb.Barcode_Code = txtBarcodeMain.Text;
                    bb.Barcode_Count = "1";
                    bb.Save();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        TblGoodsBarcode xx = new TblGoodsBarcode();
                        xx.AddNew();
                        xx.Titel_Id = obj.Title_ID;
                        xx.Barcode_Code = row.Cells["Column1"].Value.ToString();
                        xx.Barcode_Unit = row.Cells["Column2"].Value.ToString();
                        xx.Barcode_PayPrice = row.Cells["Column3"].Value.ToString();
                        xx.Barcode_BuyPrice = row.Cells["Column4"].Value.ToString();                        
                        xx.Barcode_Count = row.Cells["Column5"].Value.ToString();
                        xx.Barcode_PaySpecial = row.Cells["Column6"].Value.ToString();
                        xx.Save();
                    }
                }
                else
                {
                    obj.LoadByPrimaryKey(MyID);

                    obj.Category_Id = int.Parse(comboCategory.SelectedValue.ToString());
                    obj.Good_TraidName = txtTraidName.Text;

                    obj.Good_FirstDate = DateTime.Parse(dateTimePicker5.Text);
                    obj.s_FirstStore_Amount0 = txtFirstStore0.Text;
                    obj.s_FirstStore_Amount1 = txtFirstStore1.Text;
                    obj.s_FirstStore_Amount2 = txtFirstStore2.Text;
                    obj.Good_MinimumCount = int.Parse(txtMinimumMain.Text);
                    obj.Save();                  


                    TblGoodsBarcode bb = new TblGoodsBarcode();
                    bb.Where.Titel_Id.Value = MyID;
                    if (bb.Query.Load())
                    {
                        bb.Titel_Id = obj.Title_ID;
                        bb.Barcode_Unit = comboUnitMain.Text;
                        bb.Barcode_PayPrice = txtPayPriceMain.Text;
                        bb.Barcode_PaySpecial = txtPaySpecial1.Text;
                        bb.Barcode_BuyPrice = txtBuyMain.Text;
                        bb.Barcode_Code = txtBarcodeMain.Text;
                        bb.Barcode_Count = "1";
                        bb.Save();
                    }

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        TblGoodsBarcode xx = new TblGoodsBarcode();
                        if (row.Cells["ColumnID"].Value.ToString() == "0")
                        {
                            xx.AddNew();
                        }
                        else
                        {
                            xx.LoadByPrimaryKey(int.Parse(row.Cells["ColumnID"].Value.ToString()));
                        }

                        xx.Titel_Id = obj.Title_ID;
                        xx.Barcode_Code = row.Cells["Column1"].Value.ToString();
                        xx.Barcode_Unit = row.Cells["Column2"].Value.ToString();
                        xx.Barcode_PayPrice = row.Cells["Column3"].Value.ToString();
                        xx.Barcode_BuyPrice = row.Cells["Column4"].Value.ToString();
                        xx.Barcode_Count = row.Cells["Column5"].Value.ToString();
                        xx.Barcode_PaySpecial = row.Cells["Column6"].Value.ToString();
                        xx.Save();
                    }
                }

                obj.Save();
                GlobalVar.title_Id = obj.Title_ID;
                this.Close();
           
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void txtMinimum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPayPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("هل تريد حذف هذا الصنف بالفعل ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (d == DialogResult.OK)
            {
                ViewVendorsGoods obj = new ViewVendorsGoods();
                obj.Where.Titel_Id.Value = MyID;
                if (obj.Query.Load())
                {
                    MessageBox.Show("لا يمكن حذف هذا الصنف لانه يوجد في فاتورة مشتريات رقم " + obj.Bill_id.ToString(), "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ViewCustomerPayments py = new ViewCustomerPayments();
                    py.Where.Titel_Id.Value = MyID;
                    if (py.Query.Load())
                    {
                        MessageBox.Show("لا يمكن حذف هذا الصنف لانه يوجد في فاتورة مبيعات رقم " + py.CustomerBill_Id.ToString(), "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        TblGoodsBarcode bb = new TblGoodsBarcode();
                        bb.Where.Titel_Id.Value = MyID;
                        if (bb.Query.Load())
                        {
                            bb.DeleteAll();
                            bb.Save();
                        }

                        TblGoodsTitles tt = new TblGoodsTitles();
                        tt.LoadByPrimaryKey(MyID);
                        tt.MarkAsDeleted();
                        tt.Save();

                         

                        MessageBox.Show("تم الحذف");

                        this.Close();
                    }
                }

            }
        }       

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            TblGoodsCategory obj = new TblGoodsCategory();
            obj.Where.Category_Name.Value = comboCategory.Text;
            if (obj.Query.Load())
            {
                BtnAdd.Enabled = true;
            }
            else
            {
                BtnAdd.Enabled = false;
            }
        }       

        private void DialogAddGood_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }      

        private void BtnGenerateBarcode1_Click(object sender, EventArgs e)
        {
            double barcode = 15000;
            for (int i = 1; i > 0; i++)
            {                                
                ViewGoods obj = new ViewGoods();
                obj.Where.Barcode_Code.Value = barcode;
                if (obj.Query.Load())
                {
                    ++barcode;
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["Column1"].Value.ToString() == barcode.ToString())
                        {
                            ++barcode;
                        }
                    }

                    if (txtBarcode2.Text == barcode.ToString())
                    {
                        ++barcode;
                    }
                    else
                    {
                        txtBarcodeMain.Text = barcode.ToString();
                        break;
                    }                  
                }                             
            }

            comboUnitMain.Focus();
        }

        private void txtBarcodeMain_TextChanged(object sender, EventArgs e)
        {
            if (txtBarcodeMain.Text != "")
            {
                if (MyID == 0)
                {
                    TblGoodsBarcode obj = new TblGoodsBarcode();
                    obj.Where.Barcode_Code.Value = txtBarcodeMain.Text;
                    if (obj.Query.Load())
                    {
                        BtnAdd.Enabled = false;
                        lblBarcode.Text = "باركود غير متاح .. مسجل من قبل";
                    }
                    else
                    {
                        BtnAdd.Enabled = true;
                        lblBarcode.Text = "باركود  متاح";
                    }
                }
                else
                {
                    TblGoodsBarcode obj = new TblGoodsBarcode();
                    obj.Where.Barcode_Code.Value = txtBarcodeMain.Text;
                    obj.Where.Titel_Id.Value = MyID;
                    obj.Where.Titel_Id.Operator = WhereParameter.Operand.NotEqual;
                    if (obj.Query.Load())
                    {
                        BtnAdd.Enabled = false;
                        lblBarcode.Text = "باركود غير متاح .. مسجل من قبل";
                    }
                    else
                    {
                        BtnAdd.Enabled = true;
                        lblBarcode.Text = "باركود  متاح";
                    }
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Column1"].Value.ToString() == txtBarcodeMain.Text)
                    {
                        BtnAdd.Enabled = false;
                        lblBarcode.Text = "باركود غير متاح .. مسجل من قبل";
                    }
                    else
                    {
                        BtnAdd.Enabled = true;
                        lblBarcode.Text = "باركود  متاح";
                    }
                }

            }
        }

        private void BtnGenerateBarcode2_Click(object sender, EventArgs e)
        {          
            double barcode = 15000;
            for (int i = 1; i > 0; i++)
            {
                ViewGoods obj = new ViewGoods();
                obj.Where.Barcode_Code.Value = barcode;
                if (obj.Query.Load())
                {
                    ++barcode;
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["Column1"].Value.ToString() == barcode.ToString())
                        {
                            ++barcode;
                        }
                    }

                    if (txtBarcodeMain.Text == barcode.ToString())
                    {
                        ++barcode;
                    }
                    else
                    {
                        txtBarcode2.Text = barcode.ToString();
                        break;
                    }

                }                                                                  
            }

            comboUnit2.Focus();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            if (txtBarcode2.Text != "")
            {
                if (MyID == 0)
                {
                    TblGoodsBarcode obj = new TblGoodsBarcode();
                    obj.Where.Barcode_Code.Value = txtBarcode2.Text;
                    if (obj.Query.Load())
                    {
                        IconAddToGrid.Enabled = false;
                        lblBarcode2.Text = "باركود غير متاح .. مسجل من قبل";
                    }
                    else
                    {
                        IconAddToGrid.Enabled = true;
                        lblBarcode2.Text = "باركود  متاح";
                    }
                }
                else
                {
                    TblGoodsBarcode obj = new TblGoodsBarcode();
                    obj.Where.Barcode_Code.Value = txtBarcode2.Text;
                    obj.Where.Titel_Id.Value = MyID;
                    obj.Where.Titel_Id.Operator = WhereParameter.Operand.NotEqual;
                    if (obj.Query.Load())
                    {
                        IconAddToGrid.Enabled = false;
                        lblBarcode2.Text = "باركود غير متاح .. مسجل من قبل";
                    }
                    else
                    {
                        IconAddToGrid.Enabled = true;
                        lblBarcode2.Text = "باركود  متاح";
                    }
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Column1"].Value.ToString() == txtBarcode2.Text)
                    {
                        IconAddToGrid.Enabled = false;
                        lblBarcode2.Text = "باركود غير متاح .. مسجل من قبل";
                    }
                    else
                    {
                        IconAddToGrid.Enabled = true;
                        lblBarcode2.Text = "باركود  متاح";
                    }
                }

            }
        }

        private void IconAddToGrid_Click(object sender, EventArgs e)
        {
            if (txtBarcode2.Text != "" && comboUnit2.Text != "" && txtPayKash2.Text != "" && txtPayKash2.Text != "." &&txtPaySpecial2.Text != ""&& txtPaySpecial2.Text != "."&& txtBuy2.Text != "" && txtBuy2.Text != "." && txtCount2.Text != "" && txtCount2.Text != ".")
            {
                dataGridView1.Rows.Add(0, dataGridView1.Rows.Count + 1, txtBarcode2.Text, comboUnit2.Text, txtBuy2.Text, txtPayKash2.Text, txtPaySpecial2.Text, txtCount2.Text, "X");

                txtBarcode2.Text = comboUnit2.Text = txtPayKash2.Text = txtBuy2.Text = txtCount2.Text = "";

                txtBarcode2.Focus();
            }
            else
            {
                MessageBox.Show("تأكد من كتابة البيانات بشكل صحيح");
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string barcode = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value);
            string Unit = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value);
            string PayPrice = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value);
            string PaySpecial = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Column6"].Value);
            string BuyPrice = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value);
            string Count = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Column5"].Value);

            if (barcode == "")
            {
                dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value = "0";
            }

            if (Unit == "")
            {
                dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value = "حبه";
            }

            if (PayPrice== "" || PayPrice == ".")
            {
                dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value = "0";
            }

            if (PaySpecial == "" || PaySpecial == ".")
            {
                dataGridView1.Rows[e.RowIndex].Cells["Column6"].Value = "0";
            }

            if (BuyPrice == "" || BuyPrice == ".")
            {
                dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value = "0";
            }

            if (Count == "" || Count == ".")
            {
                dataGridView1.Rows[e.RowIndex].Cells["Column5"].Value = "1";
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
                        }
                        else
                        {
                            TblCustomerBillsPayments py = new TblCustomerBillsPayments();
                            py.Where.Barcode_Id.Value = RowID;
                            if (py.Query.Load())
                            {
                                MessageBox.Show("لا يمكن حذف هذا البند لانه مسجل في فا تورة مبيعات رقم " + py.CustomerBill_Id.ToString());
                                return;
                            }

                            TblVendorsBillGoods gb = new TblVendorsBillGoods();
                            gb.Where.Barcode_Id.Value = RowID;
                            if (gb.Query.Load())
                            {
                                MessageBox.Show("لا يمكن حذف هذا البند لانه مسجل في فا تورة مشتريات رقم " + gb.Bill_id.ToString());
                                return;
                            }

                            TblGoodsBarcode obj = new TblGoodsBarcode();
                            obj.LoadByPrimaryKey(RowID);
                            obj.MarkAsDeleted();
                            obj.Save();

                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;

            if (dataGridView1.CurrentCell.OwningColumn == Column2)
            {
                txt.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress1);
            }
            else
            {
                txt.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
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

        private void dataGridView1_KeyPress1(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }

        private void txtTraidName_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-sa"));
        }

        private void DialogAddGood_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        

        private void txtPayPriceMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && txtPayPriceMain.Text != "" && txtPayPriceMain.Text != ".")
            {
                txtPayPriceMainAfterVat.Text = (double.Parse(txtPayPriceMain.Text) + double.Parse(txtPayPriceMain.Text) * VatPercent).ToString("0.000");
            }
        }

        private void txtPayPriceMain_Leave(object sender, EventArgs e)
        {
            if (txtPayPriceMain.Text != "" && txtPayPriceMain.Text != ".")
            {
                txtPayPriceMainAfterVat.Text = (double.Parse(txtPayPriceMain.Text) + double.Parse(txtPayPriceMain.Text) * VatPercent).ToString("0.000");
            }
        }

        private void txtPayPriceMainAfterVat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && txtPayPriceMainAfterVat.Text != "" && txtPayPriceMainAfterVat.Text != ".")
            {
                txtPayPriceMain.Text = (double.Parse(txtPayPriceMainAfterVat.Text) / (1+ VatPercent)).ToString("0.000");
            }
        }

        private void txtPayPriceMainAfterVat_Leave(object sender, EventArgs e)
        {
            if (txtPayPriceMainAfterVat.Text != "" && txtPayPriceMainAfterVat.Text != ".")
            {
                txtPayPriceMain.Text = (double.Parse(txtPayPriceMainAfterVat.Text) / (1 + VatPercent)).ToString("0.000");
            }
        }

        private void txtPaySpecial1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && txtPaySpecial1.Text != "" && txtPaySpecial1.Text != ".")
            {
                txtPaySpecial1AfterVat.Text = (double.Parse(txtPaySpecial1.Text) + double.Parse(txtPaySpecial1.Text) * VatPercent).ToString("0.000");
            }
        }

        private void txtPaySpecial1_Leave(object sender, EventArgs e)
        {
            if (txtPaySpecial1.Text != "" && txtPaySpecial1.Text != ".")
            {
                txtPaySpecial1AfterVat.Text = (double.Parse(txtPaySpecial1.Text) + double.Parse(txtPaySpecial1.Text) * VatPercent).ToString("0.000");
            }
        }

        private void txtPaySpecial1AfterVat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && txtPaySpecial1AfterVat.Text != "" && txtPaySpecial1AfterVat.Text != ".")
            {
                txtPaySpecial1.Text = (double.Parse(txtPaySpecial1AfterVat.Text) / (1 + VatPercent)).ToString("0.000");
            }
        }

        private void txtPaySpecial1AfterVat_Leave(object sender, EventArgs e)
        {
            if (txtPaySpecial1AfterVat.Text != "" && txtPaySpecial1AfterVat.Text != ".")
            {
                txtPaySpecial1.Text = (double.Parse(txtPaySpecial1AfterVat.Text) / (1 + VatPercent)).ToString("0.000");
            }
        }

        private void txtPayKash2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && txtPayKash2.Text != "" && txtPayKash2.Text != ".")
            {
                txtPayKash2AfterVat.Text = (double.Parse(txtPayKash2.Text) + double.Parse(txtPayKash2.Text) * VatPercent).ToString("0.000");
            }
        }

        private void txtPayKash2_Leave(object sender, EventArgs e)
        {
            if (txtPayKash2.Text != "" && txtPayKash2.Text != ".")
            {
                txtPayKash2AfterVat.Text = (double.Parse(txtPayKash2.Text) + double.Parse(txtPayKash2.Text) * VatPercent).ToString("0.000");
            }
        }

        private void txtPayKash2AfterVat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && txtPayKash2AfterVat.Text != "" && txtPayKash2AfterVat.Text != ".")
            {
                txtPayKash2.Text = (double.Parse(txtPayKash2AfterVat.Text) / (1 + VatPercent)).ToString("0.000");
            }
        }

        private void txtPayKash2AfterVat_Leave(object sender, EventArgs e)
        {
            if (txtPayKash2AfterVat.Text != "" && txtPayKash2AfterVat.Text != ".")
            {
                txtPayKash2.Text = (double.Parse(txtPayKash2AfterVat.Text) / (1 + VatPercent)).ToString("0.000");
            }
        }

        private void txtPaySpecial2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && txtPaySpecial2.Text != "" && txtPaySpecial2.Text != ".")
            {
                txtPaySpecial2AfterVat.Text = (double.Parse(txtPaySpecial2.Text) + double.Parse(txtPaySpecial2.Text) * VatPercent).ToString("0.000");
            }
        }

        private void txtPaySpecial2_Leave(object sender, EventArgs e)
        {
            if (txtPaySpecial2.Text != "" && txtPaySpecial2.Text != ".")
            {
                txtPaySpecial2AfterVat.Text = (double.Parse(txtPaySpecial2.Text) + double.Parse(txtPaySpecial2.Text) * VatPercent).ToString("0.000");
            }
        }

        private void txtPaySpecial2AfterVat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && txtPaySpecial2AfterVat.Text != "" && txtPaySpecial2AfterVat.Text != ".")
            {
                txtPaySpecial2.Text = (double.Parse(txtPaySpecial2AfterVat.Text) / (1 + VatPercent)).ToString("0.000");
            }
        }

        private void txtPaySpecial2AfterVat_Leave(object sender, EventArgs e)
        {
            if (txtPaySpecial2AfterVat.Text != "" && txtPaySpecial2AfterVat.Text != ".")
            {
                txtPaySpecial2.Text = (double.Parse(txtPaySpecial2AfterVat.Text) / (1 + VatPercent)).ToString("0.000");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
