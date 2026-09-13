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

namespace DICPS
{
    public partial class RegisterUserForm : Form
    {
        string role, name, username, password, badge;
        DateTime dob;
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
            if (rbDetective.Checked)
            {
                role = "Detective";
            }
            else if (rbCaseRecordOfficer.Checked)
            {
                role = "Case Record Officer";
            }
            else if (rbForensicOfficer.Checked)
            {
                role = "Forensic Officer";
            }
            else if (rbChiefInvestigator.Checked)
            {
                role = "Chief Investigator";
            }

            name = txtName.Text;
            dob = Convert.ToDateTime(dateTimePicker1.Text);
            username = txtUsername.Text;
            password = txtPass.Text;
            badge = txtBadge.Text;

            SqlConnection conn = new SqlConnection(@"Server=WIN-POR2474TN8O\SQLEXPRESS;Database=DICPS;Trusted_Connection=True;TrustServerCertificate=True;");
            conn.Open();
            string query = "Insert into StaffInfo (Role, Name, DOB, Username, Password, Badge) values ('" + role + "', '" + name + "', '" + dob.ToString("yyyy-MM-dd") + "', '" + username + "', '" + password + "', '" + badge + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
