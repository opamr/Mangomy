namespace MyApplication.Finance
{
    partial class DialogTotalMonthReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogTotalMonthReport));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalPayments = new System.Windows.Forms.Label();
            this.lblTotalOutcome = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVendors = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKash = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRestPayments = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCustomerPayes = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotalVendors = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblKashBuy = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblRestBuys = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPaymentProfit = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblBankFees = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.btnSearchByDate);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(76, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(554, 85);
            this.groupBox4.TabIndex = 110;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "بحث بالمدة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(308, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 64;
            this.label3.Text = "إلى :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(179, 30);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker2.RightToLeftLayout = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(123, 26);
            this.dateTimePicker2.TabIndex = 65;
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.BackgroundImage = global::MyApplication.Properties.Resources.Search;
            this.btnSearchByDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchByDate.ForeColor = System.Drawing.Color.Red;
            this.btnSearchByDate.Location = new System.Drawing.Point(25, 25);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(130, 40);
            this.btnSearchByDate.TabIndex = 63;
            this.btnSearchByDate.UseVisualStyleBackColor = true;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(504, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 19);
            this.label8.TabIndex = 61;
            this.label8.Text = "من :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(373, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 26);
            this.dateTimePicker1.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(560, 133);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(159, 19);
            this.label5.TabIndex = 114;
            this.label5.Text = "إجمالي المبيعات كاش واجل :";
            // 
            // lblTotalPayments
            // 
            this.lblTotalPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalPayments.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayments.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPayments.Location = new System.Drawing.Point(396, 126);
            this.lblTotalPayments.Name = "lblTotalPayments";
            this.lblTotalPayments.Size = new System.Drawing.Size(158, 26);
            this.lblTotalPayments.TabIndex = 113;
            this.lblTotalPayments.Text = "0";
            this.lblTotalPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalOutcome
            // 
            this.lblTotalOutcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTotalOutcome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOutcome.ForeColor = System.Drawing.Color.Black;
            this.lblTotalOutcome.Location = new System.Drawing.Point(396, 246);
            this.lblTotalOutcome.Name = "lblTotalOutcome";
            this.lblTotalOutcome.Size = new System.Drawing.Size(158, 26);
            this.lblTotalOutcome.TabIndex = 113;
            this.lblTotalOutcome.Text = "0";
            this.lblTotalOutcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(560, 253);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(118, 19);
            this.label7.TabIndex = 114;
            this.label7.Text = "إجمالي المصروفات :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(560, 433);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 117;
            this.label1.Text = "صافي الربح :";
            // 
            // lblNet
            // 
            this.lblNet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblNet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNet.ForeColor = System.Drawing.Color.Black;
            this.lblNet.Location = new System.Drawing.Point(396, 426);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(158, 26);
            this.lblNet.TabIndex = 116;
            this.lblNet.Text = "0";
            this.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(176, 546);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 119;
            this.label2.Text = "مدفوعات مشتريات اجل :";
            // 
            // lblVendors
            // 
            this.lblVendors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblVendors.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendors.ForeColor = System.Drawing.Color.Black;
            this.lblVendors.Location = new System.Drawing.Point(12, 539);
            this.lblVendors.Name = "lblVendors";
            this.lblVendors.Size = new System.Drawing.Size(158, 26);
            this.lblVendors.TabIndex = 118;
            this.lblVendors.Text = "0";
            this.lblVendors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(560, 313);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 121;
            this.label6.Text = "رواتب الموظفين :";
            // 
            // lblEmployees
            // 
            this.lblEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblEmployees.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployees.ForeColor = System.Drawing.Color.Black;
            this.lblEmployees.Location = new System.Drawing.Point(396, 306);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(158, 26);
            this.lblEmployees.TabIndex = 120;
            this.lblEmployees.Text = "0";
            this.lblEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackgroundImage = global::MyApplication.Properties.Resources.Print;
            this.BtnPrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.BtnPrint.ForeColor = System.Drawing.Color.Red;
            this.BtnPrint.Location = new System.Drawing.Point(400, 555);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(130, 40);
            this.BtnPrint.TabIndex = 123;
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(176, 126);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 125;
            this.label4.Text = "مبيعات كاش :";
            // 
            // lblKash
            // 
            this.lblKash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblKash.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKash.ForeColor = System.Drawing.Color.Black;
            this.lblKash.Location = new System.Drawing.Point(12, 119);
            this.lblKash.Name = "lblKash";
            this.lblKash.Size = new System.Drawing.Size(158, 26);
            this.lblKash.TabIndex = 124;
            this.lblKash.Text = "0";
            this.lblKash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(176, 186);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(84, 19);
            this.label10.TabIndex = 127;
            this.label10.Text = "مبيعات شبكة :";
            // 
            // lblBank
            // 
            this.lblBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblBank.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.ForeColor = System.Drawing.Color.Black;
            this.lblBank.Location = new System.Drawing.Point(12, 179);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(158, 26);
            this.lblBank.TabIndex = 126;
            this.lblBank.Text = "0";
            this.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(176, 246);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 129;
            this.label9.Text = "مبيعات اجل :";
            // 
            // lblRestPayments
            // 
            this.lblRestPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblRestPayments.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestPayments.ForeColor = System.Drawing.Color.Black;
            this.lblRestPayments.Location = new System.Drawing.Point(12, 239);
            this.lblRestPayments.Name = "lblRestPayments";
            this.lblRestPayments.Size = new System.Drawing.Size(158, 26);
            this.lblRestPayments.TabIndex = 128;
            this.lblRestPayments.Text = "0";
            this.lblRestPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(176, 306);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(125, 19);
            this.label12.TabIndex = 131;
            this.label12.Text = "مدفوعات عملاء اجل :";
            // 
            // lblCustomerPayes
            // 
            this.lblCustomerPayes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCustomerPayes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPayes.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerPayes.Location = new System.Drawing.Point(12, 299);
            this.lblCustomerPayes.Name = "lblCustomerPayes";
            this.lblCustomerPayes.Size = new System.Drawing.Size(158, 26);
            this.lblCustomerPayes.TabIndex = 130;
            this.lblCustomerPayes.Text = "0";
            this.lblCustomerPayes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(176, 486);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(170, 19);
            this.label14.TabIndex = 133;
            this.label14.Text = "إجمالي المشتريات كاش واجل :";
            // 
            // lblTotalVendors
            // 
            this.lblTotalVendors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTotalVendors.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVendors.ForeColor = System.Drawing.Color.Black;
            this.lblTotalVendors.Location = new System.Drawing.Point(12, 479);
            this.lblTotalVendors.Name = "lblTotalVendors";
            this.lblTotalVendors.Size = new System.Drawing.Size(158, 26);
            this.lblTotalVendors.TabIndex = 132;
            this.lblTotalVendors.Text = "0";
            this.lblTotalVendors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(176, 366);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(92, 19);
            this.label11.TabIndex = 135;
            this.label11.Text = "مشتريات كاش :";
            // 
            // lblKashBuy
            // 
            this.lblKashBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblKashBuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKashBuy.ForeColor = System.Drawing.Color.Black;
            this.lblKashBuy.Location = new System.Drawing.Point(12, 359);
            this.lblKashBuy.Name = "lblKashBuy";
            this.lblKashBuy.Size = new System.Drawing.Size(158, 26);
            this.lblKashBuy.TabIndex = 134;
            this.lblKashBuy.Text = "0";
            this.lblKashBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(176, 426);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(87, 19);
            this.label15.TabIndex = 137;
            this.label15.Text = "مشتريات اجل :";
            // 
            // lblRestBuys
            // 
            this.lblRestBuys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblRestBuys.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestBuys.ForeColor = System.Drawing.Color.Black;
            this.lblRestBuys.Location = new System.Drawing.Point(12, 419);
            this.lblRestBuys.Name = "lblRestBuys";
            this.lblRestBuys.Size = new System.Drawing.Size(158, 26);
            this.lblRestBuys.TabIndex = 136;
            this.lblRestBuys.Text = "0";
            this.lblRestBuys.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(560, 193);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(93, 19);
            this.label13.TabIndex = 139;
            this.label13.Text = "أرباح المبيعات :";
            // 
            // lblPaymentProfit
            // 
            this.lblPaymentProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPaymentProfit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentProfit.ForeColor = System.Drawing.Color.Black;
            this.lblPaymentProfit.Location = new System.Drawing.Point(396, 186);
            this.lblPaymentProfit.Name = "lblPaymentProfit";
            this.lblPaymentProfit.Size = new System.Drawing.Size(158, 26);
            this.lblPaymentProfit.TabIndex = 138;
            this.lblPaymentProfit.Text = "0";
            this.lblPaymentProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(560, 373);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(87, 19);
            this.label17.TabIndex = 141;
            this.label17.Text = "رسوم الشبكة :";
            // 
            // lblBankFees
            // 
            this.lblBankFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblBankFees.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankFees.ForeColor = System.Drawing.Color.Black;
            this.lblBankFees.Location = new System.Drawing.Point(396, 366);
            this.lblBankFees.Name = "lblBankFees";
            this.lblBankFees.Size = new System.Drawing.Size(158, 26);
            this.lblBankFees.TabIndex = 140;
            this.lblBankFees.Text = "0";
            this.lblBankFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DialogTotalMonthReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(734, 607);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblBankFees);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblPaymentProfit);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblRestBuys);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblKashBuy);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblTotalVendors);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblCustomerPayes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblRestPayments);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblKash);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVendors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalOutcome);
            this.Controls.Add(this.lblTotalPayments);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogTotalMonthReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير رقمي شهري";
            this.Load += new System.EventHandler(this.DialogTotalMonthReport_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnSearchByDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalPayments;
        private System.Windows.Forms.Label lblTotalOutcome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVendors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKash;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRestPayments;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCustomerPayes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTotalVendors;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblKashBuy;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblRestBuys;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPaymentProfit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblBankFees;
    }
}