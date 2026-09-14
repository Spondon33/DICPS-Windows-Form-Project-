using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DICPS.Common;

namespace DICPS.Models.Evidence
{
    public class PhysicalEvidence : Evidence
    {
        public override bool Verify()
        {
            SqlConnection conn = null;
            try
            {
                conn = DatabaseManager.OpenConnection();
                string query = "SELECT COUNT(*) FROM CUSTODY_LOG WHERE EvidenceID = " + EvidenceId;
                SqlCommand cmd = new SqlCommand(query, conn);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
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