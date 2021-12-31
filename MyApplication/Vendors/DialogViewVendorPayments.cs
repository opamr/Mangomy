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

namespace MyApplication.Vendors
{
    public partial class DialogViewVendorPayments : Form
    {
        int MyVendorID;
        string MySearchType;
        public DialogViewVendorPayments(int vendorId)
        {
            MyVendorID = vendorId;           
            InitializeComponent();
        }

        private void DialogViewVendorPayments_Load(object sender, EventArgs e)
        {
            MySearchType = "all";
            FillMyList();
        }

        private void FillMyList()
        {
            ListViewItem lv;
            ListPaying.Items.Clear();

            double Allpaying = 0;
            int g = 0;

            ViewVendorPaying py = new ViewVendorPaying();
            py.Where.Vendor_Id.Value = MyVendorID;
            if (MySearchType == "date")
            {
                py.Where.Ven_PayDate.BetweenBeginValue = DateTime.Parse(dateTimePicker1.Text);
                py.Where.Ven_PayDate.BetweenEndValue = DateTime.Parse(dateTimePicker2.Text);
                py.Where.Ven_PayDate.Operator = WhereParameter.Operand.Between;
            }
            if (py.Query.Load())
            {
                py.Sort = TblVendorsPaying.ColumnNames.Ven_PayDate + " ASC";
                do
                {
                    ++g;
                    Allpaying += py.Ven_PayMoney;

                    lv = new ListViewItem(py.Ven_PayID.ToString());
                    lv.SubItems.Add(g.ToString());
                    lv.SubItems.Add(py.Ven_PayDate.ToShortDateString());
                    lv.SubItems.Add(py.Ven_PayMoney.ToString());
                    lv.SubItems.Add(py.Vendor_Sendor);
                    lv.SubItems.Add(py.Ven_PayDetails);
                    lv.SubItems.Add(py.Bank_Name);
                    lv.SubItems.Add(py.User_Name);
                    ListPaying.Items.Add(lv);

                } while (py.MoveNext());

            }
            lblAllPaying.Text = Allpaying.ToString();
        }

        private void DialogViewVendorPayments_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ListPaying_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = ListPaying.SelectedItems[0];
            int id = int.Parse(item.SubItems[0].Text);

            MyApplication.Vendors.DialogAddVendorPaying vv = new MyApplication.Vendors.DialogAddVendorPaying(MyVendorID, id);
            vv.ShowDialog();
            if (vv.DialogResult == DialogResult.OK)
            {
                DialogViewVendorPayments_Load(sender, e);
            }
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            MySearchType = "date";
            FillMyList();
        }       
    }
}
