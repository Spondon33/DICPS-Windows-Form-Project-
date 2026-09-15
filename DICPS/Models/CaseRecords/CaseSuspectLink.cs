using System;
using System.Data;
using System.Data.SqlClient;
using DICPS.Common;

namespace DICPS.Models.CaseRecords
{
    internal class CaseSuspectLink
    {
        public static bool LinkSuspectToCase(
            int caseId,
            int suspectId,
            DateTime dateLinked)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"INSERT INTO CASE_SUSPECT_LINK
                                (CaseID, SuspectID, DateLinked)
                                VALUES
                                (@CaseID, @SuspectID, @DateLinked)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@CaseID", caseId);
                cmd.Parameters.AddWithValue("@SuspectID", suspectId);
                cmd.Parameters.AddWithValue("@DateLinked", dateLinked);

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

        public static bool UnlinkSuspectFromCase(int linkId)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"DELETE FROM CASE_SUSPECT_LINK
                                 WHERE LinkID = @LinkID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LinkID", linkId);

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

        public static DataTable GetCaseSuspectList(int caseId)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT CSL.LinkID,
                                        S.SuspectID,
                                        S.Name,
                                        S.ContactInfo,
                                        S.PhysicalDescription,
                                        CSL.DateLinked
                                 FROM CASE_SUSPECT_LINK CSL
                                 INNER JOIN SUSPECT S
                                     ON CSL.SuspectID = S.SuspectID
                                 WHERE CSL.CaseID = @CaseID
                                 ORDER BY S.Name";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CaseID", caseId);

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