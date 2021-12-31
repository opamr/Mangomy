namespace MyApplication
{
    partial class FrmPrintOutCome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintOutCome));
            this.OutComeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PharmacyDBDataSet1 = new MyApplication.PharmacyDBDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OutComeViewTableAdapter = new MyApplication.PharmacyDBDataSet1TableAdapters.OutComeViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OutComeViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PharmacyDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // OutComeViewBindingSource
            // 
            this.OutComeViewBindingSource.DataMember = "OutComeView";
            this.OutComeViewBindingSource.DataSource = this.PharmacyDBDataSet1;
            // 
            // PharmacyDBDataSet1
            // 
            this.PharmacyDBDataSet1.DataSetName = "PharmacyDBDataSet1";
            this.PharmacyDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OutComeViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MyApplication.ReportOutCome.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(814, 662);
            this.reportViewer1.TabIndex = 0;
            // 
            // OutComeViewTableAdapter
            // 
            this.OutComeViewTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintOutCome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyApplication.Properties.Resources.newbg;
            this.ClientSize = new System.Drawing.Size(814, 662);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrintOutCome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة المصروفات";
            this.Load += new System.EventHandler(this.FrmPrintOutCome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OutComeViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PharmacyDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OutComeViewBindingSource;
        private PharmacyDBDataSet1 PharmacyDBDataSet1;
        private PharmacyDBDataSet1TableAdapters.OutComeViewTableAdapter OutComeViewTableAdapter;
    }
}