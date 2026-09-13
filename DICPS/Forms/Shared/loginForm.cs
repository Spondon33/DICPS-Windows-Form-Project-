using DICPS.Common;
using DICPS.Forms.CaseRecords;
using DICPS.Forms.ChiefInvestigator;
using DICPS.Forms.Detective;
using DICPS.Forms.Evidence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DICPS.Forms.Shared
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterUserForm registerUser = new RegisterUserForm();
            registerUser.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            StaffUser currentUser = new StaffUser();
            bool loginSuccess = currentUser.Login(username, password);

            if (loginSuccess)
            {
                switch (currentUser.Role)
                {
                    case "Detective":
                        DetectiveDashboardForm detectiveDashboard = new DetectiveDashboardForm();
                        detectiveDashboard.Show();
                        break;
                    case "Case Record Officer":
                        CaseRecordsDashboardForm caseRecordsDashboard = new CaseRecordsDashboardForm();
                        caseRecordsDashboard.Show();
                        break;
                    case "Forensic Officer":
                        EvidenceDashboardForm evidenceDashboard = new EvidenceDashboardForm();
                        evidenceDashboard.Show();
                        break;
                    case "Chief Investigator":
                        ChiefInvestigatorDashboardForm chiefInvestigatorDashboard = new ChiefInvestigatorDashboardForm(currentUser);
                        chiefInvestigatorDashboard.Show();
                        break;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }  
    }
}
