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

        public static DataTable GetMyCases(int detectiveId)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT CaseID, CaseNumber, CaseType,
                                        Location, Status, Priority,
                                        DateOpened
                                 FROM [CASE]
                                 WHERE DetectiveID = @DetectiveID
                                 ORDER BY DateOpened DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DetectiveID", detectiveId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
            catch
            {
                return new DataTable();
            }
            finally
            {
                DatabaseManager.CloseConnection(conn);
            }
        }

        public static DataTable SearchMyCases(int detectiveId, string caseNumber, string status)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT CaseID, CaseNumber, CaseType,
                                        Location, Status, Priority,
                                        DateOpened
                                 FROM [CASE]
                                 WHERE DetectiveID = @DetectiveID
                                   AND CaseNumber LIKE @CaseNumber
                                   AND (@Status = 'All' OR Status = @Status)
                                 ORDER BY DateOpened DESC";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@DetectiveID", detectiveId);
                cmd.Parameters.AddWithValue("@CaseNumber", "%" + caseNumber + "%");
                cmd.Parameters.AddWithValue("@Status", status);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
            catch
            {
                return new DataTable();
            }
            finally
            {
                DatabaseManager.CloseConnection(conn);
            }
        }

        public static DataTable GetCaseSuspects(int caseId)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT S.SuspectID, S.Name,
                                        S.ContactInfo,
                                        S.PhysicalDescription,
                                        S.IsActive
                                 FROM SUSPECT S
                                 INNER JOIN CASE_SUSPECT_LINK CSL
                                     ON S.SuspectID = CSL.SuspectID
                                 WHERE CSL.CaseID = @CaseID
                                 ORDER BY S.Name";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CaseID", caseId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
            catch
            {
                return new DataTable();
            }
            finally
            {
                DatabaseManager.CloseConnection(conn);
            }
        }
    }
}