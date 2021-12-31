namespace MyApplication.Employees
{
    partial class DialogAddSalary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogAddSalary));
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCheak = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnNotSelect = new System.Windows.Forms.Button();
            this.BtnSelectAll = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMonth
            // 
            this.txtMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.Location = new System.Drawing.Point(417, 43);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMonth.Size = new System.Drawing.Size(93, 26);
            this.txtMonth.TabIndex = 124;
            this.txtMonth.Text = "0";
            this.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMonth.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
            this.txtMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonth_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(464, 21);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 123;
            this.label5.Text = "الشهر :";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(249, 43);
            this.txtYear.Name = "txtYear";
            this.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtYear.Size = new System.Drawing.Size(93, 26);
            this.txtYear.TabIndex = 126;
            this.txtYear.Text = "0";
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYear.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(299, 21);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 125;
            this.label1.Text = "السنة :";
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
            this.ColumnCheak});
            this.dataGridView1.Location = new System.Drawing.Point(13, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(423, 420);
            this.dataGridView1.TabIndex = 128;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "id";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "م";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "اسم الموظف";
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // ColumnCheak
            // 
            this.ColumnCheak.HeaderText = "تحديد";
            this.ColumnCheak.Name = "ColumnCheak";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnNotSelect);
            this.groupBox1.Controls.Add(this.BtnSelectAll);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(447, 509);
            this.groupBox1.TabIndex = 127;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "النشاط";
            // 
            // BtnNotSelect
            // 
            this.BtnNotSelect.BackgroundImage = global::MyApplication.Properties.Resources.EmptyBTN;
            this.BtnNotSelect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotSelect.ForeColor = System.Drawing.Color.White;
            this.BtnNotSelect.Location = new System.Drawing.Point(206, 451);
            this.BtnNotSelect.Name = "BtnNotSelect";
            this.BtnNotSelect.Size = new System.Drawing.Size(130, 40);
            this.BtnNotSelect.TabIndex = 130;
            this.BtnNotSelect.Text = "إلغاء التحديد";
            this.BtnNotSelect.UseVisualStyleBackColor = true;
            this.BtnNotSelect.Click += new System.EventHandler(this.BtnNotSelect_Click);
            // 
            // BtnSelectAll
            // 
            this.BtnSelectAll.BackgroundImage = global::MyApplication.Properties.Resources.EmptyBTN;
            this.BtnSelectAll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectAll.ForeColor = System.Drawing.Color.White;
            this.BtnSelectAll.Location = new System.Drawing.Point(13, 451);
            this.BtnSelectAll.Name = "BtnSelectAll";
            this.BtnSelectAll.Size = new System.Drawing.Size(130, 40);
            this.BtnSelectAll.TabIndex = 129;
            this.BtnSelectAll.Text = "تحديد الكل";
            this.BtnSelectAll.UseVisualStyleBackColor = true;
            this.BtnSelectAll.Click += new System.EventHandler(this.BtnSelectAll_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = global::MyApplication.Properties.Resources.Save;
            this.BtnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(63, 98);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(139, 40);
            this.BtnSave.TabIndex = 150;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(464, 91);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 123;
            this.label2.Text = "البيان :";
            // 
            // txtDetails
            // 
            this.txtDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(249, 113);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDetails.Size = new System.Drawing.Size(261, 26);
            this.txtDetails.TabIndex = 124;
            this.txtDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker5.Location = new System.Drawing.Point(64, 43);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker5.RightToLeftLayout = true;
            this.dateTimePicker5.Size = new System.Drawing.Size(142, 26);
            this.dateTimePicker5.TabIndex = 152;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(107, 21);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 151;
            this.label6.Text = "تاريخ الإستحقاق :";
            // 
            // DialogAddSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(580, 661);
            this.Controls.Add(this.dateTimePicker5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogAddSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة رواتب";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DialogAddSalary_FormClosed);
            this.Load += new System.EventHandler(this.DialogAddSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnNotSelect;
        private System.Windows.Forms.Button BtnSelectAll;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCheak;
    }
}