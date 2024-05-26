using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentFeedbacksandSuggestionSystem.StudentsComponents;

namespace StudentFeedbacksandSuggestionSystem
{
    public partial class StudentDashboard : Form
    {
        UserInfo userInfo;
        FormManager formManager;
        public StudentDashboard(UserInfo userInfo, FormManager formManager)
        {
            InitializeComponent();
            loadPage(new Home(userInfo));
            this.userInfo = userInfo;
            this.formManager = formManager;
        }

        public void loadingScreen()
        {

        }

        public void loadPage(Form form)
        {
            if (mainPanel.Controls.Count > 0)
            {
                mainPanel.Controls[0].Dispose();
                mainPanel.Controls.Clear();
            }
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            form.Show();
        }

        private void SetButtonBorders(Button selectedButton)
        {
            homeButton.BorderSize = selectedButton == homeButton ? 1 : 0;
            profileButton.BorderSize = selectedButton == profileButton ? 1 : 0;
            settingsButton.BorderSize = selectedButton == settingsButton ? 1 : 0;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            SetButtonBorders(homeButton);
            loadPage(new Home(userInfo));
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            SetButtonBorders(profileButton);
            loadPage(new Profile(userInfo));
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SetButtonBorders(settingsButton);
            loadPage(new Settings(userInfo));
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            formManager.Logout();
        }

        private void StudentDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
