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
    public partial class DialogUnits : Form
    {
        int MyEditID;
        public DialogUnits()
        {
            InitializeComponent();
        }

        private void DialogUnits_Load(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            ListViewItem lv;
            panel1.Visible = panel2.Visible = false;

            TblGoodUnits obj = new TblGoodUnits();
            obj.LoadAll();
            if (obj.RowCount > 0)
            {                
                int g = 0;
                do
                {
                    ++g;
                    lv = new ListViewItem(obj.Unit_ID.ToString());
                    lv.SubItems.Add(g.ToString());
                    lv.SubItems.Add(obj.Unit_Name);
                    listView3.Items.Add(lv);
                } while (obj.MoveNext());
            }
        }

        private void txtCategoryName_MouseClick(object sender, MouseEventArgs e)
        {
            txtCategoryName.Text = "";
            txtCategoryName.ForeColor = Color.Black;
        }

        private void BtnShowAdd_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            txtCategoryName.Text = "اكتب اسم الوحدة هنا";
            txtCategoryName.ForeColor = Color.Gray;
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text != "")
            {
                TblGoodUnits obj = new TblGoodUnits();
                obj.AddNew();
                obj.Unit_Name = txtCategoryName.Text;
                obj.Save();
                DialogUnits_Load(sender, e);
            }
            else
            {
                txtCategoryName.Text = "اكتب اسم الوحدة هنا";
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
                TblGoodUnits obj = new TblGoodUnits();
                obj.LoadByPrimaryKey(MyEditID);
                obj.Unit_Name = txtEdit.Text;
                obj.Save();
                DialogUnits_Load(sender, e);
            }
            else
            {
                txtEdit.Text = "اكتب اسم الوحدة هنا";
                txtEdit.ForeColor = Color.Gray;
            }
        }
    }
}
