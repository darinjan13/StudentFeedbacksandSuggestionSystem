﻿using System;
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
        public Profile(UserInfo userInfo)
        {
            InitializeComponent();
            fullName.Text = userInfo.Firstname + " " + userInfo.Lastname;
        }
    }
}
