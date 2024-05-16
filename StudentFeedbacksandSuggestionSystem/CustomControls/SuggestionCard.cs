using StudentFeedbacksandSuggestionSystem.Datas;
using StudentFeedbacksandSuggestionSystem.StudentsComponents;
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
            SetDatePosted();
        }

        private void SetDatePosted()
        {
            TimeSpan timeDifference = suggestionsInfo.TimeDifference;
            if (timeDifference.TotalSeconds < 60)
            {
                datePosted.Text = $"{timeDifference.TotalSeconds:F0} second/s ago.";
            }
            else if (timeDifference.TotalMinutes < 1 || timeDifference.TotalHours < 1)
            {
                datePosted.Text = $"{timeDifference.TotalMinutes:F0} minute/s ago.";
            }
            else if (timeDifference.TotalDays < 1)
            {
                datePosted.Text = $"{timeDifference.TotalHours:F0} hour/s ago.";
            }
            else
            {
                datePosted.Text = $"{timeDifference.TotalDays:F0} day/s ago.";
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            ClickedSuggestion clickedSuggestion = new ClickedSuggestion();
            clickedSuggestion.ShowDialog();

        }
    }
}
