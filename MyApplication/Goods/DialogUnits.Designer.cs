namespace MyApplication.Goods
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnShowAdd = new System.Windows.Forms.Button();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView3
            // 
            resources.ApplyResources(this.listView3, "listView3");
            this.listView3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader1});
            this.listView3.ForeColor = System.Drawing.Color.Navy;
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Name = "listView3";
            this.toolTip1.SetToolTip(this.listView3, resources.GetString("listView3.ToolTip"));
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.DoubleClick += new System.EventHandler(this.listView3_DoubleClick);
            // 
            // columnHeader11
            // 
            resources.ApplyResources(this.columnHeader11, "columnHeader11");
            // 
            // columnHeader12
            // 
            resources.ApplyResources(this.columnHeader12, "columnHeader12");
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            // 
            // BtnShowAdd
            // 
            resources.ApplyResources(this.BtnShowAdd, "BtnShowAdd");
            this.BtnShowAdd.BackgroundImage = global::MyApplication.Properties.Resources.IconAdd;
            this.BtnShowAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShowAdd.Name = "BtnShowAdd";
            this.toolTip1.SetToolTip(this.BtnShowAdd, resources.GetString("BtnShowAdd.ToolTip"));
            this.BtnShowAdd.UseVisualStyleBackColor = true;
            this.BtnShowAdd.Click += new System.EventHandler(this.BtnShowAdd_Click);
            // 
            // btnSaveEdit
            // 
            resources.ApplyResources(this.btnSaveEdit, "btnSaveEdit");
            this.btnSaveEdit.BackgroundImage = global::MyApplication.Properties.Resources.IconSave;
            this.btnSaveEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.toolTip1.SetToolTip(this.btnSaveEdit, resources.GetString("btnSaveEdit.ToolTip"));
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // btnSaveCategory
            // 
            resources.ApplyResources(this.btnSaveCategory, "btnSaveCategory");
            this.btnSaveCategory.BackgroundImage = global::MyApplication.Properties.Resources.IconSave;
            this.btnSaveCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.toolTip1.SetToolTip(this.btnSaveCategory, resources.GetString("btnSaveCategory.ToolTip"));
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // txtCategoryName
            // 
            resources.ApplyResources(this.txtCategoryName, "txtCategoryName");
            this.txtCategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryName.Name = "txtCategoryName";
            this.toolTip1.SetToolTip(this.txtCategoryName, resources.GetString("txtCategoryName.ToolTip"));
            this.txtCategoryName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCategoryName_MouseClick);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnSaveEdit);
            this.panel2.Controls.Add(this.txtEdit);
            this.panel2.Name = "panel2";
            this.toolTip1.SetToolTip(this.panel2, resources.GetString("panel2.ToolTip"));
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Name = "label9";
            this.toolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // txtEdit
            // 
            resources.ApplyResources(this.txtEdit, "txtEdit");
            this.txtEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdit.Name = "txtEdit";
            this.toolTip1.SetToolTip(this.txtEdit, resources.GetString("txtEdit.ToolTip"));
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnSaveCategory);
            this.panel1.Controls.Add(this.txtCategoryName);
            this.panel1.Name = "panel1";
            this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // DialogUnits
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyApplication.Properties.Resources.newbg;
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.BtnShowAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogUnits";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.DialogUnits_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button BtnShowAdd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.Panel panel1;
    }
}