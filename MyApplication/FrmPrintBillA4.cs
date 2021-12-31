using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MyPro;
using MyGeneration.dOOdads;
using System.IO;
using System.Drawing.Imaging;
using QRCoder;

namespace MyApplication
{
    public partial class FrmPrintBillA4 : Form
    {
        int MyBillId;
        
        public FrmPrintBillA4(int id)
        {
            MyBillId = id;
            
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sallerName">saller name </param>
        /// <param name="sallerTRN"> saller TRN</param>
        /// <param name="invoiceDateTime">invoice date time</param>
        /// <param name="totalWithVAT">total with vat </param>
        /// <param name="VATTotal">vat total</param>
        /// <returns></returns>
        public string encodeQrText(string sallerName, string sallerTRN, string invoiceDateTime, string totalWithVAT, string VATTotal)
        {
            //use UTF8 with sallerName to solve arabic issue
            byte[] bytes = Encoding.UTF8.GetBytes(sallerName);
            string L1 = bytes.Length.ToString("X");
            string tag1Hex = BitConverter.ToString(bytes);
            tag1Hex = tag1Hex.Replace("-", "");

            string L2 = sallerTRN.Length.ToString("X");
            string L3 = invoiceDateTime.Length.ToString("X");
            string L4 = totalWithVAT.Length.ToString("X");
            string L5 = VATTotal.Length.ToString("X");
            //length tag must be 2 digit like '0C' 
            string hex = "01" + ((L1.Length == 1) ? ("0" + L1) : L1) + tag1Hex +
                         "02" + ((L2.Length == 1) ? ("0" + L2) : L2) + ToHexString(sallerTRN) +
                         "03" + ((L3.Length == 1) ? ("0" + L3) : L3) + ToHexString(invoiceDateTime) +
                         "04" + ((L4.Length == 1) ? ("0" + L4) : L4) + ToHexString(totalWithVAT) +
                         "05" + ((L5.Length == 1) ? ("0" + L5) : L5) + ToHexString(VATTotal);

            return HexToBase64(hex);
        }

        private string ToHexString(string str)
        {
            byte[] bytes = Encoding.Default.GetBytes(str);
            string hexString = BitConverter.ToString(bytes);
            hexString = hexString.Replace("-", "");
            return hexString;
        }

        private string HexToBase64(string strInput)
        {
            try
            {
                var bytes = new byte[strInput.Length / 2];
                for (var i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = Convert.ToByte(strInput.Substring(i * 2, 2), 16);
                }
                return Convert.ToBase64String(bytes);
            }
            catch (Exception)
            {
                return "-1";
            }
        }

        private Bitmap generateQRImage(string text)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
        }

        private void FrmPrintBill_Load(object sender, EventArgs e)
        {
            ClassCustomerBillTotal cs = new ClassCustomerBillTotal(MyBillId);

            TblCustomersBills obj = new TblCustomersBills();
            obj.LoadByPrimaryKey(MyBillId);

            #region SaveQrCode
            var sallerName = "محل سليمان خلف رده المنجومي";
            var trn = "310645349700003";
            var date = obj.Bill_Date.ToString("yyyy-MM-dd hh:mm");
            var totalWithVat = cs.BillTotalAfterVat.ToString();
            var vat = obj.Bill_Vat.ToString();

            var qrText = encodeQrText(sallerName, trn, date, totalWithVat, vat);

            PictureBox Pic = new PictureBox();
            Pic.Image = generateQRImage(qrText);
            Pic.SizeMode = PictureBoxSizeMode.StretchImage;

            var bmp = (Bitmap)Pic.Image;
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Bmp);

                obj.Bill_QrCode = ms.ToArray();
                obj.Save();
            }           
            #endregion


            // TODO: This line of code loads data into the 'NewDataSet.ViewCustomerPayments' table. You can move, or remove it, as needed.
            this.ViewCustomerPaymentsTableAdapter.Fill(this.NewDataSet.ViewCustomerPayments, MyBillId);

            this.reportViewer1.RefreshReport();

            string VatType = "فاتورة ضريبية مبسطة";
            if (cs.BillVatNumber != "")
            {
                VatType = "فاتورة ضريبية";
            }

            ClassCustomerFinance h = new ClassCustomerFinance(obj.Customer_Id);

            var culture = new System.Globalization.CultureInfo("ar-SA");
            string MyDay = culture.DateTimeFormat.GetDayName(obj.Bill_Date.DayOfWeek);

            ReportParameter[] param = new ReportParameter[8];
            param[0] = new ReportParameter("Name",cs.BillCustomerName);
            param[1] = new ReportParameter("AfterVat", cs.BillTotalAfterVat.ToString("0,0.00"));
            param[2] = new ReportParameter("Mobile", cs.BillCustomerPhone);
            param[3] = new ReportParameter("VatNumber", cs.BillVatNumber);
            param[4] = new ReportParameter("VatType", VatType);
            param[5] = new ReportParameter("CustomerFinance", h.CustomerFinance.ToString("0,0.00"));
            param[6] = new ReportParameter("Address", cs.BillAddress);
            param[7] = new ReportParameter("Day", MyDay);


            reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();

            obj.Bill_QrCode = null;
            obj.Save();
        }
    }
}
