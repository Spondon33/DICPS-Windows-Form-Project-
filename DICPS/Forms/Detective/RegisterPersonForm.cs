using System;
using System.Data;
using System.Windows.Forms;
using DICPS.Common;
using DICPS.Models.Detective;

namespace DICPS.Forms.Detective
{
    public partial class RegisterPersonForm : Form
    {
        private StaffUser loggedInUser;
        private int selectedPersonId = -1;

        public RegisterPersonForm(StaffUser user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void RegisterPersonForm_Load(object sender, EventArgs e)
        {
            cmbPersonType.Items.Clear();
            cmbPersonType.Items.Add("Suspect");
            cmbPersonType.Items.Add("Witness");

            cmbPersonType.SelectedIndex = 0;
        }

        private void cmbPersonType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPersonId = -1;

            if (cmbPersonType.SelectedItem == null)
                return;

            if (cmbPersonType.SelectedItem.ToString() == "Suspect")
            {
                lblPhysicalDescription.Text = "Physical Description";
                LoadSuspects();
            }
            else
            {
                lblPhysicalDescription.Text = "Statement";
                LoadWitnesses();
            }

            ClearFields();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhysicalDescription_Click(object sender, EventArgs e)
        {

        }

        private void txtPhysicalDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadSuspects()
        {
            dgvPersons.DataSource = Suspect.GetAllSuspects();
            selectedPersonId = -1;
        }

        private void LoadWitnesses()
        {
            dgvPersons.DataSource = Witness.GetAllWitnesses();
            selectedPersonId = -1;
        }

        private void dgvPersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvPersons.Rows[e.RowIndex];

            selectedPersonId = Convert.ToInt32(
                row.Cells[0].Value
            );

            txtName.Text = row.Cells["Name"].Value?.ToString() ?? "";
            txtContactInfo.Text = row.Cells["ContactInfo"].Value?.ToString() ?? "";

            if (cmbPersonType.SelectedItem.ToString() == "Suspect")
            {
                txtPhysicalDescription.Text =
                    row.Cells["PhysicalDescription"].Value?.ToString() ?? "";
            }
            else
            {
                txtPhysicalDescription.Text =
                    row.Cells["Statement"].Value?.ToString() ?? "";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            bool success;

            if (cmbPersonType.SelectedItem.ToString() == "Suspect")
            {
                success = Suspect.RegisterSuspect(
                    txtName.Text.Trim(),
                    txtContactInfo.Text.Trim(),
                    txtPhysicalDescription.Text.Trim()
                );
            }
            else
            {
                success = Witness.RegisterWitness(
                    txtName.Text.Trim(),
                    txtContactInfo.Text.Trim(),
                    txtPhysicalDescription.Text.Trim()
                );
            }

            if (success)
            {
                MessageBox.Show(
                    "Person registered successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                RefreshPersons();
                ClearFields();
            }
            else
            {
                MessageBox.Show(
                    "Failed to register person.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPersonId == -1)
            {
                MessageBox.Show(
                    "Please select a person to update.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!ValidateInput())
                return;

            bool success;

            if (cmbPersonType.SelectedItem.ToString() == "Suspect")
            {
                success = Suspect.UpdateSuspect(
                    selectedPersonId,
                    txtName.Text.Trim(),
                    txtContactInfo.Text.Trim(),
                    txtPhysicalDescription.Text.Trim()
                );
            }
            else
            {
                success = Witness.UpdateWitness(
                    selectedPersonId,
                    txtName.Text.Trim(),
                    txtContactInfo.Text.Trim(),
                    txtPhysicalDescription.Text.Trim()
                );
            }

            if (success)
            {
                MessageBox.Show(
                    "Person updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                RefreshPersons();
                ClearFields();
            }
            else
            {
                MessageBox.Show(
                    "Failed to update person.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPersonId == -1)
            {
                MessageBox.Show(
                    "Please select a person to delete.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this person?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            bool success;

            if (cmbPersonType.SelectedItem.ToString() == "Suspect")
            {
                success = Suspect.DeleteSuspect(selectedPersonId);
            }
            else
            {
                success = Witness.DeleteWitness(selectedPersonId);
            }

            if (success)
            {
                MessageBox.Show(
                    "Person deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                RefreshPersons();
                ClearFields();
            }
            else
            {
                MessageBox.Show(
                    "Failed to delete person.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedPersonId = -1;

            txtName.Clear();
            txtContactInfo.Clear();
            txtPhysicalDescription.Clear();

            dgvPersons.ClearSelection();
        }

        private void RefreshPersons()
        {
            if (cmbPersonType.SelectedItem == null)
                return;

            if (cmbPersonType.SelectedItem.ToString() == "Suspect")
            {
                LoadSuspects();
            }
            else
            {
                LoadWitnesses();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show(
                    "Please enter the person's name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContactInfo.Text))
            {
                MessageBox.Show(
                    "Please enter the contact information.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtContactInfo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhysicalDescription.Text))
            {
                MessageBox.Show(
                    "Please enter the required information.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPhysicalDescription.Focus();
                return false;
            }

            return true;
        }
    }
}