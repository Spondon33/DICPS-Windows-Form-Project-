using DICPS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DICPS.Forms.Shared
{
    public partial class RegisterUserForm : Form
    {
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public RegisterUserForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string role = "";
            if (rbDetective.Checked) role = "Detective";
            else if (rbCaseRecordOfficer.Checked) role = "Case Record Officer";
            else if (rbForensicOfficer.Checked) role = "Forensic Officer";
            else if (rbChiefInvestigator.Checked) role = "Chief Investigator";

            StaffUser newUser = new StaffUser
            {
                Role = role,
                Name = txtName.Text,
                DateOfBirth = Convert.ToDateTime(dateTimePicker1.Text),
                Username = txtUsername.Text,
                Password = txtPass.Text,
                Badgenumber = txtBadge.Text
            };

            newUser.register();

            if (rbDetective.Checked)
            {
                newUser.Rank = cmbRank.SelectedItem.ToString();
                newUser.registerDetective();
            }

            MessageBox.Show("Registration successful!");
            ClearForm();

            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void rbDetective_CheckedChanged(object sender, EventArgs e)
        {
            bool isDetective = rbDetective.Checked;
            lblRank.Visible = isDetective;
            cmbRank.Visible = isDetective;
        }

        private void rbCaseRecordOfficer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCaseRecordOfficer.Checked) HideDetectiveFields();
        }

        private void rbForensicOfficer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbForensicOfficer.Checked) HideDetectiveFields();
        }

        private void rbChiefInvestigator_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChiefInvestigator.Checked) HideDetectiveFields();
        }
        private void HideDetectiveFields()
        {
            lblRank.Visible = false;
            cmbRank.Visible = false;
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtUsername.Clear();
            txtPass.Clear();
            txtBadge.Clear();
            dateTimePicker1.Value = DateTime.Now;   

            rbDetective.Checked = false;
            rbCaseRecordOfficer.Checked = false;
            rbForensicOfficer.Checked = false;
            rbChiefInvestigator.Checked = false;

            cmbRank.SelectedIndex = -1;
            lblRank.Visible = false;
            cmbRank.Visible = false;
        }
    }
}
