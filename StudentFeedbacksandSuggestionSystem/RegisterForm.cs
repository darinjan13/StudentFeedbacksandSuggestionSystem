using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbacksandSuggestionSystem
{
    public partial class RegisterForm : Form
    {
        MainForm mainForm;
        public RegisterForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void register_Click(object sender, EventArgs e)
        {
            try
            {
                string firstname = firstNameTxtBox.Texts;
                string lastname = lastNameTxtBox.Texts;
                int age = Convert.ToInt32(ageTxtBox.Texts);
                string email = emailTxtBox.Texts;
                string gender = genderComboBox.Texts;
                string username = userNameTxtBox.Texts;
                string password = passwordTxtBox.Texts;
                bool registered = DBFunction.DBFunction.Register(firstname, lastname, age, email, gender, username, password, "student");

                if (registered)
                {
                    
                }
            } catch (FormatException)
            {
                MessageBox.Show("Please enter required details.");
            }

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            mainForm.LoadLogin();
        }
    }
}
