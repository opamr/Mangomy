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
namespace MyApplication.Goods
{
    public partial class DialogSelectGoodsBarCode : Form
    {
        string BarcodeForPrint;
        public DialogSelectGoodsBarCode()
        {
            InitializeComponent();
        }
        double VatPercent = 0;
        private void DialogPrintGoodsBarCode_Load(object sender, EventArgs e)
        {
            TblVat vvd = new TblVat();
            vvd.LoadByPrimaryKey(1);
            VatPercent = vvd.Vat_Value / 100;

            TblGoodsTitles x3 = new TblGoodsTitles();
            x3.LoadAll();
            if (x3.LoadAll())
            {
                x3.Sort = TblGoodsTitles.ColumnNames.Good_TraidName + " ASC";
                comboBox1.ValueMember = TblGoodsTitles.ColumnNames.Title_ID;
                comboBox1.DisplayMember = TblGoodsTitles.ColumnNames.Good_TraidName;
                comboBox1.DataSource = x3.DefaultView;
            }

            dataGridView1.Rows.Clear();

            TblBarcodePrint obj = new TblBarcodePrint();
            obj.LoadAll();
            if (obj.RowCount >0)
            {
                int g = 0;
                do
                {
                    ViewGoods vv = new ViewGoods();
                    vv.Where.Barcode_ID.Value = obj.Title_ID;
                    if (vv.Query.Load())
                    {
                        ++g;
                        dataGridView1.Rows.Add(obj.Barcode_ID, g, obj.BarCode, vv.Good_TraidName,  obj.Count, obj.Pay_Price,  "إلغاء");
                    }                  
                } while (obj.MoveNext());
            }
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 )
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && txtCount.Text != "")
            {
                BtnSave_Click(sender, e);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TblGoodsBarcode obj = new TblGoodsBarcode();
            obj.Where.Titel_Id.Value = int.Parse(comboBox1.SelectedValue.ToString());
            if (obj.Query.Load())
            {
                comboUnits.DisplayMember = TblGoodsBarcode.ColumnNames.Barcode_Unit;
                comboUnits.ValueMember = TblGoodsBarcode.ColumnNames.Barcode_ID;
                comboUnits.DataSource = obj.DefaultView;
            }                   
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtCount.Text != "" && double.Parse(txtCount.Text) >0)
            {
                TblBarcodePrint obj = new TblBarcodePrint();
                obj.AddNew();
                obj.Title_ID = int.Parse(comboUnits.SelectedValue.ToString());
                obj.Count = txtCount.Text;
                obj.Pay_Price = txtPayPrice.Text + " ريال";
                obj.BarCode = lblBarcode.Text;
                obj.Save();

                string MyNewBarcode;
                IDAutomation.NetAssembly.FontEncoder FontEncoder = new IDAutomation.NetAssembly.FontEncoder();
                MyNewBarcode = FontEncoder.Code128b(lblBarcode.Text);

                ////if (lblBarcode.Text.Contains("00"))
                ////{
                //    MyNewBarcode = FontEncoder.Code128b(lblBarcode.Text);
                ////}
                ////else
                ////{
                //MyNewBarcode = FontEncoder.Code128(lblBarcode.Text);
                //}


                //string MyNewBarcode = FontEncoder.Code128c(lblBarcode.Text);  بيضيف صفر قبل الرقم عند القراءة ومش بيقرأ الحروف

                //lblbbbb.Text = MyNewBarcode;

                for (int i = 0; i < int.Parse(txtCount.Text); i++)
                {
                    TblBarcodeCountPrint pr = new TblBarcodeCountPrint();
                    pr.AddNew();
                    pr.Barcode_ID = obj.Barcode_ID;
                    pr.Title_Name = comboBox1.Text;
                    pr.Title_Barcode = MyNewBarcode;
                    //pr.Title_Barcode = BarcodeForPrint;
                    pr.Title_PayPrice =  txtPayPrice.Text + " ريال ";
                    //pr.Title_Unit = lblBarcode.Text;
                    pr.Save();
                                        
                }

                txtBarcode.Focus();
                txtCount.Text =txtBarcode.Text= "";

                DialogPrintGoodsBarCode_Load(sender, e);
            }
            else
            {
                MessageBox.Show("تأكد من كتابة العدد");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                if (e.RowIndex >= 0)
                {
                    int Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnID"].Value.ToString());

                    if (e.ColumnIndex == dataGridView1.Columns["ColumnDelete"].Index)
                    {
                        DialogResult d = MessageBox.Show("هل تريد بالتأكيد حذف هذا الصنف من قائمة الطباعة ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (d == DialogResult.OK)
                        {
                            TblBarcodeCountPrint pr = new TblBarcodeCountPrint();
                            pr.Where.Barcode_ID.Value = Id;
                            if (pr.Query.Load())
                            {
                                pr.DeleteAll();
                                pr.Save();
                            }

                            TblBarcodePrint bb = new TblBarcodePrint();
                            bb.LoadByPrimaryKey(Id);
                            bb.MarkAsDeleted();
                            bb.Save();

                            DialogPrintGoodsBarCode_Load(sender, e);
                        }
                    }
                }
            }


        }

