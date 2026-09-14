using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DICPS.Common;

namespace DICPS.Models.ChiefInvestigator
{
    public class ProfilingReport
    {
        public int ReportId { get; set; }
        public int CaseId { get; set; }
        public int SuspectId { get; set; }
        public int ReviewedByUserId { get; set; }
        public float ProfilingScore { get; set; }
        public DateTime DateGenerated { get; set; }

        public void SaveProfilingReport()
        {
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();

                string query = "INSERT INTO PROFILING_REPORT (CaseID, SuspectID, ReviewedByUserID, ProfilingScore, DateGenerated) " +
                    "VALUES (@CaseID, @SuspectID, @ReviewedByUserID, @ProfilingScore, @DateGenerated)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CaseID", CaseId);
                cmd.Parameters.AddWithValue("@SuspectID", SuspectId);
                cmd.Parameters.AddWithValue("@ReviewedByUserID", ReviewedByUserId);
                cmd.Parameters.AddWithValue("@ProfilingScore", ProfilingScore);
                cmd.Parameters.AddWithValue("@DateGenerated", DateTime.Now);

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

        public DataTable GetProfilingReportByCase(int caseId)
        {
            DataTable table = new DataTable();
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();

                string query = "SELECT pr.ReportID, s.Name AS SuspectName, pr.ProfilingScore, pr.DateGenerated " +
                    "FROM PROFILING_REPORT pr " +
                    "JOIN SUSPECT s ON pr.SuspectID = s.SuspectID " +
                    "WHERE pr.CaseID = @CaseID " +
                    "ORDER BY pr.DateGenerated DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CaseID", caseId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
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
    }
}
