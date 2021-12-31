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

namespace MyApplication.Attentions
{
    public partial class DialogRequiredGoods : Form
    {
        public DialogRequiredGoods()
        {
            InitializeComponent();
        }

        private void DialogRequiredGoods_Load(object sender, EventArgs e)
        {
            TblGoodsCategory x = new TblGoodsCategory();
            x.LoadAll();
            if (x.RowCount > 0)
            {
                comboCategory.ValueMember = TblGoodsCategory.ColumnNames.Ctaegory_ID;
                comboCategory.DisplayMember = TblGoodsCategory.ColumnNames.Category_Name;
                comboCategory.DataSource = x.DefaultView;
            }

            TblGoodsTitles gg = new TblGoodsTitles();
            gg.LoadAll();
            if (gg.RowCount > 0)
            {
                gg.Sort = TblGoodsTitles.ColumnNames.Good_TraidName + " ASC";
                comboBox1.ValueMember = TblGoodsTitles.ColumnNames.Title_ID;
                comboBox1.DisplayMember = TblGoodsTitles.ColumnNames.Good_TraidName;
                comboBox1.DataSource = gg.DefaultView;
            }
        }

        string MySearchType = "all";

        private void FillMyGrid()
        {
            double AllTotal = 0;

            dataGridView1.Rows.Clear();

            ViewGoods obj = new ViewGoods();
            obj.Where.Good_RequiredCount.Value = 0;
            obj.Where.Good_RequiredCount.Operator = WhereParameter.Operand.GreaterThan;
            if (MySearchType == "id")
            {
                obj.Where.Titel_Id.Value = int.Parse(comboBox1.SelectedValue.ToString());
            }
            else if (MySearchType == "category")
            {
                obj.Where.Category_Id.Value = int.Parse(comboCategory.SelectedValue.ToString());
            }
            else if (MySearchType == "name")
            {
                obj.Where.Good_TraidName.Value = "%" + txtSearchGood.Text + "%";
                obj.Where.Good_TraidName.Operator = WhereParameter.Operand.Like;
            }
            else if (MySearchType == "barcode")
            {
                obj.Where.Barcode_Code.Value = txtBarcode.Text;
            }
            if (obj.Query.Load())
            {
                do
                {
                    TblGoodsBarcode bb = new TblGoodsBarcode();
                    bb.Where.Titel_Id.Value = obj.Titel_Id;
                    bb.Query.Load();

                    double Total = obj.Good_RequiredCount * double.Parse(bb.Barcode_BuyPrice);

                    AllTotal += Total;

                    dataGridView1.Rows.Add(obj.Titel_Id, dataGridView1.Rows.Count + 1, obj.Good_TraidName, bb.Barcode_Code,
                        obj.Good_CurrentCount.ToString("0.00"), bb.Barcode_BuyPrice, obj.Good_RequiredCount.ToString("0.00"), Total.ToString("0,0.00"));
                } while (obj.MoveNext());
            }

            lblTotal.Text = AllTotal.ToString("0,0.00");
        }

        private void EditRow(int rowID, DataGridViewCellEventArgs e)
        {
            TblGoodsTitles obj = new TblGoodsTitles();
            obj.Where.Good_RequiredCount.Value = 0;
            obj.Where.Good_RequiredCount.Operator = WhereParameter.Operand.GreaterThan;
            obj.Where.Title_ID.Value = rowID;
            if (obj.Query.Load())
            {
                do
                {
                    TblGoodsBarcode bb = new TblGoodsBarcode();
                    bb.Where.Titel_Id.Value = obj.Title_ID;
                    bb.Query.Load();

                    double Total = obj.Good_RequiredCount * double.Parse(bb.Barcode_BuyPrice);

                    dataGridView1.CurrentRow.SetValues(obj.Title_ID, dataGridView1.Rows.Count + 1, obj.Good_TraidName, bb.Barcode_Code,
                         obj.Good_CurrentCount.ToString("0.00"), bb.Barcode_BuyPrice, obj.Good_RequiredCount.ToString("0.00"), Total.ToString("0.00"));
                } while (obj.MoveNext());
            }
            else
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
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
                        Goods.DialogFollowDetails obj = new Goods.DialogFollowDetails(RowID);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            EditRow(RowID, e);
                        }
                    }
                    else if (e.ColumnIndex == dataGridView1.Columns["ColumnEdit"].Index)
                    {
                        DialogAddGood obj = new DialogAddGood(RowID);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            EditRow(RowID, e);
                        }
                    }
                }
            }

        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            MySearchType = "category";
            FillMyGrid();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            MySearchType = "all";
            FillMyGrid();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                TblPrint pr = new TblPrint();
                pr.LoadAll();
                pr.DeleteAll();
                pr.Save();

                string Title = "تقرير قائمة الطلب من الأصناف";

                if (MySearchType == "category")
                {
                    Title += " للفئة : " + comboCategory.Text;
                }


                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    TblPrint obj = new TblPrint();
                    obj.AddNew();
                    obj.Column1 = Convert.ToString(row.Cells["Column1"].Value);
                    obj.Column2 = Convert.ToString(row.Cells["Column2"].Value);
                    obj.Column3 = Convert.ToString(row.Cells["Column3"].Value);
                    obj.Column4 = Convert.ToString(row.Cells["Column4"].Value);
                    obj.Column5 = Convert.ToString(row.Cells["Column5"].Value);
                    obj.Column6 = Convert.ToString(row.Cells["Column6"].Value);
                    obj.Column7 = Title;                    
                    obj.Save();
                }

                FrmPrintGoodsRequired x = new FrmPrintGoodsRequired();
                x.ShowDialog();
            }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtBarcode.Text != "")
                {
                    MySearchType = "barcode";
                    FillMyGrid();

                    txtBarcode.Text = "";
                }
            }
        }

        private void txtSearchGood_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtSearchGood.Text != "")
                {
                    MySearchType = "name";
                    FillMyGrid();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused)
            {
                return;
            }

            MySearchType = "id";
            FillMyGrid();
        }
    }
}
