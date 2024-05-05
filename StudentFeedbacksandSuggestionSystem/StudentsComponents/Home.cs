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
        private BindingList<SuggestionsInfo> suggestionsInfoList = new BindingList<SuggestionsInfo>();

        public Home(UserInfo userInfo)
        {
            InitializeComponent();
            this.userInfo = userInfo;
            DisplaySuggestions();
        }

        private void DisplaySuggestions()
        {
            suggestionsInfoList.Clear();

            List<SuggestionsInfo> fetchedSuggestions = DBFunction.DBFunction.GetSuggestions();

            foreach (var suggestionsInfo in fetchedSuggestions)
            {
                suggestionsInfoList.Add(suggestionsInfo);
            }

            foreach (var suggestionsInfo in suggestionsInfoList)
            {
                Suggestions suggestions = new Suggestions();
                suggestions.Author = suggestionsInfo.Author;
                suggestions.Message = suggestionsInfo.Message;
                suggestions.SuggestionsClick += Suggestions_SuggestionsClick; // Subscribe to the event
                suggestionsLayout.Controls.Add(suggestions);
            }
        }

        private void addSuggestion_Click(object sender, EventArgs e)
        {
            string message = suggestionMessage.Texts;
            DBFunction.DBFunction.AddSuggestions(userInfo.User_id, message);

            SuggestionsInfo newSuggestionInfo = new SuggestionsInfo
            {
                Author = userInfo.Firstname + " " + userInfo.Lastname,
                Message = message
            };

            suggestionsInfoList.Add(newSuggestionInfo);

            Suggestions newSuggestion = new Suggestions();
            newSuggestion.Author = newSuggestionInfo.Author;
            newSuggestion.Message = newSuggestionInfo.Message;
            newSuggestion.SuggestionsClick += Suggestions_SuggestionsClick; // Subscribe to the event

            suggestionsLayout.Controls.Add(newSuggestion);
        }

        // Step 3: Handle the event
        private void Suggestions_SuggestionsClick(object sender, EventArgs e)
        {
            Suggestions clickedSuggestion = sender as Suggestions;

            if (clickedSuggestion != null)
            {
                string message = $"Author: {clickedSuggestion.Author}\nMessage: {clickedSuggestion.Message}";
                MessageBox.Show(message, "Suggestion Details", MessageBoxButtons.OK);
            }
        }
    }
}
