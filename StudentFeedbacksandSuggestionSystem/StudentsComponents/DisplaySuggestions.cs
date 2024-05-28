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

namespace StudentFeedbacksandSuggestionSystem.StudentsComponents
{
    public partial class DisplaySuggestions : Form
    {
        public DisplaySuggestions(int votes, string title, TimeSpan timeDifference)
        {
            InitializeComponent();
            votesLabel.Text = votes.ToString() + " Votes";
            titleLabel.Text = title;
            SetDatePosted(timeDifference);
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        }

        private void SetDatePosted(TimeSpan timeDifference)
        {

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
    }
}
