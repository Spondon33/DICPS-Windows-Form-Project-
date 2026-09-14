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

namespace DICPS.Forms.Evidence
{
    public partial class AddEvidenceForm : Form
    {
        private StaffUser loggedInUser;

        public AddEvidenceForm(StaffUser user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void AddEvidenceForm_Load(object sender, EventArgs e)
        {
            cmbEvidenceType.Items.Add("Physical");
            cmbEvidenceType.Items.Add("Digital");
            cmbEvidenceType.SelectedIndex = 0;

            cmbEvidenceType.SelectedIndexChanged += cmbEvidenceType_SelectedIndexChanged;
            UpdateHashFieldVisibility();
        }

        private void cmbEvidenceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateHashFieldVisibility();
        }

        private void UpdateHashFieldVisibility()
        {
            bool isDigital = cmbEvidenceType.SelectedItem.ToString() == "Digital";
            lblHashValue.Visible = isDigital;
            txtHashValue.Visible = isDigital;
        }

        private void btnSaveEvidence_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text;
            DateTime dateCollected = dtpDateCollected.Value;

            string errorMessage;
            if (!Validator.ValidateEvidenceInput(description, dateCollected, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DICPS.Models.Evidence.Evidence evidence;

            if (cmbEvidenceType.SelectedItem.ToString() == "Physical")
            {
                evidence = new PhysicalEvidence();
            }
            else
            {
                evidence = new DigitalEvidence();
                evidence.HashValue = txtHashValue.Text;
            }

            evidence.EvidenceType = cmbEvidenceType.SelectedItem.ToString();
            evidence.Description = description;
            evidence.DateCollected = dateCollected;
            evidence.LoggedByUserId = loggedInUser.UserId;

            if (!string.IsNullOrWhiteSpace(txtCaseId.Text))
            {
                evidence.CaseId = Convert.ToInt32(txtCaseId.Text);
            }
            else
            {
                evidence.CaseId = null;
            }

            evidence.AddEvidence();

            MessageBox.Show("Evidence added successfully.");
            ClearForm();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEvidenceIdToVerify.Text))
            {
                MessageBox.Show("Enter an Evidence ID to verify.");
                return;
            }

            int evidenceId = Convert.ToInt32(txtEvidenceIdToVerify.Text);

            DICPS.Models.Evidence.Evidence evidence;
            if (cmbEvidenceType.SelectedItem.ToString() == "Physical")
            {
                evidence = new PhysicalEvidence();
            }
            else
            {
                evidence = new DigitalEvidence();
            }

            evidence.EvidenceId = evidenceId;
            bool isVerified = evidence.Verify();

            lblVerifyResult.Text = isVerified ? "Status: Verified" : "Status: Not Verified";
        }

        private void ClearForm()
        {
            txtCaseId.Clear();
            txtDescription.Clear();
            txtHashValue.Clear();
            dtpDateCollected.Value = DateTime.Now;
            cmbEvidenceType.SelectedIndex = 0;
        }
    }
}
