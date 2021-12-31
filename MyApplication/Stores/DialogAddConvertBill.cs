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
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Web;

namespace MyApplication.Store
{
    public partial class DialogAddConvertBill : Form
    {
        int MyConvertID;
        public DialogAddConvertBill(int ConvertID)
        {
            MyConvertID = ConvertID;
            InitializeComponent();
        }

        private void DialogAddConvertBill_Load(object sender, EventArgs e)
        {           
            TblStores sa;
            sa = new TblStores();
            sa.LoadAll();
            comboBoxFrom.DisplayMember = TblStores.ColumnNames.Store_Name;
            comboBoxFrom.ValueMember = TblStores.ColumnNames.Store_ID;
            comboBoxFrom.DataSource = sa.DefaultView;

            sa = new TblStores();
            sa.LoadAll();
            comboBoxTo.DisplayMember = TblStores.ColumnNames.Store_Name;
            comboBoxTo.ValueMember = TblStores.ColumnNames.Store_ID;
            comboBoxTo.DataSource = sa.DefaultView;

            //------------------------------------------------load Ctaegories
            TblGoodsCategory gc = new TblGoodsCategory();
            gc.LoadAll();
            if (gc.RowCount > 0)
            {
                ComboCategories.ValueMember = TblGoodsCategory.ColumnNames.Ctaegory_ID;
                ComboCategories.DisplayMember = TblGoodsCategory.ColumnNames.Category_Name;
                ComboCategories.DataSource = gc.DefaultView;
            }

            lblConvertNumber.Text = MyConvertID.ToString();

            if (MyConvertID != 0)
            {               
                TblStoreConverts cc = new TblStoreConverts();
                cc.LoadByPrimaryKey(MyConvertID);
                dateTimePicker5.Text = cc.Convert_Date.ToShortDateString();
                comboBoxFrom.SelectedValue = cc.Convert_From;
                comboBoxTo.SelectedValue = cc.Convert_To;

                ViewStoreConvertDetails obj = new ViewStoreConvertDetails();
                obj.Where.Convert_Id.Value = MyConvertID;
                if (obj.Query.Load())
                {
                    do
                    {
                        dataGridView1.Rows.Add(obj.Detail_ID, obj.Barcode_Id, dataGridView1.Rows.Count + 1, obj.Good_TraidName,obj.Barcode_Unit, obj.Detail_Count, "حذف");
                    } while (obj.MoveNext());
                }
            }
        }

        private void ComboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //-------------------------------------load combo
            TblGoodsTitles x3 = new TblGoodsTitles();
            if (int.Parse(ComboCategories.SelectedValue.ToString()) == 1)
            {
                x3.LoadAll();
                x3.Sort = TblGoodsTitles.ColumnNames.Good_TraidName + " ASC";
                comboGoods.ValueMember = TblGoodsTitles.ColumnNames.Title_ID;
                comboGoods.DisplayMember = TblGoodsTitles.ColumnNames.Good_TraidName;
                comboGoods.DataSource = x3.DefaultView;
            }
            else
            {
                x3.Where.Category_Id.Value = int.Parse(ComboCategories.SelectedValue.ToString());
                if (x3.Query.Load())
                {
                    x3.Sort = TblGoodsTitles.ColumnNames.Good_TraidName + " ASC";
                    comboGoods.ValueMember = TblGoodsTitles.ColumnNames.Title_ID;
                    comboGoods.DisplayMember = TblGoodsTitles.ColumnNames.Good_TraidName;
                    comboGoods.DataSource = x3.DefaultView;
                }
            }
        }

        private void BtnAddToBill_Click(object sender, EventArgs e)
        {
            if (comboBoxFrom.SelectedValue == comboBoxTo.SelectedValue)
            {
                MessageBox.Show("يجب ضبط مستدوعات التحويل");
                return;
            }            

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (int.Parse(comboGoods.SelectedValue.ToString()) == int.Parse(row.Cells["ColumnGoodID"].Value.ToString()))
                {
                    MessageBox.Show("هذا الصنف مسجل في الفاتورة من قبل");
                    return;
                }
            }

            if (txtCount.Text != "" && txtCount.Text != "0")
            {
                dataGridView1.Rows.Add(0, comboUnits.SelectedValue, dataGridView1.Rows.Count + 1, comboGoods.Text, comboUnits.Text,
                       txtCount.Text, "حذف");
            }

