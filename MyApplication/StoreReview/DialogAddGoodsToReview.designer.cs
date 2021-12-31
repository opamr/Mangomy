namespace MyApplication.StoreReview
{
    partial class DialogAddGoodsToReview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogAddGoodsToReview));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboUnits = new System.Windows.Forms.ComboBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.BtnAddToBill = new System.Windows.Forms.Button();
            this.comboGoods = new System.Windows.Forms.ComboBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnEndReview = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.comboUnits);
            this.groupBox3.Controls.Add(this.txtBarcode);
            this.groupBox3.Controls.Add(this.BtnAddToBill);
            this.groupBox3.Controls.Add(this.comboGoods);
            this.groupBox3.Controls.Add(this.txtCount);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Green;
            this.groupBox3.Location = new System.Drawing.Point(9, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(906, 503);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "محتوى الجرد";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(28, 13);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(40, 22);
            this.label5.TabIndex = 81;
            this.label5.Text = "F5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OldLace;
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
            this.ColumnBarcode,
            this.Column2,
            this.ColumnType,
            this.ColumnCount,
            this.ColumnDelete});
            this.dataGridView1.Location = new System.Drawing.Point(6, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Maroon;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(893, 421);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnID
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColumnID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnID.HeaderText = "id";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "م";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 44;
            // 
            // ColumnBarcode
            // 
            this.ColumnBarcode.HeaderText = "باركود";
            this.ColumnBarcode.Name = "ColumnBarcode";
            this.ColumnBarcode.Width = 200;
            // 
            // Column2
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "اسم الصنف";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 400;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "الوحدة";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnType.Width = 110;
            // 
            // ColumnCount
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnCount.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnCount.HeaderText = "العدد";
            this.ColumnCount.Name = "ColumnCount";
            this.ColumnCount.Width = 65;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "حذف";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Text = "حذف";
            this.ColumnDelete.UseColumnTextForButtonValue = true;
            this.ColumnDelete.Width = 50;
            // 
            // comboUnits
            // 
            this.comboUnits.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboUnits.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUnits.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUnits.FormattingEnabled = true;
            this.comboUnits.Location = new System.Drawing.Point(151, 42);
            this.comboUnits.Name = "comboUnits";
            this.comboUnits.Size = new System.Drawing.Size(99, 27);
            this.comboUnits.TabIndex = 14;
            this.comboUnits.SelectedIndexChanged += new System.EventHandler(this.comboUnits_SelectedIndexChanged);
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(653, 42);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(246, 26);
            this.txtBarcode.TabIndex = 12;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.Enter += new System.EventHandler(this.txtBarcode_Enter);
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // BtnAddToBill
            // 
            this.BtnAddToBill.BackgroundImage = global::MyApplication.Properties.Resources.IconSave;
            this.BtnAddToBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddToBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddToBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddToBill.Location = new System.Drawing.Point(28, 35);
            this.BtnAddToBill.Name = "BtnAddToBill";
            this.BtnAddToBill.Size = new System.Drawing.Size(40, 40);
            this.BtnAddToBill.TabIndex = 20;
            this.BtnAddToBill.UseVisualStyleBackColor = true;
            this.BtnAddToBill.Click += new System.EventHandler(this.BtnAddToBill_Click);
            // 
            // comboGoods
            // 
            this.comboGoods.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboGoods.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboGoods.BackColor = System.Drawing.Color.OldLace;
            this.comboGoods.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboGoods.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGoods.FormattingEnabled = true;
            this.comboGoods.Location = new System.Drawing.Point(256, 42);
            this.comboGoods.Name = "comboGoods";
            this.comboGoods.Size = new System.Drawing.Size(391, 27);
            this.comboGoods.TabIndex = 13;
            this.comboGoods.SelectedIndexChanged += new System.EventHandler(this.comboGoods_SelectedIndexChanged);
            this.comboGoods.Enter += new System.EventHandler(this.comboGoods_Enter);
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.Color.Lime;
            this.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(74, 44);
            this.txtCount.Name = "txtCount";
            this.txtCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCount.Size = new System.Drawing.Size(70, 26);
            this.txtCount.TabIndex = 15;
            this.txtCount.Text = "0";
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCount_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(858, 23);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 99;
            this.label6.Text = "التاريخ :";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Blue;
            this.lblDate.Location = new System.Drawing.Point(700, 21);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(155, 22);
            this.lblDate.TabIndex = 100;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(437, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(155, 22);
            this.lblTitle.TabIndex = 102;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(598, 25);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 101;
            this.label3.Text = "عنوان الجرد :";
            // 
            // lblDetails
            // 
            this.lblDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDetails.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.Blue;
            this.lblDetails.Location = new System.Drawing.Point(9, 21);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDetails.Size = new System.Drawing.Size(302, 53);
            this.lblDetails.TabIndex = 104;
            this.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(317, 23);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 103;
            this.label7.Text = "الملاحظات :";
            // 
            // BtnEndReview
            // 
            this.BtnEndReview.BackgroundImage = global::MyApplication.Properties.Resources.EmptyBTN;
            this.BtnEndReview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEndReview.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEndReview.ForeColor = System.Drawing.Color.White;
            this.BtnEndReview.Location = new System.Drawing.Point(348, 609);
            this.BtnEndReview.Name = "BtnEndReview";
            this.BtnEndReview.Size = new System.Drawing.Size(201, 40);
            this.BtnEndReview.TabIndex = 173;
            this.BtnEndReview.Text = "تم الإنتهاء من الجرد";
            this.BtnEndReview.UseVisualStyleBackColor = true;
            this.BtnEndReview.Click += new System.EventHandler(this.BtnEndReview_Click);
            // 
            // DialogAddGoodsToReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(927, 661);
            this.Controls.Add(this.BtnEndReview);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogAddGoodsToReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الجرد";
            this.Load += new System.EventHandler(this.DialogAddReview_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboUnits;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button BtnAddToBill;
        private System.Windows.Forms.ComboBox comboGoods;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
        private System.Windows.Forms.Button BtnEndReview;
    }
}