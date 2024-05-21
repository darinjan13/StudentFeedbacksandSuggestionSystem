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

        public static void GetData(string q, DataGridView dgv)
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

        public static bool Delete(int ID)
        {
            bool success = false;
            try
            {
                query = "DELETE FROM users WHERE user_id = @ID";

                Connection.Connection.DB();
                command = new OleDbCommand(query, Connection.Connection.conn);

                command.Parameters.AddWithValue("@ID", ID);

                int rowsAffected = command.ExecuteNonQuery();

                Connection.Connection.conn.Close();

                success = rowsAffected > 0;
            }
            catch(Exception ex)
            {
                Connection.Connection.conn.Close();

            }

            return success;
        }

        public static bool Update(int ID, string firstname, string lastname, int age, string email, string gender, string username, string password, string role)
        {
            bool success = false;
            try
            {
                query = "UPDATE users SET firstname = @firstname, lastname = @lastname, age = @age, email = @email, gender = @gender, username = @username, [password] = @password, role = @role WHERE user_id = @user_id";

                Connection.Connection.DB();
                command = new OleDbCommand(query, Connection.Connection.conn);

                command.Parameters.AddWithValue("@firstname", firstname);
                command.Parameters.AddWithValue("@lastname", lastname);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", role);
                command.Parameters.AddWithValue("@user_id", ID);

                int rowsAffected = command.ExecuteNonQuery();

                Connection.Connection.conn.Close();

                    success = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter required details.");
                Connection.Connection.conn.Close();
            }
            return success;
        }

        public static bool Register(string firstname, string lastname, int age, string email, string gender, string username, string password, string role)
        {
            bool success = false;
            try
            {
                query = "INSERT INTO users ( firstname, lastname, age, email, gender, username, [password], role ) VALUES (@firstname, @lastname, @age, @email, @gender, @username, @password, @role)";

                Connection.Connection.DB();
                command = new OleDbCommand(query, Connection.Connection.conn);

                command.Parameters.AddWithValue("@firstname", firstname);
                command.Parameters.AddWithValue("@lastname", lastname);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", role);

                int rowsAffected = command.ExecuteNonQuery();

                Connection.Connection.conn.Close();

                success = rowsAffected > 0;
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

        public static bool AddSuggestions(int user_id, string title, string message)
        {
            bool result = false;
            try
            {
                Connection.Connection.DB();
                query = "INSERT INTO suggestions (user_id, title, message, date_created) VALUES (@user_id, @title, @message, @date_created)";
                command = new OleDbCommand(query, Connection.Connection.conn);
                command.Parameters.AddWithValue("@user_id", user_id);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@message", message);
                command.Parameters.AddWithValue("@date_created", DateTime.Now.ToString());
                command.ExecuteNonQuery();

                result = true;
            } catch (Exception ex)
            {
                MessageBox.Show("asdas" + ex.Message);
            }
            return result;
        }

        public static List<SuggestionsInfo> GetSuggestions()
        {
            List<SuggestionsInfo> suggestionsInfo = new List<SuggestionsInfo>();
            string author, title, message;
            int suggestion_id, votes;
            DateTime dateTime;

            try
            {
                Connection.Connection.DB();
                query = "SELECT users.firstname, users.lastname, suggestions.suggestion_id, suggestions.title, suggestions.message, suggestions.votes, suggestions.date_created FROM users INNER JOIN suggestions ON users.user_id = suggestions.user_id";
                command = new OleDbCommand(query, Connection.Connection.conn);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        suggestion_id = Convert.ToInt32(reader["suggestion_id"]);
                        title = reader["title"].ToString();
                        author = reader["firstname"].ToString() + " " + reader["lastname"].ToString();
                        message = reader["message"].ToString();
                        votes = Convert.ToInt32(reader["votes"]);
                        dateTime = Convert.ToDateTime(reader["date_created"]);
                        SuggestionsInfo suggestion = new SuggestionsInfo
                        {
                            Suggestion_ID = suggestion_id,
                            Title = title,
                            Author = author,
                            Message = message,
                            Votes = votes,
                            CreatedDate = dateTime
                        };
                        suggestionsInfo.Add(suggestion);
                    }
                }
                else
                {
                    MessageBox.Show("Error!");
                }
                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("asaasd"+ex.Message);
                Connection.Connection.conn.Close();
            }

            return suggestionsInfo;
        }

            public static bool UpdateVotes(int suggestion_id, bool upVote)
            {
                try
                {
                    Connection.Connection.DB();
                    if(upVote)
                    query = "UPDATE suggestions SET votes = votes + 1 WHERE suggestion_id = ?";
                    else
                    query = "UPDATE suggestions SET votes = votes - 1 WHERE suggestion_id = ?";
                command = new OleDbCommand(query, Connection.Connection.conn);
                    command.Parameters.AddWithValue("@suggestion_id", suggestion_id);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Update successful
                    return true;
                }
                else
                {
                    // No rows updated
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., connection error, invalid user_id, etc.)
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public static bool EditProfile(string firstname, string lastname, string username, string email, int userid)
        {
            bool result = false;
            try
            {
                Connection.Connection.DB();
                query = "UPDATE users SET firstname = ?, lastname = ?, username = ?, email = ? where user_id = ?";
                command = new OleDbCommand(query, Connection.Connection.conn);
                command.Parameters.AddWithValue("firstname", firstname);
                command.Parameters.AddWithValue("lastname", lastname);
                command.Parameters.AddWithValue("username", username);
                command.Parameters.AddWithValue("email", email);
                command.Parameters.AddWithValue("userid", userid);
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Edit Successful");
                    result = true;
                }
                else
                    result = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Connection.conn.Close();
            }

            return result;
        }

    }
}
