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
            this.components = new System.ComponentModel.Container();
            this.suggestionsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayout1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.latestSuggestionsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayout1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // suggestionsLayout
            // 
            this.suggestionsLayout.AutoScroll = true;
            this.suggestionsLayout.BackColor = System.Drawing.Color.Transparent;
            this.suggestionsLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.suggestionsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suggestionsLayout.Location = new System.Drawing.Point(0, 0);
            this.suggestionsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.suggestionsLayout.Name = "suggestionsLayout";
            this.suggestionsLayout.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.suggestionsLayout.Size = new System.Drawing.Size(900, 550);
            this.suggestionsLayout.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel1.Size = new System.Drawing.Size(1306, 576);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.suggestionsLayout);
            this.panel5.Controls.Add(this.flowLayout1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(13, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1278, 550);
            this.panel5.TabIndex = 11;
            // 
            // flowLayout1
            // 
            this.flowLayout1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayout1.Controls.Add(this.panel2);
            this.flowLayout1.Controls.Add(this.panel3);
            this.flowLayout1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayout1.Location = new System.Drawing.Point(900, 0);
            this.flowLayout1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayout1.Name = "flowLayout1";
            this.flowLayout1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.flowLayout1.Size = new System.Drawing.Size(378, 550);
            this.flowLayout1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.latestSuggestionsLayout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(13, 86);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 450);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(13, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 74);
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
            this.label1.Size = new System.Drawing.Size(350, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Most Up Votes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // latestSuggestionsLayout
            // 
            this.latestSuggestionsLayout.AutoScroll = true;
            this.latestSuggestionsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.latestSuggestionsLayout.Location = new System.Drawing.Point(0, 0);
            this.latestSuggestionsLayout.Name = "latestSuggestionsLayout";
            this.latestSuggestionsLayout.Size = new System.Drawing.Size(350, 450);
            this.latestSuggestionsLayout.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1332, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.flowLayout1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel suggestionsLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel flowLayout1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel latestSuggestionsLayout;
    }
}