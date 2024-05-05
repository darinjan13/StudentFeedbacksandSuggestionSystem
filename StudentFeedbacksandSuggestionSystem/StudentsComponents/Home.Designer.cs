namespace StudentFeedbacksandSuggestionSystem.StudentsComponents
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.suggestionsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addSuggestion = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.suggestionMessage = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // suggestionsLayout
            // 
            this.suggestionsLayout.AutoScroll = true;
            this.suggestionsLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.suggestionsLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.suggestionsLayout.Location = new System.Drawing.Point(10, 143);
            this.suggestionsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.suggestionsLayout.Name = "suggestionsLayout";
            this.suggestionsLayout.Padding = new System.Windows.Forms.Padding(10);
            this.suggestionsLayout.Size = new System.Drawing.Size(716, 392);
            this.suggestionsLayout.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addSuggestion);
            this.panel2.Controls.Add(this.suggestionMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(716, 134);
            this.panel2.TabIndex = 0;
            // 
            // addSuggestion
            // 
            this.addSuggestion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addSuggestion.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addSuggestion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addSuggestion.BorderRadius = 0;
            this.addSuggestion.BorderSize = 0;
            this.addSuggestion.FlatAppearance.BorderSize = 0;
            this.addSuggestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSuggestion.ForeColor = System.Drawing.Color.White;
            this.addSuggestion.Location = new System.Drawing.Point(540, 26);
            this.addSuggestion.Name = "addSuggestion";
            this.addSuggestion.Size = new System.Drawing.Size(113, 60);
            this.addSuggestion.TabIndex = 1;
            this.addSuggestion.Text = "Add Suggestion";
            this.addSuggestion.TextColor = System.Drawing.Color.White;
            this.addSuggestion.UseVisualStyleBackColor = false;
            this.addSuggestion.Click += new System.EventHandler(this.addSuggestion_Click);
            // 
            // suggestionMessage
            // 
            this.suggestionMessage.BackColor = System.Drawing.SystemColors.Window;
            this.suggestionMessage.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.suggestionMessage.BorderFocusColor = System.Drawing.Color.HotPink;
            this.suggestionMessage.BorderRadius = 0;
            this.suggestionMessage.BorderSize = 2;
            this.suggestionMessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.suggestionMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestionMessage.ForeColor = System.Drawing.Color.Black;
            this.suggestionMessage.Location = new System.Drawing.Point(5, 5);
            this.suggestionMessage.Margin = new System.Windows.Forms.Padding(4);
            this.suggestionMessage.Multiline = true;
            this.suggestionMessage.Name = "suggestionMessage";
            this.suggestionMessage.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.suggestionMessage.PasswordChar = false;
            this.suggestionMessage.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.suggestionMessage.PlaceholderText = "";
            this.suggestionMessage.Size = new System.Drawing.Size(483, 124);
            this.suggestionMessage.TabIndex = 0;
            this.suggestionMessage.Texts = "";
            this.suggestionMessage.UnderlinedStyle = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.suggestionsLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Home";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel suggestionsLayout;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.CustomButton addSuggestion;
        private CustomControls.CustomTextBox suggestionMessage;
    }
}