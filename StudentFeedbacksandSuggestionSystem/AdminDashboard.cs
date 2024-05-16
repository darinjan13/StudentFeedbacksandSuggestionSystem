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
            LogoutRequested?.Invoke(this, EventArgs.Empty);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                IDTxt.Texts = dataGridView1[0, e.RowIndex].Value.ToString();
                firstnameTxtBox.Texts = dataGridView1[1, e.RowIndex].Value.ToString();
                lastnameTxtBox.Texts = dataGridView1[2, e.RowIndex].Value.ToString();
                ageTxtBox.Texts = dataGridView1[3, e.RowIndex].Value.ToString();
                emailTxtBox.Texts = dataGridView1[4, e.RowIndex].Value.ToString();
                usernameTxtBox.Texts = dataGridView1[5, e.RowIndex].Value.ToString();
                passwordTxtBox.Texts = dataGridView1[6, e.RowIndex].Value.ToString();
                genderComboBox.Texts = dataGridView1[7, e.RowIndex].Value.ToString();
                roleComboBox.Texts = dataGridView1[8, e.RowIndex].Value.ToString();
            }

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
    }
}
