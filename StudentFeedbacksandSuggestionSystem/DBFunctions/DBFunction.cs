using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Web.Security;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using StudentFeedbacksandSuggestionSystem.Datas;


namespace StudentFeedbacksandSuggestionSystem.DBFunction
{
    internal class DBFunction
    {
        //used for database transaction
        public static string query = "";
        public static OleDbCommand command;
        public static OleDbDataReader reader;

        public static void FetchUsers(string q, DataGridView dgv)
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

        public static bool Register(string firstname, string lastname, int age, string email, string gender, string username, string password, string role)
        {
            bool success = false;
            try
            {
                // Define the SQL query
                query = "INSERT INTO users ( firstname, lastname, age, email, gender, username, [password], role ) VALUES (@firstname, @lastname, @age, @email, @gender, @username, @password, @role)";

                Connection.Connection.DB();
                // Create a command object
                command = new OleDbCommand(query, Connection.Connection.conn);

                // Add parameters
                command.Parameters.AddWithValue("@firstname", firstname);
                command.Parameters.AddWithValue("@lastname", lastname);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", role);

                // Execute the query
                int rowsAffected = command.ExecuteNonQuery();

                // Close the connection
                Connection.Connection.conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registered Successfully.");
                    success = true;
                }
                else
                {
                    MessageBox.Show("Somethings Wrong.");
                    success = false;
                }
            }
            catch (Exception)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show("Please enter required details.");
            }
            return success;

        }

        public static UserInfo Login(string username, string password) 
        {
            UserInfo userInfo = null;
            int user_id, age;
            string firstname, lastname, email, gender, role = null;

            try
            {
                Connection.Connection.DB();
                query = "SELECT * FROM users WHERE [username] = ? AND [password] = ?";
                command = new OleDbCommand(query, Connection.Connection.conn);
                command.Parameters.AddWithValue("username", username);
                command.Parameters.AddWithValue("password", password);

                // Execute the query
               reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    //database  
                    user_id = Convert.ToInt32(reader["user_id"]);
                    firstname = reader["firstname"].ToString();
                    lastname = reader["lastname"].ToString();
                    email = reader["email"].ToString();
                    age = Convert.ToInt32(reader["age"]);
                    username = reader["username"].ToString();
                    password = reader["password"].ToString();
                    gender = reader["gender"].ToString();
                    role = reader["role"].ToString();
                    userInfo = new UserInfo(user_id, firstname, lastname, age, email, username, password, gender, role);
                    
                }
                else
                {
                    MessageBox.Show("Invalid Username and Password");
                    return userInfo;
                }
                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
            return userInfo;
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

        public static bool AddSuggestions(int user_id, string message)
        {
            bool result = false;
            try
            {
                Connection.Connection.DB();
                query = "INSERT INTO suggestions (user_id, message, date_created) VALUES (@user_id, @message, @date_created)";
                command = new OleDbCommand(query, Connection.Connection.conn);
                command.Parameters.AddWithValue("@user_id", user_id);
                command.Parameters.AddWithValue("@message", message);
                command.Parameters.AddWithValue("@date_created", DateTime.Now.ToString());
                command.ExecuteNonQuery();

                result = true;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public static List<SuggestionsInfo> GetSuggestions()
        {
            List<SuggestionsInfo> suggestionsInfo = new List<SuggestionsInfo>();
            string author, message;

            try
            {
                Connection.Connection.DB();
                query = "SELECT users.firstname, users.lastname, suggestions.message FROM users INNER JOIN suggestions ON users.user_id = suggestions.user_id";
                command = new OleDbCommand(query, Connection.Connection.conn);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        author = reader["firstname"].ToString() + " " + reader["lastname"].ToString();
                        message = reader["message"].ToString();
                        SuggestionsInfo suggestion = new SuggestionsInfo
                        {
                            Author = author,
                            Message = message
                        };
                        suggestionsInfo.Add(suggestion);
                    }
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return suggestionsInfo;
        }

    }
}
