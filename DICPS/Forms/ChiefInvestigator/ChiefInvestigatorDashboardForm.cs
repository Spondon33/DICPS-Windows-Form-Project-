using DICPS.Forms.Shared;
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

namespace DICPS.Forms.ChiefInvestigator
{
    public partial class ChiefInvestigatorDashboardForm : Form
    {
        private DashboardData dashboardData = new DashboardData();
        public ChiefInvestigatorDashboardForm()
        {
            InitializeComponent();
        }

        private void ChiefInvestigatorDashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }
        private void LoadDashboard()
        {
            dashboardData.LoadStatistics();

            lblTotalCases.Text = "Total Cases: " + dashboardData.TotalCases;
            lblOpenCases.Text = "Open Cases: " + dashboardData.OpenCases;
            lblColdCases.Text = "Cold Cases: " + dashboardData.ColdCases;
            lblClosedCases.Text = "Closed Cases: " + dashboardData.ClosedCases;
            lblTotalSuspects.Text = "Total Suspects: " + dashboardData.TotalSuspects;
            lblTotalWitnesses.Text = "Total Witnesses: " + dashboardData.TotalWitnesses;
            lblPendingEvidence.Text = "Pending Evidence: " + dashboardData.PendingEvidence;
            lblUnlinkedEvidence.Text = "Unlinked Evidence: " + dashboardData.UnlinkedEvidence;
            lblTotalProfilingReports.Text = "Profiling Reports: " + dashboardData.TotalProfilingReports;

            dgvAllCases.DataSource = dashboardData.GetAllCases();
        }

        private void btnRefreshDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void buttonReassignDetective_Click(object sender, EventArgs e)
        {
            if (dgvAllCases.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a case first.");
                return;
            }

            int caseId = (int)dgvAllCases.SelectedRows[0].Cells["CaseID"].Value;

            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter new Detective's UserID:", "Reassign Detective", "");

            if (int.TryParse(input, out int newDetectiveId))
            {
                dashboardData.ReassignDetective(caseId, newDetectiveId);
                MessageBox.Show("Case reassigned successfully.");
                LoadDashboard();
            }
            else
            {
                MessageBox.Show("Invalid Detective ID.");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
