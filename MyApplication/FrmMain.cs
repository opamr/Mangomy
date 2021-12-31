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
using System.Threading;

namespace MyApplication
{
    public partial class FrmMain : Form
    {      
        public FrmMain()
        {
            Thread.CurrentThread.CurrentUICulture =
      System.Globalization.CultureInfo.GetCultureInfo("en-PK");
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            TblGoodsTitles obj = new TblGoodsTitles();
            obj.Where.Good_RequiredCount.Value = 0;
            obj.Where.Good_RequiredCount.Operator = WhereParameter.Operand.GreaterThan;
            if (obj.Query.Load())
            {
                lblRequiredGoods.Text = obj.RowCount.ToString();
                lblRequiredGoods.BackColor = Color.Tomato;
            }
            else
            {
                lblRequiredGoods.Text = "0";
                lblRequiredGoods.BackColor = Color.Yellow;
            }

            this.KeyPreview = true;

            TblUsers u = new TblUsers();
            u.LoadByPrimaryKey(GlobalVar.user_Id);
            lblUser.Text = u.User_Name;          

                        
            panel1.Visible = true;

            AddSalary();       
        }

        private void AddSalary()
        {
            TblEmployeesData obj = new TblEmployeesData();
            obj.Where.Emp_Archive.Value = "لا";
            if (obj.Query.Load())
            {
                do
                {
                    TblEmployeesSalary sa = new TblEmployeesSalary();
                    sa.Where.Salary_Month.Value = DateTime.Now.Month;
                    sa.Where.Salary_Year.Value = DateTime.Now.Year;
                    sa.Where.Emp_Id.Value = obj.Emp_ID;
                    if (!sa.Query.Load())
                    {
                        var DaysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                        var lastDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DaysInMonth);

                        sa.AddNew();
                        sa.Salary_Month = DateTime.Now.Month;
                        sa.Salary_Year = DateTime.Now.Year;
                        sa.Emp_Id = obj.Emp_ID;
                        sa.Salary_Money = obj.Emp_Salary;
                        sa.Salary_House = obj.Emp_House;
                        sa.Salary_Details = "راتب شهر " + DateTime.Now.Month + " / " + DateTime.Now.Year;
                        sa.Salary_Date = lastDay;
                        sa.Save();
                    }
                } while (obj.MoveNext());
            }
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                BtnNewBill_Click(sender, e);              
            }
            else if (e.KeyCode == Keys.F2)
            {
                BtnNewCustomerPay_Click(sender, e);              
            }
            else if (e.KeyCode == Keys.F3)
            {
                إضافةفاتورةToolStripMenuItem_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F4)
            {
                BtnAddVendorPay_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                BtnAddComing_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F6)
            {
                تسليمراتبToolStripMenuItem_Click(sender, e);
            }
        }

        private void عرضفواتيرالشراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 9);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }
         
          
            panel1.Visible = false;
           Vendors.FrmCurrentBills obj = new Vendors.FrmCurrentBills();
            obj.MdiParent = this;
            obj.Show();
        }

        private void كلالأصنافالحاليةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 25);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

           
            panel1.Visible = false;
            FrmAllGoods obj = new FrmAllGoods();
            obj.MdiParent = this;
            obj.Show();
        }

        private void الرئيسيةToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            panel1.Visible = true;
            FrmMain_Load(sender, e);          
        }

        private void إضافةفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 8);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            Vendors.DialogNewBill obj = new Vendors.DialogNewBill(0);
            obj.Show();            
        }

        private void تسجيلخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Form1")
                    Application.OpenForms[i].Close();
            }
        }      

        private void بياناتالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 2);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            } 
            
           
            FrmVendorsData obj1 = new FrmVendorsData();
            panel1.Visible = false;
            obj1.MdiParent = this;
            obj1.Show();
        }    
     
        private void AddNewCustomermenu_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 13);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            } 

          
            FrmCustomersData obj1 = new FrmCustomersData();
            panel1.Visible = false;
            obj1.MdiParent = this;
            obj1.Show();
        }       

        private void الموقفالماليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 36);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }  
            
           
            FrmSafeAll obj1 = new FrmSafeAll();
            panel1.Visible = false;
            obj1.MdiParent = this;
            obj1.Show();
        }

        private void حساباتاجلهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 37);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }  
            
         
            FrmVendorsMoney obj1 = new FrmVendorsMoney();
            panel1.Visible = false;
            obj1.MdiParent = this;
            obj1.Show();
        }

        private void ربحيةفاتورةمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 38);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }  
            
         
            FrmProfitBills obj1 = new FrmProfitBills();
            panel1.Visible = false;
            obj1.MdiParent = this;
            obj1.Show();
        }      

        private void الخزينةToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Banks.FrmBanks obj1 = new Banks.FrmBanks();
            panel1.Visible = false;
            obj1.MdiParent = this;
            obj1.Show();
        }
    
       
        private void الفئاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 28);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }  
            
            DialogUnits obj = new DialogUnits();
            obj.Show();
        }                       
      
        private void طباعةاستيكرباركودToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 30);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }  

            Goods.DialogSelectGoodsBarCode obj = new Goods.DialogSelectGoodsBarCode();
            obj.Show();
        }      

        private void قائمةالطلبToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 40);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }  

            Attentions.DialogRequiredGoods obj = new Attentions.DialogRequiredGoods();
            obj.Show();
        }

        private void بياناتالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 34);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }
           
           
            panel1.Visible = false;
            Validations.FrmUsers obj = new Validations.FrmUsers();
            obj.MdiParent = this;
            obj.Show();
        }

        private void تعديلبياناتيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validations.DialogEditUserNameAndPass obj = new Validations.DialogEditUserNameAndPass(GlobalVar.user_Id);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                FrmMain_Load(sender, e);
            }
        }

        private void الوحداتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalVar.user_Id != 1)
            {
                return;
            }

            Goods.DialogUnits obj = new Goods.DialogUnits();
            obj.Show();
        }

        private void المستودعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalVar.user_Id != 1)
            {
                return;
            }

            Goods.DialogStores obj = new Goods.DialogStores();
            obj.Show();
        }       
    
        private void تحويلبينالمستودعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 43);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            Store.DialogConvertsBills obj = new Store.DialogConvertsBills();            
            obj.Show();
        }

        private void BtnDailyReport_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 44);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            Finance.DialogDailyReport obj = new Finance.DialogDailyReport();
            obj.Show();
        }     

        private void بياناتالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalVar.user_Id != 1)
            {
                return;
            }

            Employees.FrmEmployeesData obj = new Employees.FrmEmployeesData();
            panel1.Visible = false;
            obj.MdiParent = this;
            obj.Show();
        }

        private void حساباتالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalVar.user_Id != 1)
            {
                return;
            }

            Employees.FrmEmployeesSalary obj = new Employees.FrmEmployeesSalary();
            panel1.Visible = false;
            obj.MdiParent = this;
            obj.Show();
        }

        private void BtnNewBill_Click(object sender, EventArgs e)
        {
            DialogNewOrder obj = new DialogNewOrder(0);
            obj.Show();
        }
     
        private void المصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 22);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            FrmOutComing obj1 = new FrmOutComing();
            panel1.Visible = false;
            obj1.MdiParent = this;
            obj1.Show();
        }

        private void بنودالمصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutComing.DialogOutItems obj = new OutComing.DialogOutItems();
            obj.ShowDialog();
        }

        private void تقريرضريبةالقيمةالمضافةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Finance.DialogVatDetails obj = new Finance.DialogVatDetails();
            obj.ShowDialog();
        }             

        private void بحثيوميToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 19);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }


            FrmSearchPayments obj1 = new FrmSearchPayments();
            panel1.Visible = false;
            obj1.MdiParent = this;
            obj1.Show();
        }

        private void بحثمتقدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 19);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            Payments.DialogAdvancedSearchPayments obj1 = new Payments.DialogAdvancedSearchPayments();
            obj1.Show();
        }

        private void BtnAddVendorPay_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 6);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            Vendors.DialogAddVendorPaying obj = new Vendors.DialogAddVendorPaying(0, 0);
            obj.ShowDialog();
        }

        private void BtnNewCustomerPay_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 17);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            Customers.DialogAddCustomerPaying obj = new Customers.DialogAddCustomerPaying(0, 0, "سند قبض");
            obj.ShowDialog();
        }

        private void قيمةالضريبةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalVar.user_Id != 1)
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            Finance.DialogVatValue obj = new Finance.DialogVatValue();
            obj.ShowDialog();
        }

        private void أرشيفالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalVar.user_Id != 1)
            {
                return;
            }

            Employees.DialogEmployeesArchive obj = new Employees.DialogEmployeesArchive();
            obj.ShowDialog();
        }

        private void الجردالسنويToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalVar.user_Id != 1)
            {
                return;
            }

            StoreReview.DialogStoreReviews obj = new StoreReview.DialogStoreReviews();
            obj.ShowDialog();
        }

        private void التقريرالشهريToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalVar.user_Id != 1)
            {
                return;
            }

            Finance.DialogTotalMonthReport obj = new Finance.DialogTotalMonthReport();
            obj.ShowDialog();
        }

        private void تسليمراتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 42);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            Employees.DialogTakeSalary obj = new Employees.DialogTakeSalary(0, 0);
            obj.ShowDialog();
        }

        private void BtnAddComing_Click(object sender, EventArgs e)
        {
            ClassValidation xx = new ClassValidation(GlobalVar.user_Id, 23);
            if (xx.Allow == "no")
            {
                MessageBox.Show("عفواً .. غير مسموح لك فتح هذه الشاشة");
                return;
            }

            DialogAddOutComing obj = new DialogAddOutComing(0);
            obj.ShowDialog();
        }
    }
}

