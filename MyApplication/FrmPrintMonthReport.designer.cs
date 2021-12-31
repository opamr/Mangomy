namespace MyApplication
{
    partial class FrmPrintMonthReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintMonthReport));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PaymentsDBDataSet2 = new MyApplication.PaymentsDBDataSet2();
            this.TblPrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TblPrintTableAdapter = new MyApplication.PaymentsDBDataSet2TableAdapters.TblPrintTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblPrintBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblPrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MyApplication.ReportMonthReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(834, 611);
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
            this.TblPrintBindingSource.DataSource = this.PaymentsDBDataSet2;
            // 
            // TblPrintTableAdapter
            // 
            this.TblPrintTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintMonthReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrintMonthReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة التقرير الرقمي";
            this.Load += new System.EventHandler(this.FrmPrintMonthReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblPrintBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblPrintBindingSource;
        private PaymentsDBDataSet2 PaymentsDBDataSet2;
        private PaymentsDBDataSet2TableAdapters.TblPrintTableAdapter TblPrintTableAdapter;
    }
}