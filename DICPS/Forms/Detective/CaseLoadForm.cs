using System;
using System.Data;
using System.Windows.Forms;
using DICPS.Common;
using DICPS.Models.Detective;

namespace DICPS.Forms.Detective
{
    public partial class CaseLoadForm : Form
    {
        private StaffUser loggedInUser;
        private int selectedCaseId = 0;

        public CaseLoadForm(StaffUser user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void CaseLoadForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("All");
            cmbStatus.Items.Add("Open");
            cmbStatus.Items.Add("Closed");
            cmbStatus.Items.Add("Cold");
            cmbStatus.SelectedIndex = 0;

            LoadMyCases();
        }

        private void LoadMyCases()
        {
            dgvCases.DataSource =
                DICPS.Models.Detective.Detective.GetMyCases(loggedInUser.UserId);

            ClearSelectedCase();
        }

        private void txtSearchCase_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string caseNumber = txtSearchCase.Text.Trim();
            string status = cmbStatus.SelectedItem == null
                ? "All"
                : cmbStatus.SelectedItem.ToString();

            dgvCases.DataSource =
                DICPS.Models.Detective.Detective.SearchMyCases(
                    loggedInUser.UserId,
                    caseNumber,
                    status);

            ClearSelectedCase();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearchCase.Clear();
            cmbStatus.SelectedIndex = 0;

            LoadMyCases();
        }

        private void dgvCases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dgvCases.Rows[e.RowIndex].Cells["CaseID"].Value == null)
            {
                return;
            }

            selectedCaseId =
                Convert.ToInt32(dgvCases.Rows[e.RowIndex].Cells["CaseID"].Value);

            LoadCaseSuspects();
            LoadCaseNotes();
        }

        private void LoadCaseSuspects()
        {
            dgvSuspects.DataSource =
                DICPS.Models.Detective.Detective.GetCaseSuspects(selectedCaseId);
        }

        private void LoadCaseNotes()
        {
            dgvCaseNotes.DataSource =
                DICPS.Models.Detective.CaseNote.GetCaseNotes(selectedCaseId);
        }

        private void dgvSuspects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCaseNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNewNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if (selectedCaseId == 0)
            {
                MessageBox.Show("Please select a case first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNewNote.Text))
            {
                MessageBox.Show("Enter a case note.");
                return;
            }

            bool result = DICPS.Models.Detective.CaseNote.AddCaseNote(
                selectedCaseId,
                loggedInUser.UserId,
                txtNewNote.Text.Trim());

            if (result)
            {
                MessageBox.Show("Case note added.");

                txtNewNote.Clear();
                LoadCaseNotes();
            }
            else
            {
                MessageBox.Show("Failed to add case note.");
            }
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            if (selectedCaseId == 0)
            {
                MessageBox.Show("Please select a case first.");
                return;
            }

            if (dgvCaseNotes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a case note first.");
                return;
            }

            int noteId =
                Convert.ToInt32(
                    dgvCaseNotes.SelectedRows[0].Cells["NoteID"].Value);

            DialogResult confirm = MessageBox.Show(
                "Delete this case note?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                bool result =
                    DICPS.Models.Detective.CaseNote.DeleteCaseNote(noteId);

                if (result)
                {
                    MessageBox.Show("Case note deleted.");
                    LoadCaseNotes();
                }
                else
                {
                    MessageBox.Show("Failed to delete case note.");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchCase.Clear();
            cmbStatus.SelectedIndex = 0;

            LoadMyCases();
        }

        private void ClearSelectedCase()
        {
            selectedCaseId = 0;

            dgvSuspects.DataSource = null;
            dgvCaseNotes.DataSource = null;

            txtNewNote.Clear();
        }
    }
}