        private void BtnNewList_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("هل تريد بالتأكيد إنشاء قائمة جديدة ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {
                TblBarcodeCountPrint pr = new TblBarcodeCountPrint();
                pr.LoadAll();
                pr.DeleteAll();
                pr.Save();


                TblBarcodePrint bb = new TblBarcodePrint();
                bb.LoadAll();
                bb.DeleteAll();
                bb.Save();

                DialogPrintGoodsBarCode_Load(sender, e);
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            FrmPrintBarcode obj = new FrmPrintBarcode();
            obj.ShowDialog();
        }

        private void comboUnits_SelectedIndexChanged(object sender, EventArgs e)
        {            
            TblGoodsBarcode obj = new TblGoodsBarcode();
            obj.Where.Barcode_ID.Value = int.Parse(comboUnits.SelectedValue.ToString());
            if (obj.Query.Load())
            {                
                lblBarcode.Text = obj.Barcode_Code;
                txtPayPrice.Text = (double.Parse(obj.Barcode_PayPrice) + double.Parse(obj.Barcode_PayPrice) * VatPercent).ToString("0.00");
                BarcodeForPrint =  obj.Barcode_Code;
                
                lblUnit.Text = obj.Barcode_Unit;
            }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtBarcode.Text != "")
            {
                TblGoodsBarcode obj1 = new TblGoodsBarcode();
                obj1.Where.Barcode_Code.Value = txtBarcode.Text;
                if (obj1.Query.Load())
                {
                    comboBox1.SelectedValue = obj1.Titel_Id;
                    comboUnits.SelectedValue = obj1.Barcode_ID;

                   
                    lblBarcode.Text = obj1.Barcode_Code;
                    txtPayPrice.Text = (double.Parse(obj1.Barcode_PayPrice) + double.Parse(obj1.Barcode_PayPrice) * VatPercent).ToString("0.00");

                    BarcodeForPrint = obj1.Barcode_Code;

                    txtCount.Focus();
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int MyID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnID"].Value.ToString());

            TblBarcodePrint pp = new TblBarcodePrint();
            pp.LoadByPrimaryKey(MyID);

            ViewGoods tt = new ViewGoods();
            tt.Where.Barcode_ID.Value = pp.Title_ID;
            tt.Query.Load();
        

            

            if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == "")
            {
                if (e.ColumnIndex == dataGridView1.Columns["ColumnCount"].Index)
                {
                    dataGridView1.Rows[e.RowIndex].Cells["ColumnCount"].Value = 1;
                }
                else if (e.ColumnIndex == dataGridView1.Columns["ColumnPayPrice"].Index)
                {                   
                    double PayPrice = double.Parse(tt.Barcode_PayPrice) + double.Parse(tt.Barcode_PayPrice) * VatPercent;

                    dataGridView1.Rows[e.RowIndex].Cells["ColumnPayPrice"].Value = PayPrice.ToString("0.00");
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }
            }

            int Count =Convert.ToInt32( dataGridView1.Rows[e.RowIndex].Cells["ColumnCount"].Value);

            pp.Count = Count.ToString();
            pp.Pay_Price = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ColumnPayPrice"].Value);
            pp.Save();

            TblBarcodeCountPrint pr2 = new TblBarcodeCountPrint();
            pr2.Where.Barcode_ID.Value = MyID;
            if (pr2.Query.Load())
            {
                pr2.DeleteAll();
                pr2.Save();
            }                     

            for (int i = 0; i < Count; i++)
            {
                TblBarcodeCountPrint pr = new TblBarcodeCountPrint();
                pr.AddNew();
                pr.Barcode_ID = MyID;
                pr.Title_Name = tt.Good_TraidName;                
                pr.Title_Barcode = tt.Barcode_Code;
                pr.Title_PayPrice = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ColumnPayPrice"].Value) + " ريال ";
                //pr.Title_Unit = tt.Barcode_Code;
                pr.Save();
            }

            MessageBox.Show("تم التعديل");
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
    }
}
