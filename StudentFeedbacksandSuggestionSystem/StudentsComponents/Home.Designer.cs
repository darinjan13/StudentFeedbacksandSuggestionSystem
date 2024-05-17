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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayout1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.latestSuggestionsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.customTextBox1 = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.addSuggestion = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.suggestionMessage = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayout1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // suggestionsLayout
            // 
            this.suggestionsLayout.AutoScroll = true;
            this.suggestionsLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.suggestionsLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.suggestionsLayout.Location = new System.Drawing.Point(0, 234);
            this.suggestionsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.suggestionsLayout.Name = "suggestionsLayout";
            this.suggestionsLayout.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.suggestionsLayout.Size = new System.Drawing.Size(650, 357);
            this.suggestionsLayout.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customTextBox1);
            this.panel2.Controls.Add(this.addSuggestion);
            this.panel2.Controls.Add(this.suggestionMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel2.Size = new System.Drawing.Size(1307, 234);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.suggestionsLayout);
            this.panel1.Controls.Add(this.flowLayout1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 591);
            this.panel1.TabIndex = 1;
            // 
            // flowLayout1
            // 
            this.flowLayout1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayout1.Controls.Add(this.panel3);
            this.flowLayout1.Controls.Add(this.latestSuggestionsLayout);
            this.flowLayout1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayout1.Location = new System.Drawing.Point(889, 234);
            this.flowLayout1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayout1.Name = "flowLayout1";
            this.flowLayout1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.flowLayout1.Size = new System.Drawing.Size(418, 357);
            this.flowLayout1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(13, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 74);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label1.Size = new System.Drawing.Size(390, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latest Suggestions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // latestSuggestionsLayout
            // 
            this.latestSuggestionsLayout.AutoScroll = true;
            this.latestSuggestionsLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.latestSuggestionsLayout.Location = new System.Drawing.Point(13, 25);
            this.latestSuggestionsLayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.latestSuggestionsLayout.Name = "latestSuggestionsLayout";
            this.latestSuggestionsLayout.Size = new System.Drawing.Size(390, 318);
            this.latestSuggestionsLayout.TabIndex = 1;
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox1.BorderRadius = 0;
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox1.ForeColor = System.Drawing.Color.Black;
            this.customTextBox1.Location = new System.Drawing.Point(12, 16);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "Title";
            this.customTextBox1.Size = new System.Drawing.Size(270, 35);
            this.customTextBox1.TabIndex = 2;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderlinedStyle = false;
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
            this.addSuggestion.Location = new System.Drawing.Point(307, 60);
            this.addSuggestion.Margin = new System.Windows.Forms.Padding(4);
            this.addSuggestion.Name = "addSuggestion";
            this.addSuggestion.Size = new System.Drawing.Size(151, 74);
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
            this.suggestionMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestionMessage.ForeColor = System.Drawing.Color.Black;
            this.suggestionMessage.Location = new System.Drawing.Point(12, 60);
            this.suggestionMessage.Margin = new System.Windows.Forms.Padding(5);
            this.suggestionMessage.Multiline = true;
            this.suggestionMessage.Name = "suggestionMessage";
            this.suggestionMessage.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.suggestionMessage.PasswordChar = false;
            this.suggestionMessage.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.suggestionMessage.PlaceholderText = "Suggestion";
            this.suggestionMessage.Size = new System.Drawing.Size(270, 153);
            this.suggestionMessage.TabIndex = 0;
            this.suggestionMessage.Texts = "";
            this.suggestionMessage.UnderlinedStyle = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 615);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Text = "Home";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayout1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel suggestionsLayout;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.CustomButton addSuggestion;
        private CustomControls.CustomTextBox suggestionMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel flowLayout1;
        private System.Windows.Forms.FlowLayoutPanel latestSuggestionsLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.CustomTextBox customTextBox1;
    }
}