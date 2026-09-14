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
using DICPS.Models.Evidence;
using DICPS.Forms.Shared;

namespace DICPS.Forms.Evidence
{
    public partial class EvidenceDashboardForm : Form
    {
        private StaffUser loggedInUser;

        public EvidenceDashboardForm(StaffUser user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void EvidenceDashboardForm_Load(object sender, EventArgs e)
        {
            lblLoggedInUserID.Text = "User ID: " + loggedInUser.UserId;
            lblLoggedInName.Text = "Name: " + loggedInUser.Name;

            LoadAllEvidence();
        }

        private void LoadAllEvidence()
        {
            dgvEvidence.DataSource = DICPS.Models.Evidence.Evidence.GetAllEvidence();
        }

        private void btnAddEvidence_Click(object sender, EventArgs e)
        {
            AddEvidenceForm form = new AddEvidenceForm(loggedInUser);
            form.Show();
        }

        private void btnSearchByCase_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchCaseId.Text))
            {
                MessageBox.Show("Enter a Case ID to search.");
                return;
            }
            int caseId = Convert.ToInt32(txtSearchCaseId.Text);
            dgvEvidence.DataSource = DICPS.Models.Evidence.Evidence.SearchEvidenceByCase(caseId);
        }

        private void btnSearchByType_Click(object sender, EventArgs e)
        {
            string type = cmbSearchType.SelectedItem.ToString();
            dgvEvidence.DataSource = DICPS.Models.Evidence.Evidence.SearchEvidenceByType(type);
        }

        private void btnShowUnlinked_Click(object sender, EventArgs e)
        {
            dgvEvidence.DataSource = DICPS.Models.Evidence.Evidence.FlagMissingEvidenceLinks();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadAllEvidence();
        }

        private void btnDeleteEvidence_Click(object sender, EventArgs e)
        {
            if (dgvEvidence.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an evidence row first.");
                return;
            }

            int evidenceId = (int)dgvEvidence.SelectedRows[0].Cells["EvidenceID"].Value;

            DialogResult confirm = MessageBox.Show("Delete this evidence record?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                DICPS.Models.Evidence.Evidence evidence = new DICPS.Models.Evidence.Evidence();
                evidence.EvidenceId = evidenceId;
                evidence.DeleteEvidence();

                MessageBox.Show("Evidence deleted.");
                LoadAllEvidence();
            }
        }

        private void btnChainOfCustody_Click(object sender, EventArgs e)
        {
            if (dgvEvidence.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an evidence row first.");
                return;
            }

            int evidenceId = (int)dgvEvidence.SelectedRows[0].Cells["EvidenceID"].Value;
            ChainOfCustodyForm form = new ChainOfCustodyForm(loggedInUser, evidenceId);
            form.Show();
        }

        private void btnEvidenceReport_Click(object sender, EventArgs e)
        {
            EvidenceReportForm form = new EvidenceReportForm();
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
