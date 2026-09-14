using System;
using System.Windows.Forms;
using DICPS.Common;
using DICPS.Models.Detective;
using DICPS.Forms.Shared;

namespace DICPS.Forms.Detective
{
    public partial class DetectiveDashboardForm : Form
    {
        private StaffUser loggedInUser;

        public DetectiveDashboardForm(StaffUser user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void DetectiveDashboardForm_Load(object sender, EventArgs e)
        {
            lblLoggedInUserId.Text = "User ID: " + loggedInUser.UserId;
            lblLoggedInName.Text = "Name: " + loggedInUser.Name;

            LoadStatistics();
        }

        private void LoadStatistics()
        {
            lblCaseCount.Text = DICPS.Models.Detective.Detective.GetCaseCount(loggedInUser.UserId).ToString();
            lblSuspectCount.Text = DICPS.Models.Detective.Detective.GetSuspectCount().ToString();
            lblWitnessCount.Text = DICPS.Models.Detective.Detective.GetWitnessCount().ToString();
        }

        private void btnCaseLoad_Click(object sender, EventArgs e)
        {
            CaseLoadForm form = new CaseLoadForm(loggedInUser);
            form.Show();
        }

        private void btnPersonSearch_Click(object sender, EventArgs e)
        {
            PersonSearchForm form = new PersonSearchForm(loggedInUser);
            form.Show();
        }

        private void btnRegisterPerson_Click(object sender, EventArgs e)
        {
            RegisterPersonForm form = new RegisterPersonForm(loggedInUser);
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