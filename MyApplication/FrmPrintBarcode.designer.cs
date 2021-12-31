namespace MyApplication
{
    partial class FrmPrintBarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintBarcode));
            this.TblBarcodeCountPrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaferHealthDB2DataSet1 = new MyApplication.SaferHealthDB2DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TblBarcodeCountPrintTableAdapter = new MyApplication.SaferHealthDB2DataSet1TableAdapters.TblBarcodeCountPrintTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TblBarcodeCountPrintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaferHealthDB2DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // TblBarcodeCountPrintBindingSource
            // 
            this.TblBarcodeCountPrintBindingSource.DataMember = "TblBarcodeCountPrint";
            this.TblBarcodeCountPrintBindingSource.DataSource = this.SaferHealthDB2DataSet1;
            // 
            // SaferHealthDB2DataSet1
            // 
            this.SaferHealthDB2DataSet1.DataSetName = "SaferHealthDB2DataSet1";
            this.SaferHealthDB2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblBarcodeCountPrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MyApplication.ReportBarcodeStiker.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(621, 257);
            this.reportViewer1.TabIndex = 0;
            // 
            // TblBarcodeCountPrintTableAdapter
            // 
            this.TblBarcodeCountPrintTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 257);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrintBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة استيكر باركود";
            this.Load += new System.EventHandler(this.FrmPrintBarcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblBarcodeCountPrintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaferHealthDB2DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblBarcodeCountPrintBindingSource;
        private SaferHealthDB2DataSet1 SaferHealthDB2DataSet1;
        private SaferHealthDB2DataSet1TableAdapters.TblBarcodeCountPrintTableAdapter TblBarcodeCountPrintTableAdapter;
    }
}