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

        public int register()
        {
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();
                string query = "Insert into STAFF_USER (Name, DateOfBirth, Username, Password, Role, BadgeNumber) " +
                "values ('" + Name + "', '" + DateOfBirth.ToString("yyyy-MM-dd") + "', '" + Username + "', '" + Password + "', '" + Role + "', '" + Badgenumber + "'); " +
                "SELECT CAST(SCOPE_IDENTITY() AS int);";
                SqlCommand cmd = new SqlCommand(query, conn);
                UserId = (int)cmd.ExecuteScalar();
                return UserId;
            }
            catch (Exception ex)
            {
                DatabaseManager.HandleDatabaseException(ex);
                return -1;
            }
            finally
            {
                DatabaseManager.CloseConnection(conn);
            }
        }

        public void registerDetective()
        {
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();
                string query = "Insert into DETECTIVE (DetectiveID, Rank) " +
                "values ('" + UserId + "', '" + Rank + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                DatabaseManager.HandleDatabaseException(ex);
            }
            finally
            {
                DatabaseManager.CloseConnection(conn);
            }
        }

        public bool Login(string enteredUsername, string enteredPassword)
        {
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();
                string query = "SELECT UserID, Name, Role, BadgeNumber FROM STAFF_USER " +
                    "WHERE Username = '" + enteredUsername + "' AND Password = '" + enteredPassword + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    UserId = (int)reader["UserID"];
                    Name = reader["Name"].ToString();
                    Role = reader["Role"].ToString();
                    Badgenumber = reader["BadgeNumber"].ToString();
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                DatabaseManager.HandleDatabaseException(ex);
                return false;
            }
            finally
            {
                DatabaseManager.CloseConnection(conn);
            }
        }
    }
}
