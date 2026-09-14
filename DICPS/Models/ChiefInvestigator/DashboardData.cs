using DICPS.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICPS.Models.ChiefInvestigator
{
    internal class DashboardData
    {
        public int TotalCases { get; set; }
        public int OpenCases { get; set; }
        public int ColdCases { get; set; }
        public int ClosedCases { get; set; }
        public int TotalSuspects { get; set; }
        public int TotalWitnesses { get; set; }
        public int PendingEvidence { get; set; }
        public int UnlinkedEvidence { get; set; }
        public int TotalProfilingReports { get; set; }

        public void LoadStatistics()
        {
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();

                TotalCases = RunCount(conn, "SELECT COUNT(*) FROM [CASE]");
                OpenCases = RunCount(conn, "SELECT COUNT(*) FROM [CASE] WHERE Status IN ('Open', 'Under Investigation')");
                ColdCases = RunCount(conn, "SELECT COUNT(*) FROM COLD_CASE");
                ClosedCases = RunCount(conn, "SELECT COUNT(*) FROM [CASE] WHERE Status = 'Closed'");
                TotalSuspects = RunCount(conn, "SELECT COUNT(*) FROM SUSPECT WHERE IsActive = 1");
                TotalWitnesses = RunCount(conn, "SELECT COUNT(*) FROM WITNESS WHERE IsActive = 1");
                PendingEvidence = RunCount(conn, "SELECT COUNT(*) FROM EVIDENCE WHERE HashValue IS NULL");
                UnlinkedEvidence = RunCount(conn, "SELECT COUNT(*) FROM EVIDENCE WHERE CaseID IS NULL");
                TotalProfilingReports = RunCount(conn, "SELECT COUNT(*) FROM PROFILING_REPORT");
            }
            catch (Exception ex)
            {
                DatabaseManager.HandleDatabaseException(ex);
            }
            finally
            {
                DatabaseManager.CloseConnection(conn);
            }
        }

        private int RunCount(SqlConnection conn, string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            return (int)cmd.ExecuteScalar();
        }

        public DataTable GetAllCases()
        {
            DataTable table = new DataTable();
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();

                string query = "SELECT c.CaseID, c.CaseNumber, c.Status, c.Priority, " +
                    "s.Name AS AssignedDetective, c.DateOpened " +
                    "FROM [CASE] c " +
                    "LEFT JOIN DETECTIVE d ON c.DetectiveID = d.DetectiveID " +
                    "LEFT JOIN STAFF_USER s ON d.DetectiveID = s.UserID " +
                    "ORDER BY c.DateOpened DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                DatabaseManager.HandleDatabaseException(ex);
            }
            finally
            {
                DatabaseManager.CloseConnection(conn);
            }
            return table;
        }

        public void ReassignDetective(int caseId, int newDetectiveId)
        {
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();
                string query = "UPDATE [CASE] SET DetectiveID = @DetectiveID WHERE CaseID = @CaseID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DetectiveID", newDetectiveId);
                cmd.Parameters.AddWithValue("@CaseID", caseId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                DatabaseManager.HandleDatabaseException(ex);
            }
            finally
            {
                DatabaseManager.CloseConnection(conn);
            }
        }
    }
}
