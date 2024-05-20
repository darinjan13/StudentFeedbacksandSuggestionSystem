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
    public partial class LoginForm : Form
    {
        private MainForm mainForm;
        UserInfo userInfo;
        public LoginForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void Login()
        {
            string username;
            string password;
            //retrieving username and password from the database
            if (string.IsNullOrWhiteSpace(txtusername.Texts) && string.IsNullOrWhiteSpace(txtpassword.Texts))
            {
                MessageBox.Show("Username and Password must not be empty!");
            } else
            {
                username = txtusername.Texts;
                password = txtpassword.Texts;
                userInfo = DBFunction.DBFunction.Login(username, password);
                if (userInfo != null)
                {
                    timer1.Enabled = true;
                    timer1.Start();
                    timer1.Interval = 1;
                    progressBar1.Maximum = 200;
                    timer1.Tick += new EventHandler(timer1_Tick);
                }
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 200)
            {
                button1.Enabled = false;
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                progressBar1.Value = 0;
                ClearTextBoxes();
                mainForm.AuthenticateUser(userInfo);
            }
                button1.Enabled = true;
        }

        private void register_Click(object sender, EventArgs e)
        {
            mainForm.LoadRegister();
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
                Login();
            }
        }
    }
}
