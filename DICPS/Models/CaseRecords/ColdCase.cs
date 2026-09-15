using System;
using System.Data;
using System.Data.SqlClient;
using DICPS.Common;

namespace DICPS.Models.CaseRecords
{
    internal class ColdCase
    {
        public static bool ReopenColdCase(
            int caseId,
            DateTime dateReopened,
            string newLeadsSummary)
        {
            SqlConnection conn =
                DatabaseManager.OpenConnection();

            SqlTransaction transaction = null;

            try
            {
                string checkQuery = @"SELECT Status
                                      FROM [CASE]
                                      WHERE CaseID = @CaseID";

                SqlCommand checkCmd =
                    new SqlCommand(checkQuery, conn);

                checkCmd.Parameters.AddWithValue(
                    "@CaseID",
                    caseId);

                object result =
                    checkCmd.ExecuteScalar();

                if (result == null)
                {
                    return false;
                }

                string status =
                    result.ToString();

                if (status != "Closed")
                {
                    return false;
                }

                transaction =
                    conn.BeginTransaction();

                string updateCaseQuery = @"UPDATE [CASE]
                                           SET Status = 'Cold',
                                               Priority = 2
                                           WHERE CaseID = @CaseID";

                SqlCommand updateCaseCmd =
                    new SqlCommand(
                        updateCaseQuery,
                        conn,
                        transaction);

                updateCaseCmd.Parameters.AddWithValue(
                    "@CaseID",
                    caseId);

                updateCaseCmd.ExecuteNonQuery();

                string identityInsertOnQuery =
                    "SET IDENTITY_INSERT COLD_CASE ON";

                SqlCommand identityInsertOnCmd =
                    new SqlCommand(
                        identityInsertOnQuery,
                        conn,
                        transaction);

                identityInsertOnCmd.ExecuteNonQuery();

                string insertQuery = @"INSERT INTO COLD_CASE
                                       (
                                           CaseID,
                                           DateReopened,
                                           NewLeadsSummary
                                       )
                                       VALUES
                                       (
                                           @CaseID,
                                           @DateReopened,
                                           @NewLeadsSummary
                                       )";

                SqlCommand insertCmd =
                    new SqlCommand(
                        insertQuery,
                        conn,
                        transaction);

                insertCmd.Parameters.AddWithValue(
                    "@CaseID",
                    caseId);

                insertCmd.Parameters.AddWithValue(
                    "@DateReopened",
                    dateReopened);

                insertCmd.Parameters.AddWithValue(
                    "@NewLeadsSummary",
                    newLeadsSummary);

                insertCmd.ExecuteNonQuery();

                string identityInsertOffQuery =
                    "SET IDENTITY_INSERT COLD_CASE OFF";

                SqlCommand identityInsertOffCmd =
                    new SqlCommand(
                        identityInsertOffQuery,
                        conn,
                        transaction);

                identityInsertOffCmd.ExecuteNonQuery();

                transaction.Commit();

                return true;
            }
            catch
            {
                try
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                }
                catch
                {
                }

                return false;
            }
            finally
            {
                DatabaseManager.CloseConnection(conn);
            }
        }

        public static DataTable GetColdCases()
        {
            SqlConnection conn =
                DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT
                                    CaseID,
                                    DateReopened,
                                    NewLeadsSummary
                                 FROM COLD_CASE
                                 ORDER BY DateReopened DESC";

                SqlCommand cmd =
                    new SqlCommand(
                        query,
                        conn);

                SqlDataAdapter adapter =
                    new SqlDataAdapter(cmd);

                DataTable table =
                    new DataTable();

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