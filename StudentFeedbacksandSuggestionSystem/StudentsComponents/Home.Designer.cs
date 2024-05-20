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
            this.titleTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.addSuggestion = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.suggestionMessage = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayout1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.latestSuggestionsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayout1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // suggestionsLayout
            // 
            this.suggestionsLayout.AutoScroll = true;
            this.suggestionsLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.suggestionsLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.suggestionsLayout.Location = new System.Drawing.Point(244, 10);
            this.suggestionsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.suggestionsLayout.Name = "suggestionsLayout";
            this.suggestionsLayout.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.suggestionsLayout.Size = new System.Drawing.Size(406, 458);
            this.suggestionsLayout.TabIndex = 10;
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.titleTxtBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.titleTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.titleTxtBox.BorderRadius = 0;
            this.titleTxtBox.BorderSize = 2;
            this.titleTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxtBox.ForeColor = System.Drawing.Color.Black;
            this.titleTxtBox.Location = new System.Drawing.Point(13, 99);
            this.titleTxtBox.Multiline = false;
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.titleTxtBox.PasswordChar = false;
            this.titleTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.titleTxtBox.PlaceholderText = "Title";
            this.titleTxtBox.Size = new System.Drawing.Size(202, 29);
            this.titleTxtBox.TabIndex = 1;
            this.titleTxtBox.Texts = "";
            this.titleTxtBox.UnderlinedStyle = false;
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
            this.addSuggestion.Location = new System.Drawing.Point(45, 349);
            this.addSuggestion.Name = "addSuggestion";
            this.addSuggestion.Size = new System.Drawing.Size(113, 60);
            this.addSuggestion.TabIndex = 3;
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
            this.suggestionMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestionMessage.ForeColor = System.Drawing.Color.Black;
            this.suggestionMessage.Location = new System.Drawing.Point(13, 135);
            this.suggestionMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.suggestionMessage.Multiline = true;
            this.suggestionMessage.Name = "suggestionMessage";
            this.suggestionMessage.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.suggestionMessage.PasswordChar = false;
            this.suggestionMessage.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.suggestionMessage.PlaceholderText = "Suggestion";
            this.suggestionMessage.Size = new System.Drawing.Size(202, 197);
            this.suggestionMessage.TabIndex = 2;
            this.suggestionMessage.Texts = "";
            this.suggestionMessage.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flowLayout1);
            this.panel1.Controls.Add(this.suggestionsLayout);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(980, 480);
            this.panel1.TabIndex = 1;
            // 
            // flowLayout1
            // 
            this.flowLayout1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayout1.Controls.Add(this.panel3);
            this.flowLayout1.Controls.Add(this.latestSuggestionsLayout);
            this.flowLayout1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayout1.Location = new System.Drawing.Point(682, 10);
            this.flowLayout1.Name = "flowLayout1";
            this.flowLayout1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.flowLayout1.Size = new System.Drawing.Size(286, 458);
            this.flowLayout1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 60);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.label1.Size = new System.Drawing.Size(264, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Most Up Votes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // latestSuggestionsLayout
            // 
            this.latestSuggestionsLayout.AutoScroll = true;
            this.latestSuggestionsLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.latestSuggestionsLayout.Location = new System.Drawing.Point(10, 152);
            this.latestSuggestionsLayout.Name = "latestSuggestionsLayout";
            this.latestSuggestionsLayout.Size = new System.Drawing.Size(264, 294);
            this.latestSuggestionsLayout.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.titleTxtBox);
            this.panel4.Controls.Add(this.addSuggestion);
            this.panel4.Controls.Add(this.suggestionMessage);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 458);
            this.panel4.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.flowLayout1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel suggestionsLayout;
        private CustomControls.CustomButton addSuggestion;
        private CustomControls.CustomTextBox suggestionMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel flowLayout1;
        private System.Windows.Forms.FlowLayoutPanel latestSuggestionsLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.CustomTextBox titleTxtBox;
        private System.Windows.Forms.Panel panel4;
    }
}