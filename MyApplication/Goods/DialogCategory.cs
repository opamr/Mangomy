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
    public partial class DialogUnits : Form
    {
        int MyEditID;
        public DialogUnits()
        {
            InitializeComponent();
        }

        private void DialogCategory_Load(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            ListViewItem lv;
            panel1.Visible = panel2.Visible = false;

            TblGoodsCategory obj = new TblGoodsCategory();
            obj.LoadAll();
            if (obj.RowCount > 0)
            {
                int g = 0;
                do
                {
                    ++g;
                    lv = new ListViewItem(obj.Ctaegory_ID.ToString());
                    lv.SubItems.Add(g.ToString());
                    lv.SubItems.Add(obj.Category_Name);

                    int count = 0;
                    TblGoodsTitles gt = new TblGoodsTitles();
                    gt.Where.Category_Id.Value = obj.Ctaegory_ID;
                    if (gt.Query.Load())
                    {
                        count = gt.RowCount;
                    }
                    lv.SubItems.Add(count.ToString());
                    listView3.Items.Add(lv);
                } while (obj.MoveNext());
            }
        }

        private void txtPayPrice_MouseClick(object sender, MouseEventArgs e)
        {
            txtCategoryName.Text = "";
            txtCategoryName.ForeColor = Color.Black;
        }

        private void BtnShowAdd_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            txtCategoryName.Text = "اكتب اسم الفئة هنا";
            txtCategoryName.ForeColor = Color.Gray;
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text != "" && txtCategoryName.Text != "اكتب اسم الفئة هنا")
            {
                TblGoodsCategory obj = new TblGoodsCategory();
                obj.AddNew();
                obj.Category_Name = txtCategoryName.Text;
                obj.Save();
                DialogCategory_Load(sender, e);
            }
            else
            {
                txtCategoryName.Text = "اكتب اسم الفئة هنا";
                txtCategoryName.ForeColor = Color.Gray;
            }
        }

        private void listView3_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = listView3.SelectedItems[0];
            MyEditID = int.Parse(item.SubItems[0].Text);
            txtEdit.Text = item.SubItems[2].Text;
            panel2.Visible = true;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (txtEdit.Text != "")
            {
                TblGoodsCategory obj = new TblGoodsCategory();
                obj.LoadByPrimaryKey(MyEditID);
                obj.Category_Name = txtEdit.Text;
                obj.Save();
                DialogCategory_Load(sender, e);
            }
            else
            {
                txtEdit.Text = "اكتب اسم الفئة هنا";
                txtEdit.ForeColor = Color.Gray;
            }
        }

        private void txtEdit_MouseClick(object sender, MouseEventArgs e)
        {
            //txtEdit.Text = "";
            //txtEdit.ForeColor = Color.Black;
        }

        private void IconDelete_Click(object sender, EventArgs e)
        {
            TblGoodsTitles tt = new TblGoodsTitles();
            tt.Where.Category_Id.Value = MyEditID;
            if (tt.Query.Load())
            {
                MessageBox.Show("لا يمكن حذف الفئة لانها تحتوي على أصناف");
                return;
            }

            DialogResult d = MessageBox.Show(" تأكيد حذف الفئة ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.Cancel)
            {
                return;
            }

            TblGoodsCategory obj = new TblGoodsCategory();
            obj.LoadByPrimaryKey(MyEditID);
            obj.MarkAsDeleted();
            obj.Save();
            DialogCategory_Load(sender, e);

            MessageBox.Show("تم الحذف");
            
        }
    }
}
