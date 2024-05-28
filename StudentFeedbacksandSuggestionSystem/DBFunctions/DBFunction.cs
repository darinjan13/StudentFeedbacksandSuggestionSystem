using StudentFeedbacksandSuggestionSystem.Datas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


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


                success = rowsAffected > 0;
                Connection.Connection.conn.Close();
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
                MessageBox.Show("Add Message Error: " + ex.Message);
            }
            return result;
        }

        public static void SearchSuggestion(string searchText, string searchBy, DataGridView dataGridView)
        {
            try
            {
                Connection.Connection.DB();
                query = $"SELECT * FROM suggestions WHERE {searchBy} LIKE @searchText";
                command = new OleDbCommand(query, Connection.Connection.conn);
                command.Parameters.AddWithValue("@searchText", searchText);
                DataTable dt = new DataTable();
                OleDbDataAdapter data = null;
                data = new OleDbDataAdapter(command);
                data.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Suggestion Error: " + ex.Message);
            }
            Connection.Connection.conn.Close();
        }

        public static List<SuggestionsInfo> GetUserSuggestions(int user_id)
        {
            List<SuggestionsInfo> suggestionsInfo = new List<SuggestionsInfo>();
            string author, title, message;
            int suggestion_id, votes;
            DateTime dateTime;

            try
            {
                Connection.Connection.DB();
                query = "SELECT users.firstname, users.lastname, suggestions.suggestion_id, suggestions.title, suggestions.message, suggestions.votes, suggestions.date_created FROM users INNER JOIN suggestions ON users.user_id = suggestions.user_id WHERE suggestions.user_id = ?";
                command = new OleDbCommand(query, Connection.Connection.conn);
                command.Parameters.AddWithValue("@user_id", user_id);
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
                    MessageBox.Show("Error Getting Suggestions");
                }
                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Getting Users Suggesions Error: " + ex.Message);
                Connection.Connection.conn.Close();
            }

            return suggestionsInfo;
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
                    MessageBox.Show("Error Getting Suggestions");
                }
                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Getting Suggesions Error: "+ex.Message);
                Connection.Connection.conn.Close();
            }

            return suggestionsInfo;
        }

        public static bool UpdateVotes(int user_id, int suggestion_id, bool upVote)
        {
            try
            {
                Connection.Connection.DB();

                string existingVoteQuery = "SELECT up_vote, down_vote FROM users_voted WHERE user_id = ? AND suggestion_id = ?";
                OleDbCommand existingVoteCommand = new OleDbCommand(existingVoteQuery, Connection.Connection.conn);
                existingVoteCommand.Parameters.AddWithValue("@user_id", user_id);
                existingVoteCommand.Parameters.AddWithValue("@suggestion_id", suggestion_id);

                reader = existingVoteCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        bool existingUpVote = Convert.ToBoolean(reader["up_vote"]);
                        bool existingDownVote = Convert.ToBoolean(reader["down_vote"]);

                        if ((upVote && existingUpVote) || (!upVote && existingDownVote))
                        {
                            Connection.Connection.conn.Close();
                            return true;
                        }
                    }
                    else
                    {
                    string insertVoteQuery = "INSERT INTO users_voted (user_id, suggestion_id, up_vote, down_vote) VALUES (?, ?, ?, ?)";
                    OleDbCommand insertVoteCommand = new OleDbCommand(insertVoteQuery, Connection.Connection.conn);
                    insertVoteCommand.Parameters.AddWithValue("@user_id", user_id);
                    insertVoteCommand.Parameters.AddWithValue("@suggestion_id", suggestion_id);
                    insertVoteCommand.Parameters.AddWithValue("@up_vote", upVote);
                    insertVoteCommand.Parameters.AddWithValue("@down_vote", !upVote);

                    insertVoteCommand.ExecuteNonQuery();
                    }

                query = upVote
                ? "UPDATE suggestions SET votes = votes + 1 WHERE suggestion_id = ?"
                : "UPDATE suggestions SET votes = votes - 1 WHERE suggestion_id = ?";
                OleDbCommand updateCommand = new OleDbCommand(query, Connection.Connection.conn);
                updateCommand.Parameters.AddWithValue("@suggestion_id", suggestion_id);
                int rowsAffected = updateCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {

                    string updateExistingVoteQuery = upVote
                    ? "UPDATE users_voted SET up_vote = true, down_vote = false WHERE user_id = ? AND suggestion_id = ?"
                    : "UPDATE users_voted SET up_vote = false, down_vote = true WHERE user_id = ? AND suggestion_id = ?";
                    OleDbCommand updateExistingVoteCommand = new OleDbCommand(updateExistingVoteQuery, Connection.Connection.conn);
                    updateExistingVoteCommand.Parameters.AddWithValue("@user_id", user_id);
                    updateExistingVoteCommand.Parameters.AddWithValue("@suggestion_id", suggestion_id);
                    updateExistingVoteCommand.ExecuteNonQuery();

                    Connection.Connection.conn.Close();
                    return true;
                }
                else
                {
                    Connection.Connection.conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UpdateVotes Error: " + ex.Message);
                Connection.Connection.conn.Close();
                return false;
            }
        }

        public static bool HasUserVoted(int user_id, int suggestion_id)
        {
            try
            {
                Connection.Connection.DB();
                query = "SELECT COUNT(*) FROM users_voted WHERE user_id = ? AND suggestion_id = ? AND up_vote = true";
                command = new OleDbCommand(query, Connection.Connection.conn);
                command.Parameters.AddWithValue("@user_id", user_id);
                command.Parameters.AddWithValue("@suggestion_id", suggestion_id);

                int hasVoted = Convert.ToInt32(command.ExecuteScalar());

                Connection.Connection.conn.Close();
                return hasVoted > 0;
            } catch (Exception ex)
            {
                MessageBox.Show("HasUserVoted Error: " + ex.Message);
                Connection.Connection.conn.Close();
                return false;
            }
        }

        public static bool EditProfile(string firstname, string lastname, string email, string username, string password, int userid)
        {
            bool result = false;
            try
            {
                Connection.Connection.DB();
                query = "UPDATE users SET firstname = ?, lastname = ?, email = ?, username = ?, [password] = ? where user_id = ?";
                command = new OleDbCommand(query, Connection.Connection.conn);
                command.Parameters.AddWithValue("@firstname", firstname);
                command.Parameters.AddWithValue("@lastname", lastname);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@userid", userid);
                result = command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit Profile Error: " + ex.Message);
                Connection.Connection.conn.Close();
            }

            return result;
        }

    }
}
