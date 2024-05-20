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
            titleLabel.Text = suggestionsInfo.Title;
            authorLabel.Text = "By: " + suggestionsInfo.Author;
            messageLabel.Text = suggestionsInfo.Message;
            SetDatePosted();
        }

        private void SetDatePosted()
        {
            TimeSpan timeDifference = suggestionsInfo.TimeDifference;

            if (timeDifference.TotalSeconds < 60)
            {
                if ((int)timeDifference.TotalSeconds > 1)
                {
                    datePosted.Text = $"{(int)timeDifference.TotalSeconds} seconds ago.";
                }
                else
                {
                    datePosted.Text = $"{(int)timeDifference.TotalSeconds} second ago.";
                }
            }
            else if (timeDifference.TotalMinutes < 60)
            {
                if ((int)timeDifference.TotalMinutes > 1)
                {
                    datePosted.Text = $"{(int)timeDifference.TotalMinutes} minutes ago.";
                }
                else
                {
                    datePosted.Text = $"{(int)timeDifference.TotalMinutes} minute ago.";
                }
            }
            else if (timeDifference.TotalHours < 24)
            {
                if ((int)timeDifference.TotalHours > 1)
                {
                    datePosted.Text = $"{(int)timeDifference.TotalHours} hours ago.";
                }
                else
                {
                    datePosted.Text = $"{(int)timeDifference.TotalHours} hour ago.";
                }
            }
            else
            {
                if ((int)timeDifference.TotalDays > 1)
                {
                    datePosted.Text = $"{(int)timeDifference.TotalDays} days ago.";
                }
                else
                {
                    datePosted.Text = $"{(int)timeDifference.TotalDays} day ago.";
                }
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            ClickedSuggestion clickedSuggestion = new ClickedSuggestion();
            clickedSuggestion.ShowDialog();

        }

        private void upvoteBtn_Click(object sender, EventArgs e)
        {
            suggestionsInfo.UpVotes++;
            voteCounts.Text = (suggestionsInfo.UpVotes - suggestionsInfo.DownVotes).ToString();
            //upvoteBtn.IconColor = Color.Lime;
            upvoteBtn.Cursor = Cursors.Default;

            downvoteBtn.Cursor = Cursors.Hand;
            downvoteBtn.IconColor = Color.Black;
        }

        private void downvoteBtn_Click(object sender, EventArgs e)
        {
            suggestionsInfo.DownVotes++;
            voteCounts.Text = (suggestionsInfo.UpVotes - suggestionsInfo.DownVotes).ToString();
            downvoteBtn.IconColor = Color.Red;
            downvoteBtn.Cursor = Cursors.Default;

            upvoteBtn.Cursor = Cursors.Hand;
            //upvoteBtn.IconColor = Color.Black;
        }

        private void upvoteBtn_Enter(object sender, EventArgs e)
        {

        }
    }
}
