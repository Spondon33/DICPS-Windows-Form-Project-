using DICPS.Common;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICPS.Models.Evidence
{
    public class Evidence
    {
        public int EvidenceId { get; set; }
        public int? CaseId { get; set; }
        public int LoggedByUserId { get; set; }
        public string EvidenceType { get; set; }
        public string Description { get; set; }
        public DateTime DateCollected { get; set; }
        public string HashValue { get; set; }

        public int AddEvidence()
        {
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();

                string caseIdValue = CaseId.HasValue ? CaseId.ToString() : "NULL";
                string hashValueSql = string.IsNullOrEmpty(HashValue) ? "NULL" : "'" + HashValue + "'";

                string query = "INSERT INTO EVIDENCE (CaseID, LoggedByUserID, EvidenceType, Description, DateCollected, HashValue) " +
                    "VALUES (" + caseIdValue + ", " + LoggedByUserId + ", '" + EvidenceType + "', '" + Description + "', '" +
                    DateCollected.ToString("yyyy-MM-dd") + "', " + hashValueSql + "); " +
                    "SELECT CAST(SCOPE_IDENTITY() AS int);";

                SqlCommand cmd = new SqlCommand(query, conn);
                EvidenceId = (int)cmd.ExecuteScalar();
                return EvidenceId;
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

        public void UpdateEvidenceRecord()
        {
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();

                string hashValueSql = string.IsNullOrEmpty(HashValue) ? "NULL" : "'" + HashValue + "'";

                string query = "UPDATE EVIDENCE SET Description = '" + Description + "', DateCollected = '" +
                    DateCollected.ToString("yyyy-MM-dd") + "', HashValue = " + hashValueSql +
                    " WHERE EvidenceID = " + EvidenceId;

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

        public void DeleteEvidence()
        {
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();
                string query = "DELETE FROM EVIDENCE WHERE EvidenceID = " + EvidenceId;
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

        public virtual bool Verify()
        {
            return false;
        }

        public static DataTable SearchEvidenceByCase(int caseId)
        {
            DataTable table = new DataTable();
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();
                string query = "SELECT EvidenceID, EvidenceType, Description, DateCollected, HashValue " +
                    "FROM EVIDENCE WHERE CaseID = " + caseId;
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

        public static DataTable SearchEvidenceByType(string type)
        {
            DataTable table = new DataTable();
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();
                string query = "SELECT EvidenceID, CaseID, Description, DateCollected, HashValue " +
                    "FROM EVIDENCE WHERE EvidenceType = '" + type + "'";
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

        public static DataTable GetAllEvidence()
        {
            DataTable table = new DataTable();
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();
                string query = "SELECT EvidenceID, CaseID, EvidenceType, Description, DateCollected, HashValue FROM EVIDENCE";
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

        public static DataTable FlagMissingEvidenceLinks()
        {
            DataTable table = new DataTable();
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();
                string query = "SELECT EvidenceID, EvidenceType, Description, DateCollected FROM EVIDENCE WHERE CaseID IS NULL";
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
