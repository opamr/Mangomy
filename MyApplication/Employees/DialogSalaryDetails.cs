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

namespace MyApplication.Employees
{
    public partial class DialogSalaryDetails : Form
    {
        int MySalaryID;
        public DialogSalaryDetails(int SalaryID)
        {
            MySalaryID = SalaryID;
            InitializeComponent();
        }

        private void DialogSalaryDetails_Load(object sender, EventArgs e)
        {
            ViewEmployeesSalary sa = new ViewEmployeesSalary();
            sa.Where.Salary_ID.Value = MySalaryID;
            if (sa.Query.Load())
            {
                lblDetails.Text = sa.Salary_Details;
                lblName.Text = sa.Emp_Name;                
                lblDate.Text = sa.Salary_Date.ToShortDateString();

                ClassEmployeesFinance cs = new ClassEmployeesFinance(sa.Emp_Id, sa.Salary_Month, sa.Salary_Year);
                
                lblSalary.Text = sa.Salary_Money.ToString("0,0");
                lblHouse.Text = sa.Salary_House.ToString("0,0");               
                lblTotalBones.Text = cs.TotalBones.ToString("0,0");
                lblTotalDiscount.Text = cs.TotalDiscount.ToString("0,0");
                lblTotalTake.Text = cs.TotalTakeMoney.ToString("0,0");
                lblRest.Text = cs.RestMoney.ToString("0,0");               
            }
            else
            {
                this.Close();
            }

            ListViewItem lv;
            listViewBones.Items.Clear();
            listViewTakeMoney.Items.Clear();

            ViewEmployeesBones bb = new ViewEmployeesBones();
            bb.Where.Salary_Id.Value = MySalaryID;
            if (bb.Query.Load())
            {
                int g = 0;
                do
                {
                    ++g;
                    lv = new ListViewItem(bb.Bones_ID.ToString());
                    lv.SubItems.Add(g.ToString());
                    lv.SubItems.Add(bb.Bones_Date.ToShortDateString());
                    lv.SubItems.Add(bb.Bones_Type + " - " + bb.Bones_Details);
                    lv.SubItems.Add(bb.Bones_Money.ToString());
                    lv.SubItems.Add(bb.User_Name);
                    listViewBones.Items.Add(lv);
                } while (bb.MoveNext());
            }

            ViewEmployeesSalaryPaying x = new ViewEmployeesSalaryPaying();
            x.Where.Salary_Id.Value = MySalaryID;
            if (x.Query.Load())
            {
                int g = 0;
                do
                {
                    ++g;
                    lv = new ListViewItem(x.Pay_ID.ToString());
                    lv.SubItems.Add(g.ToString());
                    lv.SubItems.Add(x.Pay_Date.ToShortDateString());
                    lv.SubItems.Add(x.Pay_Details);
                    lv.SubItems.Add(x.Pay_Money.ToString());
                    lv.SubItems.Add(x.User_Name);
                    listViewTakeMoney.Items.Add(lv);
                } while (x.MoveNext());
            }
        }

        private void btnAddBones_Click(object sender, EventArgs e)
        {
            DialogAddBones obj = new DialogAddBones(MySalaryID,0);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                DialogSalaryDetails_Load(sender, e);
            }
        }

        private void BtnEditSalary_Click(object sender, EventArgs e)
        {
            Employees.DialogAddOneSalary obj = new Employees.DialogAddOneSalary(MySalaryID);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                DialogSalaryDetails_Load(sender, e);
            }
        }

        private void BtnTakeMoney_Click(object sender, EventArgs e)
        {
            Employees.DialogTakeSalary obj = new Employees.DialogTakeSalary(MySalaryID,0);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                DialogSalaryDetails_Load(sender, e);
            }
        }

        private void listViewBones_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = listViewBones.SelectedItems[0];
            int id = int.Parse(item.SubItems[0].Text);

            DialogAddBones obj = new DialogAddBones(MySalaryID, id);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                DialogSalaryDetails_Load(sender, e);
            }
        }

        private void listViewTakeMoney_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = listViewTakeMoney.SelectedItems[0];
            int id = int.Parse(item.SubItems[0].Text);

            Employees.DialogTakeSalary obj = new Employees.DialogTakeSalary(MySalaryID, id);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                DialogSalaryDetails_Load(sender, e);
            }
        }

        private void DialogSalaryDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
       
    }
}
