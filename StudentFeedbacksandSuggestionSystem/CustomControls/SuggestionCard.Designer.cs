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
            this.messageLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.authorText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.datePosted = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoEllipsis = true;
            this.messageLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.messageLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.messageLabel.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(0, 0);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(600, 137);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "Message";
            this.messageLabel.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.messageLabel);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 239);
            this.panel2.TabIndex = 3;
            this.panel2.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // authorText
            // 
            this.authorText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorText.Dock = System.Windows.Forms.DockStyle.Right;
            this.authorText.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorText.Location = new System.Drawing.Point(289, 0);
            this.authorText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(311, 70);
            this.authorText.TabIndex = 1;
            this.authorText.Text = "Author";
            this.authorText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.authorText.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 53);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 300);
            this.panel3.TabIndex = 4;
            this.panel3.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.datePosted);
            this.panel4.Controls.Add(this.authorText);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 169);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 70);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "TItle";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datePosted
            // 
            this.datePosted.Dock = System.Windows.Forms.DockStyle.Left;
            this.datePosted.Location = new System.Drawing.Point(0, 0);
            this.datePosted.Name = "datePosted";
            this.datePosted.Size = new System.Drawing.Size(171, 70);
            this.datePosted.TabIndex = 3;
            this.datePosted.Text = "label2";
            this.datePosted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SuggestionCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SuggestionCard";
            this.Text = "SuggestionCard";
            this.Click += new System.EventHandler(this.customButton1_Click);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label authorText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datePosted;
    }
}