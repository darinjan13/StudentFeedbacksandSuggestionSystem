using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace StudentFeedbacksandSuggestionSystem
{
    public partial class Login : Form
    {
        private MainForm mainForm;
        public static string sendtext = "";
        string userRole, studentName;
        public Login(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void login()
        {
            //retrieving username and password from the database
            if (string.IsNullOrWhiteSpace(txtusername.Texts) && string.IsNullOrWhiteSpace(txtpassword.Texts))
            {
                MessageBox.Show("Username and Password must not be empty!");
            } else
            {
                try
                {
                    Connection.Connection.DB();
                    DBFunction.DBFunction.gen = "SELECT role FROM users WHERE [username] = ? AND [password] = ?";
                    DBFunction.DBFunction.command = new OleDbCommand(DBFunction.DBFunction.gen, Connection.Connection.conn);
                    DBFunction.DBFunction.command.Parameters.AddWithValue("username", txtusername.Texts);
                    DBFunction.DBFunction.command.Parameters.AddWithValue("password", txtpassword.Texts);

                    // Execute the query
                    DBFunction.DBFunction.reader = DBFunction.DBFunction.command.ExecuteReader();

                    if (DBFunction.DBFunction.reader.HasRows)
                    {
                        DBFunction.DBFunction.reader.Read();
                        //database  

                        userRole = DBFunction.DBFunction.reader["role"].ToString();
                        if (userRole.Equals("student"))
                        {
                            studentName = DBFunction.DBFunction.reader["role"].ToString();
                        }
                        timer1.Enabled = true;
                        timer1.Start();
                        timer1.Interval = 1;
                        progressBar1.Maximum = 200;
                        timer1.Tick += new EventHandler(timer1_Tick);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username and Password");

                    }
                    Connection.Connection.conn.Close();
                }
                catch (Exception ex)
                {
                    Connection.Connection.conn.Close();
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 200)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                progressBar1.Value = 0;
                ClearTextBoxes();
                mainForm.AuthenticateUser(userRole);
            }
        }

        private void register_Click(object sender, EventArgs e)
        {    

            this.Hide();
        }

        private void ClearTextBoxes()
        {
            txtusername.Texts = null;
            txtpassword.Texts = null;
        }

        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
