using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbacksandSuggestionSystem
{
    public partial class AdminDashboard : Form
    {
        public event EventHandler LogoutRequested;
        public AdminDashboard()
        {
            InitializeComponent();
            getData("users");
            //dataGridView1;
        }

        private void getData(string table)
        {
            string query = $"SELECT * FROM {table}";
            DBFunction.DBFunction.GetData(query, dataGridView1);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            string username = "s";
            string password = "s";
            string role = "s";
            //DBFunction.DBFunction.InsertIntoUsers(username, password, role);
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string firstname = firstnameTxtBox.Texts;
            string lastname = lastnameTxtBox.Texts;
            int age = Convert.ToInt32(ageTxtBox.Texts);
            string email = emailTxtBox.Texts;
            string username = usernameTxtBox.Texts;
            string password = passwordTxtBox.Texts;
            string gender = genderComboBox.Texts.ToLower();
            string role = roleComboBox.Texts.ToLower();
            DBFunction.DBFunction.Register(firstname, lastname, age, email, username, password, gender, role);
        }

        private void customTextBox5_Load(object sender, EventArgs e)
        {
            
        }
    }
}
