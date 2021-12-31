namespace MyApplication.Validations
{
    partial class DialogValidation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogValidation));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnsaveEdit = new System.Windows.Forms.Button();
            this.btnRemoveSelection = new System.Windows.Forms.Button();
            this.BtnSelectAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BtnsaveEdit);
            this.groupBox2.Controls.Add(this.btnRemoveSelection);
            this.groupBox2.Controls.Add(this.BtnSelectAll);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(19, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(538, 578);
            this.groupBox2.TabIndex = 100;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الصلاحيات";
            // 
            // BtnsaveEdit
            // 
            this.BtnsaveEdit.BackColor = System.Drawing.Color.Teal;
            this.BtnsaveEdit.BackgroundImage = global::MyApplication.Properties.Resources.SaveEdit;
            this.BtnsaveEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnsaveEdit.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnsaveEdit.ForeColor = System.Drawing.Color.White;
            this.BtnsaveEdit.Location = new System.Drawing.Point(20, 532);
            this.BtnsaveEdit.Name = "BtnsaveEdit";
            this.BtnsaveEdit.Size = new System.Drawing.Size(130, 40);
            this.BtnsaveEdit.TabIndex = 63;
            this.BtnsaveEdit.UseVisualStyleBackColor = false;
            this.BtnsaveEdit.Click += new System.EventHandler(this.BtnsaveEdit_Click);
            // 
            // btnRemoveSelection
            // 
            this.btnRemoveSelection.BackColor = System.Drawing.Color.Teal;
            this.btnRemoveSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveSelection.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelection.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSelection.Location = new System.Drawing.Point(393, 532);
            this.btnRemoveSelection.Name = "btnRemoveSelection";
            this.btnRemoveSelection.Size = new System.Drawing.Size(130, 40);
            this.btnRemoveSelection.TabIndex = 62;
            this.btnRemoveSelection.Text = "إلغاء التحديد";
            this.btnRemoveSelection.UseVisualStyleBackColor = false;
            this.btnRemoveSelection.Click += new System.EventHandler(this.btnRemoveSelection_Click);
            // 
            // BtnSelectAll
            // 
            this.BtnSelectAll.BackColor = System.Drawing.Color.Teal;
            this.BtnSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelectAll.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectAll.ForeColor = System.Drawing.Color.White;
            this.BtnSelectAll.Location = new System.Drawing.Point(226, 532);
            this.BtnSelectAll.Name = "BtnSelectAll";
            this.BtnSelectAll.Size = new System.Drawing.Size(130, 40);
            this.BtnSelectAll.TabIndex = 61;
            this.BtnSelectAll.Text = "تحديد الكل";
            this.BtnSelectAll.UseVisualStyleBackColor = false;
            this.BtnSelectAll.Click += new System.EventHandler(this.BtnSelectAll_Click);
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
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(20, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.Size = new System.Drawing.Size(503, 501);
            this.dataGridView1.TabIndex = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "م";
            this.Column3.Name = "Column3";
            this.Column3.Width = 40;
            // 
            // Column4
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "الصلاحية";
            this.Column4.Name = "Column4";
            this.Column4.Width = 330;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "اختر";
            this.Column2.Name = "Column2";
            // 
            // DialogValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyApplication.Properties.Resources.newbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 612);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogValidation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صلاحيات المستخدم";
            this.Load += new System.EventHandler(this.DialogValidation_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnsaveEdit;
        private System.Windows.Forms.Button btnRemoveSelection;
        private System.Windows.Forms.Button BtnSelectAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
    }
}