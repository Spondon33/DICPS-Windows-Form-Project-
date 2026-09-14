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
    internal class Suspect : Person
    {
        public string PhysicalDescription { get; set; }

        public static bool RegisterSuspect(string name, string contactInfo, string physicalDescription)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"INSERT INTO SUSPECT
                                 (Name, ContactInfo, PhysicalDescription, IsActive)
                                 VALUES
                                 (@Name, @ContactInfo, @PhysicalDescription, 1)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@ContactInfo", contactInfo);
                cmd.Parameters.AddWithValue("@PhysicalDescription", physicalDescription);

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

        public static DataTable GetAllSuspects()
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT SuspectID, Name, ContactInfo,
                                        PhysicalDescription, IsActive
                                 FROM SUSPECT
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

        public static bool UpdateSuspect(int suspectId, string name, string contactInfo, string physicalDescription)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"UPDATE SUSPECT
                                 SET Name = @Name,
                                     ContactInfo = @ContactInfo,
                                     PhysicalDescription = @PhysicalDescription
                                 WHERE SuspectID = @SuspectID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@SuspectID", suspectId);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@ContactInfo", contactInfo);
                cmd.Parameters.AddWithValue("@PhysicalDescription", physicalDescription);

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

        public static bool DeleteSuspect(int suspectId)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"UPDATE SUSPECT
                                 SET IsActive = 0
                                 WHERE SuspectID = @SuspectID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SuspectID", suspectId);

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