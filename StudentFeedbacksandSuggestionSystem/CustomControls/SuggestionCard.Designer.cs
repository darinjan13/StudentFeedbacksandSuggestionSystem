namespace StudentFeedbacksandSuggestionSystem.CustomControls
{
    partial class SuggestionCard
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.voteCounts = new System.Windows.Forms.Label();
            this.downvoteBtn = new FontAwesome.Sharp.IconButton();
            this.messageLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.authorLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.datePosted = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.upvoteBtn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 199);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.messageLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 107);
            this.panel4.TabIndex = 2;
            this.panel4.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.voteCounts);
            this.panel7.Controls.Add(this.downvoteBtn);
            this.panel7.Controls.Add(this.upvoteBtn);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(89, 107);
            this.panel7.TabIndex = 2;
            // 
            // voteCounts
            // 
            this.voteCounts.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.voteCounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.voteCounts.Location = new System.Drawing.Point(0, 37);
            this.voteCounts.Name = "voteCounts";
            this.voteCounts.Size = new System.Drawing.Size(89, 31);
            this.voteCounts.TabIndex = 4;
            this.voteCounts.Text = "Count";
            this.voteCounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // downvoteBtn
            // 
            this.downvoteBtn.BackColor = System.Drawing.Color.Transparent;
            this.downvoteBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downvoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downvoteBtn.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.downvoteBtn.IconColor = System.Drawing.Color.Black;
            this.downvoteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.downvoteBtn.Location = new System.Drawing.Point(0, 68);
            this.downvoteBtn.Name = "downvoteBtn";
            this.downvoteBtn.Size = new System.Drawing.Size(89, 39);
            this.downvoteBtn.TabIndex = 3;
            this.downvoteBtn.UseVisualStyleBackColor = false;
            this.downvoteBtn.Click += new System.EventHandler(this.downvoteBtn_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.messageLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(126, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(250, 107);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "Message";
            this.messageLabel.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 46);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.authorLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(200, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(176, 46);
            this.panel6.TabIndex = 1;
            this.panel6.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // authorLabel
            // 
            this.authorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(0, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(176, 46);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.authorLabel.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.datePosted);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(120, 46);
            this.panel5.TabIndex = 0;
            this.panel5.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // datePosted
            // 
            this.datePosted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePosted.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePosted.Location = new System.Drawing.Point(0, 0);
            this.datePosted.Name = "datePosted";
            this.datePosted.Size = new System.Drawing.Size(120, 46);
            this.datePosted.TabIndex = 1;
            this.datePosted.Text = "Date Posted";
            this.datePosted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.datePosted.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.titleLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 46);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(376, 46);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // upvoteBtn
            // 
            this.upvoteBtn.BackColor = System.Drawing.Color.Transparent;
            this.upvoteBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.upvoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upvoteBtn.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
            this.upvoteBtn.IconColor = System.Drawing.Color.Black;
            this.upvoteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.upvoteBtn.Location = new System.Drawing.Point(0, 0);
            this.upvoteBtn.Name = "upvoteBtn";
            this.upvoteBtn.Size = new System.Drawing.Size(89, 37);
            this.upvoteBtn.TabIndex = 2;
            this.upvoteBtn.UseVisualStyleBackColor = false;
            this.upvoteBtn.Click += new System.EventHandler(this.upvoteBtn_Click);
            this.upvoteBtn.Validated += new System.EventHandler(this.upvoteBtn_Enter);
            // 
            // SuggestionCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(376, 199);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuggestionCard";
            this.Text = "SuggestionCard";
            this.Click += new System.EventHandler(this.customButton1_Click);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label datePosted;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label voteCounts;
        private FontAwesome.Sharp.IconButton downvoteBtn;
        private FontAwesome.Sharp.IconButton upvoteBtn;
    }
}