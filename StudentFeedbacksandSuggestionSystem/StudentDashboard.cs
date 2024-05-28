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
            timer1.Interval = 1000;
            LoadPage(new Home(userInfo));
            this.userInfo = userInfo;
            this.formManager = formManager;
            usersName.Text = userInfo.Firstname + " " + userInfo.Lastname;
        }

        public void LoadPage(Form form)
        {
            LoadingScreen loadingScreen = new LoadingScreen();

            if (mainPanel.Controls.Count > 0)
            {
                mainPanel.Controls[0].Dispose();
                mainPanel.Controls.Clear();
            }
            loadingScreen.TopLevel = false;
            loadingScreen.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(loadingScreen);
            loadingScreen.Show();

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) =>
            {
                loadingScreen.Hide();

                form.TopLevel = false;
                form.Dock = DockStyle.Fill;

                mainPanel.Controls.Add(form);
                form.Show();

                timer.Stop();
            };

            timer.Start();
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
            LoadPage(new Home(userInfo));
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            SetButtonBorders(profileButton);
            LoadPage(new Profile(userInfo));
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SetButtonBorders(settingsButton);
            LoadPage(new Settings(userInfo));
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
