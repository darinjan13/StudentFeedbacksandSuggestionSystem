﻿namespace StudentFeedbacksandSuggestionSystem
{
    partial class LoginForm
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtusername = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.txtpassword = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar1.Location = new System.Drawing.Point(-1, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1444, 16);
            this.progressBar1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(362, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(665, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Student Suggestion Management System";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(592, 377);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.Transparent;
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.Color.Black;
            this.register.Location = new System.Drawing.Point(761, 441);
            this.register.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(85, 25);
            this.register.TabIndex = 11;
            this.register.Text = "Register?";
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(486, 441);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Don\'t have an account yet?";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.SystemColors.Window;
            this.txtusername.BorderColor = System.Drawing.Color.PowderBlue;
            this.txtusername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtusername.BorderRadius = 0;
            this.txtusername.BorderSize = 2;
            this.txtusername.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.IsReadOnly = false;
            this.txtusername.Location = new System.Drawing.Point(559, 268);
            this.txtusername.Margin = new System.Windows.Forms.Padding(5);
            this.txtusername.Multiline = false;
            this.txtusername.Name = "txtusername";
            this.txtusername.Padding = new System.Windows.Forms.Padding(9);
            this.txtusername.PasswordChar = false;
            this.txtusername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtusername.PlaceholderText = "Username";
            this.txtusername.Size = new System.Drawing.Size(263, 40);
            this.txtusername.TabIndex = 16;
            this.txtusername.Texts = "";
            this.txtusername.UnderlinedStyle = false;
            this.txtusername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtpassword.BorderColor = System.Drawing.Color.PowderBlue;
            this.txtpassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtpassword.BorderRadius = 0;
            this.txtpassword.BorderSize = 2;
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.IsReadOnly = false;
            this.txtpassword.Location = new System.Drawing.Point(559, 318);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtpassword.Multiline = false;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtpassword.PasswordChar = true;
            this.txtpassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtpassword.PlaceholderText = "Password";
            this.txtpassword.Size = new System.Drawing.Size(263, 40);
            this.txtpassword.TabIndex = 17;
            this.txtpassword.Texts = "";
            this.txtpassword.UnderlinedStyle = false;
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::StudentFeedbacksandSuggestionSystem.Properties.Resources.MainBackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1441, 709);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.register);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label register;
        private System.Windows.Forms.Label label5;
        private CustomControls.CustomTextBox txtusername;
        private CustomControls.CustomTextBox txtpassword;
    }
}

