namespace MyApplication
{
    partial class DialogUnits
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogUnits));
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.IconDelete = new System.Windows.Forms.Button();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.BtnShowAdd = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader1,
            this.columnHeader2});
            this.listView3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView3.ForeColor = System.Drawing.Color.Navy;
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(25, 57);
            this.listView3.Name = "listView3";
            this.listView3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView3.RightToLeftLayout = true;
            this.listView3.Size = new System.Drawing.Size(490, 390);
            this.listView3.TabIndex = 68;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.DoubleClick += new System.EventHandler(this.listView3_DoubleClick);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Id";
            this.columnHeader11.Width = 0;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "م";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 59;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "الفئة";
            this.columnHeader1.Width = 304;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "عدد الأصناف";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 88;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            // 
            // IconDelete
            // 
            this.IconDelete.BackgroundImage = global::MyApplication.Properties.Resources.IconDelete1;
            this.IconDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IconDelete.Location = new System.Drawing.Point(15, 5);
            this.IconDelete.Name = "IconDelete";
            this.IconDelete.Size = new System.Drawing.Size(40, 40);
            this.IconDelete.TabIndex = 73;
            this.toolTip1.SetToolTip(this.IconDelete, "حفظ التعديل");
            this.IconDelete.UseVisualStyleBackColor = true;
            this.IconDelete.Click += new System.EventHandler(this.IconDelete_Click);
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.BackgroundImage = global::MyApplication.Properties.Resources.IconSave;
            this.btnSaveEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveEdit.Location = new System.Drawing.Point(72, 4);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(40, 40);
            this.btnSaveEdit.TabIndex = 71;
            this.toolTip1.SetToolTip(this.btnSaveEdit, "حفظ التعديل");
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.BackgroundImage = global::MyApplication.Properties.Resources.IconSave;
            this.btnSaveCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveCategory.Location = new System.Drawing.Point(25, 4);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(40, 40);
            this.btnSaveCategory.TabIndex = 71;
            this.toolTip1.SetToolTip(this.btnSaveCategory, "إضافة");
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // BtnShowAdd
            // 
            this.BtnShowAdd.BackgroundImage = global::MyApplication.Properties.Resources.IconAdd;
            this.BtnShowAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnShowAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShowAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnShowAdd.Location = new System.Drawing.Point(451, 11);
            this.BtnShowAdd.Name = "BtnShowAdd";
            this.BtnShowAdd.Size = new System.Drawing.Size(40, 40);
            this.BtnShowAdd.TabIndex = 69;
            this.toolTip1.SetToolTip(this.BtnShowAdd, "إضافة فئة جديدة");
            this.BtnShowAdd.UseVisualStyleBackColor = true;
            this.BtnShowAdd.Click += new System.EventHandler(this.BtnShowAdd_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(72, 18);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(299, 26);
            this.txtCategoryName.TabIndex = 70;
            this.txtCategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCategoryName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPayPrice_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnSaveCategory);
            this.panel1.Controls.Add(this.txtCategoryName);
            this.panel1.Location = new System.Drawing.Point(62, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 48);
            this.panel1.TabIndex = 71;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.IconDelete);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnSaveEdit);
            this.panel2.Controls.Add(this.txtEdit);
            this.panel2.Location = new System.Drawing.Point(25, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 48);
            this.panel2.TabIndex = 72;
            this.panel2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(403, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 19);
            this.label9.TabIndex = 72;
            this.label9.Text = ": تعديل";
            // 
            // txtEdit
            // 
            this.txtEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdit.Location = new System.Drawing.Point(119, 12);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(278, 26);
            this.txtEdit.TabIndex = 70;
            this.txtEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEdit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEdit_MouseClick);
            // 
            // DialogUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(537, 506);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnShowAdd);
            this.Controls.Add(this.listView3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogUnits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الفئات";
            this.Load += new System.EventHandler(this.DialogCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button BtnShowAdd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button IconDelete;
    }
}