namespace MyApplication
{
    partial class FrmVendorsMoney
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVendorsRest = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnVendorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVendorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVendorMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnFinance = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCustomerMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCustomer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnPrintVendors = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnPrintCustomer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(981, 611);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 24);
            this.label7.TabIndex = 58;
            this.label7.Text = ": أرصدة الموردين";
            // 
            // lblVendorsRest
            // 
            this.lblVendorsRest.BackColor = System.Drawing.Color.Red;
            this.lblVendorsRest.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorsRest.ForeColor = System.Drawing.Color.White;
            this.lblVendorsRest.Location = new System.Drawing.Point(819, 604);
            this.lblVendorsRest.Name = "lblVendorsRest";
            this.lblVendorsRest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVendorsRest.Size = new System.Drawing.Size(124, 31);
            this.lblVendorsRest.TabIndex = 57;
            this.lblVendorsRest.Text = "0";
            this.lblVendorsRest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(379, 608);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = ": أرصدة العملاء";
            // 
            // lblCustomers
            // 
            this.lblCustomers.BackColor = System.Drawing.Color.Green;
            this.lblCustomers.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.ForeColor = System.Drawing.Color.White;
            this.lblCustomers.Location = new System.Drawing.Point(202, 601);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCustomers.Size = new System.Drawing.Size(132, 31);
            this.lblCustomers.TabIndex = 55;
            this.lblCustomers.Text = "0";
            this.lblCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(670, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(630, 488);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الموردين";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnVendorID,
            this.dataGridViewTextBoxColumn4,
            this.ColumnVendorName,
            this.ColumnVendorMoney,
            this.ColumnDetails,
            this.ColumnFinance});
            this.dataGridView1.Location = new System.Drawing.Point(10, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(614, 457);
            this.dataGridView1.TabIndex = 88;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnVendorID
            // 
            this.ColumnVendorID.HeaderText = "ID";
            this.ColumnVendorID.Name = "ColumnVendorID";
            this.ColumnVendorID.ReadOnly = true;
            this.ColumnVendorID.Visible = false;
            this.ColumnVendorID.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "م";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // ColumnVendorName
            // 
            this.ColumnVendorName.HeaderText = "اسم المورد";
            this.ColumnVendorName.Name = "ColumnVendorName";
            this.ColumnVendorName.ReadOnly = true;
            this.ColumnVendorName.Width = 250;
            // 
            // ColumnVendorMoney
            // 
            this.ColumnVendorMoney.HeaderText = "الرصيد";
            this.ColumnVendorMoney.Name = "ColumnVendorMoney";
            this.ColumnVendorMoney.ReadOnly = true;
            // 
            // ColumnDetails
            // 
            this.ColumnDetails.HeaderText = "تسديد مبلغ";
            this.ColumnDetails.Name = "ColumnDetails";
            this.ColumnDetails.ReadOnly = true;
            this.ColumnDetails.Text = "تسديد مبلغ";
            this.ColumnDetails.UseColumnTextForButtonValue = true;
            // 
            // ColumnFinance
            // 
            this.ColumnFinance.HeaderText = "عرض الحسابات";
            this.ColumnFinance.Name = "ColumnFinance";
            this.ColumnFinance.ReadOnly = true;
            this.ColumnFinance.Text = "عرض الحسابات";
            this.ColumnFinance.UseColumnTextForButtonValue = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(608, 488);
            this.groupBox2.TabIndex = 120;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العملاء";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ColumnCustomerName,
            this.ColumnCustomerID,
            this.ColumnCustomerMoney,
            this.ColumnCustomer});
            this.dataGridView2.Location = new System.Drawing.Point(6, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Maroon;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(596, 457);
            this.dataGridView2.TabIndex = 89;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "م";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // ColumnCustomerName
            // 
            this.ColumnCustomerName.HeaderText = "اسم العميل";
            this.ColumnCustomerName.Name = "ColumnCustomerName";
            this.ColumnCustomerName.ReadOnly = true;
            this.ColumnCustomerName.Width = 250;
            // 
            // ColumnCustomerID
            // 
            this.ColumnCustomerID.HeaderText = "رقمه";
            this.ColumnCustomerID.Name = "ColumnCustomerID";
            this.ColumnCustomerID.ReadOnly = true;
            this.ColumnCustomerID.Width = 70;
            // 
            // ColumnCustomerMoney
            // 
            this.ColumnCustomerMoney.HeaderText = "المبلغ";
            this.ColumnCustomerMoney.Name = "ColumnCustomerMoney";
            this.ColumnCustomerMoney.ReadOnly = true;
            // 
            // ColumnCustomer
            // 
            this.ColumnCustomer.HeaderText = "تسديد مبلغ";
            this.ColumnCustomer.Name = "ColumnCustomer";
            this.ColumnCustomer.ReadOnly = true;
            // 
            // BtnPrintVendors
            // 
            this.BtnPrintVendors.BackgroundImage = global::MyApplication.Properties.Resources.Print;
            this.BtnPrintVendors.ForeColor = System.Drawing.Color.White;
            this.BtnPrintVendors.Location = new System.Drawing.Point(1170, 601);
            this.BtnPrintVendors.Name = "BtnPrintVendors";
            this.BtnPrintVendors.Size = new System.Drawing.Size(130, 40);
            this.BtnPrintVendors.TabIndex = 138;
            this.BtnPrintVendors.UseVisualStyleBackColor = true;
            this.BtnPrintVendors.Click += new System.EventHandler(this.BtnPrintVendors_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MyApplication.Properties.Resources.Header;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1314, 83);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MyApplication.Properties.Resources.Footer;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 655);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1314, 37);
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // BtnPrintCustomer
            // 
            this.BtnPrintCustomer.BackgroundImage = global::MyApplication.Properties.Resources.Print;
            this.BtnPrintCustomer.ForeColor = System.Drawing.Color.White;
            this.BtnPrintCustomer.Location = new System.Drawing.Point(12, 598);
            this.BtnPrintCustomer.Name = "BtnPrintCustomer";
            this.BtnPrintCustomer.Size = new System.Drawing.Size(130, 40);
            this.BtnPrintCustomer.TabIndex = 139;
            this.BtnPrintCustomer.UseVisualStyleBackColor = true;
            this.BtnPrintCustomer.Click += new System.EventHandler(this.BtnPrintCustomer_Click);
            // 
            // FrmVendorsMoney
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1314, 692);
            this.ControlBox = false;
            this.Controls.Add(this.BtnPrintCustomer);
            this.Controls.Add(this.BtnPrintVendors);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblVendorsRest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmVendorsMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابات آجله";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVendorsMoney_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVendorsRest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnPrintVendors;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomerMoney;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnCustomer;
        private System.Windows.Forms.Button BtnPrintCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVendorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVendorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVendorMoney;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDetails;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnFinance;
    }
}