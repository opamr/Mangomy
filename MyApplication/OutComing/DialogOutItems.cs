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

namespace MyApplication.OutComing
{
    public partial class DialogOutItems : Form
    {
        int MyEditID;        
        public DialogOutItems()
        {            
            InitializeComponent();
        }

        private void DialogCategory_Load(object sender, EventArgs e)
        {            

            listView3.Items.Clear();
            ListViewItem lv;
            panel1.Visible = panel2.Visible = false;

            TblOutComingItems obj = new TblOutComingItems();
            obj.LoadAll();
            if (obj.RowCount > 0)
            {                
                int g = 0;
                do
                {
                    ++g;
                    lv = new ListViewItem(obj.Item_Id.ToString());
                    lv.SubItems.Add(g.ToString());
                    lv.SubItems.Add(obj.Item_name);
                    listView3.Items.Add(lv);
                } while (obj.MoveNext());
            }
        }

        private void txtPayPrice_MouseClick(object sender, MouseEventArgs e)
        {
            txtItemName.Text = "";
            txtItemName.ForeColor = Color.Black;
        }

        private void BtnShowAdd_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            txtItemName.Text = "اكتب اسم البند هنا";
            txtItemName.ForeColor = Color.Gray;
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text != "")
            {
                TblOutComingItems obj = new TblOutComingItems();
                obj.AddNew();
                obj.Item_name = txtItemName.Text;                
                obj.Save();
                DialogCategory_Load(sender, e);
            }
            else
            {
                txtItemName.Text = "اكتب اسم البند هنا";
                txtItemName.ForeColor = Color.Gray;
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
                TblOutComingItems obj = new TblOutComingItems();
                obj.LoadByPrimaryKey(MyEditID);
                obj.Item_name = txtEdit.Text;
                obj.Save();
                DialogCategory_Load(sender, e);
            }
            else
            {
                txtEdit.Text = "اكتب اسم البند هنا";
                txtEdit.ForeColor = Color.Gray;
            }
        }

        private void txtEdit_MouseClick(object sender, MouseEventArgs e)
        {
            //txtEdit.Text = "";
            //txtEdit.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show(" تأكيد الحذف ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.Cancel)
            {
                return;
            }

            TblOutComings x = new TblOutComings();
            x.Where.Item_Id.Value = MyEditID;
            if (x.Query.Load())
            {
                MessageBox.Show("لا يوجد حذف البند لانه مسجل عليه مصروفات");
                return;
            }

            TblOutComingItems obj = new TblOutComingItems();
            obj.LoadByPrimaryKey(MyEditID);
            obj.MarkAsDeleted();
            obj.Save();

            DialogCategory_Load(sender, e);
        }

        private void DialogOutItems_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
