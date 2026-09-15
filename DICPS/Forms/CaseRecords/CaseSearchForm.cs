using System;
using System.Data;
using System.Windows.Forms;
using DICPS.Models.CaseRecords;
using DICPS.Common;

namespace DICPS.Forms.CaseRecords
{
    public partial class CaseSearchForm : Form
    {
        private StaffUser loggedInUser;

        public CaseSearchForm(StaffUser user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void CaseSearchForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("Open");
            cmbStatus.Items.Add("Closed");
            cmbStatus.Items.Add("Cold");

            cmbStatus.SelectedIndex = 0;

            LoadAllCases();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchByStatus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                MessageBox.Show(
                    "Please select a status.",
                    "Search by Status",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataTable table =
                CaseRecord.SearchCasesByStatus(cmbStatus.Text);

            dgvCases.DataSource = table;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            DateTime selectedDate =
                dateTimePicker1.Value.Date;

            DataTable table =
                CaseRecord.SearchCasesByDate(
                    selectedDate,
                    selectedDate);

            dgvCases.DataSource = table;
        }

        private void dgvCases_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllCases();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadAllCases();
        }

        private void LoadAllCases()
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

            if (dgvCases.Columns.Contains("Location"))
            {
                dgvCases.Columns["Location"].HeaderText =
                    "Location";
            }

            if (dgvCases.Columns.Contains("Status"))
            {
                dgvCases.Columns["Status"].HeaderText =
                    "Status";
            }

            if (dgvCases.Columns.Contains("Priority"))
            {
                dgvCases.Columns["Priority"].HeaderText =
                    "Priority";
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
    }
}