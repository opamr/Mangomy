namespace MyApplication.Employees
{
    partial class DialogTakeSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogTakeSalary));
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBanks = new System.Windows.Forms.ComboBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEmployees = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSalary = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker5.Location = new System.Drawing.Point(218, 238);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker5.RightToLeftLayout = true;
            this.dateTimePicker5.Size = new System.Drawing.Size(142, 26);
            this.dateTimePicker5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(310, 216);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 204;
            this.label6.Text = "التاريخ :";
            // 
            // txtDetails
            // 
            this.txtDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(22, 322);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDetails.Size = new System.Drawing.Size(488, 26);
            this.txtDetails.TabIndex = 3;
            this.txtDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(452, 300);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 201;
            this.label1.Text = "التفاصيل :";
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoney.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(380, 238);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMoney.Size = new System.Drawing.Size(130, 26);
            this.txtMoney.TabIndex = 1;
            this.txtMoney.Text = "0";
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            this.txtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoney_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(465, 216);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 202;
            this.label5.Text = "المبلغ :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(125, 215);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 206;
            this.label8.Text = "طريقة الدفع :";
            // 
            // comboBanks
            // 
            this.comboBanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBanks.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBanks.FormattingEnabled = true;
            this.comboBanks.Location = new System.Drawing.Point(22, 237);
            this.comboBanks.Name = "comboBanks";
            this.comboBanks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBanks.Size = new System.Drawing.Size(178, 27);
            this.comboBanks.TabIndex = 4;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = global::MyApplication.Properties.Resources.Delete;
            this.BtnDelete.Location = new System.Drawing.Point(380, 386);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(130, 40);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = global::MyApplication.Properties.Resources.Save;
            this.BtnSave.Location = new System.Drawing.Point(22, 386);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(130, 40);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(430, 120);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 208;
            this.label2.Text = "اسم الموظف :";
            // 
            // comboBoxEmployees
            // 
            this.comboBoxEmployees.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxEmployees.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEmployees.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmployees.FormattingEnabled = true;
            this.comboBoxEmployees.Location = new System.Drawing.Point(22, 142);
            this.comboBoxEmployees.Name = "comboBoxEmployees";
            this.comboBoxEmployees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxEmployees.Size = new System.Drawing.Size(488, 27);
            this.comboBoxEmployees.TabIndex = 0;
            this.comboBoxEmployees.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployees_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(463, 34);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 211;
            this.label3.Text = "الراتب :";
            // 
            // comboSalary
            // 
            this.comboSalary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSalary.FormattingEnabled = true;
            this.comboSalary.Location = new System.Drawing.Point(22, 56);
            this.comboSalary.Name = "comboSalary";
            this.comboSalary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboSalary.Size = new System.Drawing.Size(488, 27);
            this.comboSalary.TabIndex = 210;
            this.comboSalary.SelectedIndexChanged += new System.EventHandler(this.comboSalary_SelectedIndexChanged);
            // 
            // DialogTakeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 458);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEmployees);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBanks);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.dateTimePicker5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogTakeSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسليم راتب";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DialogTakeSalary_FormClosed);
            this.Load += new System.EventHandler(this.DialogTakeSalary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBanks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEmployees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSalary;
    }
}