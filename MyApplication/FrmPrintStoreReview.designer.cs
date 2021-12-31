namespace MyApplication
{
    partial class FrmPrintStoreReview
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintStoreReview));
            this.ViewStoreReviewSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TalalPharmacyDBDataSet9 = new MyApplication.TalalPharmacyDBDataSet9();
            this.ViewStoreReviewSummary1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ViewStoreReviewSummary11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ViewStoreReviewSummaryTableAdapter = new MyApplication.TalalPharmacyDBDataSet9TableAdapters.ViewStoreReviewSummaryTableAdapter();
            this.ViewStoreReviewSummary1TableAdapter = new MyApplication.TalalPharmacyDBDataSet9TableAdapters.ViewStoreReviewSummary1TableAdapter();
            this.ViewStoreReviewSummary11TableAdapter = new MyApplication.TalalPharmacyDBDataSet9TableAdapters.ViewStoreReviewSummary11TableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStoreReviewSummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TalalPharmacyDBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStoreReviewSummary1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStoreReviewSummary11BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewStoreReviewSummaryBindingSource
            // 
            this.ViewStoreReviewSummaryBindingSource.DataMember = "ViewStoreReviewSummary";
            this.ViewStoreReviewSummaryBindingSource.DataSource = this.TalalPharmacyDBDataSet9;
            // 
            // TalalPharmacyDBDataSet9
            // 
            this.TalalPharmacyDBDataSet9.DataSetName = "TalalPharmacyDBDataSet9";
            this.TalalPharmacyDBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ViewStoreReviewSummary1BindingSource
            // 
            this.ViewStoreReviewSummary1BindingSource.DataMember = "ViewStoreReviewSummary1";
            this.ViewStoreReviewSummary1BindingSource.DataSource = this.TalalPharmacyDBDataSet9;
            // 
            // ViewStoreReviewSummary11BindingSource
            // 
            this.ViewStoreReviewSummary11BindingSource.DataMember = "ViewStoreReviewSummary11";
            this.ViewStoreReviewSummary11BindingSource.DataSource = this.TalalPharmacyDBDataSet9;
            // 
            // ViewStoreReviewSummaryTableAdapter
            // 
            this.ViewStoreReviewSummaryTableAdapter.ClearBeforeFill = true;
            // 
            // ViewStoreReviewSummary1TableAdapter
            // 
            this.ViewStoreReviewSummary1TableAdapter.ClearBeforeFill = true;
            // 
            // ViewStoreReviewSummary11TableAdapter
            // 
            this.ViewStoreReviewSummary11TableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ViewStoreReviewSummaryBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ViewStoreReviewSummary1BindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.ViewStoreReviewSummary11BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MyApplication.ReportStoreReview.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(834, 611);
            this.reportViewer1.TabIndex = 118;
            // 
            // FrmPrintStoreReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrintStoreReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة الجرد الشهري";
            this.Load += new System.EventHandler(this.FrmPrintStoreReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewStoreReviewSummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TalalPharmacyDBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStoreReviewSummary1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStoreReviewSummary11BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ViewStoreReviewSummaryBindingSource;
        private TalalPharmacyDBDataSet9 TalalPharmacyDBDataSet9;
        private TalalPharmacyDBDataSet9TableAdapters.ViewStoreReviewSummaryTableAdapter ViewStoreReviewSummaryTableAdapter;
        private System.Windows.Forms.BindingSource ViewStoreReviewSummary1BindingSource;
        private System.Windows.Forms.BindingSource ViewStoreReviewSummary11BindingSource;
        private TalalPharmacyDBDataSet9TableAdapters.ViewStoreReviewSummary1TableAdapter ViewStoreReviewSummary1TableAdapter;
        private TalalPharmacyDBDataSet9TableAdapters.ViewStoreReviewSummary11TableAdapter ViewStoreReviewSummary11TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}