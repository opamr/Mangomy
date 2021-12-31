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

namespace MyApplication.Vendors
{
    public partial class DialogBillDetails : Form
    {
        int MyBillId;        
        public DialogBillDetails(int id1)
        {
            MyBillId = id1;
            InitializeComponent();
        }

        private void FrmBillGoods_Load(object sender, EventArgs e)
        {
            TblVendorsBills bb = new TblVendorsBills();
            bb.Where.Bill_ID.Value = MyBillId;
            if (!bb.Query.Load())
            {
                this.Close();
            }

            //load Bill data
            ViewVendorsGoods x = new ViewVendorsGoods();
            x.Where.Bill_id.Value = MyBillId;
            if (x.Query.Load())
            {
                LblBillType.Text = x.Bill_PayType;
                lblVendorname.Text = x.Vendor_Name;
                lblSender.Text = x.Bill_Sender;
                lblDetails.Text = x.Bill_Details;
                lblBillVendorNumber.Text = x.Bill_VendorNumber;
                lblDeliveryDate.Text = x.Bill_Date.ToShortDateString();
                lblDiscount.Text = x.Bill_Discount_Money.ToString();
                

                ClassVendorBillTotal cs = new ClassVendorBillTotal(MyBillId);
                lblBillTotal.Text = cs.BillTotal.ToString("0.00");
                lblTotalAfterDiscount.Text = cs.BillTotalWithOutVat.ToString("0.00");

                lblVat.Text = cs.BillVat.ToString("0.00");
                lblAfterVat.Text= cs.BillTotalAfterDiscount.ToString("0.00");
            }           

            //-------------تفاصيل اصناف الفاتورة            
            listView1.Items.Clear();
            ListViewItem lv;
            ViewVendorsGoods obj = new ViewVendorsGoods();
            obj.Where.Bill_id.Value = MyBillId;
            if (obj.Query.Load())
            {
                int r = 0;
                do
                {
                    ++r;
                    lv = new ListViewItem(obj.Good_id.ToString());
                    lv.SubItems.Add(r.ToString());
                    lv.SubItems.Add(obj.Barcode_Code);
                    lv.SubItems.Add(obj.Good_TraidName);
                    lv.SubItems.Add(obj.Barcode_Unit);
                    lv.SubItems.Add(obj.Good_Count.ToString());
                    lv.SubItems.Add(obj.Good_Price.ToString());
                    lv.SubItems.Add(obj.Good_Total.ToString());
                    lv.SubItems.Add(obj.Good_FreeBones.ToString());
                    lv.SubItems.Add(obj.Barcode_PayPrice);
                    listView1.Items.Add(lv);
                } while (obj.MoveNext());
            }

        }                

        private void btnEditBill_Click(object sender, EventArgs e)
        {
            MyApplication.Vendors.DialogNewBill obj = new MyApplication.Vendors.DialogNewBill(MyBillId);
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                FrmBillGoods_Load(sender, e);
            }
        }

        private void FrmBillGoods_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            FrmPrintVendorBill x = new FrmPrintVendorBill(MyBillId);
            x.ShowDialog();
        }
    }
}
