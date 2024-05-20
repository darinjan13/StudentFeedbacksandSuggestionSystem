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
        UserInfo userInfo;
        private List<SuggestionsInfo> suggestionsInfos;

        public Home(UserInfo userInfo)
        {
            InitializeComponent();
            this.userInfo = userInfo;
            DisplaySuggestions();
            //DisplayLatest();
        }

        private void DisplayMostVotes()
        {
            suggestionsInfos = DBFunction.DBFunction.GetSuggestions();

            var sortedSuggestions = suggestionsInfos.OrderByDescending(s => s.UpVotes - s.DownVotes).ToList();

            latestSuggestionsLayout.Controls.Clear();

            if (sortedSuggestions.Any())
            {
                SuggestionCard suggestionCard = new SuggestionCard(sortedSuggestions[0]);
                suggestionCard.TopLevel = false;
                latestSuggestionsLayout.Controls.Add(suggestionCard);
                suggestionCard.Show();
            }
        }

        private void DisplaySuggestions()
        {
            suggestionsInfos = DBFunction.DBFunction.GetSuggestions();
            var sortedSuggestions = suggestionsInfos.OrderBy(s => s.TimeDifference.TotalSeconds).ToList();
            suggestionsLayout.Controls.Clear();
            foreach (var suggestions in sortedSuggestions)
            {
                SuggestionCard suggestionCard = new SuggestionCard(suggestions);
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
                DisplaySuggestions();
                DisplayMostVotes();
            }
            else
                MessageBox.Show("Error Submiting Suggestion.");
        }
    }
}
