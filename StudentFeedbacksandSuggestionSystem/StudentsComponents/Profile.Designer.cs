namespace StudentFeedbacksandSuggestionSystem.StudentsComponents
{
    partial class Profile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.suggestionsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.titleTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.addSuggestion = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.suggestionMessage = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 554);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.fullnameLabel);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(475, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panel3.Size = new System.Drawing.Size(592, 554);
            this.panel3.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.suggestionsLayout);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(27, 166);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(538, 363);
            this.panel5.TabIndex = 1;
            // 
            // suggestionsLayout
            // 
            this.suggestionsLayout.AutoScroll = true;
            this.suggestionsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suggestionsLayout.Location = new System.Drawing.Point(0, 0);
            this.suggestionsLayout.Margin = new System.Windows.Forms.Padding(4);
            this.suggestionsLayout.Name = "suggestionsLayout";
            this.suggestionsLayout.Size = new System.Drawing.Size(538, 363);
            this.suggestionsLayout.TabIndex = 0;
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLabel.Location = new System.Drawing.Point(20, 0);
            this.fullnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(545, 38);
            this.fullnameLabel.TabIndex = 9;
            this.fullnameLabel.Text = "Full Name";
            this.fullnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(27, 25);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(538, 113);
            this.panel4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(538, 113);
            this.label5.TabIndex = 0;
            this.label5.Text = "Your Suggestions";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 554);
            this.panel2.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.titleTxtBox);
            this.panel6.Controls.Add(this.addSuggestion);
            this.panel6.Controls.Add(this.suggestionMessage);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(377, 554);
            this.panel6.TabIndex = 10;
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
            this.titleTxtBox.IsReadOnly = false;
            this.titleTxtBox.Location = new System.Drawing.Point(49, 75);
            this.titleTxtBox.Margin = new System.Windows.Forms.Padding(5);
            this.titleTxtBox.Multiline = false;
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.titleTxtBox.PasswordChar = false;
            this.titleTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.titleTxtBox.PlaceholderText = "Title";
            this.titleTxtBox.Size = new System.Drawing.Size(269, 35);
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
            this.addSuggestion.Location = new System.Drawing.Point(101, 384);
            this.addSuggestion.Margin = new System.Windows.Forms.Padding(4);
            this.addSuggestion.Name = "addSuggestion";
            this.addSuggestion.Size = new System.Drawing.Size(151, 74);
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
            this.suggestionMessage.IsReadOnly = false;
            this.suggestionMessage.Location = new System.Drawing.Point(49, 119);
            this.suggestionMessage.Margin = new System.Windows.Forms.Padding(5);
            this.suggestionMessage.Multiline = true;
            this.suggestionMessage.Name = "suggestionMessage";
            this.suggestionMessage.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.suggestionMessage.PasswordChar = false;
            this.suggestionMessage.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.suggestionMessage.PlaceholderText = "Suggestion";
            this.suggestionMessage.Size = new System.Drawing.Size(269, 242);
            this.suggestionMessage.TabIndex = 2;
            this.suggestionMessage.Texts = "";
            this.suggestionMessage.UnderlinedStyle = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel suggestionsLayout;
        private System.Windows.Forms.Panel panel6;
        private CustomControls.CustomTextBox titleTxtBox;
        private CustomControls.CustomButton addSuggestion;
        private CustomControls.CustomTextBox suggestionMessage;
    }
}