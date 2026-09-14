```csharp
using System;
using System.Data;
using System.Windows.Forms;
using DICPS.Common;
using DICPS.Models.Detective;

namespace DICPS.Forms.Detective
{
    public partial class PersonSearchForm : Form
    {
        private StaffUser loggedInUser;
        private int selectedPersonId = 0;
        private string selectedPersonType = "";

        public PersonSearchForm(StaffUser user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void PersonSearchForm_Load(object sender, EventArgs e)
        {
            cmbPersonType.Items.Clear();
            cmbPersonType.Items.Add("All");
            cmbPersonType.Items.Add("Suspect");
            cmbPersonType.Items.Add("Witness");
            cmbPersonType.SelectedIndex = 0;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPersonType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string personType = cmbPersonType.SelectedItem == null
                ? "All"
                : cmbPersonType.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Enter a name to search.");
                return;
            }

            if (personType == "Suspect")
            {
                dgvPersons.DataSource =
                    DICPS.Models.Detective.Person.SearchSuspects(name);
            }
            else if (personType == "Witness")
            {
                dgvPersons.DataSource =
                    DICPS.Models.Detective.Person.SearchWitnesses(name);
            }
            else
            {
                DataTable suspects =
                    DICPS.Models.Detective.Person.SearchSuspects(name);

                DataTable witnesses =
                    DICPS.Models.Detective.Person.SearchWitnesses(name);

                DataTable results = new DataTable();

                results.Columns.Add("PersonID");
                results.Columns.Add("Name");
                results.Columns.Add("ContactInfo");
                results.Columns.Add("PersonType");

                foreach (DataRow row in suspects.Rows)
                {
                    results.Rows.Add(
                        row["SuspectID"],
                        row["Name"],
                        row["ContactInfo"],
                        "Suspect");
                }

                foreach (DataRow row in witnesses.Rows)
                {
                    results.Rows.Add(
                        row["WitnessID"],
                        row["Name"],
                        row["ContactInfo"],
                        "Witness");
                }

                dgvPersons.DataSource = results;
            }

            dgvPersonHistory.DataSource = null;
            selectedPersonId = 0;
            selectedPersonType = "";
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            string personType = cmbPersonType.SelectedItem == null
                ? "All"
                : cmbPersonType.SelectedItem.ToString();

            if (personType == "Suspect")
            {
                dgvPersons.DataSource =
                    DICPS.Models.Detective.Suspect.GetAllSuspects();
            }
            else if (personType == "Witness")
            {
                dgvPersons.DataSource =
                    DICPS.Models.Detective.Witness.GetAllWitnesses();
            }
            else
            {
                DataTable suspects =
                    DICPS.Models.Detective.Suspect.GetAllSuspects();

                DataTable witnesses =
                    DICPS.Models.Detective.Witness.GetAllWitnesses();

                DataTable results = new DataTable();

                results.Columns.Add("PersonID");
                results.Columns.Add("Name");
                results.Columns.Add("ContactInfo");
                results.Columns.Add("PersonType");

                foreach (DataRow row in suspects.Rows)
                {
                    results.Rows.Add(
                        row["SuspectID"],
                        row["Name"],
                        row["ContactInfo"],
                        "Suspect");
                }

                foreach (DataRow row in witnesses.Rows)
                {
                    results.Rows.Add(
                        row["WitnessID"],
                        row["Name"],
                        row["ContactInfo"],
                        "Witness");
                }

                dgvPersons.DataSource = results;
            }

            dgvPersonHistory.DataSource = null;
            selectedPersonId = 0;
            selectedPersonType = "";
        }

        private void dgvPersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dgvPersons.Rows[e.RowIndex].Cells["PersonID"].Value == null)
            {
                return;
            }

            selectedPersonId =
                Convert.ToInt32(
                    dgvPersons.Rows[e.RowIndex].Cells["PersonID"].Value);

            selectedPersonType =
                dgvPersons.Rows[e.RowIndex].Cells["PersonType"].Value.ToString();

            LoadPersonHistory();
        }

        private void LoadPersonHistory()
        {
            if (selectedPersonId == 0)
            {
                return;
            }

            dgvPersonHistory.DataSource =
                DICPS.Models.Detective.Person.GetPersonHistory(
                    selectedPersonId,
                    selectedPersonType);
        }

        private void dgvPersonHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            cmbPersonType.SelectedIndex = 0;

            dgvPersons.DataSource = null;
            dgvPersonHistory.DataSource = null;

            selectedPersonId = 0;
            selectedPersonType = "";
        }
    }
}
```
