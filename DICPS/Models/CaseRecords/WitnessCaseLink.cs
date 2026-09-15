using System;
using System.Data;
using System.Data.SqlClient;
using DICPS.Common;

namespace DICPS.Models.CaseRecords
{
    internal class WitnessCaseLink
    {
        public static bool LinkWitnessToCase(
            int caseId,
            int witnessId,
            DateTime dateLinked)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"INSERT INTO WITNESS_CASE_LINK
                                (CaseID, WitnessID, DateLinked)
                                VALUES
                                (@CaseID, @WitnessID, @DateLinked)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@CaseID", caseId);
                cmd.Parameters.AddWithValue("@WitnessID", witnessId);
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

        public static bool UnlinkWitnessFromCase(int linkId)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"DELETE FROM WITNESS_CASE_LINK
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

        public static DataTable GetCaseWitnessList(int caseId)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT WCL.LinkID,
                                        W.WitnessID,
                                        W.Name,
                                        W.ContactInfo,
                                        W.Statement,
                                        WCL.DateLinked
                                 FROM WITNESS_CASE_LINK WCL
                                 INNER JOIN WITNESS W
                                     ON WCL.WitnessID = W.WitnessID
                                 WHERE WCL.CaseID = @CaseID
                                 ORDER BY W.Name";

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