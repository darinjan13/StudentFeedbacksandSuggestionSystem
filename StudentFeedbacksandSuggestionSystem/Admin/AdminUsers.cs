using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbacksandSuggestionSystem
{
    public partial class AdminUsers : Form
    {
        string firstname, lastname, email, gender, username, password, role;
        int ID, age;

        private void printUsers_Click(object sender, EventArgs e)
        {
            ReportViewer reportViewer = new ReportViewer("Users.rpt");
            reportViewer.ShowDialog();
        }

        public AdminUsers()
        {
            InitializeComponent();
            GetUsers();
        }

        private void GetUsers()
        {
            string query = "SELECT * FROM users";
            DBFunction.DBFunction.GetData(query, dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                IDTxt.Texts = dataGridView1[0, e.RowIndex].Value.ToString();
                firstnameTxtBox.Texts = dataGridView1[1, e.RowIndex].Value.ToString();
                lastnameTxtBox.Texts = dataGridView1[2, e.RowIndex].Value.ToString();
                ageTxtBox.Texts = dataGridView1[3, e.RowIndex].Value.ToString();
                emailTxtBox.Texts = dataGridView1[4, e.RowIndex].Value.ToString();
                usernameTxtBox.Texts = dataGridView1[5, e.RowIndex].Value.ToString();
                passwordTxtBox.Texts = dataGridView1[6, e.RowIndex].Value.ToString();
                genderComboBox.Texts = dataGridView1[7, e.RowIndex].Value.ToString();
                roleComboBox.Texts = dataGridView1[8, e.RowIndex].Value.ToString();
            }

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            firstname = firstnameTxtBox.Texts;
            lastname = lastnameTxtBox.Texts;
            age = Convert.ToInt32(ageTxtBox.Texts);
            email = emailTxtBox.Texts;
            username = usernameTxtBox.Texts;
            password = passwordTxtBox.Texts;
            gender = genderComboBox.Texts;
            role = roleComboBox.Texts.ToLower();
            if(DBFunction.DBFunction.Register(firstname, lastname, age, email, gender, username, password, role))
            {
                MessageBox.Show("Registered Successfully");
                GetUsers();
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(IDTxt.Texts);
            firstname = firstnameTxtBox.Texts;
            lastname = lastnameTxtBox.Texts;
            age = Convert.ToInt32(ageTxtBox.Texts);
            email = emailTxtBox.Texts;
            username = usernameTxtBox.Texts;
            password = passwordTxtBox.Texts;
            gender = genderComboBox.Texts;
            role = roleComboBox.Texts.ToLower();
            if(DBFunction.DBFunction.Update(ID, firstname, lastname, age, email, gender, username, password, role))
            {
                MessageBox.Show("Updated uccessfully");
                GetUsers();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(IDTxt.Texts);
            if (DBFunction.DBFunction.Delete(ID))
            {
                MessageBox.Show("Deleted Successfully");
                GetUsers();
            }
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}