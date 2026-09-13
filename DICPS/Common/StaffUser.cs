using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DICPS.Common
{
    internal class StaffUser
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Badgenumber { get; set; }
        public int DetectiveId { get; set; }
        public string Rank { get; set; }

        public void register()
        {
            SqlConnection conn = new SqlConnection(@"Server=WIN-POR2474TN8O\SQLEXPRESS;Database=DICPS;Trusted_Connection=True;TrustServerCertificate=True;");
            conn.Open();
            string query = "Insert into STAFF_USER (Name, DateOfBirth, Username, Password, Role, BadgeNumber) " +
                "values ('" + Name + "', '" + DateOfBirth.ToString("yyyy-MM-dd") + "', '" + Username + "', '" + Password + "', '" + Role + "', '" + Badgenumber + "'); " +
                "SELECT CAST(SCOPE_IDENTITY() AS int);";
            SqlCommand cmd = new SqlCommand(query, conn);

            UserId = (int)cmd.ExecuteScalar();
            conn.Close();
        }

        public void registerDetective()
        {
            SqlConnection conn = new SqlConnection(@"Server=WIN-POR2474TN8O\SQLEXPRESS;Database=DICPS;Trusted_Connection=True;TrustServerCertificate=True;");
            conn.Open();
            string query = "Insert into DETECTIVE (DetectiveID, Rank) " +
                "values ('" + UserId + "', '" + Rank + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
