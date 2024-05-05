using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace StudentFeedbacksandSuggestionSystem.CustomControls
{
    public partial class Suggestions : UserControl
    {
        private string _author, _message;

        // Define the event
        public event EventHandler SuggestionsClick;

        public Suggestions()
        {
            InitializeComponent();

            // Add click event to each control
            this.Click += new EventHandler(Suggestions_Click);
            foreach (Control control in this.Controls)
            {
                control.Click += new EventHandler(Control_Click);
                foreach (Control subControl in control.Controls)
                {
                    subControl.Click += new EventHandler(Control_Click);
                }
            }
        }

        [Category("Custom Properties")]
        public string Author
        {
            get { return _author; }
            set { _author = value; authorText.Text = value; }
        }

        [Category("Custom Properties")]
        public string Message
        {
            get { return _message; }
            set { _message = value; messageLabel.Text = value; }
        }

        // Raise the event when the control is clicked
        void Suggestions_Click(object sender, EventArgs e)
        {
            TriggerClick();
        }

        // Raise the event when a child control is clicked
        void Control_Click(object sender, EventArgs e)
        {
            TriggerClick();
        }

        // Method to trigger the Click event
        public void TriggerClick()
        {
            SuggestionsClick?.Invoke(this, new EventArgs());
        }
    }
}
