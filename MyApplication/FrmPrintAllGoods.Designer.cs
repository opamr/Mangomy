namespace MyApplication
{
    partial class FrmPrintAllGoods
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintAllGoods));
            this.TblGoodsTitlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AbodaDBDataSet = new MyApplication.AbodaDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TblGoodsTitlesTableAdapter = new MyApplication.AbodaDBDataSetTableAdapters.TblGoodsTitlesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TblGoodsTitlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbodaDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TblGoodsTitlesBindingSource
            // 
            this.TblGoodsTitlesBindingSource.DataMember = "TblGoodsTitles";
            this.TblGoodsTitlesBindingSource.DataSource = this.AbodaDBDataSet;
            // 
            // AbodaDBDataSet
            // 
            this.AbodaDBDataSet.DataSetName = "AbodaDBDataSet";
            this.AbodaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblGoodsTitlesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MyApplication.ReportGoodsData.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(779, 741);
            this.reportViewer1.TabIndex = 0;
            // 
            // TblGoodsTitlesTableAdapter
            // 
            this.TblGoodsTitlesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintAllGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 741);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrintAllGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة كل الأصناف الحالية";
            this.Load += new System.EventHandler(this.FrmPrintAllGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblGoodsTitlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbodaDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblGoodsTitlesBindingSource;
        private AbodaDBDataSet AbodaDBDataSet;
        private AbodaDBDataSetTableAdapters.TblGoodsTitlesTableAdapter TblGoodsTitlesTableAdapter;
    }
}