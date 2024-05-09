using StudentFeedbacksandSuggestionSystem.Datas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbacksandSuggestionSystem.CustomControls
{
    public partial class SuggestionCard : Form
    {
        SuggestionsInfo suggestionsInfo;
        public SuggestionCard(SuggestionsInfo suggestionsInfo)
        {
            InitializeComponent();
            this.suggestionsInfo = suggestionsInfo;
            SetLabelValue();
        }
        
        private void SetLabelValue()
        {
            authorText.Text = suggestionsInfo.Author;
            messageLabel.Text = suggestionsInfo.Message;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            TimeSpan timeDifference = suggestionsInfo.TimeDifference;
            if (timeDifference.TotalSeconds < 60)
            {
                MessageBox.Show($"{timeDifference.TotalSeconds:F0} seconds ago.");
            }
            else if (timeDifference.TotalMinutes < 1 || timeDifference.TotalHours < 1)
            {
                MessageBox.Show($"{timeDifference.TotalMinutes:F0} minutes ago.");
            }
            else if (timeDifference.TotalDays < 1)
            {
                MessageBox.Show($"{timeDifference.TotalHours:F0} hours ago.");
            }
            else
            {
                MessageBox.Show($"{timeDifference.TotalDays:F0} days ago.");
            }

        }
    }
}
