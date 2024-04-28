using System;
using System.Windows.Forms;

namespace StudentFeedbacksandSuggestionSystem
{
    public partial class MainForm : Form
    {
        public bool IsLoggedIn { get; set; }
        private Login _loginForm;
        private RegisterForm _registerForm;
        public Action<String> LoginRequested;

        public MainForm()
        {
            InitializeComponent();
            InitializeForms();
        }

        private void InitializeForms()
        {
            _loginForm = new Login(this);
            _registerForm = new RegisterForm();

            _loginForm.FormClosed += LoginForm_FormClosed;
            _registerForm.FormClosed += RegisterForm_FormClosed;

            LoadLogin();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadRegister();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadLogin();
        }

        private void LoadRegister()
        {
            if (_registerForm == null || _registerForm.IsDisposed)
            {
                _registerForm = new RegisterForm();
            }
            _registerForm.TopLevel = false;
            _registerForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(_registerForm);
            _registerForm.Show();
        }

        private void LoadLogin()
        {
            if (_loginForm == null || _loginForm.IsDisposed)
            {
                _loginForm = new Login(this);
            }
            _loginForm.TopLevel = false;
            _loginForm.Dock = DockStyle.Fill;
            _loginForm.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add(_loginForm);
            _loginForm.Show();
        }

        public void AuthenticateUser(string role)
        {

            switch(role.ToLower())
            {
                case "admin":
                    LoginRequested?.Invoke("admin");
                    break;
                case "student":
                    LoginRequested?.Invoke("student");
                    break;
                case "teacher":
                    break;
            }

        }
    }
}
