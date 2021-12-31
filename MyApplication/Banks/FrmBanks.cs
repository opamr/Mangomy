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

namespace MyApplication.Banks
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            double Total = 0;

            dataGridView1.Rows.Clear();
            TblBanks obj = new TblBanks();
            obj.LoadAll();
            if (obj.RowCount >0)
            {
                int g = 0;
                do
                {
                    ClassSafe cs = new ClassSafe(obj.Bank_ID);
                    ++g;

                    Total += cs.MyBankNow;

                    dataGridView1.Rows.Add(obj.Bank_ID, g, obj.Bank_Name, cs.MyBankNow.ToString("0,0.00"), "كشف حساب", "تحويل");
                } while (obj.MoveNext());
            }

            lblTotal.Text = Total.ToString("0,0.00");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (GlobalVar.user_Id != 1)
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            DialogAddBank obj = new DialogAddBank(0);
            obj.ShowDialog();
            if (obj.DialogResult== DialogResult.OK)
            {
                FrmBanks_Load(sender,e);
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
                        ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 29);
                        if (xx.Allow == "no")
                        {
                            MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                            return;
                        }  

                        Banks.DialogBankFinance obj = new DialogBankFinance(RowID);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            FrmBanks_Load(sender, e);
                        }
                    }
                    else if (e.ColumnIndex == dataGridView1.Columns["ColumnConvert"].Index)
                    {
                        ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 32);
                        if (xx.Allow == "no")
                        {
                            MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                            return;
                        }  

                        Banks.DialogConvertMoney obj = new DialogConvertMoney(RowID, 0);
                        obj.ShowDialog();
                        if (obj.DialogResult == DialogResult.OK)
                        {
                            FrmBanks_Load(sender, e);
                        }
                    }                   
                }
            }
        }

        private void BtnAddOutMoney_Click(object sender, EventArgs e)
        {
            Banks.DialogConvertMoney obj = new DialogConvertMoney(0, 0);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                FrmBanks_Load(sender, e);
            }
        }
    }
}
