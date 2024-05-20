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
            fullnameLabel.Text = userInfo.Firstname + " " + userInfo.Lastname;
        }
    }
}
