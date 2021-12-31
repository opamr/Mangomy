namespace MyApplication
{
    partial class FrmSafeAll
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalAll = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVendorsRest = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentGods = new System.Windows.Forms.Label();
            this.BtnLoadData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGoodsBeforeVat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MyApplication.Properties.Resources.Footer;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 655);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1354, 37);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MyApplication.Properties.Resources.Header;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1354, 83);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(410, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(608, 189);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الأرصدة المالية";
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
            this.ColumnID,
            this.dataGridViewTextBoxColumn4,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(18, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Maroon;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(571, 156);
            this.dataGridView1.TabIndex = 88;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "id";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "م";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "البيان";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "الرصيد";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(707, 588);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 24);
            this.label9.TabIndex = 57;
            this.label9.Text = "الموقف المالي الحالي";
            // 
            // lblTotalAll
            // 
            this.lblTotalAll.BackColor = System.Drawing.Color.Blue;
            this.lblTotalAll.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAll.ForeColor = System.Drawing.Color.White;
            this.lblTotalAll.Location = new System.Drawing.Point(457, 581);
            this.lblTotalAll.Name = "lblTotalAll";
            this.lblTotalAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalAll.Size = new System.Drawing.Size(193, 31);
            this.lblTotalAll.TabIndex = 56;
            this.lblTotalAll.Text = "0";
            this.lblTotalAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(707, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 55;
            this.label7.Text = "أرصدة الموردين";
            // 
            // lblVendorsRest
            // 
            this.lblVendorsRest.BackColor = System.Drawing.Color.Red;
            this.lblVendorsRest.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorsRest.ForeColor = System.Drawing.Color.White;
            this.lblVendorsRest.Location = new System.Drawing.Point(457, 509);
            this.lblVendorsRest.Name = "lblVendorsRest";
            this.lblVendorsRest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVendorsRest.Size = new System.Drawing.Size(193, 31);
            this.lblVendorsRest.TabIndex = 54;
            this.lblVendorsRest.Text = "0";
            this.lblVendorsRest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(707, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "أرصدة العملاء";
            // 
            // lblCustomers
            // 
            this.lblCustomers.BackColor = System.Drawing.Color.Green;
            this.lblCustomers.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.ForeColor = System.Drawing.Color.White;
            this.lblCustomers.Location = new System.Drawing.Point(457, 437);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCustomers.Size = new System.Drawing.Size(193, 31);
            this.lblCustomers.TabIndex = 52;
            this.lblCustomers.Text = "0";
            this.lblCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(707, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "قيمة الأصناف الحالية شاملة الضريبة";
            // 
            // lblCurrentGods
            // 
            this.lblCurrentGods.BackColor = System.Drawing.Color.Green;
            this.lblCurrentGods.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentGods.ForeColor = System.Drawing.Color.White;
            this.lblCurrentGods.Location = new System.Drawing.Point(457, 365);
            this.lblCurrentGods.Name = "lblCurrentGods";
            this.lblCurrentGods.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCurrentGods.Size = new System.Drawing.Size(193, 31);
            this.lblCurrentGods.TabIndex = 50;
            this.lblCurrentGods.Text = "0";
            this.lblCurrentGods.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnLoadData
            // 
            this.BtnLoadData.BackgroundImage = global::MyApplication.Properties.Resources.EmptyBTN;
            this.BtnLoadData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadData.ForeColor = System.Drawing.Color.White;
            this.BtnLoadData.Location = new System.Drawing.Point(428, 108);
            this.BtnLoadData.Name = "BtnLoadData";
            this.BtnLoadData.Size = new System.Drawing.Size(130, 40);
            this.BtnLoadData.TabIndex = 91;
            this.BtnLoadData.Text = "تحميل البيانات";
            this.BtnLoadData.UseVisualStyleBackColor = true;
            this.BtnLoadData.Click += new System.EventHandler(this.BtnLoadData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(86, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 24);
            this.label1.TabIndex = 93;
            this.label1.Text = "قيمة الأصناف الحالية بدون الضريبة";
            // 
            // lblGoodsBeforeVat
            // 
            this.lblGoodsBeforeVat.BackColor = System.Drawing.Color.Green;
            this.lblGoodsBeforeVat.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodsBeforeVat.ForeColor = System.Drawing.Color.White;
            this.lblGoodsBeforeVat.Location = new System.Drawing.Point(82, 365);
            this.lblGoodsBeforeVat.Name = "lblGoodsBeforeVat";
            this.lblGoodsBeforeVat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGoodsBeforeVat.Size = new System.Drawing.Size(257, 31);
            this.lblGoodsBeforeVat.TabIndex = 92;
            this.lblGoodsBeforeVat.Text = "0";
            this.lblGoodsBeforeVat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSafeAll
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 692);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGoodsBeforeVat);
            this.Controls.Add(this.BtnLoadData);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotalAll);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblVendorsRest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCurrentGods);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSafeAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الموقف المالى";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSafeAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVendorsRest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCurrentGods;
        private System.Windows.Forms.Button BtnLoadData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGoodsBeforeVat;
    }
}