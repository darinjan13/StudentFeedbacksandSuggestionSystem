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
        LoadingScreen loadingScreen = new LoadingScreen();
        SuggestionsInfo suggestionsInfo;
        UserInfo userInfo;
        Home home;
        bool sorted;
        bool profile;

        public SuggestionCard(SuggestionsInfo suggestionsInfo)
        {
            InitializeComponent();
            this.suggestionsInfo = suggestionsInfo;
            SetLabelValue();
            timer1.Interval = 1000;
            profile = true;
            HideButtons();
        }

        public SuggestionCard(UserInfo userInfo, SuggestionsInfo suggestionsInfo, Home home, bool sorted)
        {
            InitializeComponent();
            this.suggestionsInfo = suggestionsInfo;
            this.userInfo = userInfo;
            this.home = home;
            SetLabelValue();
            this.sorted = sorted;
            timer1.Interval = 1000;

            HideButtons();
        }

        private void HideButtons()
        {
            if (sorted || profile)
            {
                upvoteBtn.Visible = false;
                downvoteBtn.Visible = false;
                voteCounts.Size = new Size(90, 40);
            }
            
        }
        
        private void SetLabelValue()
        {
            titleLabel.Text = suggestionsInfo.Title;
            authorLabel.Text = "By: " + suggestionsInfo.Author;
            messageLabel.Text = suggestionsInfo.Message;
            voteCounts.Text = suggestionsInfo.Votes.ToString() + " Votes";
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
            if (upvoteBtn.IconColor != Color.Lime)
            {
                loadingScreen.TopLevel = false;
                loadingScreen.Dock = DockStyle.Fill;
                panel1.Hide();
                this.Controls.Add(loadingScreen);

                loadingScreen.Show();

                timer1.Enabled = true;
                timer1.Start();
                timer1.Tick += (s, ev) =>
                {
                    if (DBFunction.DBFunction.UpdateVotes(suggestionsInfo.Suggestion_ID, true))
                    {
                        suggestionsInfo.Votes++;
                        upvoteBtn.IconColor = Color.Lime;
                        upvoteBtn.Cursor = Cursors.Default;

                        downvoteBtn.Cursor = Cursors.Hand;
                        downvoteBtn.IconColor = Color.Black;

                        SetLabelValue();
                        loadingScreen.Hide();
                        panel1.Show();
                        timer1.Stop();
                        if (suggestionsInfo.Votes > 10)
                        {
                            home.DisplayMostVotes();
                            home.DisplayMostVotes();
                        }
                        voteCounts.Text = suggestionsInfo.Votes.ToString();
                    }
                };
            }
        }

        private void downvoteBtn_Click(object sender, EventArgs e)
        {
            if (downvoteBtn.IconColor != Color.Red)
            {
                loadingScreen.TopLevel = false;
                loadingScreen.Dock = DockStyle.Fill;
                panel1.Hide();
                this.Controls.Add(loadingScreen);
                loadingScreen.Show();


                timer1.Enabled = true;
                timer1.Start();
                timer1.Tick += (s, ev) =>
                {
                    if (DBFunction.DBFunction.UpdateVotes(suggestionsInfo.Suggestion_ID, false))
                    {
                        suggestionsInfo.Votes--;
                        downvoteBtn.IconColor = Color.Red;
                        downvoteBtn.Cursor = Cursors.Default;

                        upvoteBtn.Cursor = Cursors.Hand;
                        upvoteBtn.IconColor = Color.Black;

                        loadingScreen.Hide();
                        panel1.Show();
                        timer1.Stop();
                        home.DisplayMostVotes();
                        voteCounts.Text = suggestionsInfo.Votes.ToString();
                    }
                };
            }
        }

        private void authorLabel_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(userInfo);
            profile.TopLevel = true;
            profile.FormBorderStyle = FormBorderStyle.Sizable;
            profile.ShowDialog();
        }
    }
}
