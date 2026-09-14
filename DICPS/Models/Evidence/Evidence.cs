using DICPS.Common;
using System;
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
    }
}
