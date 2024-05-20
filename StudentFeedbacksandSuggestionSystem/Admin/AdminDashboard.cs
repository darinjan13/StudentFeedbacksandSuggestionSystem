using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbacksandSuggestionSystem.Admin
{
    public partial class AdminDashboard : Form
    {
        private FormManager formManager;
        private AdminUsers adminUsers;
        private AdminSuggestions adminSuggestions;
        public AdminDashboard(FormManager formManager)
        {
            InitializeComponent();
            InitializeForms();
            this.formManager = formManager;
        }

        private void InitializeForms()
        {
            adminUsers = new AdminUsers();
            adminSuggestions = new AdminSuggestions();
            LoadUsers();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            formManager.Logout();
        }

        

        public void LoadUsers()
        {
            adminSuggestions.Hide();
            adminUsers.TopLevel = false;
            adminUsers.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(adminUsers);
            adminUsers.Show();
        }

        public void LoadSuggesionts()
        {
            adminUsers.Hide();
            adminSuggestions.TopLevel = false;
            adminSuggestions.Dock = DockStyle.Fill;
            adminSuggestions.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add(adminSuggestions);
            adminSuggestions.Show();
        }
        private void usersPanel_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void suggestionsPanel_Click(object sender, EventArgs e)
        {
            LoadSuggesionts();
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
