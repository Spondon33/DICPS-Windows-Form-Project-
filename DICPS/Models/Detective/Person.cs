using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DICPS.Common;

namespace DICPS.Models.Detective
{
    internal class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public bool IsActive { get; set; }

        public static DataTable SearchSuspects(string search)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT SuspectID, Name, ContactInfo,
                                        PhysicalDescription, IsActive
                                 FROM SUSPECT
                                 WHERE Name LIKE @Search
                                 ORDER BY Name";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Search", "%" + search + "%");

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

        public static DataTable SearchWitnesses(string search)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT WitnessID, Name, ContactInfo,
                                        Statement, IsActive
                                 FROM WITNESS
                                 WHERE Name LIKE @Search
                                 ORDER BY Name";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Search", "%" + search + "%");

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

        public static DataTable GetPersonHistory(int personId, string personType)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query;

                if (personType == "Suspect")
                {
                    query = @"SELECT C.CaseID, C.CaseNumber, C.CaseType,
                                     C.Location, C.Status, C.Priority,
                                     C.DateOpened
                              FROM [CASE] C
                              INNER JOIN CASE_SUSPECT_LINK CSL
                                  ON C.CaseID = CSL.CaseID
                              WHERE CSL.SuspectID = @PersonID
                              ORDER BY C.DateOpened DESC";
                }
                else if (personType == "Witness")
                {
                    query = @"SELECT C.CaseID, C.CaseNumber, C.CaseType,
                                     C.Location, C.Status, C.Priority,
                                     C.DateOpened
                              FROM [CASE] C
                              INNER JOIN WITNESS_CASE_LINK WCL
                                  ON C.CaseID = WCL.CaseID
                              WHERE WCL.WitnessID = @PersonID
                              ORDER BY C.DateOpened DESC";
                }
                else
                {
                    return new DataTable();
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PersonID", personId);

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
