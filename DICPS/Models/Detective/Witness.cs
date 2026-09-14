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
    internal class Witness : Person
    {
        public string Statement { get; set; }

        public static bool RegisterWitness(string name, string contactInfo, string statement)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"INSERT INTO WITNESS
                                 (Name, ContactInfo, Statement, IsActive)
                                 VALUES
                                 (@Name, @ContactInfo, @Statement, 1)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@ContactInfo", contactInfo);
                cmd.Parameters.AddWithValue("@Statement", statement);

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

        public static DataTable GetAllWitnesses()
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT WitnessID, Name, ContactInfo,
                                        Statement, IsActive
                                 FROM WITNESS
                                 ORDER BY Name";

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

        public static bool UpdateWitness(int witnessId, string name, string contactInfo, string statement)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"UPDATE WITNESS
                                 SET Name = @Name,
                                     ContactInfo = @ContactInfo,
                                     Statement = @Statement
                                 WHERE WitnessID = @WitnessID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@WitnessID", witnessId);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@ContactInfo", contactInfo);
                cmd.Parameters.AddWithValue("@Statement", statement);

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

        public static bool DeleteWitness(int witnessId)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"UPDATE WITNESS
                                 SET IsActive = 0
                                 WHERE WitnessID = @WitnessID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@WitnessID", witnessId);

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
    }
}