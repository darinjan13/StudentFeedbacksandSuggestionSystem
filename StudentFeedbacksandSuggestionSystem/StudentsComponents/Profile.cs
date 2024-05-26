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
    public partial class Profile : Form
    {
        private List<SuggestionsInfo> suggestionsInfos;
        UserInfo userInfo;
    public Profile(UserInfo userInfo)
        {
            InitializeComponent();
            this.userInfo = userInfo;
            fullnameLabel.Text = userInfo.Firstname + " " + userInfo.Lastname;
            LoadSuggestions();
        }

        private void LoadSuggestions()
        {
            suggestionsInfos = DBFunction.DBFunction.GetUserSuggestions(userInfo.User_id);

            var sortedSuggestions = suggestionsInfos.OrderBy(s => s.TimeDifference.TotalSeconds).ToList();

            suggestionsLayout.Controls.Clear();

            foreach (var suggestions in sortedSuggestions)
            {
                StudentsComponents.DisplaySuggestions displaySuggestions = new StudentsComponents.DisplaySuggestions(suggestions.Votes, suggestions.Title);
                displaySuggestions.TopLevel = false;
                displaySuggestions.Anchor = AnchorStyles.Left | AnchorStyles.Right;

                suggestionsLayout.Controls.Add(displaySuggestions);
                displaySuggestions.Show();
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
        }
    }
}
