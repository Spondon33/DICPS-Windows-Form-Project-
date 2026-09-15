using System;
using System.Data;
using System.Windows.Forms;
using DICPS.Models.CaseRecords;
using DICPS.Common;

namespace DICPS.Forms.CaseRecords
{
    public partial class ColdCaseForm : Form
    {
        private StaffUser loggedInUser;

        public ColdCaseForm(StaffUser user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void ColdCaseForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value =
                DateTime.Now.Date;

            LoadColdCases();
        }

        private void txtCaseId_TextChanged(
            object sender,
            EventArgs e)
        {

        }

        private void txtNewLeadsSummary_TextChanged(
            object sender,
            EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(
            object sender,
            EventArgs e)
        {

        }

        private void btnReopenCase_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCaseId.Text))
            {
                MessageBox.Show(
                    "Please enter a Case ID.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!int.TryParse(
                txtCaseId.Text.Trim(),
                out int caseId))
            {
                MessageBox.Show(
                    "Case ID must be a valid number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(
                txtNewLeadsSummary.Text))
            {
                MessageBox.Show(
                    "Please enter the new leads summary.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DateTime dateReopened =
                dateTimePicker1.Value.Date;

            bool success =
                ColdCase.ReopenColdCase(
                    caseId,
                    dateReopened,
                    txtNewLeadsSummary.Text.Trim());

            if (success)
            {
                MessageBox.Show(
                    "Case reopened as a Cold Case successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadColdCases();
                ClearFields();
            }
            else
            {
                MessageBox.Show(
                    "The case could not be reopened. " +
                    "Make sure the Case ID exists and the case is currently Closed.",
                    "Reopen Cold Case",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();
        }

        private void dgvColdCases_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvColdCases.Rows[e.RowIndex];

            if (row.Cells["CaseID"].Value == null)
            {
                return;
            }

            txtCaseId.Text =
                row.Cells["CaseID"].Value.ToString();

            if (row.Cells["NewLeadsSummary"].Value != null)
            {
                txtNewLeadsSummary.Text =
                    row.Cells["NewLeadsSummary"].Value.ToString();
            }

            if (row.Cells["DateReopened"].Value != null)
            {
                dateTimePicker1.Value =
                    Convert.ToDateTime(
                        row.Cells["DateReopened"].Value);
            }
        }

        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            LoadColdCases();
            ClearFields();
        }

        private void LoadColdCases()
        {
            DataTable table =
                ColdCase.GetColdCases();

            dgvColdCases.DataSource = table;

            if (dgvColdCases.Columns.Contains("CaseID"))
            {
                dgvColdCases.Columns["CaseID"].HeaderText =
                    "Case ID";
            }

            if (dgvColdCases.Columns.Contains("DateReopened"))
            {
                dgvColdCases.Columns["DateReopened"].HeaderText =
                    "Date Reopened";
            }

            if (dgvColdCases.Columns.Contains("NewLeadsSummary"))
            {
                dgvColdCases.Columns["NewLeadsSummary"].HeaderText =
                    "New Leads Summary";
            }
        }

        private void ClearFields()
        {
            txtCaseId.Clear();
            txtNewLeadsSummary.Clear();

            dateTimePicker1.Value =
                DateTime.Now.Date;

            dgvColdCases.ClearSelection();
        }
    }
}