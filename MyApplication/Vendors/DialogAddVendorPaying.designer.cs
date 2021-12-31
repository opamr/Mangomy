namespace MyApplication.Vendors
{
    partial class DialogAddVendorPaying
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogAddVendorPaying));
            this.txtsender = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.comboBanks = new System.Windows.Forms.ComboBox();
            this.comboVendors = new System.Windows.Forms.ComboBox();
            this.txtNots = new System.Windows.Forms.TextBox();
            this.txtWasl = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsender
            // 
            resources.ApplyResources(this.txtsender, "txtsender");
            this.txtsender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtsender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsender.Name = "txtsender";
            // 
            // txtMoney
            // 
            resources.ApplyResources(this.txtMoney, "txtMoney");
            this.txtMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoney_KeyPress);
            this.txtMoney.Leave += new System.EventHandler(this.txtMoney_Leave);
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // txtDetails
            // 
            resources.ApplyResources(this.txtDetails, "txtDetails");
            this.txtDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetails.Name = "txtDetails";
            // 
            // comboBanks
            // 
            resources.ApplyResources(this.comboBanks, "comboBanks");
            this.comboBanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBanks.FormattingEnabled = true;
            this.comboBanks.Name = "comboBanks";
            // 
            // comboVendors
            // 
            resources.ApplyResources(this.comboVendors, "comboVendors");
            this.comboVendors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboVendors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboVendors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboVendors.FormattingEnabled = true;
            this.comboVendors.Name = "comboVendors";
            // 
            // txtNots
            // 
            resources.ApplyResources(this.txtNots, "txtNots");
            this.txtNots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNots.Name = "txtNots";
            // 
            // txtWasl
            // 
            resources.ApplyResources(this.txtWasl, "txtWasl");
            this.txtWasl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtWasl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWasl.Name = "txtWasl";
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.BackgroundImage = global::MyApplication.Properties.Resources.Delete;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.BackgroundImage = global::MyApplication.Properties.Resources.Save;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Name = "label7";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Name = "label6";
            // 
            // DialogAddVendorPaying
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWasl);
            this.Controls.Add(this.txtNots);
            this.Controls.Add(this.comboVendors);
            this.Controls.Add(this.comboBanks);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtsender);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.dateTimePicker1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogAddVendorPaying";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DialogAddVendorPaying_FormClosed);
            this.Load += new System.EventHandler(this.FrmAddVendorPaying_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtsender;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comboBanks;
        private System.Windows.Forms.ComboBox comboVendors;
        private System.Windows.Forms.TextBox txtNots;
        private System.Windows.Forms.TextBox txtWasl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}