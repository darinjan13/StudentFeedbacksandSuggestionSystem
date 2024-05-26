using StudentFeedbacksandSuggestionSystem.CustomControls;
using StudentFeedbacksandSuggestionSystem.Datas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudentFeedbacksandSuggestionSystem.StudentsComponents
{
    public partial class Home : Form
    {
        LoadingScreen loadingScreen = new LoadingScreen();
        UserInfo userInfo;
        private List<SuggestionsInfo> suggestionsInfos;

        public Home(UserInfo userInfo)
        {
            InitializeComponent();
            this.userInfo = userInfo;
            timer1.Interval = 1000;
            DisplaySuggestions();
            DisplayMostVotes();
        }

        public void DisplayMostVotes()
        {

            latestSuggestionsLayout.Hide();
            loadingScreen.TopLevel = false;
            panel2.Controls.Add(loadingScreen);
            loadingScreen.Show();

            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (sender, e) => {
            suggestionsInfos = DBFunction.DBFunction.GetSuggestions();
                if (suggestionsInfos != null)
                {
                    var sortedSuggestions = suggestionsInfos.Where(s => s.Votes > 10).OrderByDescending(s => s.Votes).ToList();

                    latestSuggestionsLayout.Controls.Clear();

                    foreach (var suggestions in sortedSuggestions)
                    {
                        SuggestionCard suggestionCard = new SuggestionCard(userInfo, suggestions, true);
                        suggestionCard.TopLevel = false;
                        latestSuggestionsLayout.Controls.Add(suggestionCard);
                        suggestionCard.Show();
                    }

                    loadingScreen.Hide();
                    latestSuggestionsLayout.Show();

                    timer1.Stop();
                }
                else
                {
                    MessageBox.Show("Currently no suggestions.");
                }
            };
        }


        public void DisplaySuggestions()
        {
            suggestionsInfos = DBFunction.DBFunction.GetSuggestions();

            var sortedSuggestions = suggestionsInfos.OrderBy(s => s.TimeDifference.TotalSeconds).ToList();

            suggestionsLayout.Controls.Clear();

            foreach (var suggestions in sortedSuggestions)
            {
                SuggestionCard suggestionCard = new SuggestionCard(userInfo, suggestions, false);
                suggestionCard.TopLevel = false;
                
                suggestionsLayout.Controls.Add(suggestionCard);
                suggestionCard.Show();
            }

        }

    }
}
