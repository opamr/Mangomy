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
namespace MyApplication
{
    public partial class DialogAddOutComing : Form
    {
        int MyId;
        public DialogAddOutComing(int id1)
        {
            MyId = id1;
            InitializeComponent();
        }

        double VatValue = 0;
        private void DialogAddOutComing_Load(object sender, EventArgs e)
        {
            TblBanks y = new TblBanks();
            y.LoadAll();
            if (y.RowCount > 0)
            {
                comboBanks.DisplayMember = TblBanks.ColumnNames.Bank_Name;
                comboBanks.ValueMember = TblBanks.ColumnNames.Bank_ID;
                comboBanks.DataSource = y.DefaultView;
            }
            
            TblOutComingItems obj = new TblOutComingItems();
            obj.LoadAll();
            if (obj.RowCount>0)
            {
                comboBox1.DisplayMember = TblOutComingItems.ColumnNames.Item_name;
                comboBox1.ValueMember = TblOutComingItems.ColumnNames.Item_Id;
                comboBox1.DataSource = obj.DefaultView;
            }

            TblVat vv = new TblVat();
            vv.LoadByPrimaryKey(1);
            VatValue = vv.Vat_Value;

            if (MyId != 0)
            {
                TblOutComings tt = new TblOutComings();
                tt.LoadByPrimaryKey(MyId);

                VatValue = tt.Out_Vat_Value;

                if (tt.Out_Vat == 0)
                {
                    checkBox1.Checked = true;
                }

                txtTotal.Text = tt.s_Out_Money;

                txtDetails.Text = tt.Out_Details;
                txtNotes.Text = tt.Out_Notes;
                txtWasl.Text = tt.Out_WaslNumber;
                comboBox1.SelectedValue = tt.Item_Id;
                dateTimePicker1.Text = tt.Out_Date.ToShortDateString();
                comboBanks.SelectedValue = tt.Bank_Id;
                btnDelete.Visible = true;
                BtnNewOut.BackgroundImage = Properties.Resources.SaveEdit;
                this.Text = "تعديل";
            }
        }

        private void txtmoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        private void BtnNewOut_Click(object sender, EventArgs e)
        {
            if (txtWasl.Text == "")
            {
                MessageBox.Show("تأكد من كتابة رقم السند");
                return;
            }

            if (txtTotal.Text != "" && txtDetails.Text != "" && comboBox1.Items.Count >0)
            {
                TblOutComings obj = new TblOutComings();
                if (MyId == 0)
                {                    
                    obj.AddNew();                
                }
                else
                {                    
                    obj.LoadByPrimaryKey(MyId);                  
                }

                obj.Out_Date = DateTime.Parse(dateTimePicker1.Text).Date;
                obj.Out_Time = DateTime.Now.ToShortTimeString();
                obj.User_Id = GlobalVar.user_Id;
                obj.Out_Details = txtDetails.Text;
                obj.Out_Notes = txtNotes.Text;
                obj.Out_WaslNumber = txtWasl.Text;
                obj.Item_Id = int.Parse(comboBox1.SelectedValue.ToString());
                obj.Bank_Id = int.Parse(comboBanks.SelectedValue.ToString());
                obj.Out_Money = double.Parse(txtTotal.Text);
                obj.Out_Vat_Value = VatValue;
                obj.Out_Vat = double.Parse(lblVat.Text);
                obj.s_Out_BeforeVat = lblBeforeVat.Text;
                obj.Save();      

                this.Close();
                                                         
            }
            else
            {
                MessageBox.Show("تأكد من كتابة المبلغ والتفاصيل بشكل صحيح");
            }
        }      

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("تأكيد حذف هذا البند", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {
                TblOutComings obj = new TblOutComings();
                obj.LoadByPrimaryKey(MyId);
                obj.MarkAsDeleted();
                obj.Save();

                this.Close();
            }
        }       

        private void DialogAddOutComing_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtmoney_TextChanged(object sender, EventArgs e)
        {
            if (txtTotal.Text != "" && txtTotal.Text != "")
            {
                if (checkBox1.Checked == true)
                {
                    lblBeforeVat.Text = (double.Parse(txtTotal.Text) / (1 + (VatValue / 100))).ToString("0.00");
                    lblVat.Text = (double.Parse(txtTotal.Text) - double.Parse(lblBeforeVat.Text)).ToString("0.00");
                }
                else
                {
                    lblVat.Text = "0";
                    lblBeforeVat.Text = txtTotal.Text;
                }
            }
            else
            {
                lblVat.Text = lblBeforeVat.Text = "0";
            }
        }
    }
}
