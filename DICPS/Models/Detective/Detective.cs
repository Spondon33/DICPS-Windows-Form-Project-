using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DICPS.Common;

namespace DICPS.Models.Detective
{
    internal class Detective
    {
        public int DetectiveID { get; set; }
        public string Rank { get; set; }

        public static int GetCaseCount(int detectiveId)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = "SELECT COUNT(*) FROM [CASE] WHERE DetectiveID = @DetectiveID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DetectiveID", detectiveId);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch
            {
                return 0;
            }
            finally
            {
                DatabaseManager.CloseConnection(conn);
            }
        }

        public static int GetSuspectCount()
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = "SELECT COUNT(*) FROM SUSPECT WHERE IsActive = 1";

                SqlCommand cmd = new SqlCommand(query, conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch
            {
                return 0;
            }
            finally
            {
                DatabaseManager.CloseConnection(conn);
            }
        }

        public static int GetWitnessCount()
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = "SELECT COUNT(*) FROM WITNESS WHERE IsActive = 1";

                SqlCommand cmd = new SqlCommand(query, conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch
            {
                return 0;
            }
            finally
            {
                DatabaseManager.CloseConnection(conn);
            }
        }
    }
}