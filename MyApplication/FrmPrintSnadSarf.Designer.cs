namespace MyApplication
{
    partial class FrmPrintSnadSarf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintSnadSarf));
            this.TblVendorsPayingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AbodaDBDataSet1 = new MyApplication.AbodaDBDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TblVendorsPayingTableAdapter = new MyApplication.AbodaDBDataSet1TableAdapters.TblVendorsPayingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TblVendorsPayingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbodaDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // TblVendorsPayingBindingSource
            // 
            this.TblVendorsPayingBindingSource.DataMember = "TblVendorsPaying";
            this.TblVendorsPayingBindingSource.DataSource = this.AbodaDBDataSet1;
            // 
            // AbodaDBDataSet1
            // 
            this.AbodaDBDataSet1.DataSetName = "AbodaDBDataSet1";
            this.AbodaDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblVendorsPayingBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MyApplication.ReportSnadSarf.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(784, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // TblVendorsPayingTableAdapter
            // 
            this.TblVendorsPayingTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintSnadSarf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrintSnadSarf";
            this.Text = "طباعة سند صرف";
            this.Load += new System.EventHandler(this.FrmPrintWasl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblVendorsPayingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbodaDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblVendorsPayingBindingSource;
        private AbodaDBDataSet1 AbodaDBDataSet1;
        private AbodaDBDataSet1TableAdapters.TblVendorsPayingTableAdapter TblVendorsPayingTableAdapter;
    }
}