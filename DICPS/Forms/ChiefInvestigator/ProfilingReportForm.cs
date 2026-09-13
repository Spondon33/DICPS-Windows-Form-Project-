using DICPS.Common;
using DICPS.Models.ChiefInvestigator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DICPS.Common;
using DICPS.Models.ChiefInvestigator;

namespace DICPS.Forms.ChiefInvestigator
{
    public partial class ProfilingReportForm : Form
    {
        private StaffUser loggedInUser;
        private ProfilingEngine engine = new ProfilingEngine();
        public ProfilingReportForm(StaffUser user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void ProfilingReportForm_Load(object sender, EventArgs e)
        {
            var suspects = engine.GetAllSuspects();
            cmbSuspect.DataSource = suspects;
            cmbSuspect.DisplayMember = "Name";
            cmbSuspect.ValueMember = "SuspectID";

            var cases = engine.GetAllCases();
            cmbCase.DataSource = cases;
            cmbCase.DisplayMember = "CaseNumber";
            cmbCase.ValueMember = "CaseID";
        }

        private void btnGenerateScore_Click(object sender, EventArgs e)
        {
            int suspectId = Convert.ToInt32(cmbSuspect.SelectedValue);
            int caseId = Convert.ToInt32(cmbCase.SelectedValue);

            float score = engine.GenerateProfilingScore(suspectId, caseId);
            lblScoreResult.Text = "Profiling Score: " + score;

            ProfilingReport report = new ProfilingReport
            {
                CaseId = caseId,
                SuspectId = suspectId,
                ReviewedByUserId = loggedInUser.UserId,
                ProfilingScore = score
            };
            report.SaveProfilingReport();

            MessageBox.Show("Profiling report generated and saved.");
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            int caseId = Convert.ToInt32(cmbCase.SelectedValue);
            ProfilingReport report = new ProfilingReport();
            dgvReports.DataSource = report.GetProfilingReportByCase(caseId);
        }
    }
}
