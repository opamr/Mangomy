namespace MyApplication.Payments
{
    partial class DialogPaymentBillDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogPaymentBillDetails));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.lblBillNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPayCash = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.LblPayBank = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditBill = new System.Windows.Forms.Button();
            this.LblDiscount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAfterVat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRest = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblVatType = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotalAfterDiscount = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.BtnPrintSmall = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(5, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(832, 355);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اصناف الفاتورة";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader9,
            this.columnHeader12,
            this.columnHeader2,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader1,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Navy;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 22);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(826, 330);
            this.listView1.TabIndex = 66;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "id";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "م";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 59;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "إسم الصنف";
            this.columnHeader12.Width = 275;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "الوحدة";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 98;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "العدد";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 86;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "السعر";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 89;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "الإجمالي";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "شامل الضريبة";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(751, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 84;
            this.label4.Text = ": نوع الفاتورة";
            // 
            // lblBillNumber
            // 
            this.lblBillNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblBillNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillNumber.Location = new System.Drawing.Point(620, 26);
            this.lblBillNumber.Name = "lblBillNumber";
            this.lblBillNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBillNumber.Size = new System.Drawing.Size(117, 19);
            this.lblBillNumber.TabIndex = 87;
            this.lblBillNumber.Text = "1000";
            this.lblBillNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(743, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 86;
            this.label3.Text = ": رقم الفاتورة";
            // 
            // lblBillDate
            // 
            this.lblBillDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblBillDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDate.Location = new System.Drawing.Point(620, 81);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBillDate.Size = new System.Drawing.Size(117, 19);
            this.lblBillDate.TabIndex = 91;
            this.lblBillDate.Text = "فاتورة مبيعات";
            this.lblBillDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(743, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 90;
            this.label8.Text = ": التاريخ";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(321, 81);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTime.Size = new System.Drawing.Size(211, 19);
            this.lblTime.TabIndex = 93;
            this.lblTime.Text = "1000";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(538, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 19);
            this.label10.TabIndex = 92;
            this.label10.Text = ": الوقت";
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(317, 26);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(211, 19);
            this.lblUser.TabIndex = 95;
            this.lblUser.Text = "1000";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(534, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 19);
            this.label12.TabIndex = 94;
            this.label12.Text = ": نقداًير";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(602, 538);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(117, 19);
            this.lblTotal.TabIndex = 97;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(725, 538);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 19);
            this.label14.TabIndex = 96;
            this.label14.Text = ": إجمالي الفاتورة";
            // 
            // lblPayCash
            // 
            this.lblPayCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPayCash.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayCash.Location = new System.Drawing.Point(18, 538);
            this.lblPayCash.Name = "lblPayCash";
            this.lblPayCash.Size = new System.Drawing.Size(117, 19);
            this.lblPayCash.TabIndex = 99;
            this.lblPayCash.Text = "0";
            this.lblPayCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(141, 538);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 19);
            this.label16.TabIndex = 98;
            this.label16.Text = ": المدفوع نقداً";
            // 
            // LblPayBank
            // 
            this.LblPayBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblPayBank.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPayBank.Location = new System.Drawing.Point(18, 582);
            this.LblPayBank.Name = "LblPayBank";
            this.LblPayBank.Size = new System.Drawing.Size(117, 19);
            this.LblPayBank.TabIndex = 103;
            this.LblPayBank.Text = "0";
            this.LblPayBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(141, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 102;
            this.label2.Text = ": المدفوع صراف";
            // 
            // btnEditBill
            // 
            this.btnEditBill.BackgroundImage = global::MyApplication.Properties.Resources.EmptyBTN;
            this.btnEditBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditBill.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditBill.Location = new System.Drawing.Point(5, 121);
            this.btnEditBill.Name = "btnEditBill";
            this.btnEditBill.Size = new System.Drawing.Size(130, 40);
            this.btnEditBill.TabIndex = 104;
            this.btnEditBill.Text = "تعديل الفاتورة";
            this.btnEditBill.UseVisualStyleBackColor = true;
            this.btnEditBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // LblDiscount
            // 
            this.LblDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblDiscount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiscount.Location = new System.Drawing.Point(602, 582);
            this.LblDiscount.Name = "LblDiscount";
            this.LblDiscount.Size = new System.Drawing.Size(117, 19);
            this.LblDiscount.TabIndex = 108;
            this.LblDiscount.Text = "0";
            this.LblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(725, 582);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 107;
            this.label5.Text = ": الخصم";
            // 
            // lblAfterVat
            // 
            this.lblAfterVat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAfterVat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfterVat.Location = new System.Drawing.Point(291, 631);
            this.lblAfterVat.Name = "lblAfterVat";
            this.lblAfterVat.Size = new System.Drawing.Size(117, 19);
            this.lblAfterVat.TabIndex = 110;
            this.lblAfterVat.Text = "0";
            this.lblAfterVat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(414, 631);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 19);
            this.label7.TabIndex = 109;
            this.label7.Text = ": الإجمالي شامل الضريبة";
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackgroundImage = global::MyApplication.Properties.Resources.EmptyBTN;
            this.BtnPrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.BtnPrint.ForeColor = System.Drawing.Color.Transparent;
            this.BtnPrint.Location = new System.Drawing.Point(211, 121);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnPrint.Size = new System.Drawing.Size(130, 40);
            this.BtnPrint.TabIndex = 111;
            this.BtnPrint.Text = "طباعة A4";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(141, 626);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 112;
            this.label1.Text = ": الباقي";
            // 
            // lblRest
            // 
            this.lblRest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblRest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRest.Location = new System.Drawing.Point(18, 626);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(117, 19);
            this.lblRest.TabIndex = 113;
            this.lblRest.Text = "0";
            this.lblRest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblCustomerName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(12, 26);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(211, 19);
            this.lblCustomerName.TabIndex = 115;
            this.lblCustomerName.Text = "1000";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(229, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 19);
            this.label9.TabIndex = 114;
            this.label9.Text = ": اسم العميل";
            // 
            // lblVatType
            // 
            this.lblVatType.AutoSize = true;
            this.lblVatType.BackColor = System.Drawing.Color.Transparent;
            this.lblVatType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVatType.ForeColor = System.Drawing.Color.Blue;
            this.lblVatType.Location = new System.Drawing.Point(414, 582);
            this.lblVatType.Name = "lblVatType";
            this.lblVatType.Size = new System.Drawing.Size(60, 19);
            this.lblVatType.TabIndex = 109;
            this.lblVatType.Text = ": الضريبة";
            // 
            // lblVat
            // 
            this.lblVat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblVat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(291, 582);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(117, 19);
            this.lblVat.TabIndex = 110;
            this.lblVat.Text = "0";
            this.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(414, 538);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 19);
            this.label13.TabIndex = 109;
            this.label13.Text = ": الاجمالي بعد الخصم";
            // 
            // lblTotalAfterDiscount
            // 
            this.lblTotalAfterDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalAfterDiscount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAfterDiscount.Location = new System.Drawing.Point(291, 538);
            this.lblTotalAfterDiscount.Name = "lblTotalAfterDiscount";
            this.lblTotalAfterDiscount.Size = new System.Drawing.Size(117, 19);
            this.lblTotalAfterDiscount.TabIndex = 110;
            this.lblTotalAfterDiscount.Text = "0";
            this.lblTotalAfterDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMobile
            // 
            this.lblMobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblMobile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(12, 81);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(211, 19);
            this.lblMobile.TabIndex = 162;
            this.lblMobile.Text = "1000";
            this.lblMobile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(229, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 19);
            this.label15.TabIndex = 161;
            this.label15.Text = ": الجوال";
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(620, 124);
            this.lblType.Name = "lblType";
            this.lblType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblType.Size = new System.Drawing.Size(117, 19);
            this.lblType.TabIndex = 163;
            this.lblType.Text = "فاتورة مبيعات";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnPrintSmall
            // 
            this.BtnPrintSmall.BackgroundImage = global::MyApplication.Properties.Resources.EmptyBTN;
            this.BtnPrintSmall.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.BtnPrintSmall.ForeColor = System.Drawing.Color.Transparent;
            this.BtnPrintSmall.Location = new System.Drawing.Point(440, 121);
            this.BtnPrintSmall.Name = "BtnPrintSmall";
            this.BtnPrintSmall.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnPrintSmall.Size = new System.Drawing.Size(130, 40);
            this.BtnPrintSmall.TabIndex = 164;
            this.BtnPrintSmall.Text = "طباعة صغير";
            this.BtnPrintSmall.UseVisualStyleBackColor = true;
            this.BtnPrintSmall.Visible = false;
            this.BtnPrintSmall.Click += new System.EventHandler(this.BtnPrintSmall_Click);
            // 
            // DialogPaymentBillDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 670);
            this.Controls.Add(this.BtnPrintSmall);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRest);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.lblTotalAfterDiscount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.lblVatType);
            this.Controls.Add(this.lblAfterVat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblDiscount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEditBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblPayBank);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblPayCash);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblBillDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblBillNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogPaymentBillDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيل الفاتورة";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DialogPaymentBillDetails_FormClosed);
            this.Load += new System.EventHandler(this.DialogPaymentBillDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBillNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPayCash;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label LblPayBank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnEditBill;
        private System.Windows.Forms.Label LblDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAfterVat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRest;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblVatType;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotalAfterDiscount;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button BtnPrintSmall;
    }
}