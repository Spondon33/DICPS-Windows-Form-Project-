using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DICPS.Common
{
    internal class DatabaseManager
    {
        private static readonly string connectionString = @"Server=WIN-POR2474TN8O\SQLEXPRESS;Database=DICPS;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection OpenConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public static void CloseConnection(SqlConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public static void HandleDatabaseException(Exception ex)
        {
            MessageBox.Show(
                "A database error occurred: " + ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
