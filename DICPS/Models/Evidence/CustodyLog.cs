using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DICPS.Common;

namespace DICPS.Models.Evidence
{
    public class CustodyLog
    {
        public int LogId { get; set; }
        public int EvidenceId { get; set; }
        public int HandledByUserId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Notes { get; set; }

        public void LogChainOfCustody()
        {
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();

                string query = "INSERT INTO CUSTODY_LOG (EvidenceID, HandledByUserID, TimeStamp, Notes) " +
                    "VALUES (" + EvidenceId + ", " + HandledByUserId + ", '" +
                    Timestamp.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + Notes + "')";

                SqlCommand cmd = new SqlCommand(query, conn);
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

        public static DataTable GetCustodyLogByEvidence(int evidenceId)
        {
            DataTable table = new DataTable();
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();

                string query = "SELECT cl.LogID, s.Name AS HandledBy, cl.TimeStamp, cl.Notes " +
                    "FROM CUSTODY_LOG cl " +
                    "JOIN STAFF_USER s ON cl.HandledByUserID = s.UserID " +
                    "WHERE cl.EvidenceID = " + evidenceId + " " +
                    "ORDER BY cl.TimeStamp ASC";

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