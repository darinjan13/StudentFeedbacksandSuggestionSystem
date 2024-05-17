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
    public partial class Profile : Form
    {
        UserInfo userInfo;
        public Profile(UserInfo userInfo)
        {
            InitializeComponent();
            this.userInfo = userInfo;
            firstname.Texts = userInfo.Firstname;
            lastname.Texts = userInfo.Lastname;
            username.Texts = userInfo.Username;
            email.Texts = userInfo.Email;
        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            firstname.Enabled = true;
            lastname.Enabled = true;
            username.Enabled = true;
            email.Enabled = true;
        }

        private void saveEdit_Click(object sender, EventArgs e)
        {
            DBFunction.DBFunction.EditProfile(firstname.Texts, lastname.Texts, username.Texts, email.Texts, userInfo.User_id);
            disableTextBox();
        }

        private void disableTextBox()
        {
            firstname.Enabled = false;
            lastname.Enabled = false;
            username.Enabled = false;
            email.Enabled = false;
        }
    }
}
