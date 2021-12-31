namespace MyApplication
{
    partial class FrmAllGoods
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAllGoods));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnNewGood = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnPrintSelected = new System.Windows.Forms.Button();
            this.BtnSearchByStore = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchGood = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.comboStores = new System.Windows.Forms.ComboBox();
            this.checkBoxStore = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCurrrent = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MyApplication.Properties.Resources.Footer;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 625);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1314, 37);
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MyApplication.Properties.Resources.Header;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1314, 83);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // BtnNewGood
            // 
            this.BtnNewGood.BackgroundImage = global::MyApplication.Properties.Resources.EmptyBTN;
            this.BtnNewGood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNewGood.ForeColor = System.Drawing.Color.White;
            this.BtnNewGood.Location = new System.Drawing.Point(12, 547);
            this.BtnNewGood.Name = "BtnNewGood";
            this.BtnNewGood.Size = new System.Drawing.Size(130, 40);
            this.BtnNewGood.TabIndex = 78;
            this.BtnNewGood.Text = "إضافة صنف جديد";
            this.BtnNewGood.UseVisualStyleBackColor = true;
            this.BtnNewGood.Click += new System.EventHandler(this.BtnNewGood_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnViewAll.BackgroundImage = global::MyApplication.Properties.Resources.EmptyBTN;
            this.btnViewAll.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewAll.Location = new System.Drawing.Point(200, 547);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(182, 40);
            this.btnViewAll.TabIndex = 79;
            this.btnViewAll.Text = "عرض كل الأصناف";
            this.toolTip1.SetToolTip(this.btnViewAll, "تحديث الصفحة");
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.StripAmpersands = true;
            // 
            // BtnPrintSelected
            // 
            this.BtnPrintSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnPrintSelected.BackgroundImage = global::MyApplication.Properties.Resources.BtnPrintSelected;
            this.BtnPrintSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPrintSelected.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintSelected.Location = new System.Drawing.Point(1068, 547);
            this.BtnPrintSelected.Name = "BtnPrintSelected";
            this.BtnPrintSelected.Size = new System.Drawing.Size(133, 40);
            this.BtnPrintSelected.TabIndex = 83;
            this.toolTip1.SetToolTip(this.BtnPrintSelected, "تحديث الصفحة");
            this.BtnPrintSelected.UseVisualStyleBackColor = false;
            this.BtnPrintSelected.Click += new System.EventHandler(this.BtnPrintSelected_Click);
            // 
            // BtnSearchByStore
            // 
            this.BtnSearchByStore.BackgroundImage = global::MyApplication.Properties.Resources.IconSearch;
            this.BtnSearchByStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSearchByStore.Location = new System.Drawing.Point(1099, 111);
            this.BtnSearchByStore.Name = "BtnSearchByStore";
            this.BtnSearchByStore.Size = new System.Drawing.Size(40, 40);
            this.BtnSearchByStore.TabIndex = 120;
            this.toolTip1.SetToolTip(this.BtnSearchByStore, "إضافة صنف جديد");
            this.BtnSearchByStore.UseVisualStyleBackColor = true;
            this.BtnSearchByStore.Click += new System.EventHandler(this.BtnSearchByStore_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OldLace;
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
            this.Column2,
            this.Column7,
            this.Column3,
            this.Column5,
            this.Column8,
            this.Column6,
            this.Column4,
            this.Column9,
            this.Column11,
            this.Column12});
            this.dataGridView1.Location = new System.Drawing.Point(6, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1302, 362);
            this.dataGridView1.TabIndex = 84;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "م";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 40;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "الفئة";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "إسم الصنف";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 350;
            // 
            // Column5
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "باركود";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 180;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "الوحدة";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 120;
            // 
            // Column6
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column6.HeaderText = "العدد الحالي";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "سعر البيع";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // Column9
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column9.HeaderText = "سعر الشراء";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column11
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column11.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column11.HeaderText = "الإجمالي";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "تتبُع";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 70;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(321, 63);
            this.groupBox3.TabIndex = 90;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بحث بكامل الاسم";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(309, 23);
            this.comboBox1.TabIndex = 67;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtSearchGood);
            this.groupBox2.Location = new System.Drawing.Point(333, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(200, 63);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بحث بجزء من الاسم";
            // 
            // txtSearchGood
            // 
            this.txtSearchGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSearchGood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchGood.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchGood.Location = new System.Drawing.Point(6, 26);
            this.txtSearchGood.Name = "txtSearchGood";
            this.txtSearchGood.Size = new System.Drawing.Size(186, 26);
            this.txtSearchGood.TabIndex = 3;
            this.txtSearchGood.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboCategory);
            this.groupBox1.Location = new System.Drawing.Point(725, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(216, 63);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بحث بالفئة";
            // 
            // comboCategory
            // 
            this.comboCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCategory.BackColor = System.Drawing.Color.White;
            this.comboCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(6, 25);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboCategory.Size = new System.Drawing.Size(201, 27);
            this.comboCategory.TabIndex = 68;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // comboStores
            // 
            this.comboStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStores.FormattingEnabled = true;
            this.comboStores.Location = new System.Drawing.Point(1145, 124);
            this.comboStores.Name = "comboStores";
            this.comboStores.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboStores.Size = new System.Drawing.Size(163, 27);
            this.comboStores.TabIndex = 119;
            // 
            // checkBoxStore
            // 
            this.checkBoxStore.AutoSize = true;
            this.checkBoxStore.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxStore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStore.Location = new System.Drawing.Point(1199, 96);
            this.checkBoxStore.Name = "checkBoxStore";
            this.checkBoxStore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxStore.Size = new System.Drawing.Size(109, 23);
            this.checkBoxStore.TabIndex = 121;
            this.checkBoxStore.Text = "تحديد مستودع :";
            this.checkBoxStore.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(1047, 101);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 125;
            this.label2.Text = "النوع :";
            // 
            // comboCurrrent
            // 
            this.comboCurrrent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCurrrent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCurrrent.FormattingEnabled = true;
            this.comboCurrrent.Items.AddRange(new object[] {
            "الكل",
            "الحالية",
            "المنتهية"});
            this.comboCurrrent.Location = new System.Drawing.Point(951, 124);
            this.comboCurrrent.Name = "comboCurrrent";
            this.comboCurrrent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboCurrrent.Size = new System.Drawing.Size(142, 27);
            this.comboCurrrent.TabIndex = 124;
            this.comboCurrrent.SelectedIndexChanged += new System.EventHandler(this.comboCurrrent_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.txtBarcode);
            this.groupBox4.Location = new System.Drawing.Point(539, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(180, 63);
            this.groupBox4.TabIndex = 126;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "بحث باركود";
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(9, 26);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBarcode.Size = new System.Drawing.Size(161, 26);
            this.txtBarcode.TabIndex = 3;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // FrmAllGoods
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1314, 662);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboCurrrent);
            this.Controls.Add(this.checkBoxStore);
            this.Controls.Add(this.BtnSearchByStore);
            this.Controls.Add(this.comboStores);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnPrintSelected);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.BtnNewGood);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAllGoods";
            this.Text = "كل الأصناف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAllGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnNewGood;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnPrintSelected;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearchGood;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Button BtnSearchByStore;
        private System.Windows.Forms.ComboBox comboStores;
        private System.Windows.Forms.CheckBox checkBoxStore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCurrrent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewButtonColumn Column12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBarcode;
    }
}