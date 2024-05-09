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
            DisplayLatest();
        }

        private void DisplayLatest()
        {
            suggestionsInfos = DBFunction.DBFunction.GetSuggestions();
            latestSuggestionsLayout.Controls.Clear();
            foreach (var suggestions in suggestionsInfos)
            {
                    if (suggestions.TimeDifference.TotalMinutes < 20)
                    {
                        SuggestionCard suggestionCard = new SuggestionCard(suggestions);
                        suggestionCard.TopLevel = false;
                        latestSuggestionsLayout.Controls.Add(suggestionCard);
                        suggestionCard.Show();
                    }
                    
            }
        }

        private void DisplaySuggestions()
        {
            suggestionsInfos = DBFunction.DBFunction.GetSuggestions();
            suggestionsLayout.Controls.Clear();
            foreach (var suggestions in suggestionsInfos)
            {
                SuggestionCard suggestionCard = new SuggestionCard(suggestions);
                suggestionCard.TopLevel = false;
                suggestionsLayout.Controls.Add(suggestionCard);
                suggestionCard.Show();
            }
        }

        private void addSuggestion_Click(object sender, EventArgs e)
        {
            if (DBFunction.DBFunction.AddSuggestions(userInfo.User_id, suggestionMessage.Texts))
            {
                MessageBox.Show("Added.");
                suggestionMessage.Texts = null;
                DisplaySuggestions();
                DisplayLatest();
            }
            else
                MessageBox.Show("Error Submiting Suggestion.");
        }
    }
}
