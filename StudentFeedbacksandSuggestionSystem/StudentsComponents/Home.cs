using StudentFeedbacksandSuggestionSystem.CustomControls;
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
    public partial class Home : Form
    {
        LoadingScreen loadingScreen = new LoadingScreen();
        UserInfo userInfo;
        private List<SuggestionsInfo> suggestionsInfos;

        public Home(UserInfo userInfo)
        {
            InitializeComponent();
            this.userInfo = userInfo;
            DisplaySuggestions();
            DisplayMostVotes();
        }

        public void DisplayMostVotes()
        {
            loadingScreen.TopLevel = false;
            panel3.Controls.Add(loadingScreen);
            loadingScreen.Show();
            suggestionsInfos = DBFunction.DBFunction.GetSuggestions();

            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 100;
            timer1.Tick += (sender, e) => {
                if (suggestionsInfos != null)
                {
                    var sortedSuggestions = suggestionsInfos.Where(s => s.Votes > 10).OrderByDescending(s => s.Votes).ToList();

                    latestSuggestionsLayout.Controls.Clear();

                    foreach (var suggestions in sortedSuggestions)
                    {
                        SuggestionCard suggestionCard = new SuggestionCard(suggestions, this, true);
                        suggestionCard.TopLevel = false;
                        latestSuggestionsLayout.Controls.Add(suggestionCard);
                        suggestionCard.Show();
                    }

                    loadingScreen.Hide();


                    timer1.Stop();
                }
            };
        }

        private void DisplaySuggestions()
        {
            suggestionsInfos = DBFunction.DBFunction.GetSuggestions();

            var sortedSuggestions = suggestionsInfos.OrderBy(s => s.TimeDifference.TotalSeconds).ToList();

            suggestionsLayout.Controls.Clear();

            foreach (var suggestions in sortedSuggestions)
            {
                SuggestionCard suggestionCard = new SuggestionCard(suggestions, this, false);
                suggestionCard.TopLevel = false;
                suggestionsLayout.Controls.Add(suggestionCard);
                suggestionCard.Show();
            }
        }

        private void addSuggestion_Click(object sender, EventArgs e)
        {
            if (DBFunction.DBFunction.AddSuggestions(userInfo.User_id, titleTxtBox.Texts, suggestionMessage.Texts))
            {
                MessageBox.Show("Added.");
                suggestionMessage.Texts = null;
            }
            else
                MessageBox.Show("Error Submiting Suggestion.");
            DisplaySuggestions();
        }

    }
}
