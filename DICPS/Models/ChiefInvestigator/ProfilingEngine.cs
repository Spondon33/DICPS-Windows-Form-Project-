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
    public class ProfilingEngine
    {
        public float GenerateProfilingScore(int suspectId, int caseId)
        {
            SqlConnection conn = null;
            float score = 0;
            try
            {
                conn = DatabaseManager.OpenConnection();

                string query = "SELECT COUNT(*) FROM CASE_SUSPECT_LINK WHERE SuspectID = @SuspectID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SuspectID", suspectId);

                int pastCaseCount = (int)cmd.ExecuteScalar();

                score = Math.Min(100, 20 + (pastCaseCount * 15));
            }
            catch (Exception ex)
            {
                DatabaseManager.HandleDatabaseException(ex);
            }
            finally
            {
                DatabaseManager.CloseConnection(conn);
            }
            return score;
        }

        public DataTable CompareSuspectToPastCases(int suspectId)
        {
            DataTable table = new DataTable();
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();

                string query = "SELECT c.CaseID, c.CaseNumber, c.CaseType, csl.DateLinked " +
                    "FROM CASE_SUSPECT_LINK csl " +
                    "JOIN [CASE] c ON csl.CaseID = c.CaseID " +
                    "WHERE csl.SuspectID = @SuspectID " +
                    "ORDER BY csl.DateLinked DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SuspectID", suspectId);

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

        public DataTable GetTopMatchingSuspects(int caseId)
        {
            DataTable table = new DataTable();
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();

                string query = "SELECT pr.SuspectID, s.Name, pr.ProfilingScore " +
                    "FROM PROFILING_REPORT pr " +
                    "JOIN SUSPECT s ON pr.SuspectID = s.SuspectID " +
                    "WHERE pr.CaseID = @CaseID " +
                    "ORDER BY pr.ProfilingScore DESC";

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

        public DataTable GetAllSuspects()
        {
            DataTable table = new DataTable();
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();
                string query = "SELECT SuspectID, Name FROM SUSPECT WHERE IsActive = 1";
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

        public DataTable GetAllCases()
        {
            DataTable table = new DataTable();
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();
                string query = "SELECT CaseID, CaseNumber FROM [CASE]";
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
    }
}