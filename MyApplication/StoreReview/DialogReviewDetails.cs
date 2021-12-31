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

namespace MyApplication.StoreReview
{
    public partial class DialogReviewDetails : Form
    {
        int MyReviewID;
        public DialogReviewDetails(int ReviewID)
        {
            MyReviewID = ReviewID;
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void DialogAddReview_Load(object sender, EventArgs e)
        {
            TblGoodsTitles gt = new TblGoodsTitles();
            gt.LoadAll();
            if (gt.RowCount > 0)
            {
                gt.Sort = TblGoodsTitles.ColumnNames.Good_TraidName + " ASC";
                comboGoods.DisplayMember = TblGoodsTitles.ColumnNames.Good_TraidName;
                comboGoods.ValueMember = TblGoodsTitles.ColumnNames.Title_ID;
                comboGoods.DataSource = gt.DefaultView;
            }

            TblStoreReview obj = new TblStoreReview();
            obj.LoadByPrimaryKey(MyReviewID);
            lblDate.Text = obj.Review_Date.ToShortDateString();
            lblTitle.Text = obj.Review_Title;
            lblDetails.Text = obj.Review_Details;
            lblStatus.Text = obj.Review_Status;
        }        
      
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["ColumnType"].Value.ToString() == "لم يتم")
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells["ColumnType"].Value.ToString() == "لا يوجد")
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Lime;
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells["ColumnType"].Value.ToString() == "عجز")
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Tomato;
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells["ColumnType"].Value.ToString() == "زيادة")
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }

        string MySearchType = "";
        private void FillMyGrid()
        {
            dataGridView1.Rows.Clear();

            double OperationTotal = 0;

            ViewStoreReviewSummary bb = new ViewStoreReviewSummary();
            bb.Where.Review_Id.Value = MyReviewID;
            if (MySearchType == "Type")
            {
                bb.Where.Detail_Type.Value = comboBox1.Text;
            }
            else if (MySearchType == "id")
            {
                bb.Where.Title_Id.Value = comboGoods.SelectedValue;
            }
            if (bb.Query.Load())
            {

                do
                {

                    TblGoodsBarcode x = new TblGoodsBarcode();
                    x.Where.Titel_Id.Value = bb.Title_Id;
                    x.Query.Load();

                    double Total = bb.Entry_Count * bb.Pay_Price;
                    AllTotal += Total;
                    OperationTotal += bb.Detail_Total;
                    dataGridView1.Rows.Add(bb.Summary_ID, bb.Title_Id, dataGridView1.Rows.Count + 1, x.Barcode_Code, bb.Good_TraidName,
                          bb.Entry_Count, bb.Program_Count, bb.Detail_Difference, bb.Detail_Type, bb.Pay_Price, bb.Detail_Total);
                } while (bb.MoveNext());
            }

            lblOperationTotal.Text = OperationTotal.ToString("0,0.00");          
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            MySearchType = "Type";
            FillMyGrid();
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtBarcode.Text != "")
            {
                ViewGoods obj1 = new ViewGoods();
                obj1.Where.Barcode_Code.Value = txtBarcode.Text;
                if (obj1.Query.Load())
                {
                    comboGoods.SelectedValue = obj1.Titel_Id;

                    MySearchType = "id";
                    FillMyGrid();
                }
            }
        }

        double AllTotal = 0;
        double OperationTotal = 0;

        private void comboGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused)
            {
                return;
            }

            MySearchType = "id";
            FillMyGrid();
        }
     
        private void BtnDeleteAll_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "انتهى")
            {
                MessageBox.Show("لا يمكن حذف الجرد المنتهي");
            }
             
            DialogResult d = MessageBox.Show(" تأكيد حذف الجرد بكامل محتوياته ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.Cancel)
            {
                return;
            }           

            TblStoreReviewSummary py = new TblStoreReviewSummary();
            py.Where.Review_Id.Value = MyReviewID;
            if (py.Query.Load())
            {
                do
                {
                    TblStoreReviewDetails f = new TblStoreReviewDetails();
                    f.Where.Summary_Id.Value = py.Summary_ID;
                    if (f.Query.Load())
                    {
                        f.DeleteAll();
                        f.Save();
                    }

                } while (py.MoveNext());

                py.DeleteAll();
                py.Save();
            }

            TblStoreReview x = new TblStoreReview();
            x.LoadByPrimaryKey(MyReviewID);
            x.MarkAsDeleted();
            x.Save();

            MessageBox.Show("تم الحذف");
            this.Close();
        }

        private void DialogAddReview_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            FrmPrintStoreReview w = new FrmPrintStoreReview(MyReviewID);
            w.ShowDialog();
        }

        private void BtnReOpen_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show(" تأكيد إعادة فتح الجرد ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.Cancel)
            {
                return;
            }

            TblStoreReview yy = new TblStoreReview();
            yy.LoadByPrimaryKey(MyReviewID);
            yy.Review_Status = "لم ينتهي";
            yy.Save();

            MessageBox.Show("تم التعديل");
            DialogAddReview_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["ColumnCancel"].Index)
            {
                DialogResult d = MessageBox.Show(" تأكيد إعادة جرد هذا الصنف ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (d == DialogResult.Cancel)
                {
                    return;
                }


                int RowID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnID"].Value.ToString());

                TblStoreReviewSummary x = new TblStoreReviewSummary();
                x.LoadByPrimaryKey(RowID);
                x.Entry_Count = 0;
                x.Detail_Type = "لم يتم";
                x.Detail_Difference = 0;
                x.User_Id = GlobalVar.user_Id;
                x.Save();

                TblStoreReviewDetails obj = new TblStoreReviewDetails();
                obj.Where.Summary_Id.Value = RowID;
                if (obj.Query.Load())
                {
                    do
                    {
                        obj.Detail_Count = 0;
                        obj.User_Id = GlobalVar.user_Id;
                        obj.Save();
                    } while (obj.MoveNext());
                }

                MessageBox.Show("تم التعديل");
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
