namespace MyApplication
{
    partial class FrmPrintBillEpson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintBillEpson));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NewDataSet = new MyApplication.NewDataSet();
            this.ViewCustomerPaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ViewCustomerPaymentsTableAdapter = new MyApplication.NewDataSetTableAdapters.ViewCustomerPaymentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCustomerPaymentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ViewCustomerPaymentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MyApplication.ReportBillEpson.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(834, 611);
            this.reportViewer1.TabIndex = 0;
            // 
            // NewDataSet
            // 
            this.NewDataSet.DataSetName = "NewDataSet";
            this.NewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ViewCustomerPaymentsBindingSource
            // 
            this.ViewCustomerPaymentsBindingSource.DataMember = "ViewCustomerPayments";
            this.ViewCustomerPaymentsBindingSource.DataSource = this.NewDataSet;
            // 
            // ViewCustomerPaymentsTableAdapter
            // 
            this.ViewCustomerPaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintBillEpson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrintBillEpson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة فاتورة ايبسون";
            this.Load += new System.EventHandler(this.FrmPrintBillEpson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCustomerPaymentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ViewCustomerPaymentsBindingSource;
        private NewDataSet NewDataSet;
        private NewDataSetTableAdapters.ViewCustomerPaymentsTableAdapter ViewCustomerPaymentsTableAdapter;
    }
}