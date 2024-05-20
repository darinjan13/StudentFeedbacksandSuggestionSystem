using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFeedbacksandSuggestionSystem.Datas
{
    public class SuggestionsInfo
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
        public DateTime CreatedDate { get; set; }
        public TimeSpan TimeDifference
        {
            get
            {
                return DateTime.Now.Subtract(CreatedDate);
            }
        }
    }
}
