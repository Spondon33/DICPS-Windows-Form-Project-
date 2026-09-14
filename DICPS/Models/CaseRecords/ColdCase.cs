using System;
using System.Data;
using System.Data.SqlClient;
using DICPS.Common;

namespace DICPS.Models.CaseRecords
{
    internal class ColdCase
    {
        public static int CalculatePriority(
            string status,
            int currentPriority)
        {
            if (currentPriority > 0)
            {
                return currentPriority;
            }

            if (status == "Cold")
            {
                return 2;
            }

            if (status == "Reopened")
            {
                return 4;
            }

            return 2;
        }

        public static bool ReopenColdCase(
            int caseId,
            DateTime dateReopened,
            string newLeadsSummary)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string checkQuery = @"SELECT COUNT(*)
                                      FROM [CASE]
                                      WHERE CaseID = @CaseID
                                      AND Status = 'Closed'";

                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@CaseID", caseId);

                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    return false;
                }

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string updateCaseQuery = @"UPDATE [CASE]
                                               SET Status = 'Reopened'
                                               WHERE CaseID = @CaseID";

                    SqlCommand updateCmd =
                        new SqlCommand(updateCaseQuery, conn, transaction);

                    updateCmd.Parameters.AddWithValue("@CaseID", caseId);
                    updateCmd.ExecuteNonQuery();

                    string insertQuery = @"SET IDENTITY_INSERT COLD_CASE ON;

                                           INSERT INTO COLD_CASE
                                           (CaseID, DateReopened, NewLeadsSummary)
                                           VALUES
                                           (@CaseID, @DateReopened, @NewLeadsSummary);

                                           SET IDENTITY_INSERT COLD_CASE OFF;";

                    SqlCommand insertCmd =
                        new SqlCommand(insertQuery, conn, transaction);

                    insertCmd.Parameters.AddWithValue("@CaseID", caseId);
                    insertCmd.Parameters.AddWithValue("@DateReopened", dateReopened);
                    insertCmd.Parameters.AddWithValue("@NewLeadsSummary", newLeadsSummary);

                    insertCmd.ExecuteNonQuery();

                    transaction.Commit();

                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                DatabaseManager.CloseConnection(conn);
            }
        }

        public static DataTable GetColdCases()
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT C.CaseID,
                                        C.CaseNumber,
                                        C.CaseType,
                                        C.Location,
                                        C.Status,
                                        C.Priority,
                                        C.DateOpened,
                                        CC.DateReopened,
                                        CC.NewLeadsSummary
                                 FROM [CASE] C
                                 INNER JOIN COLD_CASE CC
                                     ON C.CaseID = CC.CaseID
                                 WHERE C.Status IN ('Cold', 'Reopened')
                                 ORDER BY C.DateOpened DESC";

                SqlCommand cmd = new SqlCommand(query, conn);

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