using System;
using System.Data;
using System.Windows.Forms;
using DICPS.Common;
using DICPS.Models.CaseRecords;
using Microsoft.VisualBasic;

namespace DICPS.Forms.CaseRecords
{
    public partial class CaseFileForm : Form
    {
        private StaffUser loggedInUser;
        private int selectedCaseId = -1;
        private int selectedSuspectLinkId = -1;

        public CaseFileForm(StaffUser user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void CaseFileForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Open");
            cmbStatus.Items.Add("Closed");

            cmbStatus.SelectedIndex = 0;

            LoadCases();
        }

        private void txtCaseNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCaseType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDetectiveId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCaseNumber.Text) ||
                string.IsNullOrWhiteSpace(txtCaseType.Text) ||
                string.IsNullOrWhiteSpace(txtLocation.Text) ||
                string.IsNullOrWhiteSpace(cmbStatus.Text) ||
                string.IsNullOrWhiteSpace(txtDetectiveId.Text))
            {
                MessageBox.Show(
                    "Please fill in all case information.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int detectiveId;

            if (!int.TryParse(
                txtDetectiveId.Text.Trim(),
                out detectiveId))
            {
                MessageBox.Show(
                    "Detective ID must be a valid number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int priority =
                CaseRecord.CalculatePriority(
                    cmbStatus.Text);

            bool success = CaseRecord.CreateCaseFile(
                detectiveId,
                loggedInUser.UserId,
                txtCaseNumber.Text.Trim(),
                txtCaseType.Text.Trim(),
                txtLocation.Text.Trim(),
                cmbStatus.Text,
                priority,
                DateTime.Now.Date);

            if (success)
            {
                MessageBox.Show(
                    "Case created successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadCases();
                ClearFields();
            }
            else
            {
                MessageBox.Show(
                    "Failed to create the case.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCaseId == -1)
            {
                MessageBox.Show(
                    "Please select a case first.",
                    "Delete Case",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this case?",
                "Delete Case",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            bool success =
                CaseRecord.DeleteCase(selectedCaseId);

            if (success)
            {
                MessageBox.Show(
                    "Case deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadCases();
                ClearFields();
            }
            else
            {
                MessageBox.Show(
                    "The case cannot be deleted because it has evidence or linked records.",
                    "Delete Case",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCaseId == -1)
            {
                MessageBox.Show(
                    "Please select a case first.",
                    "Update Case",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtCaseNumber.Text) ||
                string.IsNullOrWhiteSpace(txtCaseType.Text) ||
                string.IsNullOrWhiteSpace(txtLocation.Text) ||
                string.IsNullOrWhiteSpace(cmbStatus.Text) ||
                string.IsNullOrWhiteSpace(txtDetectiveId.Text))
            {
                MessageBox.Show(
                    "Please fill in all case information.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int detectiveId;

            if (!int.TryParse(
                txtDetectiveId.Text.Trim(),
                out detectiveId))
            {
                MessageBox.Show(
                    "Detective ID must be a valid number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int priority =
                CaseRecord.CalculatePriority(
                    cmbStatus.Text);

            bool success = CaseRecord.UpdateCaseFile(
                selectedCaseId,
                detectiveId,
                txtCaseNumber.Text.Trim(),
                txtCaseType.Text.Trim(),
                txtLocation.Text.Trim(),
                cmbStatus.Text,
                priority);

            if (success)
            {
                MessageBox.Show(
                    "Case updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadCases();
                LoadSelectedCaseData();
            }
            else
            {
                MessageBox.Show(
                    "Failed to update the case.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadCases();
            ClearFields();
        }

        private void dgvCases_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvCases.Rows[e.RowIndex];

            if (row.Cells["CaseID"].Value == null)
            {
                return;
            }

            selectedCaseId =
                Convert.ToInt32(row.Cells["CaseID"].Value);

            txtCaseNumber.Text =
                row.Cells["CaseNumber"].Value.ToString();

            txtCaseType.Text =
                row.Cells["CaseType"].Value.ToString();

            txtLocation.Text =
                row.Cells["Location"].Value.ToString();

            cmbStatus.Text =
                row.Cells["Status"].Value.ToString();

            txtDetectiveId.Text =
                row.Cells["DetectiveID"].Value.ToString();

            LoadSelectedCaseData();
        }

        private void dgvSuspects_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvSuspects.Rows[e.RowIndex];

            if (row.Cells["LinkID"].Value != null)
            {
                selectedSuspectLinkId =
                    Convert.ToInt32(
                        row.Cells["LinkID"].Value);
            }
        }

        private void btnLinkSuspect_Click(object sender, EventArgs e)
        {
            if (selectedCaseId == -1)
            {
                MessageBox.Show(
                    "Please select a case first.",
                    "Link Suspect",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string input = Interaction.InputBox(
                "Enter the Suspect ID:",
                "Link Suspect",
                "");

            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            int suspectId;

            if (!int.TryParse(input, out suspectId))
            {
                MessageBox.Show(
                    "Please enter a valid Suspect ID.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            bool success =
                CaseSuspectLink.LinkSuspectToCase(
                    selectedCaseId,
                    suspectId,
                    DateTime.Now.Date);

            if (success)
            {
                MessageBox.Show(
                    "Suspect linked successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadSuspects();
            }
            else
            {
                MessageBox.Show(
                    "Failed to link the suspect.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUnlinkSuspect_Click(object sender, EventArgs e)
        {
            if (selectedSuspectLinkId == -1)
            {
                MessageBox.Show(
                    "Please select a linked suspect first.",
                    "Unlink Suspect",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to unlink this suspect?",
                "Unlink Suspect",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            bool success =
                CaseSuspectLink.UnlinkSuspectFromCase(
                    selectedSuspectLinkId);

            if (success)
            {
                MessageBox.Show(
                    "Suspect unlinked successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                selectedSuspectLinkId = -1;
                LoadSuspects();
            }
            else
            {
                MessageBox.Show(
                    "Failed to unlink the suspect.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtCaseSummary_TextChanged(
            object sender,
            EventArgs e)
        {

        }

        private void btnGenerateSummary_Click(
            object sender,
            EventArgs e)
        {
            if (selectedCaseId == -1)
            {
                MessageBox.Show(
                    "Please select a case first.",
                    "Generate Summary",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            txtCaseSummary.Text =
                CaseRecord.GenerateCaseSummary(
                    selectedCaseId);
        }

        private void btnExportReport_Click(
            object sender,
            EventArgs e)
        {
            if (selectedCaseId == -1)
            {
                MessageBox.Show(
                    "Please select a case first.",
                    "Export Report",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string report =
                CaseRecord.ExportCaseReport(
                    selectedCaseId);

            if (string.IsNullOrWhiteSpace(report))
            {
                MessageBox.Show(
                    "Unable to generate the case report.",
                    "Export Report",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            SaveFileDialog saveDialog =
                new SaveFileDialog();

            saveDialog.Filter =
                "Text Files (*.txt)|*.txt";

            saveDialog.Title =
                "Export Case Report";

            saveDialog.FileName =
                "Case_Report_" + selectedCaseId + ".txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(
                        saveDialog.FileName,
                        report);

                    MessageBox.Show(
                        "Case report exported successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show(
                        "Failed to export the case report.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void LoadCases()
        {
            DataTable table =
                CaseRecord.GetAllCases();

            dgvCases.DataSource = table;

            if (dgvCases.Columns.Contains("CaseID"))
            {
                dgvCases.Columns["CaseID"].HeaderText =
                    "Case ID";
            }

            if (dgvCases.Columns.Contains("CaseNumber"))
            {
                dgvCases.Columns["CaseNumber"].HeaderText =
                    "Case Number";
            }

            if (dgvCases.Columns.Contains("CaseType"))
            {
                dgvCases.Columns["CaseType"].HeaderText =
                    "Case Type";
            }

            if (dgvCases.Columns.Contains("DateOpened"))
            {
                dgvCases.Columns["DateOpened"].HeaderText =
                    "Date Opened";
            }

            if (dgvCases.Columns.Contains("DetectiveID"))
            {
                dgvCases.Columns["DetectiveID"].HeaderText =
                    "Detective ID";
            }

            if (dgvCases.Columns.Contains("CreatedByUserID"))
            {
                dgvCases.Columns["CreatedByUserID"].HeaderText =
                    "Created By User ID";
            }
        }

        private void LoadSelectedCaseData()
        {
            if (selectedCaseId == -1)
            {
                return;
            }

            LoadSuspects();

            txtCaseSummary.Text =
                CaseRecord.GenerateCaseSummary(
                    selectedCaseId);
        }

        private void LoadSuspects()
        {
            if (selectedCaseId == -1)
            {
                dgvSuspects.DataSource = null;
                return;
            }

            DataTable table =
                CaseSuspectLink.GetCaseSuspectList(
                    selectedCaseId);

            dgvSuspects.DataSource = table;

            if (dgvSuspects.Columns.Contains("LinkID"))
            {
                dgvSuspects.Columns["LinkID"].HeaderText =
                    "Link ID";
            }

            if (dgvSuspects.Columns.Contains("SuspectID"))
            {
                dgvSuspects.Columns["SuspectID"].HeaderText =
                    "Suspect ID";
            }

            if (dgvSuspects.Columns.Contains("DateLinked"))
            {
                dgvSuspects.Columns["DateLinked"].HeaderText =
                    "Date Linked";
            }

            selectedSuspectLinkId = -1;
        }

        private void ClearFields()
        {
            selectedCaseId = -1;
            selectedSuspectLinkId = -1;

            txtCaseNumber.Clear();
            txtCaseType.Clear();
            txtLocation.Clear();
            txtDetectiveId.Clear();
            txtCaseSummary.Clear();

            cmbStatus.SelectedIndex = 0;

            dgvSuspects.DataSource = null;

            dgvCases.ClearSelection();
        }
    }
}