using System;
using System.Data;
using System.Data.SqlClient;
using DICPS.Common;

namespace DICPS.Models.CaseRecords
{
    internal class CaseRecord
    {
        public static bool CreateCaseFile(
            int detectiveId,
            int createdByUserId,
            string caseNumber,
            string caseType,
            string location,
            string status,
            int priority,
            DateTime dateOpened)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"INSERT INTO [CASE]
                                (DetectiveID, CreatedByUserID, CaseNumber,
                                 CaseType, Location, Status,
                                 Priority, DateOpened)
                                VALUES
                                (@DetectiveID, @CreatedByUserID, @CaseNumber,
                                 @CaseType, @Location, @Status,
                                 @Priority, @DateOpened)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@DetectiveID", detectiveId);
                cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserId);
                cmd.Parameters.AddWithValue("@CaseNumber", caseNumber);
                cmd.Parameters.AddWithValue("@CaseType", caseType);
                cmd.Parameters.AddWithValue("@Location", location);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Priority", priority);
                cmd.Parameters.AddWithValue("@DateOpened", dateOpened);

                cmd.ExecuteNonQuery();

                return true;
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

        public static bool UpdateCaseStatus(int caseId, string status)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"UPDATE [CASE]
                                 SET Status = @Status
                                 WHERE CaseID = @CaseID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@CaseID", caseId);
                cmd.Parameters.AddWithValue("@Status", status);

                cmd.ExecuteNonQuery();

                return true;
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

        public static bool CloseCase(int caseId)
        {
            return UpdateCaseStatus(caseId, "Closed");
        }

        public static int CalculatePriority(
            string caseType,
            string status,
            int currentPriority)
        {
            if (currentPriority > 0)
            {
                return currentPriority;
            }

            if (caseType == "Criminal")
            {
                return 5;
            }

            if (status == "Cold")
            {
                return 2;
            }

            return 3;
        }

        public static int GetCaseCount()
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT COUNT(*)
                                 FROM [CASE]";

                SqlCommand cmd = new SqlCommand(query, conn);

                return (int)cmd.ExecuteScalar();
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

        public static int GetOpenCaseCount()
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT COUNT(*)
                                 FROM [CASE]
                                 WHERE Status = 'Open'";

                SqlCommand cmd = new SqlCommand(query, conn);

                return (int)cmd.ExecuteScalar();
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

        public static int GetClosedCaseCount()
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT COUNT(*)
                                 FROM [CASE]
                                 WHERE Status = 'Closed'";

                SqlCommand cmd = new SqlCommand(query, conn);

                return (int)cmd.ExecuteScalar();
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

        public static int GetColdCaseCount()
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT COUNT(*)
                                 FROM COLD_CASE";

                SqlCommand cmd = new SqlCommand(query, conn);

                return (int)cmd.ExecuteScalar();
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

        public static string GenerateCaseSummary(int caseId)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT CaseID, CaseNumber,
                                        CaseType, Location,
                                        Status, Priority,
                                        DateOpened, DetectiveID,
                                        CreatedByUserID
                                 FROM [CASE]
                                 WHERE CaseID = @CaseID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CaseID", caseId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return "Case ID: " + reader["CaseID"] +
                           "\r\nCase Number: " + reader["CaseNumber"] +
                           "\r\nCase Type: " + reader["CaseType"] +
                           "\r\nLocation: " + reader["Location"] +
                           "\r\nStatus: " + reader["Status"] +
                           "\r\nPriority: " + reader["Priority"] +
                           "\r\nDate Opened: " + reader["DateOpened"] +
                           "\r\nDetective ID: " + reader["DetectiveID"] +
                           "\r\nCreated By User ID: " + reader["CreatedByUserID"];
                }

                return "";
            }
            catch
            {
                return "";
            }
            finally
            {
                DatabaseManager.CloseConnection(conn);
            }
        }

        public static DataTable SearchCasesByStatus(string status)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT CaseID, CaseNumber,
                                        CaseType, Location,
                                        Status, Priority,
                                        DateOpened, DetectiveID,
                                        CreatedByUserID
                                 FROM [CASE]
                                 WHERE Status = @Status
                                 ORDER BY DateOpened DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
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

        public static DataTable SearchCasesByDate(
            DateTime startDate,
            DateTime endDate)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT CaseID, CaseNumber,
                                        CaseType, Location,
                                        Status, Priority,
                                        DateOpened, DetectiveID,
                                        CreatedByUserID
                                 FROM [CASE]
                                 WHERE DateOpened BETWEEN @StartDate AND @EndDate
                                 ORDER BY DateOpened DESC";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@StartDate", startDate.Date);
                cmd.Parameters.AddWithValue("@EndDate", endDate.Date);

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

        public static DataTable GetAllCases()
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT CaseID, CaseNumber,
                                        CaseType, Location,
                                        Status, Priority,
                                        DateOpened, DetectiveID,
                                        CreatedByUserID
                                 FROM [CASE]
                                 ORDER BY DateOpened DESC";

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

        public static bool DeleteCase(int caseId)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string checkQuery = @"SELECT COUNT(*)
                                      FROM EVIDENCE
                                      WHERE CaseID = @CaseID";

                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@CaseID", caseId);

                int evidenceCount = (int)checkCmd.ExecuteScalar();

                if (evidenceCount > 0)
                {
                    return false;
                }

                string suspectLinkQuery = @"DELETE FROM CASE_SUSPECT_LINK
                                            WHERE CaseID = @CaseID";

                SqlCommand suspectLinkCmd =
                    new SqlCommand(suspectLinkQuery, conn);

                suspectLinkCmd.Parameters.AddWithValue("@CaseID", caseId);
                suspectLinkCmd.ExecuteNonQuery();

                string witnessLinkQuery = @"DELETE FROM WITNESS_CASE_LINK
                                            WHERE CaseID = @CaseID";

                SqlCommand witnessLinkCmd =
                    new SqlCommand(witnessLinkQuery, conn);

                witnessLinkCmd.Parameters.AddWithValue("@CaseID", caseId);
                witnessLinkCmd.ExecuteNonQuery();

                string noteQuery = @"DELETE FROM CASE_NOTE
                                     WHERE CaseID = @CaseID";

                SqlCommand noteCmd = new SqlCommand(noteQuery, conn);
                noteCmd.Parameters.AddWithValue("@CaseID", caseId);
                noteCmd.ExecuteNonQuery();

                string caseQuery = @"DELETE FROM [CASE]
                                     WHERE CaseID = @CaseID";

                SqlCommand caseCmd = new SqlCommand(caseQuery, conn);
                caseCmd.Parameters.AddWithValue("@CaseID", caseId);

                caseCmd.ExecuteNonQuery();

                return true;
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

        public static string ExportCaseReport(int caseId)
        {
            return GenerateCaseSummary(caseId);
        }
    }
}