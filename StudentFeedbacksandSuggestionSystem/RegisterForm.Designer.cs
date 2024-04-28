namespace StudentFeedbacksandSuggestionSystem
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginButton = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.firstNameTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.lastNameTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.ageTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.emailTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.register = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.userNameTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.passwordTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 100);
            this.label1.TabIndex = 13;
            this.label1.Text = "Student Registration Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(300, 0, 300, 0);
            this.panel1.Size = new System.Drawing.Size(1000, 100);
            this.panel1.TabIndex = 14;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.loginButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.loginButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.loginButton.BorderRadius = 0;
            this.loginButton.BorderSize = 0;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(359, 454);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(250, 40);
            this.loginButton.TabIndex = 15;
            this.loginButton.Text = "Login";
            this.loginButton.TextColor = System.Drawing.Color.White;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.firstNameTxtBox.BorderColor = System.Drawing.Color.Transparent;
            this.firstNameTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.firstNameTxtBox.BorderRadius = 0;
            this.firstNameTxtBox.BorderSize = 2;
            this.firstNameTxtBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.firstNameTxtBox.Location = new System.Drawing.Point(359, 151);
            this.firstNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTxtBox.Multiline = false;
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Padding = new System.Windows.Forms.Padding(7);
            this.firstNameTxtBox.PasswordChar = false;
            this.firstNameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.firstNameTxtBox.PlaceholderText = "First Name";
            this.firstNameTxtBox.Size = new System.Drawing.Size(250, 31);
            this.firstNameTxtBox.TabIndex = 7;
            this.firstNameTxtBox.Texts = "";
            this.firstNameTxtBox.UnderlinedStyle = false;
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.lastNameTxtBox.BorderColor = System.Drawing.Color.Transparent;
            this.lastNameTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lastNameTxtBox.BorderRadius = 0;
            this.lastNameTxtBox.BorderSize = 2;
            this.lastNameTxtBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.lastNameTxtBox.Location = new System.Drawing.Point(359, 190);
            this.lastNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTxtBox.Multiline = false;
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Padding = new System.Windows.Forms.Padding(7);
            this.lastNameTxtBox.PasswordChar = false;
            this.lastNameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lastNameTxtBox.PlaceholderText = "Last Name";
            this.lastNameTxtBox.Size = new System.Drawing.Size(250, 31);
            this.lastNameTxtBox.TabIndex = 8;
            this.lastNameTxtBox.Texts = "";
            this.lastNameTxtBox.UnderlinedStyle = false;
            // 
            // ageTxtBox
            // 
            this.ageTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.ageTxtBox.BorderColor = System.Drawing.Color.Transparent;
            this.ageTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ageTxtBox.BorderRadius = 0;
            this.ageTxtBox.BorderSize = 2;
            this.ageTxtBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTxtBox.ForeColor = System.Drawing.Color.Black;
            this.ageTxtBox.Location = new System.Drawing.Point(359, 229);
            this.ageTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.ageTxtBox.Multiline = false;
            this.ageTxtBox.Name = "ageTxtBox";
            this.ageTxtBox.Padding = new System.Windows.Forms.Padding(7);
            this.ageTxtBox.PasswordChar = false;
            this.ageTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ageTxtBox.PlaceholderText = "";
            this.ageTxtBox.Size = new System.Drawing.Size(250, 31);
            this.ageTxtBox.TabIndex = 9;
            this.ageTxtBox.Texts = "";
            this.ageTxtBox.UnderlinedStyle = false;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailTxtBox.BorderColor = System.Drawing.Color.Transparent;
            this.emailTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.emailTxtBox.BorderRadius = 0;
            this.emailTxtBox.BorderSize = 2;
            this.emailTxtBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxtBox.ForeColor = System.Drawing.Color.Black;
            this.emailTxtBox.Location = new System.Drawing.Point(359, 268);
            this.emailTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxtBox.Multiline = false;
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Padding = new System.Windows.Forms.Padding(7);
            this.emailTxtBox.PasswordChar = false;
            this.emailTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.emailTxtBox.PlaceholderText = "Email";
            this.emailTxtBox.Size = new System.Drawing.Size(250, 31);
            this.emailTxtBox.TabIndex = 10;
            this.emailTxtBox.Texts = "";
            this.emailTxtBox.UnderlinedStyle = false;
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.Transparent;
            this.register.BackgroundColor = System.Drawing.Color.Transparent;
            this.register.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.register.BorderRadius = 0;
            this.register.BorderSize = 1;
            this.register.FlatAppearance.BorderSize = 0;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.Color.White;
            this.register.Location = new System.Drawing.Point(358, 385);
            this.register.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(251, 40);
            this.register.TabIndex = 13;
            this.register.Text = "Register";
            this.register.TextColor = System.Drawing.Color.White;
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.userNameTxtBox.BorderColor = System.Drawing.Color.Transparent;
            this.userNameTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.userNameTxtBox.BorderRadius = 0;
            this.userNameTxtBox.BorderSize = 2;
            this.userNameTxtBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.userNameTxtBox.Location = new System.Drawing.Point(359, 307);
            this.userNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.userNameTxtBox.Multiline = false;
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Padding = new System.Windows.Forms.Padding(7);
            this.userNameTxtBox.PasswordChar = false;
            this.userNameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.userNameTxtBox.PlaceholderText = "Username";
            this.userNameTxtBox.Size = new System.Drawing.Size(250, 31);
            this.userNameTxtBox.TabIndex = 11;
            this.userNameTxtBox.Texts = "";
            this.userNameTxtBox.UnderlinedStyle = false;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTxtBox.BorderColor = System.Drawing.Color.Transparent;
            this.passwordTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passwordTxtBox.BorderRadius = 0;
            this.passwordTxtBox.BorderSize = 2;
            this.passwordTxtBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTxtBox.Location = new System.Drawing.Point(359, 346);
            this.passwordTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTxtBox.Multiline = false;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Padding = new System.Windows.Forms.Padding(7);
            this.passwordTxtBox.PasswordChar = true;
            this.passwordTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passwordTxtBox.PlaceholderText = "Password";
            this.passwordTxtBox.Size = new System.Drawing.Size(250, 31);
            this.passwordTxtBox.TabIndex = 12;
            this.passwordTxtBox.Texts = "";
            this.passwordTxtBox.UnderlinedStyle = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::StudentFeedbacksandSuggestionSystem.Properties.Resources.MainBackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.firstNameTxtBox);
            this.Controls.Add(this.lastNameTxtBox);
            this.Controls.Add(this.ageTxtBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.register);
            this.Controls.Add(this.userNameTxtBox);
            this.Controls.Add(this.passwordTxtBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Opacity = 0D;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.CustomButton register;
        private CustomControls.CustomTextBox passwordTxtBox;
        private CustomControls.CustomTextBox userNameTxtBox;
        private CustomControls.CustomTextBox emailTxtBox;
        private CustomControls.CustomTextBox ageTxtBox;
        private CustomControls.CustomTextBox lastNameTxtBox;
        private CustomControls.CustomTextBox firstNameTxtBox;
        private CustomControls.CustomButton loginButton;
    }
}