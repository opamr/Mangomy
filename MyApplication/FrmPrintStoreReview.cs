using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPro;
using MyGeneration.dOOdads;
using System.IO;
using System.Globalization;
using System.Net.Mail;
using System.Net;

namespace MyApplication
{
    public partial class FrmPrintStoreReview : Form
    {
        int MyReviewID;
       
        public FrmPrintStoreReview(int ReviewID)
        {
            MyReviewID = ReviewID;
            InitializeComponent();         
        }

        private void FrmPrintStoreReview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TalalPharmacyDBDataSet9.ViewStoreReviewSummary1' table. You can move, or remove it, as needed.
            this.ViewStoreReviewSummary1TableAdapter.Fill(this.TalalPharmacyDBDataSet9.ViewStoreReviewSummary1,MyReviewID);
            // TODO: This line of code loads data into the 'TalalPharmacyDBDataSet9.ViewStoreReviewSummary11' table. You can move, or remove it, as needed.
            this.ViewStoreReviewSummary11TableAdapter.Fill(this.TalalPharmacyDBDataSet9.ViewStoreReviewSummary11, MyReviewID);
            // TODO: This line of code loads data into the 'TalalPharmacyDBDataSet9.ViewStoreReviewSummary' table. You can move, or remove it, as needed.
            this.ViewStoreReviewSummaryTableAdapter.Fill(this.TalalPharmacyDBDataSet9.ViewStoreReviewSummary,MyReviewID);

            this.reportViewer1.RefreshReport();
        }       
    }
}
