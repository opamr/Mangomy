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
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Diagnostics;
using MyGeneration.dOOdads;
using System.IO.Compression;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Data.OleDb;

namespace MyApplication
{
    public partial class Form1 : Form
    {
        BackgroundWorker worker;
        int RowCount = 0;
        public Form1()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TblUsers xc = new TblUsers();
            xc.LoadAll();
            do
            {
                txtUser.AutoCompleteCustomSource.Add(xc.User_Name);
            } while (xc.MoveNext());

            this.KeyPreview = true;

            //txtPass.Text = "sh2008";
            //txtUser.Text = "admin";

            worker.RunWorkerAsync();
            InitTimer();
        }

        private void LoadData()
        {
            //OleDbConnection con = new OleDbConnection();
            //string excelFilePath =
            //    "E:\\Desktop App\\Current\\بصمة تحكم\\الامل للدهانات\\GoodsData.xlsx";
            //con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + excelFilePath + @";Extended Properties=""Excel 12.0;HDR=YES;IMEX=1;""";

            //con.Open();
            //OleDbCommand com = new OleDbCommand();
            //com.Connection = con;
            //com.CommandText = "select * from [Sheet1$]";

            //OleDbDataReader dr = com.ExecuteReader();
            //if (dr.HasRows)
            //{
            //    int g = 0;
            //    while (dr.Read())
            //    {

            //        if (Convert.ToString(dr[0]).Length > 3)
            //        {
            //            ++g;

            //            TblGoodsTitles obj = new TblGoodsTitles();
            //            obj.AddNew();
            //            obj.Category_Id = 1;
            //            obj.Good_TraidName = Convert.ToString(dr[0]);
            //            obj.FirstStore_Amount0 = Convert.ToDouble(dr[3]);
            //            obj.FirstStore_Amount1 = 0;
            //            obj.FirstStore_Amount2 = 0;
            //            obj.Good_MinimumCount = 0;
            //            obj.Good_FirstDate = DateTime.Now.Date;
            //            obj.Good_CurrentCount = 0;
            //            obj.Save();

            //            TblGoodsBarcode bb = new TblGoodsBarcode();
            //            bb.AddNew();
            //            bb.Titel_Id = obj.Title_ID;
            //            bb.Barcode_Unit = "حبه";
            //            bb.Barcode_PayPrice = (Convert.ToDouble(dr[2]) / 1.15).ToString("0.000");
            //            bb.Barcode_PaySpecial = (Convert.ToDouble(dr[2]) / 1.15).ToString("0.000");
            //            bb.Barcode_BuyPrice = Convert.ToString(dr[1]);                        
            //            bb.Barcode_Count = "1";
            //            bb.Save();

            //            //if (Convert.ToString(dr[6]) != "0")
            //            //{
            //            //    bb = new TblGoodsBarcode();
            //            //    bb.AddNew();
            //            //    bb.Titel_Id = obj.Title_ID;
            //            //    bb.Barcode_Unit = "كرتون";
            //            //    bb.Barcode_PayPrice = Convert.ToString(dr[5]);
            //            //    bb.Barcode_PaySpecial = Convert.ToString(dr[5]);
            //            //    bb.Barcode_BuyPrice = Convert.ToString(dr[4]);
            //            //    bb.Barcode_Code = Convert.ToString(dr[1]);
            //            //    bb.Barcode_Count = Convert.ToString(dr[6]);
            //            //    bb.Save();
            //            //}

            //        }
            //    }
            //    MessageBox.Show(g.ToString());
            //}
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "" && txtPass.Text != "")
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "Form1")
                        Application.OpenForms[i].Close();
                }


                if (txtUser.Text == "admin" && txtPass.Text == "sh2008")
                {
                    GlobalVar.user_Id = 1;
                    FrmMain ff = new FrmMain();
                    ff.Show();

                    txtPass.Text = txtUser.Text = "";

                    return;
                }

                TblUsers obj = new TblUsers();
                obj.Where.User_Name.Value = txtUser.Text;
                obj.Where.User_Pass.Value = txtPass.Text;
                if (obj.Query.Load())
                {
                    GlobalVar.user_Id = obj.User_ID;

                    TblStoreReview y = new TblStoreReview();
                    y.Where.Review_Status.Value = "لم ينتهي";
                    if (obj.User_ID != 1 && y.Query.Load())
                    {
                        StoreReview.DialogAddGoodsToReview ff = new StoreReview.DialogAddGoodsToReview(y.Review_ID);
                        ff.ShowDialog();
                    }
                    else
                    {
                        FrmMain ff = new FrmMain();
                        ff.Show();
                    }
                                   
                    txtPass.Text = txtUser.Text = "";
                }
                else
                {
                    MessageBox.Show("تأكد من اسم المستخدم وكلمة المرور الصحيحة");
                }
            }
        }

        private static string CompressFile(string sourceFileName)
        {
            using (ZipArchive archive = ZipFile.Open(Path.ChangeExtension(sourceFileName, ".zip"), ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(sourceFileName, Path.GetFileName(sourceFileName));
            }
            return Path.ChangeExtension(sourceFileName, ".zip");
        }

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 300000; 
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!worker.IsBusy)
            {
                progressBar1.Value = 0;
                worker.RunWorkerAsync();
            }           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnlog.Enabled == true)
            {
                btnlog_Click(sender, e);
            }  
        }

        private void LnkWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.FCSS-Systems.com");
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            lblStatus.Text = "بسم الله";

            int g = 0;



            #region العملاء
            lblStatus.Text = "العملاء";
            System.Threading.Thread.Sleep(5000);

            TblCustomersData cc = new TblCustomersData();
            cc.Where.Customer_ID.Value = 1;
            cc.Where.Customer_ID.Operator = WhereParameter.Operand.NotEqual;
            if (cc.Query.Load())
            {
                RowCount = cc.RowCount;
                do
                {
                    worker.ReportProgress(g++);
                    ClassCustomerFinance cs = new ClassCustomerFinance(cc.Customer_ID);
                } while (cc.MoveNext());
            }
            #endregion

            #region الموردين
            lblStatus.Text = "الموردين";
            System.Threading.Thread.Sleep(5000);

            g = 0;
            TblVendorsData vv = new TblVendorsData();
            vv.LoadAll();
            if (vv.RowCount > 0)
            {
                RowCount = vv.RowCount;
                do
                {
                    worker.ReportProgress(g++);
                    ClassVendorFinance cs = new ClassVendorFinance(vv.Vendor_ID);
                } while (vv.MoveNext());
            }
            #endregion

            #region الاصناف
            lblStatus.Text = "الأصناف";
            System.Threading.Thread.Sleep(5000);

            g = 0;
            TblGoodsTitles obj = new TblGoodsTitles();
            if (obj.Query.Load())
            {
                RowCount = obj.RowCount;

                do
                {
                    worker.ReportProgress(g++);
                    ClassFollowGood cs = new ClassFollowGood(obj.Title_ID);
                } while (obj.MoveNext());

            }
            #endregion

            //string root = "E://BackUp//";

            //if (!Directory.Exists(root))
            //{
            //    Directory.CreateDirectory(root);
            //}

            //#region BackUp

            //lblStatus.Text = "حفظ نسخة احتياطية";


            //string BackName = root + "BarakatyFoodsDB" + DateTime.Now.Day + " " + DateTime.Now.Month + " " + DateTime.Now.Year + ".bak";

            //try
            //{
            //    SqlConnection con = new SqlConnection();
            //    con.ConnectionString = "server=.\\SQLEXPRESS;database=BarakatyFoodsDB;Integrated security = false;user=sa;password=sh2008";
            //    //con.ConnectionString = "server=.;database=BarakatyFoodsDB;Integrated security = true";

            //    SqlCommand com = new SqlCommand();
            //    com.Connection = con;
            //    com.CommandType = CommandType.Text;

            //    System.IO.File.Delete(BackName);
            //    com.CommandText = @"BACKUP DATABASE [BarakatyFoodsDB] TO DISK = N'" + BackName + "'  WITH NOFORMAT, NOINIT,  NAME = N'spansh-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,STATS = 10";

            //    con.Open();

            //    SqlDataReader dr = com.ExecuteReader();
            //}
            //catch (Exception ex)
            //{
            //    //MessageBox.Show(ex.Message + "\nلم يتم الحفظ\n حدث خطأ أثناء حفظ النسخه الإحتياطيه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //try
            //{
            //    using (var client = new System.Net.WebClient())
            //    {
            //        using (var stream = client.OpenRead("http://www.google.com"))
            //        {
            //            //MessageBox.Show("yes");
            //        }
            //    }
            //}
            //catch
            //{
            //    lblStatus.Text = "النت غير متصل";
            //    return;
            //}

            //return;

            //TblBackUp m = new TblBackUp();
            //m.Where.BackUp_Date.Value = DateTime.Now.Date;
            //if (m.Query.Load())
            //{
            //    return;
            //}
            //else
            //{
            //    m.AddNew();
            //    m.BackUp_Date = DateTime.Now.Date;
            //    m.User_Id = GlobalVar.user_Id;
            //    m.Save();
            //}

            //string CompreesdFile = root + "BarakatyFoodsDB" + DateTime.Now.Day + " " + DateTime.Now.Month + " " + DateTime.Now.Year + ".zip";
            //if (File.Exists(CompreesdFile))
            //{
            //    File.Delete(CompreesdFile);
            //}

            //CompressFile(BackName);

            //try
            //{
            //    SmtpClient client = new SmtpClient("smtp.gmail.com");
            //    client.Port = 587;
            //    client.EnableSsl = true;
            //    client.Timeout = 100000;
            //    client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //    client.UseDefaultCredentials = false;
            //    client.Credentials = new NetworkCredential("AndeeelSendBackup@gmail.com", "2020BackUp");
            //    MailMessage msg = new MailMessage();
            //    string mail = "Mmm22aa33@gmail.com";
            //    msg.To.Add(mail);
            //    msg.From = new MailAddress("AndeeelSendBackup@gmail.com", "مؤسسة العميد");

            //    msg.Subject = "نسخة احتياطية";
            //    msg.IsBodyHtml = true;

            //    Attachment data = new Attachment(CompreesdFile);
            //    msg.Attachments.Add(data);


            //    client.Send(msg);


            //    //worker.ReportProgress(RowCount);
            //    //System.Threading.Thread.Sleep(4);

            //    lblStatus.Text = "تم ارسال النسخة الاحتياطية";
            //    //MessageBox.Show("تم الإرسال");

            //    //DialogBackUpRecord_Load(sender, e);

            //}
            //catch (Exception ex)
            //{
            //    lblStatus.Text = "خطأ في ارسال النسخة الاحتياطية";
            //}
            //#endregion
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            /* Scrolling the Data Grid View to last row */
            //int lastRow = RowCount - 1;
            // dataGridView1.FirstDisplayedScrollingRowIndex = lastRow;                  

            /* When the number of operations is known, we set the maximum property and perform a step */
            progressBar1.PerformStep();
            progressBar1.Maximum += 1;
            progressBar1.Value += 1;

            lblStatus.Text = string.Format("تم تحميل " + "{0}", e.ProgressPercentage + " من: " + RowCount);
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = "تم التحميل...";
            RowCount = 0;
        }
    }
}
