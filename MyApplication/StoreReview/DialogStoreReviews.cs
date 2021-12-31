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

namespace MyApplication.StoreReview
{
    public partial class DialogStoreReviews : Form
    {
        public DialogStoreReviews()
        {
            InitializeComponent();
        }

        private void DialogStoreReviews_Load(object sender, EventArgs e)
        {
            FillMyGrid();
        }

        string MySearchType = "load";
        private void FillMyGrid()
        {
            dataGridView1.Rows.Clear();

            TblStoreReview obj = new TblStoreReview();
            if (MySearchType == "date")
            {
                obj.Where.Review_Date.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text);
                obj.Where.Review_Date.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text);
                obj.Where.Review_Date.Operator = WhereParameter.Operand.Between;
            }
            else if (MySearchType == "load")
            {
                obj.Where.Review_Status.Value = "لم ينتهي";
            }
          
            if (obj.Query.Load())
            {
                do
                {
                    ClassStoreReview cs = new ClassStoreReview(obj.Review_ID);
                    dataGridView1.Rows.Add(obj.Review_ID, dataGridView1.Rows.Count + 1, obj.Review_Date.ToShortDateString(),
                        cs.Minuse.ToString("0,0.00"), cs.Plus.ToString("0,0.00"), obj.Review_Title, obj.Review_Status);

                    if (obj.Review_Status == "لم ينتهي")
                    {
                        dataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;
                    }

                } while (obj.MoveNext());
            }
        }

        private void BtnAddReview_Click(object sender, EventArgs e)
        {
            TblStoreReview y = new TblStoreReview();
            y.Where.Review_Status.Value = "لم ينتهي";
            if (y.Query.Load())
            {
                MessageBox.Show("لا يمكن اضافة جرد جديد قبل انهاء الجرد الحالي");
                return;
            }

            DialogNewReview obj = new DialogNewReview(0);
            obj.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (e.RowIndex >= 0)
                {
                    int RowID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ColumnID"].Value.ToString());
                    if (e.ColumnIndex == dataGridView1.Columns["ColumnDetails"].Index)
                    {
                        DialogReviewDetails obj = new DialogReviewDetails(RowID);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            DialogStoreReviews_Load(sender, e);
                        }
                    }
                    else if (e.ColumnIndex == dataGridView1.Columns["ColumnAddReview"].Index)
                    {
                        DialogAddGoodsToReview obj = new DialogAddGoodsToReview(RowID);
                        obj.ShowDialog();
                    }
                }
            }
        }
     
        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            MySearchType = "date";
            FillMyGrid();
        }
    }
}
