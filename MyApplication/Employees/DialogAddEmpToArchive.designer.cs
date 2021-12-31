namespace MyApplication.Employees
{
    partial class DialogAddEmpToArchive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogAddEmpToArchive));
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArchiveReson = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker5.Location = new System.Drawing.Point(265, 32);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker5.RightToLeftLayout = true;
            this.dateTimePicker5.Size = new System.Drawing.Size(142, 26);
            this.dateTimePicker5.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(413, 38);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 99;
            this.label6.Text = "تاريخ الحفظ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(413, 119);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 101;
            this.label1.Text = "سبب الحفظ :";
            // 
            // txtArchiveReson
            // 
            this.txtArchiveReson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtArchiveReson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArchiveReson.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchiveReson.Location = new System.Drawing.Point(25, 114);
            this.txtArchiveReson.Name = "txtArchiveReson";
            this.txtArchiveReson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtArchiveReson.Size = new System.Drawing.Size(382, 26);
            this.txtArchiveReson.TabIndex = 102;
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = global::MyApplication.Properties.Resources.Save;
            this.BtnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(25, 190);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(130, 40);
            this.BtnSave.TabIndex = 152;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // DialogAddEmpToArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 257);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtArchiveReson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker5);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogAddEmpToArchive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حفظ الموظف في الأرشيف";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DialogAddEmpToArchive_FormClosed);
            this.Load += new System.EventHandler(this.DialogAddEmpToArchive_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArchiveReson;
        private System.Windows.Forms.Button BtnSave;
    }
}