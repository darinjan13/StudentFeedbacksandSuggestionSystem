using System;
using System.Windows.Forms;

namespace StudentFeedbacksandSuggestionSystem
{
    public partial class MainForm : Form
    {
        public bool IsLoggedIn { get; set; }
        private LoginForm _loginForm;
        private RegisterForm _registerForm;
        private FormManager _formManager;

        public MainForm()
        {
            InitializeComponent();
            InitializeForms();
        }

        public delegate void LoginRequestedEventHandler(UserInfo userInfo, FormManager formManager);

        private void InitializeForms()
        {
            _loginForm = new LoginForm(this);
            _registerForm = new RegisterForm(this);
            _formManager = new FormManager(this);
            LoadLogin();
        }

        public void LoadRegister()
        {
            _loginForm.Hide();
            _registerForm.TopLevel = false;
            _registerForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(_registerForm);
            _registerForm.Show();
        }

        public void LoadLogin()
        {
            _registerForm.Hide();
            _loginForm.TopLevel = false;
            _loginForm.Dock = DockStyle.Fill;
            _loginForm.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add(_loginForm);
            _loginForm.Show();
        }

        public void AuthenticateUser(UserInfo userInfo)
        {

            switch(userInfo.Role.ToLower())
            {
                case "admin":
                    _formManager.Login(userInfo);
                    break;
                case "student":
                    _formManager.Login(userInfo);
                    break;
                case "teacher":
                    break;
            }
        }
    }
}
