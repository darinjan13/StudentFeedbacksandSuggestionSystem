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
    public partial class DisplaySuggestions : Form
    {
        public DisplaySuggestions(int votes, string title)
        {
            InitializeComponent();
            votesLabel.Text = votes.ToString() + " Votes";
            titleLabel.Text = title;
        }
    }
}
