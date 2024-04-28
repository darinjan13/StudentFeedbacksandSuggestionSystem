using System;
using System.Windows.Forms;

namespace StudentFeedbacksandSuggestionSystem
{
    public class FormManager
    {
        private readonly MainForm _mainForm;
        private readonly StudentDashboard _studentDashboard;
        private readonly AdminDashboard _adminDashboard;

        public FormManager(MainForm mainForm)
        {
            _mainForm = mainForm;
            _studentDashboard = new StudentDashboard();
            _adminDashboard = new AdminDashboard();
            WireUpEvents(); // Initialize event handlers
        }

        private void WireUpEvents()
        {
            // Attach event handlers for form navigation
            _mainForm.LoginRequested += role =>
            {
                if (role != null)
                {
                    if (role == "admin")
                    {
                        ShowAdminDashboard();
                    }
                    else if (role == "student")
                    {
                        ShowStudentDashboard();
                    }
                }
            };
            _studentDashboard.LogoutRequested += Logout;
            _adminDashboard.LogoutRequested += Logout;
            _mainForm.FormClosed += Exit;
            _studentDashboard.FormClosed += Exit;
            _adminDashboard.FormClosed += Exit;
        }

        public void Start()
        {
            Application.Run(_mainForm);
        }

        private void ShowStudentDashboard()
        {
            _mainForm.Hide();
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
            _studentDashboard.Hide();
            _adminDashboard.Hide();
        }
        private void Exit(object sender, FormClosedEventArgs e)
        {
            // Close the MainForm when the StudentDashboard is closed
            Application.Exit();
        }
    }
}
