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
    public partial class FrmAllFinancial : Form
    {
        public FrmAllFinancial()
        {
            InitializeComponent();
        }

        private void FrmAllFinancial_Load(object sender, EventArgs e)
        {
            //********************************load payments
            //---------------------------------------------------load customers payments
            double payments = 0; // المبيعات            
            double Profit = 0;
            TblCustomersBills obj = new TblCustomersBills();
            obj.Where.Bill_Date.BetweenBeginValue = DateTime.Parse(dateTimePickerFrom.Text);
            obj.Where.Bill_Date.BetweenEndValue = DateTime.Parse(dateTimePickerTO.Text);
            obj.Where.Bill_Date.Operator = WhereParameter.Operand.Between;
            if (obj.Query.Load())
            {
                
                do
                {
                    ViewCustomerPayments py = new ViewCustomerPayments();
                    py.Where.CustomerBill_Id.Value = obj.Bill_ID;
                    if (py.Query.Load())
                    {
                      
                        do
                        {
                            if (obj.Bill_Type=="فاتورة مرتجعات")
                            {
                               
                                payments -= py.Pay_Total;
                                Profit -= py.Pay_Profit;
                            }
                            else
                            {
                                payments += py.Pay_Total;
                                Profit += py.Pay_Profit;
                            }
                           
                        } while (py.MoveNext());
                    }
                } while (obj.MoveNext());
            }


            lblPayments.Text = payments.ToString("0,0.00");
            lblGomla.Text = (payments - Profit).ToString("0,0.00");
            lblProfit.Text = Profit.ToString("0,0.00");
            //-----------------------------------------------------------------------------
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmAllFinancial_Load(sender, e);
        }
    }
}
