namespace MyApplication
{
    partial class FrmPrintDailyReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintDailyReport));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PaymentsDBDataSet2 = new MyApplication.PaymentsDBDataSet2();
            this.TblPrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PharmacyDBDataSet2 = new MyApplication.PharmacyDBDataSet2();
            this.TblPrint1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TblPrint11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TblPrint12BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TblPrint13BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TblPrintTableAdapter = new MyApplication.PharmacyDBDataSet2TableAdapters.TblPrintTableAdapter();
            this.TblPrint1TableAdapter = new MyApplication.PharmacyDBDataSet2TableAdapters.TblPrint1TableAdapter();
            this.TblPrint11TableAdapter = new MyApplication.PharmacyDBDataSet2TableAdapters.TblPrint11TableAdapter();
            this.TblPrint12TableAdapter = new MyApplication.PharmacyDBDataSet2TableAdapters.TblPrint12TableAdapter();
            this.TblPrint13TableAdapter = new MyApplication.PharmacyDBDataSet2TableAdapters.TblPrint13TableAdapter();
            this.TblPrint14BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TblPrint14TableAdapter = new MyApplication.PharmacyDBDataSet2TableAdapters.TblPrint14TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblPrintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PharmacyDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblPrint1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblPrint11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblPrint12BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblPrint13BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblPrint14BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblPrintBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.TblPrint1BindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.TblPrint11BindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.TblPrint12BindingSource;
            reportDataSource5.Name = "DataSet5";
            reportDataSource5.Value = this.TblPrint13BindingSource;
            reportDataSource6.Name = "DataSet6";
            reportDataSource6.Value = this.TblPrint14BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MyApplication.ReportDailyReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1134, 611);
            this.reportViewer1.TabIndex = 0;
            // 
            // PaymentsDBDataSet2
            // 
            this.PaymentsDBDataSet2.DataSetName = "PaymentsDBDataSet2";
            this.PaymentsDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TblPrintBindingSource
            // 
            this.TblPrintBindingSource.DataMember = "TblPrint";
            this.TblPrintBindingSource.DataSource = this.PharmacyDBDataSet2;
            // 
            // PharmacyDBDataSet2
            // 
            this.PharmacyDBDataSet2.DataSetName = "PharmacyDBDataSet2";
            this.PharmacyDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TblPrint1BindingSource
            // 
            this.TblPrint1BindingSource.DataMember = "TblPrint1";
            this.TblPrint1BindingSource.DataSource = this.PharmacyDBDataSet2;
            // 
            // TblPrint11BindingSource
            // 
            this.TblPrint11BindingSource.DataMember = "TblPrint11";
            this.TblPrint11BindingSource.DataSource = this.PharmacyDBDataSet2;
            // 
            // TblPrint12BindingSource
            // 
            this.TblPrint12BindingSource.DataMember = "TblPrint12";
            this.TblPrint12BindingSource.DataSource = this.PharmacyDBDataSet2;
            // 
            // TblPrint13BindingSource
            // 
            this.TblPrint13BindingSource.DataMember = "TblPrint13";
            this.TblPrint13BindingSource.DataSource = this.PharmacyDBDataSet2;
            // 
            // TblPrintTableAdapter
            // 
            this.TblPrintTableAdapter.ClearBeforeFill = true;
            // 
            // TblPrint1TableAdapter
            // 
            this.TblPrint1TableAdapter.ClearBeforeFill = true;
            // 
            // TblPrint11TableAdapter
            // 
            this.TblPrint11TableAdapter.ClearBeforeFill = true;
            // 
            // TblPrint12TableAdapter
            // 
            this.TblPrint12TableAdapter.ClearBeforeFill = true;
            // 
            // TblPrint13TableAdapter
            // 
            this.TblPrint13TableAdapter.ClearBeforeFill = true;
            // 
            // TblPrint14BindingSource
            // 
            this.TblPrint14BindingSource.DataMember = "TblPrint14";
            this.TblPrint14BindingSource.DataSource = this.PharmacyDBDataSet2;
            // 
            // TblPrint14TableAdapter
            // 
            this.TblPrint14TableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintDailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrintDailyReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التقرير اليومي";
            this.Load += new System.EventHandler(this.FrmPrintDailyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblPrintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PharmacyDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblPrint1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblPrint11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblPrint12BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblPrint13BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblPrint14BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblPrintBindingSource;
        private PharmacyDBDataSet2 PharmacyDBDataSet2;
        private PharmacyDBDataSet2TableAdapters.TblPrintTableAdapter TblPrintTableAdapter;
        private System.Windows.Forms.BindingSource TblPrint1BindingSource;
        private System.Windows.Forms.BindingSource TblPrint11BindingSource;
        private System.Windows.Forms.BindingSource TblPrint12BindingSource;
        private System.Windows.Forms.BindingSource TblPrint13BindingSource;
        private PaymentsDBDataSet2 PaymentsDBDataSet2;
        private PharmacyDBDataSet2TableAdapters.TblPrint1TableAdapter TblPrint1TableAdapter;
        private PharmacyDBDataSet2TableAdapters.TblPrint11TableAdapter TblPrint11TableAdapter;
        private PharmacyDBDataSet2TableAdapters.TblPrint12TableAdapter TblPrint12TableAdapter;
        private PharmacyDBDataSet2TableAdapters.TblPrint13TableAdapter TblPrint13TableAdapter;
        private System.Windows.Forms.BindingSource TblPrint14BindingSource;
        private PharmacyDBDataSet2TableAdapters.TblPrint14TableAdapter TblPrint14TableAdapter;
    }
}