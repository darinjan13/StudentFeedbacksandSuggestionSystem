﻿using System;
using System.Windows.Forms;

namespace StudentFeedbacksandSuggestionSystem
{
    public partial class MainForm : Form
    {
        public bool IsLoggedIn { get; set; }
        private LoginForm _loginForm;
        private RegisterForm _registerForm;
        public event LoginRequestedEventHandler LoginRequested;

        public MainForm()
        {
            InitializeComponent();
            InitializeForms();
        }

        public delegate void LoginRequestedEventHandler(UserInfo userInfo);

        private void InitializeForms()
        {
            _loginForm = new LoginForm(this);
            _registerForm = new RegisterForm(this);

            //_loginForm.FormClosed += LoginForm_FormClosed;
            //_registerForm.FormClosed += RegisterForm_FormClosed;

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
                    LoginRequested?.Invoke(userInfo);
                    break;
                case "student":
                    LoginRequested?.Invoke(userInfo);
                    break;
                case "teacher":
                    break;
            }
        }
    }
}
