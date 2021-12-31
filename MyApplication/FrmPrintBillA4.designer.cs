namespace MyApplication
{
    partial class FrmPrintBillA4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintBillA4));
            this.ViewCustomerPaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NewDataSet = new MyApplication.NewDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ViewCustomerPaymentsTableAdapter = new MyApplication.NewDataSetTableAdapters.ViewCustomerPaymentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCustomerPaymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewCustomerPaymentsBindingSource
            // 
            this.ViewCustomerPaymentsBindingSource.DataMember = "ViewCustomerPayments";
            this.ViewCustomerPaymentsBindingSource.DataSource = this.NewDataSet;
            // 
            // NewDataSet
            // 
            this.NewDataSet.DataSetName = "NewDataSet";
            this.NewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1NN";
            reportDataSource1.Value = this.ViewCustomerPaymentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MyApplication.ReportBillA4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(779, 662);
            this.reportViewer1.TabIndex = 0;
            // 
            // ViewCustomerPaymentsTableAdapter
            // 
            this.ViewCustomerPaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyApplication.Properties.Resources.newbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 662);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrintBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة الفاتورة";
            this.Load += new System.EventHandler(this.FrmPrintBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewCustomerPaymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ViewCustomerPaymentsBindingSource;
        private NewDataSet NewDataSet;
        private NewDataSetTableAdapters.ViewCustomerPaymentsTableAdapter ViewCustomerPaymentsTableAdapter;
    }
}