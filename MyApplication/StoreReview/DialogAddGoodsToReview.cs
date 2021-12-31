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
using System.Globalization;

namespace MyApplication.StoreReview
{
    public partial class DialogAddGoodsToReview : Form
    {
        int MyReviewID;
        public DialogAddGoodsToReview(int ReviewID)
        {
            MyReviewID = ReviewID;
            InitializeComponent();

            TblGoodsTitles gt = new TblGoodsTitles();
            gt.LoadAll();
            if (gt.RowCount > 0)
            {
                gt.Sort = TblGoodsTitles.ColumnNames.Good_TraidName + " ASC";
                comboGoods.DisplayMember = TblGoodsTitles.ColumnNames.Good_TraidName;
                comboGoods.ValueMember = TblGoodsTitles.ColumnNames.Title_ID;
                comboGoods.DataSource = gt.DefaultView;              
            }
        }

        private void DialogAddReview_Load(object sender, EventArgs e)
        {
            TblStoreReview obj = new TblStoreReview();
            obj.LoadByPrimaryKey(MyReviewID);
            lblDate.Text = obj.Review_Date.ToShortDateString();
            lblTitle.Text = obj.Review_Title;
            lblDetails.Text = obj.Review_Details;
        }

        private void comboGoods_SelectedIndexChanged(object sender, EventArgs e)
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
                }
            }
        }

        private void txtBarcode_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }

        private void comboGoods_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-sa"));
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
                        comboGoods_SelectedIndexChanged(sender, e);

                        comboUnits.SelectedValue = obj.Barcode_ID;
                        comboUnits_SelectedIndexChanged(sender, e);
                       
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

        private void comboUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            TblGoodsBarcode bb = new TblGoodsBarcode();
            bb.LoadByPrimaryKey(int.Parse(comboUnits.SelectedValue.ToString()));          
            txtBarcode.Text = bb.Barcode_Code;
        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && txtCount.Text != "" && txtCount.Text != ".")
            {
                BtnAddToBill_Click(sender, e);
            }
        }

        private void BtnAddToBill_Click(object sender, EventArgs e)
        {
            if (txtCount.Text =="" || txtCount.Text == "0")
            {
                return;
            }

            if (comboGoods.SelectedValue == null)
            {
                MessageBox.Show("هذا الصنف غير مسجل");
                return;
            }

            TblStoreReviewSummary x = new TblStoreReviewSummary();
            x.Where.Title_Id.Value = comboGoods.SelectedValue;
            if (!x.Query.Load())
            {
                ClassFollowGood cs = new ClassFollowGood(int.Parse(comboGoods.SelectedValue.ToString()));

                x.AddNew();
                x.Review_Id = MyReviewID;
                x.Title_Id = int.Parse(comboGoods.SelectedValue.ToString());
                x.Program_Count = cs.CurrentCount;
                x.Entry_Count = 0;
                x.Detail_Type = "لم يتم";
                x.Detail_Difference = 0;
                x.Pay_Price = cs.PayPrice;
                x.User_Id = GlobalVar.user_Id;
                x.Save();
            }

            TblStoreReviewDetails obj = new TblStoreReviewDetails();
            obj.AddNew();
            obj.Summary_Id = x.Summary_ID;
            obj.s_Detail_Count = txtCount.Text;
            obj.s_Barcode_Id = comboUnits.SelectedValue.ToString();
            obj.User_Id = GlobalVar.user_Id;
            obj.Save();

            //add to grid
            dataGridView1.Rows.Add(obj.Detail_ID, dataGridView1.Rows.Count + 1, txtBarcode.Text,
                comboGoods.Text, comboUnits.Text, txtCount.Text);

            //update summary Row
            UpdateSummary(x.Title_Id);

            txtBarcode.Text = txtCount.Text = "";
            txtBarcode.Focus();
        }

        private void UpdateSummary(int TitleID)
        {
            double TotalEntry = 0;
            ViewStoreReviewDetails obj = new ViewStoreReviewDetails();
            obj.Where.Titel_Id.Value = TitleID;
            if (obj.Query.Load())
            {
                do
                {
                    TotalEntry += obj.Detail_Count;
                } while (obj.MoveNext());
            }


            TblStoreReviewSummary x = new TblStoreReviewSummary();
            x.Where.Title_Id.Value = TitleID;
            if (x.Query.Load())
            {
                double Diffrence = x.Program_Count - TotalEntry;

                if (Diffrence > 0)
                {
                    x.Detail_Type = "عجز";
                }
                else if (Diffrence < 0)
                {
                    x.Detail_Type = "زيادة";
                    Diffrence *= -1;
                }
                else
                {
                    x.Detail_Type = "لا يوجد";
                }

                x.Entry_Count = TotalEntry;
                x.Detail_Difference = Diffrence;
                x.Save();
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
                        DialogResult d = MessageBox.Show(" تأكيد الحذف ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (d == DialogResult.Cancel)
                        {
                            return;
                        }


                        TblStoreReviewDetails obj = new TblStoreReviewDetails();
                        obj.LoadByPrimaryKey(RowID);

                        TblGoodsBarcode x = new TblGoodsBarcode();
                        x.LoadByPrimaryKey(obj.Barcode_Id);

                        obj.MarkAsDeleted();
                        obj.Save();

                        dataGridView1.Rows.RemoveAt(e.RowIndex);

                        UpdateSummary(x.Titel_Id);
                    }
                }
            }
        }

        private void BtnEndReview_Click(object sender, EventArgs e)
        {
            TblStoreReviewSummary y = new TblStoreReviewSummary();
            y.Where.Review_Id.Value = MyReviewID;
            y.Where.Detail_Type.Value = "لم يتم";
            if (y.Query.Load())
            {
                MessageBox.Show("الجرد غير مكتمل يوجد اصناف لم يتم جردها");
                return;
            }

            DialogResult d = MessageBox.Show(" تأكيد انهاء الجرد ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.Cancel)
            {
                return;
            }

            TblStoreReview obj = new TblStoreReview();
            obj.LoadByPrimaryKey(MyReviewID);
            obj.Review_Status = "انتهى";
            obj.User_End = GlobalVar.user_Id;
            obj.End_Time = DateTime.Now;
            obj.Save();

            FrmPrintStoreReview w = new FrmPrintStoreReview(MyReviewID);
            w.ShowDialog();

            Application.Exit();
        }
    }
}
