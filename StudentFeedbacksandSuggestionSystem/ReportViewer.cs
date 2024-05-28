using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbacksandSuggestionSystem
{
    public partial class ReportViewer : Form
    {
        public ReportViewer(string reportName)
        {
            InitializeComponent();
            LoadReport(reportName);
        }

        private void LoadReport(string reportName)
        {
            string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", reportName);
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load(reportPath);

            crystalReportViewer1.ReportSource = reportDocument;
        }
    }
}
