namespace MyApplication
{
    partial class DialogChooseBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogChooseBill));
            this.BtnPrint1 = new System.Windows.Forms.Button();
            this.BtnPrint2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPrint1
            // 
            this.BtnPrint1.BackgroundImage = global::MyApplication.Properties.Resources.EmptyBTN;
            this.BtnPrint1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPrint1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint1.ForeColor = System.Drawing.Color.White;
            this.BtnPrint1.Location = new System.Drawing.Point(274, 79);
            this.BtnPrint1.Name = "BtnPrint1";
            this.BtnPrint1.Size = new System.Drawing.Size(168, 51);
            this.BtnPrint1.TabIndex = 0;
            this.BtnPrint1.Text = "A4 طباعة";
            this.BtnPrint1.UseVisualStyleBackColor = true;
            this.BtnPrint1.Click += new System.EventHandler(this.BtnPrint1_Click);
            // 
            // BtnPrint2
            // 
            this.BtnPrint2.BackgroundImage = global::MyApplication.Properties.Resources.EmptyBTN;
            this.BtnPrint2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPrint2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint2.ForeColor = System.Drawing.Color.White;
            this.BtnPrint2.Location = new System.Drawing.Point(28, 79);
            this.BtnPrint2.Name = "BtnPrint2";
            this.BtnPrint2.Size = new System.Drawing.Size(168, 51);
            this.BtnPrint2.TabIndex = 1;
            this.BtnPrint2.Text = "طباعة فاتورة ايبسون";
            this.BtnPrint2.UseVisualStyleBackColor = true;
            this.BtnPrint2.Click += new System.EventHandler(this.BtnPrint2_Click);
            // 
            // DialogChooseBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(471, 199);
            this.Controls.Add(this.BtnPrint2);
            this.Controls.Add(this.BtnPrint1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogChooseBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اختيار تصميم الفاتورة";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DialogChooseBill_FormClosed);
            this.Load += new System.EventHandler(this.DialogChooseBill_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPrint1;
        private System.Windows.Forms.Button BtnPrint2;
    }
}