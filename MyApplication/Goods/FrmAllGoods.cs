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
    public partial class FrmAllGoods : Form
    {        
        string MySearchType;
        public FrmAllGoods()
        {
            InitializeComponent();
            comboCurrrent.SelectedIndex = 0;
        }

        private void FrmAllGoods_Load(object sender, EventArgs e)
        {
            TblStores st = new TblStores();
            st.LoadAll();
            comboStores.DisplayMember = TblStores.ColumnNames.Store_Name;
            comboStores.ValueMember = TblStores.ColumnNames.Store_ID;
            comboStores.DataSource = st.DefaultView;


            //--------------------------------------------------------load category
            TblGoodsCategory x = new TblGoodsCategory();
            x.LoadAll();
            if (x.RowCount > 0)
            {
                comboCategory.ValueMember = TblGoodsCategory.ColumnNames.Ctaegory_ID;
                comboCategory.DisplayMember = TblGoodsCategory.ColumnNames.Category_Name;
                comboCategory.DataSource = x.DefaultView;
            }
            //------------------------


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

        private void FillMyGrid()
        {
            double allTotal = 0;
            double AllPayCost = 0;

            dataGridView1.Rows.Clear();

            ViewGoods obj = new ViewGoods();           
            if (comboCurrrent.SelectedIndex == 1)
            {
                obj.Where.Good_CurrentCount.Value = "0";
                obj.Where.Good_CurrentCount.Operator = WhereParameter.Operand.NotEqual;
            }
            else if (comboCurrrent.SelectedIndex == 2)
            {
                obj.Where.Good_CurrentCount.Value = "0";                
            }

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
                obj.Sort = ViewGoods.ColumnNames.Good_TraidName + " ASC";
                int r = 0;
                do
                {
                    //TblGoodsBarcode gr = new TblGoodsBarcode();
                    //gr.Where.Titel_Id.Value = obj.Titel_Id;
                    //gr.Query.Load();

                    double CurrentCount = 0;                    
                    if (checkBoxStore.Checked == true)
                    {
                        ClassFollowGood cs = new ClassFollowGood(obj.Titel_Id, int.Parse(comboStores.SelectedValue.ToString()));
                        CurrentCount = cs.CurrentCount / double.Parse(obj.Barcode_Count);                        
                    }
                    else
                    {
                        ClassFollowGood cs = new ClassFollowGood(obj.Titel_Id);
                        CurrentCount = cs.CurrentCount / double.Parse(obj.Barcode_Count);                        
                    }


                    TblGoodsCategory cat = new TblGoodsCategory();
                    cat.LoadByPrimaryKey(obj.Category_Id);


                    if (checkBoxStore.Checked == true)
                    {
                        if (CurrentCount > 0)
                        {
                                                       
                            double Total = CurrentCount * double.Parse(obj.Barcode_BuyPrice);

                            allTotal += Total;

                            AllPayCost += CurrentCount * double.Parse(obj.Barcode_PayPrice);

                            ++r;
                            dataGridView1.Rows.Add(obj.Titel_Id, r, cat.Category_Name, obj.Good_TraidName, obj.Barcode_Code, obj.Barcode_Unit,
                                CurrentCount.ToString("0.00"), obj.Barcode_PayPrice,
                                obj.Barcode_BuyPrice, Total.ToString("0,0.00"), "تتبُع");
                        }
                    }
                    else
                    {

                        double Total = CurrentCount * double.Parse(obj.Barcode_BuyPrice);

                        allTotal += Total;

                        AllPayCost += CurrentCount * double.Parse(obj.Barcode_PayPrice);

                        ++r;
                        dataGridView1.Rows.Add(obj.Titel_Id, r, cat.Category_Name, obj.Good_TraidName, obj.Barcode_Code, obj.Barcode_Unit,
                            CurrentCount.ToString("0.00"), obj.Barcode_PayPrice,
                            obj.Barcode_BuyPrice, Total.ToString("0,0.00"), "تتبُع");
                    }

                   

                } while (obj.MoveNext());
            }

            dataGridView1.ClearSelection();

            //lblAllTotal.Text = allTotal.ToString("0,0.00");
            //lblPayCost.Text = AllPayCost.ToString("0,0.00");
        }        

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            MySearchType = "all";
            FillMyGrid();
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
      
        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused)
            {
                return;
            }

            MySearchType = "category";
            FillMyGrid();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
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
       

        private void BtnNewGood_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 26);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            DialogAddGood obj = new DialogAddGood(0);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                FrmAllGoods_Load(sender, e);
            }
        }     

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 27);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = int.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                int comboindex = int.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()) - 1;
                DialogAddGood obj = new DialogAddGood(id);
                obj.ShowDialog();
                if (obj.DialogResult == DialogResult.OK)
                {
                    ViewGoods vv = new ViewGoods();
                    vv.Where.Titel_Id.Value = id;
                    if (vv.Query.Load())
                    {                     
                        dataGridView1["Column7", dataGridView1.CurrentRow.Index].Value = vv.Category_Name;
                        dataGridView1["Column3", dataGridView1.CurrentRow.Index].Value = vv.Good_TraidName;
                        dataGridView1["Column5", dataGridView1.CurrentRow.Index].Value = vv.Barcode_Code;
                        dataGridView1["Column8", dataGridView1.CurrentRow.Index].Value = vv.Barcode_Unit;

                        ClassFollowGood cs = new ClassFollowGood(vv.Titel_Id);

                        double CurrentCount = 0;
                        if (cs.CurrentCount != 0)
                        {
                            CurrentCount = cs.CurrentCount / double.Parse(vv.Barcode_Count);
                        }

                        dataGridView1["Column6", dataGridView1.CurrentRow.Index].Value = CurrentCount;
                        dataGridView1["Column4", dataGridView1.CurrentRow.Index].Value = vv.Barcode_PayPrice;
                        dataGridView1["Column9", dataGridView1.CurrentRow.Index].Value = vv.Barcode_BuyPrice.ToString();
                        dataGridView1["Column11", dataGridView1.CurrentRow.Index].Value = cs.CurrentCost.ToString("0,0.00");
                    }
                    else
                    {
                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (e.RowIndex >= 0)
                {
                    int Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString());

                    if (e.ColumnIndex == dataGridView1.Columns["Column12"].Index)
                    {
                        Goods.DialogFollowDetails obj = new Goods.DialogFollowDetails(Id);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            FillMyGrid();
                        }
                    }
                }
            }
        }

        private void BtnPrintSelected_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                TblPrint pr = new TblPrint();
                pr.LoadAll();
                pr.DeleteAll();
                pr.Save();

                DialogResult d = MessageBox.Show("هل تريد بالتأكيد طباعة الأصناف المحددة حالياً", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (d == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        TblPrint obj = new TblPrint();
                        obj.AddNew();
                        obj.Column1 = row.Cells["Column3"].Value.ToString();
                        obj.Column2 = row.Cells["Column6"].Value.ToString();
                        obj.Column3 = row.Cells["Column8"].Value.ToString();
                        obj.Column4 = row.Cells["Column9"].Value.ToString();
                        obj.Column5 = row.Cells["Column11"].Value.ToString();
                        obj.Save();
                    }

                    FrmPrintSelectedGoods obj1 = new FrmPrintSelectedGoods();
                    obj1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("لا يوجد اصناف للطباعة");
            }

        }

        private void BtnSearchByStore_Click(object sender, EventArgs e)
        {
            MySearchType = "store";
            FillMyGrid();
        }

        private void comboCurrrent_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused)
            {
                return;
            }

            FillMyGrid();
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
    }
}
