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

namespace MyApplication.Store
{
    public partial class DialogConvertsBills : Form
    {
        public DialogConvertsBills()
        {
            InitializeComponent();
        }

        private void DialogConvertsBills_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ListViewItem lv;

            ViewStoreConverts obj = new ViewStoreConverts();
            obj.LoadAll();
            if (obj.RowCount > 0)
            {
                int g = 0;
                do
                {
                    lv = new ListViewItem(g.ToString());
                    lv.SubItems.Add(obj.Convert_ID.ToString());
                    lv.SubItems.Add(obj.Convert_Date.ToShortDateString());
                    lv.SubItems.Add(obj.FromStore);
                    lv.SubItems.Add(obj.ToStore);
                    lv.SubItems.Add(obj.User_Name);
                    listView1.Items.Add(lv);
                } while (obj.MoveNext());
            }
        }

        private void BtnAddBill_Click(object sender, EventArgs e)
        {
            Store.DialogAddConvertBill obj = new DialogAddConvertBill(0);
            obj.ShowDialog();
            if (obj.DialogResult== DialogResult.OK)
            {
                DialogConvertsBills_Load(sender, e);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            int id = int.Parse(item.SubItems[1].Text);

            Store.DialogAddConvertBill obj = new DialogAddConvertBill(id);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                DialogConvertsBills_Load(sender, e);
            }
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ListViewItem lv;

            ViewStoreConverts obj = new ViewStoreConverts();
            obj.Where.Convert_Date.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text);
            obj.Where.Convert_Date.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text);
            obj.Where.Convert_Date.Operator = WhereParameter.Operand.Between;
            if (obj.Query.Load())
            {
                int g = 0;
                do
                {
                    lv = new ListViewItem(g.ToString());
                    lv.SubItems.Add(obj.Convert_ID.ToString());
                    lv.SubItems.Add(obj.Convert_Date.ToShortDateString());
                    lv.SubItems.Add(obj.FromStore);
                    lv.SubItems.Add(obj.ToStore);
                    lv.SubItems.Add(obj.User_Name);
                    listView1.Items.Add(lv);
                } while (obj.MoveNext());
            }
        }
    }
}
