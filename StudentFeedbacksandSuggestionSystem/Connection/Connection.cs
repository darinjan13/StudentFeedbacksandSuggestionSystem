using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace StudentFeedbacksandSuggestionSystem.Connection
{
    internal class Connection
    {
        public static OleDbConnection conn;
        private static string dbconnect = "Provider=Microsoft.ACE.OleDb.12.0; Data Source=" + Application.StartupPath + "\\StudentFeedbackAndSuggestionsDB.accdb";

        public static void DB()
        {
            try
            {
                conn = new OleDbConnection(dbconnect);
                conn.Open();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
