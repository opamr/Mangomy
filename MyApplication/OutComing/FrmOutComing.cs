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
    public partial class FrmOutComing : Form
    {
        string MySearchType;
        public FrmOutComing()
        {
            InitializeComponent();
            MySearchType = "date";
        }

        private void FrmAddOutComing_Load(object sender, EventArgs e)
        {
            TblOutComingItems obj1 = new TblOutComingItems();
            obj1.LoadAll();
            if (obj1.RowCount > 0)
            {
                comboBox1.DisplayMember = TblOutComingItems.ColumnNames.Item_name;
                comboBox1.ValueMember = TblOutComingItems.ColumnNames.Item_Id;
                comboBox1.DataSource = obj1.DefaultView;
            }
         
            FillMyGrid();
        }

        private void FillMyGrid()
        {
            double Total = 0;
            listView1.Items.Clear();
            ListViewItem lv;

            ViewOutComing obj = new ViewOutComing();
            if (MySearchType == "date")
            {
                obj.Where.Out_Date.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text);
                obj.Where.Out_Date.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text);
                obj.Where.Out_Date.Operator = WhereParameter.Operand.Between;
                if (checkBox1.Checked == true)
                {
                    obj.Where.Item_Id.Value = int.Parse(comboBox1.SelectedValue.ToString());
                }
            }
            else if (MySearchType == "wasl")
            {
                obj.Where.Out_WaslNumber.Value = txtWasl.Text;
            }

                if (obj.Query.Load())
            {
                int g = 0;
                obj.Sort = ViewOutComing.ColumnNames.Out_Date + " ASC";
                do
                {

                    Total += obj.Out_Money;
                    ++g;
                    lv = new ListViewItem(obj.Out_ID.ToString());
                    lv.SubItems.Add(g.ToString());
                    lv.SubItems.Add(obj.Item_name);
                    lv.SubItems.Add(obj.Out_Date.ToShortDateString());
                    lv.SubItems.Add(obj.Out_WaslNumber);
                    lv.SubItems.Add(obj.Out_Money.ToString("0.00"));
                    lv.SubItems.Add(obj.Out_Vat.ToString("0.00"));
                    lv.SubItems.Add(obj.Out_Details);                    
                    lv.SubItems.Add(obj.Out_Notes);
                    lv.SubItems.Add(obj.Bank_Name);
                    listView1.Items.Add(lv);

                } while (obj.MoveNext());
            }
            lblAllOut.Text = Total.ToString("0,0.00");
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 23);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            DialogAddOutComing obj = new DialogAddOutComing(0);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                FrmAddOutComing_Load(sender, e);
            }
        }       
      
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 24);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            DialogResult d = MessageBox.Show("هل تريد التعديل على هذا البند", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int id = int.Parse(item.SubItems[0].Text);
                DialogAddOutComing obj = new DialogAddOutComing(id);
                obj.ShowDialog();
                if (obj.DialogResult == DialogResult.OK)
                {
                    FrmAddOutComing_Load(sender, e);
                }
            }
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            MySearchType = "date";
            FillMyGrid();
        }      

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            FrmPrintOutCome obj = new FrmPrintOutCome(DateTime.Parse(dateTimePicker1.Text), DateTime.Parse(dateTimePicker2.Text), lblAllOut.Text);
            obj.Show();
        }

        private void BtnOutItems_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 46);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }


            OutComing.DialogOutItems obj = new OutComing.DialogOutItems();
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                FrmAddOutComing_Load(sender, e);
            }
        }

        private void txtWasl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtWasl.Text != "")
            {
                MySearchType = "wasl";
                FillMyGrid();
            }
        }
    }
}
