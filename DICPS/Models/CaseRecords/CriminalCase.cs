using System;
using System.Data;
using System.Data.SqlClient;
using DICPS.Common;

namespace DICPS.Models.CaseRecords
{
    internal class CriminalCase
    {
        public static int CalculatePriority(
            string status,
            int currentPriority)
        {
            if (currentPriority > 0)
            {
                return currentPriority;
            }

            if (status == "Open")
            {
                return 5;
            }

            if (status == "Under Investigation")
            {
                return 4;
            }

            if (status == "Reopened")
            {
                return 5;
            }

            return 3;
        }

        public static DataTable GetCriminalCases()
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
                                 WHERE CaseType = 'Criminal'
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
    }
}