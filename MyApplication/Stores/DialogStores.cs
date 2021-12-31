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
    public partial class DialogStores : Form
    {
        int MyEditID;
        public DialogStores()
        {
            InitializeComponent();
        }

        private void DialogCategory_Load(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            ListViewItem lv;
            panel1.Visible = panel2.Visible = false;

            TblStores obj = new TblStores();
            obj.LoadAll();
            if (obj.RowCount >0)
            {                
                int g = 0;
                do
                {
                    ++g;
                    lv = new ListViewItem(obj.Store_ID.ToString());
                    lv.SubItems.Add(g.ToString());
                    lv.SubItems.Add(obj.Store_Name);
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
            txtCategoryName.Text = "اكتب اسم المستودع هنا";
            txtCategoryName.ForeColor = Color.Gray;
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text != "")
            {
                TblStores obj = new TblStores();
                obj.AddNew();
                obj.Store_Name = txtCategoryName.Text;
                obj.Save();
                DialogCategory_Load(sender, e);
            }
            else
            {
                txtCategoryName.Text = "اكتب اسم المستودع هنا";
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
                TblStores obj = new TblStores();
                obj.LoadByPrimaryKey(MyEditID);
                obj.Store_Name = txtEdit.Text;
                obj.Save();
                DialogCategory_Load(sender, e);
            }
            else
            {
                txtEdit.Text = "اكتب اسم المستودع هنا";
                txtEdit.ForeColor = Color.Gray;
            }
        }

        private void txtEdit_MouseClick(object sender, MouseEventArgs e)
        {
            //txtEdit.Text = "";
            //txtEdit.ForeColor = Color.Black;
        }
    }
}
