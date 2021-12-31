namespace MyApplication.Employees
{
    partial class DialogAddOneSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogAddOneSalary));
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEmployees = new System.Windows.Forms.ComboBox();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(12, 45);
            this.txtYear.Name = "txtYear";
            this.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtYear.Size = new System.Drawing.Size(93, 26);
            this.txtYear.TabIndex = 2;
            this.txtYear.Text = "0";
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonth_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(62, 23);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 157;
            this.label1.Text = "السنة :";
            // 
            // txtMonth
            // 
            this.txtMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.Location = new System.Drawing.Point(134, 45);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMonth.Size = new System.Drawing.Size(93, 26);
            this.txtMonth.TabIndex = 1;
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
            this.label5.Location = new System.Drawing.Point(181, 23);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 155;
            this.label5.Text = "الشهر :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(451, 23);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 160;
            this.label2.Text = "اسم الموظف :";
            // 
            // comboBoxEmployees
            // 
            this.comboBoxEmployees.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxEmployees.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEmployees.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmployees.FormattingEnabled = true;
            this.comboBoxEmployees.Location = new System.Drawing.Point(270, 45);
            this.comboBoxEmployees.Name = "comboBoxEmployees";
            this.comboBoxEmployees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxEmployees.Size = new System.Drawing.Size(261, 27);
            this.comboBoxEmployees.TabIndex = 0;
            this.comboBoxEmployees.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployees_SelectedIndexChanged);
            // 
            // txtHouse
            // 
            this.txtHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtHouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHouse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHouse.Location = new System.Drawing.Point(270, 147);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(93, 26);
            this.txtHouse.TabIndex = 4;
            this.txtHouse.Text = "0";
            this.txtHouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonth_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(492, 125);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 164;
            this.label3.Text = "الراتب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(305, 125);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 166;
            this.label4.Text = "بدل السكن";
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(400, 147);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(130, 26);
            this.txtSalary.TabIndex = 3;
            this.txtSalary.Text = "0";
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonth_KeyPress);
            // 
            // txtDetails
            // 
            this.txtDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(270, 219);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDetails.Size = new System.Drawing.Size(260, 26);
            this.txtDetails.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(481, 197);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 164;
            this.label6.Text = "التفاصيل";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker5.Location = new System.Drawing.Point(76, 147);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker5.RightToLeftLayout = true;
            this.dateTimePicker5.Size = new System.Drawing.Size(142, 26);
            this.dateTimePicker5.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(119, 125);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 167;
            this.label7.Text = "تاريخ الإستحقاق :";
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = global::MyApplication.Properties.Resources.Save;
            this.BtnSave.Location = new System.Drawing.Point(12, 274);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(130, 40);
            this.BtnSave.TabIndex = 13;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = global::MyApplication.Properties.Resources.Delete;
            this.BtnDelete.Location = new System.Drawing.Point(405, 274);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(130, 40);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // DialogAddOneSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 333);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.dateTimePicker5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHouse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEmployees);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogAddOneSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "راتب موظف واحد";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DialogAddOneSalary_FormClosed);
            this.Load += new System.EventHandler(this.DialogAddOneSalary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEmployees;
        private System.Windows.Forms.TextBox txtHouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
    }
}