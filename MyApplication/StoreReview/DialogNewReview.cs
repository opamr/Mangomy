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
    public partial class DialogNewReview : Form
    {
        int MyReviewID;
        public DialogNewReview(int ReviewID)
        {
            MyReviewID = ReviewID;
            InitializeComponent();
        }

        private void DialogNewReview_Load(object sender, EventArgs e)
        {
            if (GlobalVar.user_Id != 1)
            {
                dateTimePicker5.Enabled = false;
            }

            if (MyReviewID != 0)
            {
                BtnSave.Text = "حفظ";

                TblStoreReview obj = new TblStoreReview();
                obj.LoadByPrimaryKey(MyReviewID);
                dateTimePicker5.Text = obj.Review_Date.ToShortDateString();
                txtTitle.Text = obj.Review_Title;
                txtDetails.Text = obj.Review_Details;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("تأكد من كتابة عنوان الجرد");
                return;
            }


            TblStoreReview yy = new TblStoreReview();
            if (MyReviewID == 0)
            {
                int NewID = 1;
                TblStoreReview x = new TblStoreReview();
                x.LoadAll();
                if (x.RowCount > 0)
                {
                    x.Sort = TblStoreReview.ColumnNames.Review_ID + " DESC";
                    NewID = x.Review_ID + 1;
                }

                yy.AddNew();
                yy.Review_ID = NewID;
                yy.Review_Status = "لم ينتهي";

            }
            else
            {
                yy.LoadByPrimaryKey(MyReviewID);
            }
            yy.Review_Details = txtDetails.Text;
            yy.Review_Date = DateTime.Parse(dateTimePicker5.Text);
            yy.Review_Title = txtTitle.Text;
            yy.User_Id = GlobalVar.user_Id;
            yy.Save();


            if (MyReviewID == 0)
            {
                TblGoodsTitles obj = new TblGoodsTitles();
                obj.Where.Good_CurrentCount.Value = 0;
                obj.Where.Good_CurrentCount.Operator = WhereParameter.Operand.NotEqual;
                obj.Query.Distinct = true;
                if (obj.Query.Load())
                {
                    do
                    {
                        TblGoodsBarcode bb = new TblGoodsBarcode();
                        bb.Where.Titel_Id.Value = obj.Title_ID;
                        bb.Query.Load();

                        TblStoreReviewSummary py = new TblStoreReviewSummary();
                        py.AddNew();
                        py.Review_Id = yy.Review_ID;
                        py.Title_Id = obj.Title_ID;
                        py.Program_Count = double.Parse(obj.Good_CurrentCount.ToString("0.00"));
                        py.Entry_Count = 0;
                        py.Detail_Difference = 0;
                        py.Detail_Type = "لم يتم";
                        py.s_Pay_Price = bb.Barcode_PayPrice;
                        py.User_Id = GlobalVar.user_Id;
                        py.Save();

                    } while (obj.MoveNext());
                }
            }

            MessageBox.Show("تم إنشاء الجرد بنجاح");

            if (MyReviewID == 0)
            {
                Application.Exit();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }           
        }
    }
}
