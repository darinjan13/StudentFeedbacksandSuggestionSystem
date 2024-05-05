using System;
using System.Windows.Forms;

namespace StudentFeedbacksandSuggestionSystem
{
    public class FormManager
    {
        private readonly MainForm _mainForm;
        private StudentDashboard _studentDashboard;
        private readonly AdminDashboard _adminDashboard;
        private UserInfo userInfo;

        public FormManager(MainForm mainForm)
        {
            _mainForm = mainForm;
            _adminDashboard = new AdminDashboard();
            WireUpEvents(); // Initialize event handlers
        }

        private void WireUpEvents()
        {
            // Attach event handlers for form navigation
            _mainForm.LoginRequested += userInfo =>
            {
                if (userInfo.Role != null)
                {
                    if (userInfo.Role == "admin")
                    {
                        ShowAdminDashboard();
                    }
                    else if (userInfo.Role == "student")
                    {
                        this.userInfo = userInfo;
                        ShowStudentDashboard();
                    }
                }
            };
            if (_studentDashboard != null)
            {
                _studentDashboard.LogoutRequested += Logout;
                _studentDashboard.FormClosed += Exit;
            }
                _adminDashboard.LogoutRequested += Logout;
                _adminDashboard.FormClosed += Exit;

            _mainForm.FormClosed += Exit;
        }

        public void Start()
        {
            Application.Run(_mainForm);
        }

        private void ShowStudentDashboard()
        {
            _mainForm.Hide();

            // Create a new StudentDashboard instance and attach event handlers
            _studentDashboard = new StudentDashboard(userInfo);
            _studentDashboard.LogoutRequested += Logout;
            _studentDashboard.FormClosed += Exit;

            _studentDashboard.Show();
        }

        private void ShowAdminDashboard()
        {
            _mainForm.Hide();
            _adminDashboard.Show();
        }

        private void Logout(object sender, EventArgs e)
        {
            // Reset login status
            _mainForm.IsLoggedIn = false;

            // Show the MainForm again
            _mainForm.Show();

            // Close the dashboard form
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
