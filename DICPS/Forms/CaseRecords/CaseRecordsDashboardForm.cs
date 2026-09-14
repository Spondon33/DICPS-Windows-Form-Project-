using System;
using System.Windows.Forms;
using DICPS.Common;
using DICPS.Forms.Shared;
using DICPS.Models.CaseRecords;

namespace DICPS.Forms.CaseRecords
{
    public partial class CaseRecordsDashboardForm : Form
    {
        private StaffUser loggedInUser;

        public CaseRecordsDashboardForm(StaffUser user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void CaseRecordsDashboardForm_Load(object sender, EventArgs e)
        {
            lblLoggedInUserId.Text = "User ID: " + loggedInUser.UserId;
            lblLoggedInName.Text = "Name: " + loggedInUser.Name;

            LoadStatistics();
        }

        private void LoadStatistics()
        {
            lblCaseCount.Text = CaseRecord.GetCaseCount().ToString();
            lblOpenCaseCount.Text = CaseRecord.GetOpenCaseCount().ToString();
            lblClosedCaseCount.Text = CaseRecord.GetClosedCaseCount().ToString();
            lblColdCaseCount.Text = CaseRecord.GetColdCaseCount().ToString();
        }

        private void lblLoggedInUserId_Click(object sender, EventArgs e)
        {

        }

        private void lblLoggedInName_Click(object sender, EventArgs e)
        {

        }

        private void lblCaseCount_Click(object sender, EventArgs e)
        {

        }

        private void lblOpenCaseCount_Click(object sender, EventArgs e)
        {

        }

        private void lblClosedCaseCount_Click(object sender, EventArgs e)
        {

        }

        private void lblColdCaseCount_Click(object sender, EventArgs e)
        {

        }

        private void btnCaseFile_Click(object sender, EventArgs e)
        {
            CaseFileForm form = new CaseFileForm(loggedInUser);
            form.Show();
        }

        private void btnCaseSearch_Click(object sender, EventArgs e)
        {
            CaseSearchForm form = new CaseSearchForm(loggedInUser);
            form.Show();
        }

        private void btnColdCases_Click(object sender, EventArgs e)
        {
            ColdCaseForm form = new ColdCaseForm(loggedInUser);
            form.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}