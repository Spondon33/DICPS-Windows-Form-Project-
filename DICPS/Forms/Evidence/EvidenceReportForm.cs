using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DICPS.Models.Evidence;

namespace DICPS.Forms.Evidence
{
    public partial class EvidenceReportForm : Form
    {
        public EvidenceReportForm()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCaseId.Text))
            {
                MessageBox.Show("Please enter a Case ID.");
                return;
            }

            int caseId = Convert.ToInt32(txtCaseId.Text);
            dgvReport.DataSource = DICPS.Models.Evidence.Evidence.SearchEvidenceByCase(caseId);

            lblReportTitle.Text = "Evidence Report for Case ID: " + caseId;
        }
    }
}
