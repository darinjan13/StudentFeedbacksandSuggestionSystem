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
            DBFunction.DBFunction.FetchUsers(query, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "s";
            string password = "s";
            string role = "s";
            //DBFunction.DBFunction.InsertIntoUsers(username, password, role);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LogoutRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
