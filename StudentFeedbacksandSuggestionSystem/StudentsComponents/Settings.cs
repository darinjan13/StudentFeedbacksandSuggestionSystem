using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbacksandSuggestionSystem.StudentsComponents
{
    public partial class Settings : Form
    {
        UserInfo userInfo;
        public Settings(UserInfo userInfo)
        {
            InitializeComponent();
            this.userInfo = userInfo;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            firstnameTxtBox.IsReadOnly = false;
            lastnameTxtBox.IsReadOnly = false;
            emailTxtBox.IsReadOnly = false;
            usernameTxt.IsReadOnly = false;
            passwordTxt.IsReadOnly = false;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            firstnameTxtBox.Texts = userInfo.Firstname;
            lastnameTxtBox.Texts = userInfo.Lastname;
            emailTxtBox.Texts = userInfo.Email;
            usernameTxt.Texts = userInfo.Username;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (DBFunction.DBFunction.EditProfile(firstnameTxtBox.Texts, lastnameTxtBox.Texts, emailTxtBox.Texts, usernameTxt.Texts, passwordTxt.Texts, userInfo.User_id))
            {
                MessageBox.Show("Edited Successfully");
                SetReadOnly();
            }
        }

        private void SetReadOnly()
        {
            firstnameTxtBox.IsReadOnly = true;
            lastnameTxtBox.IsReadOnly = true;
            emailTxtBox.IsReadOnly = true;
            usernameTxt.IsReadOnly = true;
            passwordTxt.IsReadOnly = true;

        }
    }
}
