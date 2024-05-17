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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveEdit = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.email = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.username = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.editProfile = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.lastname = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.firstname = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentFeedbacksandSuggestionSystem.Properties.Resources.Profile;
            this.pictureBox1.Location = new System.Drawing.Point(327, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.saveEdit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.editProfile);
            this.panel1.Controls.Add(this.lastname);
            this.panel1.Controls.Add(this.firstname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // saveEdit
            // 
            this.saveEdit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.saveEdit.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.saveEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveEdit.BorderRadius = 0;
            this.saveEdit.BorderSize = 0;
            this.saveEdit.FlatAppearance.BorderSize = 0;
            this.saveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveEdit.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEdit.ForeColor = System.Drawing.Color.White;
            this.saveEdit.Location = new System.Drawing.Point(437, 334);
            this.saveEdit.Name = "saveEdit";
            this.saveEdit.Size = new System.Drawing.Size(90, 40);
            this.saveEdit.TabIndex = 8;
            this.saveEdit.Text = "Save";
            this.saveEdit.TextColor = System.Drawing.Color.White;
            this.saveEdit.UseVisualStyleBackColor = false;
            this.saveEdit.Click += new System.EventHandler(this.saveEdit_Click);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.email.BorderFocusColor = System.Drawing.Color.HotPink;
            this.email.BorderRadius = 0;
            this.email.BorderSize = 2;
            this.email.Enabled = false;
            this.email.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.Location = new System.Drawing.Point(327, 296);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Multiline = false;
            this.email.Name = "email";
            this.email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.email.PasswordChar = false;
            this.email.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.email.PlaceholderText = "";
            this.email.Size = new System.Drawing.Size(200, 31);
            this.email.TabIndex = 7;
            this.email.Texts = "";
            this.email.UnderlinedStyle = false;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.username.BorderFocusColor = System.Drawing.Color.HotPink;
            this.username.BorderRadius = 0;
            this.username.BorderSize = 2;
            this.username.Enabled = false;
            this.username.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.Location = new System.Drawing.Point(327, 257);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.username.PasswordChar = false;
            this.username.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.username.PlaceholderText = "";
            this.username.Size = new System.Drawing.Size(200, 31);
            this.username.TabIndex = 6;
            this.username.Texts = "";
            this.username.UnderlinedStyle = false;
            // 
            // editProfile
            // 
            this.editProfile.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.editProfile.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.editProfile.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editProfile.BorderRadius = 0;
            this.editProfile.BorderSize = 0;
            this.editProfile.FlatAppearance.BorderSize = 0;
            this.editProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProfile.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfile.ForeColor = System.Drawing.Color.White;
            this.editProfile.Location = new System.Drawing.Point(327, 334);
            this.editProfile.Name = "editProfile";
            this.editProfile.Size = new System.Drawing.Size(90, 40);
            this.editProfile.TabIndex = 5;
            this.editProfile.Text = "Edit Profile";
            this.editProfile.TextColor = System.Drawing.Color.White;
            this.editProfile.UseVisualStyleBackColor = false;
            this.editProfile.Click += new System.EventHandler(this.editProfile_Click);
            // 
            // lastname
            // 
            this.lastname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastname.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.lastname.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lastname.BorderRadius = 0;
            this.lastname.BorderSize = 2;
            this.lastname.Enabled = false;
            this.lastname.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.ForeColor = System.Drawing.Color.Black;
            this.lastname.Location = new System.Drawing.Point(327, 218);
            this.lastname.Margin = new System.Windows.Forms.Padding(4);
            this.lastname.Multiline = false;
            this.lastname.Name = "lastname";
            this.lastname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.lastname.PasswordChar = false;
            this.lastname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lastname.PlaceholderText = "";
            this.lastname.Size = new System.Drawing.Size(200, 31);
            this.lastname.TabIndex = 4;
            this.lastname.Texts = "";
            this.lastname.UnderlinedStyle = false;
            // 
            // firstname
            // 
            this.firstname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.firstname.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.firstname.BorderFocusColor = System.Drawing.Color.HotPink;
            this.firstname.BorderRadius = 0;
            this.firstname.BorderSize = 2;
            this.firstname.Enabled = false;
            this.firstname.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.ForeColor = System.Drawing.Color.Black;
            this.firstname.Location = new System.Drawing.Point(327, 179);
            this.firstname.Margin = new System.Windows.Forms.Padding(4);
            this.firstname.Multiline = false;
            this.firstname.Name = "firstname";
            this.firstname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.firstname.PasswordChar = false;
            this.firstname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.firstname.PlaceholderText = "";
            this.firstname.Size = new System.Drawing.Size(200, 31);
            this.firstname.TabIndex = 3;
            this.firstname.Texts = "";
            this.firstname.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "First name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Last name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.CustomTextBox email;
        private CustomControls.CustomTextBox username;
        private CustomControls.CustomButton editProfile;
        private CustomControls.CustomTextBox lastname;
        private CustomControls.CustomTextBox firstname;
        private CustomControls.CustomButton saveEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}