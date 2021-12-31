namespace MyApplication
{
    partial class FrmPrintSnadKapd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintSnadKapd));
            this.TblCustomersPayingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AbodaDBDataSet2 = new MyApplication.AbodaDBDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TblCustomersPayingTableAdapter = new MyApplication.AbodaDBDataSet2TableAdapters.TblCustomersPayingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TblCustomersPayingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbodaDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // TblCustomersPayingBindingSource
            // 
            this.TblCustomersPayingBindingSource.DataMember = "TblCustomersPaying";
            this.TblCustomersPayingBindingSource.DataSource = this.AbodaDBDataSet2;
            // 
            // AbodaDBDataSet2
            // 
            this.AbodaDBDataSet2.DataSetName = "AbodaDBDataSet2";
            this.AbodaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblCustomersPayingBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MyApplication.ReportSnadKapd.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(784, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // TblCustomersPayingTableAdapter
            // 
            this.TblCustomersPayingTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintSnadKapd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrintSnadKapd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة سند قبض";
            this.Load += new System.EventHandler(this.FrmPrintWaslCust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblCustomersPayingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbodaDBDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblCustomersPayingBindingSource;
        private AbodaDBDataSet2 AbodaDBDataSet2;
        private AbodaDBDataSet2TableAdapters.TblCustomersPayingTableAdapter TblCustomersPayingTableAdapter;
    }
}