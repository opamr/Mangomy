namespace MyApplication.Employees
{
    partial class DialogAddBones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogAddBones));
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDetails
            // 
            this.lblDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.Blue;
            this.lblDetails.Location = new System.Drawing.Point(0, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDetails.Size = new System.Drawing.Size(570, 42);
            this.lblDetails.TabIndex = 188;
            this.lblDetails.Text = "العنوان";
            this.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoney.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(419, 86);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMoney.Size = new System.Drawing.Size(139, 26);
            this.txtMoney.TabIndex = 190;
            this.txtMoney.Text = "0";
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoney_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(509, 64);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 189;
            this.label5.Text = "المبلغ :";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker5.Location = new System.Drawing.Point(209, 86);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker5.RightToLeftLayout = true;
            this.dateTimePicker5.Size = new System.Drawing.Size(142, 26);
            this.dateTimePicker5.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(301, 64);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 191;
            this.label6.Text = "التاريخ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(112, 63);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 194;
            this.label2.Text = "النوع :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "خصم",
            "مكافأة"});
            this.comboBox1.Location = new System.Drawing.Point(12, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(142, 27);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(496, 151);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 189;
            this.label1.Text = "التفاصيل :";
            // 
            // txtDetails
            // 
            this.txtDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(12, 173);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDetails.Size = new System.Drawing.Size(546, 26);
            this.txtDetails.TabIndex = 3;
            this.txtDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = global::MyApplication.Properties.Resources.Delete;
            this.BtnDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnDelete.Location = new System.Drawing.Point(428, 263);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(130, 40);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = global::MyApplication.Properties.Resources.Save;
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSave.Location = new System.Drawing.Point(12, 263);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(130, 40);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // DialogAddBones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 323);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogAddBones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة خصم أو مكافأة";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DialogAddBones_FormClosed);
            this.Load += new System.EventHandler(this.DialogAddBones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
    }
}