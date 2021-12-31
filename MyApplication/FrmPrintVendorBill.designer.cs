namespace MyApplication
{
    partial class FrmPrintVendorBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintVendorBill));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FaysalNewDBDataSet = new MyApplication.FaysalNewDBDataSet();
            this.ViewVendorGoodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ViewVendorGoodsTableAdapter = new MyApplication.FaysalNewDBDataSetTableAdapters.ViewVendorGoodsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FaysalNewDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewVendorGoodsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ViewVendorGoodsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MyApplication.ReportVendorBill.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(834, 611);
            this.reportViewer1.TabIndex = 0;
            // 
            // FaysalNewDBDataSet
            // 
            this.FaysalNewDBDataSet.DataSetName = "FaysalNewDBDataSet";
            this.FaysalNewDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ViewVendorGoodsBindingSource
            // 
            this.ViewVendorGoodsBindingSource.DataMember = "ViewVendorGoods";
            this.ViewVendorGoodsBindingSource.DataSource = this.FaysalNewDBDataSet;
            // 
            // ViewVendorGoodsTableAdapter
            // 
            this.ViewVendorGoodsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintVendorBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrintVendorBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة فاتورة المورد";
            this.Load += new System.EventHandler(this.FrmPrintVendorBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FaysalNewDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewVendorGoodsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ViewVendorGoodsBindingSource;
        private FaysalNewDBDataSet FaysalNewDBDataSet;
        private FaysalNewDBDataSetTableAdapters.ViewVendorGoodsTableAdapter ViewVendorGoodsTableAdapter;
    }
}