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
    public partial class FrmSafeAll : Form
    {
        public FrmSafeAll()
        {
            InitializeComponent();
        }

        private void FrmSafeAll_Load(object sender, EventArgs e)
        {
          
           
        }

        private void BtnLoadData_Click(object sender, EventArgs e)
        {
            double Safes = 0;

            dataGridView1.Rows.Clear();
            TblBanks obj = new TblBanks();
            obj.LoadAll();
            if (obj.RowCount > 0)
            {
                int g = 0;
                do
                {
                    ClassSafe cs = new ClassSafe(obj.Bank_ID);
                    Safes += cs.MyBankNow;

                    ++g;
                    dataGridView1.Rows.Add(obj.Bank_ID, g, obj.Bank_Name, cs.MyBankNow.ToString("0,0.00"));
                } while (obj.MoveNext());
            }



            double CurrentGod = 0;
            TblGoodsTitles cg = new TblGoodsTitles();
            cg.LoadAll();
            if (cg.RowCount > 0)
            {
                do
                {
                    ClassFollowGood cs = new ClassFollowGood(cg.Title_ID);
                    CurrentGod += cs.CurrentCost;
                } while (cg.MoveNext());
            }

            TblVat vv = new TblVat();
            vv.LoadByPrimaryKey(1);

            double Vat = CurrentGod * vv.Vat_Percent;
            lblGoodsBeforeVat.Text = CurrentGod.ToString("0,0.00");
            lblCurrentGods.Text = (Vat + CurrentGod).ToString("0,0.00");

            //-------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------أرصدة العملاء
            double CustomersRest = 0;
            TblCustomersData cd = new TblCustomersData();
            cd.Where.Customer_ID.Value = 1;
            cd.Where.Customer_ID.Operator = MyGeneration.dOOdads.WhereParameter.Operand.NotEqual;
            if (cd.Query.Load())
            {
                do
                {
                    ClassCustomerFinance cs = new ClassCustomerFinance(cd.Customer_ID);
                    CustomersRest += cs.CustomerFinance;

                } while (cd.MoveNext());
            }
            lblCustomers.Text = CustomersRest.ToString("0,0.00");

            ////----------------------------------------------------------------------------------------------
            ////--------------------------------------------------------------------------أرصدة الموردين
            double VendorsRest = 0;
            TblVendorsData vd = new TblVendorsData();
            vd.LoadAll();
            if (vd.RowCount > 0)
            {
                do
                {
                    ClassVendorFinance cs = new ClassVendorFinance(vd.Vendor_ID);
                    VendorsRest += cs.VendorRest;
                } while (vd.MoveNext());
            }
            lblVendorsRest.Text = VendorsRest.ToString("0,0.00");

            lblTotalAll.Text = (double.Parse(lblCurrentGods.Text) + Safes + CustomersRest - VendorsRest).ToString("0,0.00");
        }
    }
}
