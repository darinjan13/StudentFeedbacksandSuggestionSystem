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

namespace TESTING
{
    public partial class Login : Form
    {
        public static string sendtext = "";
        public Login()
        {
            InitializeComponent();
        }

        private void login()
        {
            //retrieving username and password from the database
            if (string.IsNullOrWhiteSpace(txtusername.Text) && string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show("Username and Password must not be empty!");
            } else
            {
                try
                {
                    Connection.Connection.DB();
                    DBFunction.DBFunction.gen = "Select * from users where [username] = '" + txtusername.Text + "' and [password] = '" + txtpassword.Text + "'";
                    DBFunction.DBFunction.command = new OleDbCommand(DBFunction.DBFunction.gen, Connection.Connection.conn);
                    DBFunction.DBFunction.reader = DBFunction.DBFunction.command.ExecuteReader();

                    if (DBFunction.DBFunction.reader.HasRows)
                    {
                        DBFunction.DBFunction.reader.Read();
                        //database  
                        txtusername.Text = (DBFunction.DBFunction.reader["username"].ToString());
                        txtpassword.Text = (DBFunction.DBFunction.reader["password"].ToString());
                        // open a next form  
                        //  Stocks s = new Stocks ();
                        //  s.Show();
                        //   this.Visible =false;//cosing the form
                        //   sale.Show();l

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
                this.Hide();

                progressBar1.Value = 0;
                sendtext = txtusername.Text;
                Stock s = new Stock(sendtext);
                s.ShowDialog();
            }
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
