using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbacksandSuggestionSystem.Admin
{
    public partial class AdminSuggestions : Form
    {
        public AdminSuggestions()
        {
            InitializeComponent();
            GetSuggestions();
        }

        private void GetSuggestions()
        {
            string query = "SELECT * FROM suggestions";
            DBFunction.DBFunction.GetData(query, dataGridView1);
        }

        private void AdminSuggestions_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
