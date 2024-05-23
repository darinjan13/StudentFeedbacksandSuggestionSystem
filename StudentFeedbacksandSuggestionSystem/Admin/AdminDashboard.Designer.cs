namespace StudentFeedbacksandSuggestionSystem.Admin
{
    partial class AdminDashboard
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
            this.greetingslbl = new System.Windows.Forms.Label();
            this.logoutButton = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.suggestionsPanel = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.usersPanel = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // greetingslbl
            // 
            this.greetingslbl.AutoSize = true;
            this.greetingslbl.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingslbl.ForeColor = System.Drawing.Color.White;
            this.greetingslbl.Location = new System.Drawing.Point(588, 75);
            this.greetingslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greetingslbl.Name = "greetingslbl";
            this.greetingslbl.Size = new System.Drawing.Size(265, 31);
            this.greetingslbl.TabIndex = 1;
            this.greetingslbl.Text = "WELCOME ADMIN!";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.PowderBlue;
            this.logoutButton.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.logoutButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.logoutButton.BorderRadius = 0;
            this.logoutButton.BorderSize = 0;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(1720, 4);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(200, 49);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextColor = System.Drawing.Color.White;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Controls.Add(this.greetingslbl);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.mainPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 1055);
            this.panel1.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.logoutButton);
            this.flowLayoutPanel1.Controls.Add(this.suggestionsPanel);
            this.flowLayoutPanel1.Controls.Add(this.usersPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1924, 58);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // suggestionsPanel
            // 
            this.suggestionsPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.suggestionsPanel.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.suggestionsPanel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.suggestionsPanel.BorderRadius = 0;
            this.suggestionsPanel.BorderSize = 0;
            this.suggestionsPanel.FlatAppearance.BorderSize = 0;
            this.suggestionsPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suggestionsPanel.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.suggestionsPanel.ForeColor = System.Drawing.Color.White;
            this.suggestionsPanel.Location = new System.Drawing.Point(1512, 4);
            this.suggestionsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.suggestionsPanel.Name = "suggestionsPanel";
            this.suggestionsPanel.Size = new System.Drawing.Size(200, 49);
            this.suggestionsPanel.TabIndex = 10;
            this.suggestionsPanel.Text = "Suggestions";
            this.suggestionsPanel.TextColor = System.Drawing.Color.White;
            this.suggestionsPanel.UseVisualStyleBackColor = false;
            this.suggestionsPanel.Click += new System.EventHandler(this.suggestionsPanel_Click);
            // 
            // usersPanel
            // 
            this.usersPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.usersPanel.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.usersPanel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.usersPanel.BorderRadius = 0;
            this.usersPanel.BorderSize = 0;
            this.usersPanel.FlatAppearance.BorderSize = 0;
            this.usersPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersPanel.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.usersPanel.ForeColor = System.Drawing.Color.White;
            this.usersPanel.Location = new System.Drawing.Point(1304, 4);
            this.usersPanel.Margin = new System.Windows.Forms.Padding(4);
            this.usersPanel.Name = "usersPanel";
            this.usersPanel.Size = new System.Drawing.Size(200, 49);
            this.usersPanel.TabIndex = 11;
            this.usersPanel.Text = "Users";
            this.usersPanel.TextColor = System.Drawing.Color.White;
            this.usersPanel.UseVisualStyleBackColor = false;
            this.usersPanel.Click += new System.EventHandler(this.usersPanel_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(0, 383);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1924, 672);
            this.mainPanel.TabIndex = 10;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashboard_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label greetingslbl;
        private CustomControls.CustomButton logoutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.CustomButton suggestionsPanel;
        private CustomControls.CustomButton usersPanel;
        private System.Windows.Forms.Panel mainPanel;
    }
}