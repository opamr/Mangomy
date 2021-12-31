using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPro;
using MyGeneration.dOOdads;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;

namespace MyApplication
{
    class ClassPrintCashirBill
    {
        public ClassPrintCashirBill()
        {

        }
        public void printDocument1_PrintPage(object sender, PrintPageEventArgs e,int MyBillID)
        {
            int i = 0;

            ClassCustomerBillTotal cs = new ClassCustomerBillTotal(MyBillID);


            TblCustomersBills pG = new TblCustomersBills();
            pG.LoadByPrimaryKey(MyBillID);

            Font font1 = new Font("Times New Roman", 9, FontStyle.Bold, GraphicsUnit.Point);
            StringFormat stringFormat = new StringFormat();
            stringFormat.LineAlignment = StringAlignment.Center;
            stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            Bitmap img = Properties.Resources.LogoPNG;
            Image newimg = img;

            int start = 10;

            //e.Graphics.DrawImage(newimg, 60, start, 180, 180);

            //start = 190;

            e.Graphics.DrawString("فاتورة ضريبية مبسطة", new Font("Times New Roman", 10, FontStyle.Bold),
           Brushes.Black, new Point(80, start));

            start += 30;
            e.Graphics.DrawString("محل الخالدية التجارية", new Font("Times New Roman", 14, FontStyle.Bold),
             Brushes.Black, new Point(60, start));

            start += 22;
            e.Graphics.DrawString("للبويات ومواد البناء وجميع العوازل المائية", new Font("Times New Roman", 12, FontStyle.Bold),
                Brushes.Black, new Point(20, start));


            start += 40;
            e.Graphics.DrawString(pG.Bill_Type + " : "+ pG.Bill_ID.ToString(), font1, Brushes.Black, new Point(260, start), stringFormat);
            start += 22;
            e.Graphics.DrawString("التاريخ :"+ pG.Bill_Date.ToShortDateString(), font1, Brushes.Black, new Point(245, start), stringFormat);
            e.Graphics.DrawString(pG.Bill_Time, font1, Brushes.Black, new Point(80, start), stringFormat);
            start += 22;
            e.Graphics.DrawString("الرقم الضريبي : 310645349700003", font1, Brushes.Black, new Point(240, start), stringFormat);

            start += 22;
            e.Graphics.DrawString(pG.Bill_CustomerName, font1, Brushes.Black, new Point(240, start), stringFormat);

            start += 10;

            StringFormat sf = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            sf.Alignment = StringAlignment.Near;
            sf.LineAlignment = StringAlignment.Center;

            StringFormat sf1 = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            sf1.Alignment = StringAlignment.Center;
            sf1.LineAlignment = StringAlignment.Center;

            Rectangle sanf = new Rectangle(130, start, 150, 20);
            e.Graphics.DrawRectangle(Pens.Black, sanf);
            e.Graphics.DrawString("الصنف", new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, sanf, sf);

            Rectangle count = new Rectangle(100, start, 30, 20);
            e.Graphics.DrawRectangle(Pens.Black, count);
            e.Graphics.DrawString("عدد", new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, count, sf1);

            Rectangle price = new Rectangle(55, start, 45, 20);
            e.Graphics.DrawRectangle(Pens.Black, price);
            e.Graphics.DrawString("السعر", new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, price, sf1);

            Rectangle total = new Rectangle(0, start, 55, 20);
            e.Graphics.DrawRectangle(Pens.Black, total);
            e.Graphics.DrawString("الإجمالى", new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, total, sf1);

            start += 20;
            ViewCustomerPayments pr = new ViewCustomerPayments();
            pr.Where.CustomerBill_Id.Value = MyBillID;
            if (pr.Query.Load())
            {
                do
                {
                    if (start > e.MarginBounds.Height)
                    {
                        e.HasMorePages = true;
                        return;
                    }

                   
                    Rectangle sanf1 = new Rectangle(130, start, 150, 20);
                    e.Graphics.DrawRectangle(Pens.Black, sanf1);
                    e.Graphics.DrawString(pr.Good_TraidName, new Font("Times New Roman", 8, FontStyle.Bold), Brushes.Black, sanf1, sf);
                    Rectangle count1 = new Rectangle(100, start, 30, 20);
                    e.Graphics.DrawRectangle(Pens.Black, count1);
                    e.Graphics.DrawString(pr.PayCount.ToString(), new Font("Times New Roman", 8, FontStyle.Bold), Brushes.Black, count1, sf1);
                    Rectangle price1 = new Rectangle(55, start, 45, 20);
                    e.Graphics.DrawRectangle(Pens.Black, price1);
                    e.Graphics.DrawString(pr.PayPriceAfterVat.ToString("0.00"), new Font("Times New Roman", 8, FontStyle.Bold), Brushes.Black, price1, sf1);
                    Rectangle total1 = new Rectangle(0, start, 55, 20);
                    e.Graphics.DrawRectangle(Pens.Black, total1);
                    e.Graphics.DrawString(pr.PayTotalAfterVat.ToString("0.00"), new Font("Times New Roman", 8, FontStyle.Bold), Brushes.Black, total1, sf1);
                    ++i;

                    start += 20;
                } while (pr.MoveNext());
            }


            e.Graphics.DrawRectangle(Pens.Black, 0, start, 280, 20);
            e.Graphics.DrawString(": الإجمالي قبل الخصم", new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new Point(110, start + 2));
            e.Graphics.DrawString(cs.BillTotal.ToString("0.00"), new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new Point(20, start + 2));

            start += 20;
            e.Graphics.DrawRectangle(Pens.Black, 0, start, 280, 20);
            e.Graphics.DrawString(": الخصم ", new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new Point(110, start + 2));
            e.Graphics.DrawString(pG.Bill_DiscountMoney.ToString("0.00"), new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new Point(20, start + 2));

            start += 20;
            e.Graphics.DrawRectangle(Pens.Black, 0, start, 280, 20);
            e.Graphics.DrawString(": الإجمالي بدون الضريبة", new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new Point(110, start + 2));
            e.Graphics.DrawString(cs.BillTotalAfterDiscount.ToString("0.00"), new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new Point(20, start + 2));

            start += 20;
            e.Graphics.DrawRectangle(Pens.Black, 0, start, 280, 20);
            e.Graphics.DrawString(" : " + " % " + "ضريبة القيمة المضافة " + pG.s_Bill_Vat_Value, new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new Point(110, start + 2));
            e.Graphics.DrawString(pG.Bill_Vat.ToString("0.00"), new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new Point(20, start + 2));

            start += 20;
            e.Graphics.DrawRectangle(Pens.Black, 0, start, 280, 20);
            e.Graphics.DrawString(": الإجمالي شامل الضريبة", new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new Point(110, start + 2));
            e.Graphics.DrawString(cs.BillTotalAfterVat.ToString("0.00"), new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new Point(20, start + 2));

            start += 20;
            e.Graphics.DrawRectangle(Pens.Black, 0, start, 280, 20);
            e.Graphics.DrawString(": المدفوع نقداً", new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new Point(110, start + 2));
            e.Graphics.DrawString(pG.Customer_Pay, new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new Point(20, start + 2));

            start += 20;
            e.Graphics.DrawRectangle(Pens.Black, 0, start, 280, 20);
            e.Graphics.DrawString(": المدفوع شبكة", new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new Point(110, start + 2));
            e.Graphics.DrawString(cs.BankPay.ToString("0.00"), new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new Point(20, start + 2));

            start += 20;
            e.Graphics.DrawRectangle(Pens.Black, 0, start, 280, 20);
            e.Graphics.DrawString(": المتبقي للعميل", new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new Point(110, start + 2));
            e.Graphics.DrawString(pG.Customer_Rest, new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new Point(20, start + 2));

          
            start += 30;
            e.Graphics.DrawString("موظف : " + GlobalVar.user_Id, font1, Brushes.Black, new Point(280, start), stringFormat);          

            start += 15;
            e.Graphics.DrawString("------------------------------------------------------------------------------", font1, Brushes.Black, new Point(280, start), stringFormat);

            start += 20;
            e.Graphics.DrawString("ملاحظة : " + "\n" +
                "البضاعة المباعة لا ترد ولا تستبدل بعد أسبوع من تاريخ الفاتورة.", font1, Brushes.Black, new Point(280, start), stringFormat);

            start += 20;
            e.Graphics.DrawString("------------------------------------------------------------------------------", font1, Brushes.Black, new Point(280, start), stringFormat);

            start += 15;
            e.Graphics.DrawString("العنوان : الطائف - الشهداء الجنوبية - بجوار كوبري حسان", font1, Brushes.Black, new Point(280, start), stringFormat);

            start += 15;          
            e.Graphics.DrawString("------------------------------------------------------------------------------", font1, Brushes.Black, new Point(280, start), stringFormat);

            start += 15;
            e.Graphics.DrawString("جوال : 0550994218", font1, Brushes.Black, new Point(280, start), stringFormat);

            start += 15;
            e.Graphics.DrawString("------------------------------------------------------------------------------", font1, Brushes.Black, new Point(280, start), stringFormat);

            start += 15;
            #region SaveQrCode
            string QrCodeText = "اسم المورد : " + "محل الخالدية التجارية";
            QrCodeText += "\n" + "الرقم الضريبي : " + "310645349700003";
            QrCodeText += "\n" + "تاريخ ووقت الفاتورة : " + pG.Bill_Date.ToShortDateString() + " " + pG.Bill_Time;
            QrCodeText += "\n" + "الإجمالي شامل الضريبة : " + cs.BillTotalAfterVat.ToString("0,0.00");
            QrCodeText += "\n" + "الضريبة " + pG.Bill_Vat_Value + "%" + ": " + pG.Bill_Vat.ToString("0.00");

            QRCoder.QRCodeGenerator qRCodeGenerator = new QRCoder.QRCodeGenerator();
            QRCoder.QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(QrCodeText, QRCoder.QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode qRCode = new QRCoder.QRCode(qRCodeData);
            Bitmap bmp = qRCode.GetGraphic(5);
            e.Graphics.DrawImage(bmp, 70, start, 140, 140);
            #endregion

            start += 150;
            e.Graphics.DrawString("------------------------------------------------------------------------------", font1, Brushes.Black, new Point(280, start), stringFormat);

        }
    }
}
