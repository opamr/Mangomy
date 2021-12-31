namespace MyApplication.Customers
{
    partial class DialogAddCustomerPaying
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogAddCustomerPaying));
            this.BtnAddPay = new System.Windows.Forms.Button();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboCustomers = new System.Windows.Forms.ComboBox();
            this.comboBanks = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnAddPay
            // 
            this.BtnAddPay.BackgroundImage = global::MyApplication.Properties.Resources.Save;
            this.BtnAddPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddPay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAddPay.Location = new System.Drawing.Point(28, 317);
            this.BtnAddPay.Name = "BtnAddPay";
            this.BtnAddPay.Size = new System.Drawing.Size(130, 40);
            this.BtnAddPay.TabIndex = 5;
            this.BtnAddPay.UseVisualStyleBackColor = true;
            this.BtnAddPay.Click += new System.EventHandler(this.BtnAddPay_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(28, 177);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDetails.Size = new System.Drawing.Size(467, 26);
            this.txtDetails.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(501, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 64;
            this.label5.Text = ": ملاحظات";
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoney.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(339, 102);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMoney.Size = new System.Drawing.Size(156, 26);
            this.txtMoney.TabIndex = 1;
            this.txtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoney_KeyPress);
            this.txtMoney.Leave += new System.EventHandler(this.txtMoney_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(501, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 62;
            this.label4.Text = ": المبلغ المدفوع";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(188, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 57;
            this.label11.Text = ": تاريخ الدفع ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(501, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 67;
            this.label3.Text = ": طريقة الدفع ";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = global::MyApplication.Properties.Resources.Delete;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnDelete.Location = new System.Drawing.Point(259, 317);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(130, 40);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(501, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 118;
            this.label7.Text = ": اسم العميل";
            // 
            // comboCustomers
            // 
            this.comboCustomers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboCustomers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboCustomers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCustomers.FormattingEnabled = true;
            this.comboCustomers.Location = new System.Drawing.Point(28, 31);
            this.comboCustomers.Name = "comboCustomers";
            this.comboCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboCustomers.Size = new System.Drawing.Size(467, 27);
            this.comboCustomers.TabIndex = 0;
            // 
            // comboBanks
            // 
            this.comboBanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBanks.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBanks.FormattingEnabled = true;
            this.comboBanks.Location = new System.Drawing.Point(28, 247);
            this.comboBanks.Name = "comboBanks";
            this.comboBanks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBanks.Size = new System.Drawing.Size(467, 27);
            this.comboBanks.TabIndex = 4;
            // 
            // DialogAddCustomerPaying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 376);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboCustomers);
            this.Controls.Add(this.comboBanks);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAddPay);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogAddCustomerPaying";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سند قبض";
            this.Load += new System.EventHandler(this.FrmAddCustomerPaying_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddPay;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboCustomers;
        private System.Windows.Forms.ComboBox comboBanks;
    }
}