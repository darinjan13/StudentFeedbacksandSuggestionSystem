using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Web.Security;


namespace StudentFeedbacksandSuggestionSystem.DBFunction
{
    internal class DBFunction
    {
        //used for database transaction
        public static string gen = "";
        public static OleDbCommand command;
        public static OleDbDataReader reader;

        public static void fill(string q, DataGridView dgv)
        {
            try 
            {
                Connection.Connection.DB();
                DataTable dt = new DataTable();
                OleDbDataAdapter data = null;
                OleDbCommand command = new OleDbCommand(q,
                Connection.Connection.conn);
                data = new OleDbDataAdapter(command);
                data.Fill(dt);
                dgv.DataSource = dt;
                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Connection.conn.Close();
            }
        }

        public static void InsertIntoUsers(string username, string password, string role)
        {
            try
            {
                // Define the SQL query
                string query = "INSERT INTO users ( username, [password], role ) VALUES (@username, @password, @role)";

                Connection.Connection.DB();
                // Create a command object
                OleDbCommand command = new OleDbCommand(query, Connection.Connection.conn);

                // Add parameters
                command.Parameters.AddWithValue("@username", role);
                command.Parameters.AddWithValue("@password", username);
                command.Parameters.AddWithValue("@role", password);

                // Execute the query
                int rowsAffected = command.ExecuteNonQuery();

                // Close the connection
                Connection.Connection.conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show(query);
                }
                else
                {
                    MessageBox.Show("No rows affected");
                }
            }
            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show($"Errors: {ex.Message}");
            }
        }

        public static bool Register(string firstname, string lastname, int age, string email, string username, string password, string role)
        {
            bool success = false;
            try
            {
                // Define the SQL query
                string query = "INSERT INTO users ( firstname, lastname, age, email, username, [password], role ) VALUES (@firstname, @lastname, @age, @email, @username, @password, @role)";

                Connection.Connection.DB();
                // Create a command object
                OleDbCommand command = new OleDbCommand(query, Connection.Connection.conn);

                // Add parameters
                command.Parameters.AddWithValue("@firstname", firstname);
                command.Parameters.AddWithValue("@lastname", lastname);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", role);

                // Execute the query
                int rowsAffected = command.ExecuteNonQuery();

                // Close the connection
                Connection.Connection.conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show(query);
                    success = true;
                }
                else
                {
                    MessageBox.Show("No rows affected");
                    success = false;
                }
            }
            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show("Please enter required details.");
            }
            return success;

        }

        public static void ModifyRecord(string updates)
        {
            try
            {
                Connection.Connection.DB();
                OleDbCommand command = new OleDbCommand(updates,
               Connection.Connection.conn);
                command.ExecuteNonQuery();
                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show("Error ---->" + updates + ex.Message);
            }
        }

    }
}