            txtCount.Text = "0";
            comboGoods.Focus();
        }

        private void BtnSaveBill_Click(object sender, EventArgs e)
        {
            if (comboBoxFrom.SelectedValue.ToString() == comboBoxTo.SelectedValue.ToString())
            {
                MessageBox.Show("يجب ضبط مستدوعات التحويل");
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
          

            TblStoreConverts sa = new TblStoreConverts();
            if (MyConvertID == 0)
            {
                sa.AddNew();

                int NewID = 0;
                TblStoreConverts vb = new TblStoreConverts();
                vb.LoadAll();
                if (vb.RowCount > 0)
                {
                    vb.Sort = TblStoreConverts.ColumnNames.Convert_ID + " DESC";
                    NewID = vb.Convert_ID + 1;
                }
                else
                {
                    NewID = 1;
                }

                sa.Convert_ID = NewID;
            }
            else
            {
                sa.LoadByPrimaryKey(MyConvertID);
            }
            sa.Convert_Date = DateTime.Parse(dateTimePicker5.Text);
            sa.Convert_From = int.Parse(comboBoxFrom.SelectedValue.ToString());
            sa.Convert_To = int.Parse(comboBoxTo.SelectedValue.ToString());
            sa.User_Id = GlobalVar.user_Id;
            sa.Save();

            if (MyConvertID != 0)
            {
                TblStoreConvertDetails xc = new TblStoreConvertDetails();
                xc.Where.Convert_Id.Value = MyConvertID;
                if (xc.Query.Load())
                {
                    do
                    {
                        int result = 0;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (xc.Detail_ID == int.Parse(row.Cells["ColumnID"].Value.ToString()))
                            {
                                result = 1;
                            }
                        }

                        if (result == 0)
                        {
                            xc.MarkAsDeleted();
                            xc.Save();
                        }
                    } while (xc.MoveNext());
                }
            }          

            MyConvertID = sa.Convert_ID;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                TblStoreConvertDetails py = new TblStoreConvertDetails();
                if (row.Cells["ColumnID"].Value.ToString() == "0")
                {
                    py.AddNew();
                }
                else
                {
                    py.LoadByPrimaryKey(int.Parse(row.Cells["ColumnID"].Value.ToString()));
                }
                py.Convert_Id = MyConvertID;
                py.Barcode_Id = int.Parse(row.Cells["ColumnGoodID"].Value.ToString());                
                py.Detail_Count = double.Parse(row.Cells["ColumnCount"].Value.ToString());                
                py.Save();
            }
                   

            this.Close();
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
                        dataGridView1.Rows.RemoveAt(e.RowIndex);                        
                    }
                }
            }
        }
              

        private void comboGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            TblGoodsBarcode obj = new TblGoodsBarcode();
            obj.Where.Titel_Id.Value = int.Parse(comboGoods.SelectedValue.ToString());
            if (obj.Query.Load())
            {
                comboUnits.DisplayMember = TblGoodsBarcode.ColumnNames.Barcode_Unit;
                comboUnits.ValueMember = TblGoodsBarcode.ColumnNames.Barcode_ID;
                comboUnits.DataSource = obj.DefaultView;
            }

            if (comboGoods.Items.Count > 0 && comboBoxFrom.Items.Count > 0 && comboBoxTo.Items.Count > 0)
            {
                int GoodId = int.Parse(comboGoods.SelectedValue.ToString());
                int Store1 = int.Parse(comboBoxFrom.SelectedValue.ToString());
                int Store2 = int.Parse(comboBoxTo.SelectedValue.ToString());

                ClassFollowGood cs = new ClassFollowGood(GoodId, Store1);
                lblStore1.Text = cs.CurrentCount.ToString();

                ClassFollowGood cs2 = new ClassFollowGood(GoodId, Store2);
                lblStore2.Text = cs2.CurrentCount.ToString();
            }
        }

        private void BtnDeleteBill_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show(" تأكيد الحذف ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {
                TblStoreConvertDetails sa = new TblStoreConvertDetails();
                sa.Where.Convert_Id.Value = MyConvertID;
                if (sa.Query.Load())
                {
                    sa.DeleteAll();
                    sa.Save();
                }

                TblStoreConverts obj = new TblStoreConverts();
                obj.LoadByPrimaryKey(MyConvertID);
                obj.MarkAsDeleted();
                obj.Save();

                this.Close();
            }
        }

        private void DialogAddConvertBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void comboUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboGoods.Items.Count > 0 && comboBoxFrom.Items.Count > 0 && comboBoxTo.Items.Count > 0)
            {
                int GoodId = int.Parse(comboGoods.SelectedValue.ToString());
                int Store1 = int.Parse(comboBoxFrom.SelectedValue.ToString());
                int Store2 = int.Parse(comboBoxTo.SelectedValue.ToString());

                ClassFollowGood cs = new ClassFollowGood(GoodId, Store1);
                lblStore1.Text = cs.CurrentCount.ToString();

                ClassFollowGood cs2 = new ClassFollowGood(GoodId, Store2);
                lblStore2.Text = cs2.CurrentCount.ToString();
            }
        }

        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboUnits_SelectedIndexChanged(sender, e);
        }
    }
}
