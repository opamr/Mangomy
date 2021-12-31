using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGeneration.dOOdads;
using MyPro;

namespace MyApplication.Employees
{
    public partial class DialogAddBones : Form
    {
        int MySalayID, MyBonesID;
        public DialogAddBones(int SalaryId,int BonesID)
        {
            MySalayID = SalaryId;
            MyBonesID = BonesID;
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }
       
        private void DialogAddBones_Load(object sender, EventArgs e)
        {
            TblEmployeesSalary sa = new TblEmployeesSalary();
            sa.LoadByPrimaryKey(MySalayID);
            lblDetails.Text = sa.Salary_Details;

            if (MyBonesID != 0)
            {
                TblEmployeesBones obj = new TblEmployeesBones();
                obj.LoadByPrimaryKey(MyBonesID);
                txtMoney.Text = obj.Bones_Money.ToString();
                dateTimePicker5.Text = obj.Bones_Date.ToShortDateString();
                comboBox1.Text = obj.Bones_Type;
                txtDetails.Text = obj.Bones_Details;

                BtnDelete.Visible = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtDetails.Text != "")
            {
                TblEmployeesBones obj = new TblEmployeesBones();

                if (MyBonesID != 0)
                {
                    obj.LoadByPrimaryKey(MyBonesID);
                }
                else
                {
                    obj.AddNew();
                }
                obj.Salary_Id = MySalayID;
                obj.User_Id = GlobalVar.user_Id;
                obj.Bones_Money = double.Parse(txtMoney.Text);
                obj.Bones_Date = DateTime.Parse(dateTimePicker5.Text);
                obj.Bones_Type = comboBox1.Text;
                obj.Bones_Details = txtDetails.Text;
                obj.Save();

                this.Close();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show(" تأكيد الحذف ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {
                TblEmployeesBones obj = new TblEmployeesBones();
                obj.LoadByPrimaryKey(MyBonesID);
                obj.MarkAsDeleted();
                obj.Save();

                this.Close();
            }
        }

        private void DialogAddBones_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            var text = (sender as TextBox).Text;

            if (sender is TextBox && text != "0")
            {
                double num;
                double.TryParse(text, out num);

                if (num.ToString() != "0")
                {
                    (sender as TextBox).BackColor = Color.Yellow;
                    BtnSave.Enabled = true;
                }
                else
                {
                    (sender as TextBox).BackColor = Color.Red;
                    (sender as TextBox).Focus();
                    BtnSave.Enabled = false;
                }
            }
        }
    }
}
