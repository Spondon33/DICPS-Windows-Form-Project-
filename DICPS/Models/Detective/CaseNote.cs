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
    internal class CaseNote
    {
        public int NoteID { get; set; }
        public int CaseID { get; set; }
        public int DetectiveID { get; set; }
        public string NoteText { get; set; }
        public DateTime DateAdded { get; set; }

        public static DataTable GetCaseNotes(int caseId)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"SELECT NoteID, CaseID, DetectiveID,
                                        NoteText, DateAdded
                                 FROM CASE_NOTE
                                 WHERE CaseID = @CaseID
                                 ORDER BY DateAdded DESC";

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

        public static bool AddCaseNote(int caseId, int detectiveId, string noteText)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = @"INSERT INTO CASE_NOTE
                                 (CaseID, DetectiveID, NoteText, DateAdded)
                                 VALUES
                                 (@CaseID, @DetectiveID, @NoteText, @DateAdded)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@CaseID", caseId);
                cmd.Parameters.AddWithValue("@DetectiveID", detectiveId);
                cmd.Parameters.AddWithValue("@NoteText", noteText);
                cmd.Parameters.AddWithValue("@DateAdded", DateTime.Now.Date);

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

        public static bool DeleteCaseNote(int noteId)
        {
            SqlConnection conn = DatabaseManager.OpenConnection();

            try
            {
                string query = "DELETE FROM CASE_NOTE WHERE NoteID = @NoteID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NoteID", noteId);

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