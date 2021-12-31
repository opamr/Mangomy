namespace MyApplication.Customers
{
    partial class FrmPrintCustomerFinance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintCustomerFinance));
            this.TblPrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PharmacyDBDataSet2 = new MyApplication.PharmacyDBDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TblPrintTableAdapter = new MyApplication.PharmacyDBDataSet2TableAdapters.TblPrintTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TblPrintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PharmacyDBDataSet2)).BeginInit();
            this.SuspendLayout();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblPrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MyApplication.ReportCustomerFinance.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(824, 662);
            this.reportViewer1.TabIndex = 0;
            // 
            // TblPrintTableAdapter
            // 
            this.TblPrintTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintCustomerFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 662);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrintCustomerFinance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة كشف حساب العميل";
            this.Load += new System.EventHandler(this.FrmPrintCustomerFinance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblPrintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PharmacyDBDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblPrintBindingSource;
        private PharmacyDBDataSet2 PharmacyDBDataSet2;
        private PharmacyDBDataSet2TableAdapters.TblPrintTableAdapter TblPrintTableAdapter;
    }
}