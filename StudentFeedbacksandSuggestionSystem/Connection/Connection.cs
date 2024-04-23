using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace TESTING.Connection
{
    internal class Connection
    {
        public static OleDbConnection conn;
        private static string dbconnect = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Customer.accdb";

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
