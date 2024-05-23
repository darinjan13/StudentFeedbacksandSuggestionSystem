using StudentFeedbacksandSuggestionSystem.Admin;
using System;
using System.Windows.Forms;

namespace StudentFeedbacksandSuggestionSystem
{
    public class FormManager
    {
        private MainForm _mainForm;
        private StudentDashboard _studentDashboard;
        private readonly AdminDashboard _adminDashboard;
        private UserInfo userInfo;

        public FormManager(MainForm mainForm)
        {
            _mainForm = mainForm;
            _adminDashboard = new AdminDashboard(this);
        }

        public void Start()
        {
            Application.Run(_mainForm);
        }

        public void ShowStudentDashboard()
        {
            _mainForm.Hide();

            _studentDashboard = new StudentDashboard(userInfo, this);
            _studentDashboard.FormClosed += Exit;

            _studentDashboard.Show();
        }

        public void ShowAdminDashboard()
        {
            _mainForm.Hide();
            _adminDashboard.Show();
        }

        public void Login(UserInfo userInfo)
        {
            this.userInfo = userInfo;
            if (userInfo.Role.Equals("admin"))
                ShowAdminDashboard();
            else
                ShowStudentDashboard();
        }

        public void Logout()
        {
            _mainForm.IsLoggedIn = false;

            _mainForm = new MainForm();
            _mainForm.Show();

            if (_studentDashboard != null)
            {
            _studentDashboard.Hide();

            }
            _adminDashboard.Hide();
        }
        private void Exit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
