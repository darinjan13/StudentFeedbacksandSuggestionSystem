namespace StudentFeedbacksandSuggestionSystem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.greetingslbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.firstnameTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.lastnameTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.ageTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.emailTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.passwordTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.usernameTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.registerBtn = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.updateBtn = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.deleteBtn = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.IDTxt = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.genderComboBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomComboBox();
            this.roleComboBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // greetingslbl
            // 
            this.greetingslbl.AutoSize = true;
            this.greetingslbl.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingslbl.Location = new System.Drawing.Point(540, 41);
            this.greetingslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greetingslbl.Name = "greetingslbl";
            this.greetingslbl.Size = new System.Drawing.Size(265, 31);
            this.greetingslbl.TabIndex = 0;
            this.greetingslbl.Text = "WELCOME ADMIN!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(27, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Size = new System.Drawing.Size(1373, 368);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 302);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panel1.Size = new System.Drawing.Size(1427, 418);
            this.panel1.TabIndex = 3;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.logoutButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.logoutButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.logoutButton.BorderRadius = 0;
            this.logoutButton.BorderSize = 0;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(1200, 15);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(200, 49);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextColor = System.Drawing.Color.White;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // firstnameTxtBox
            // 
            this.firstnameTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.firstnameTxtBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.firstnameTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.firstnameTxtBox.BorderRadius = 0;
            this.firstnameTxtBox.BorderSize = 2;
            this.firstnameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.firstnameTxtBox.Location = new System.Drawing.Point(27, 95);
            this.firstnameTxtBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.firstnameTxtBox.Multiline = false;
            this.firstnameTxtBox.Name = "firstnameTxtBox";
            this.firstnameTxtBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.firstnameTxtBox.PasswordChar = false;
            this.firstnameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.firstnameTxtBox.PlaceholderText = "First Name";
            this.firstnameTxtBox.Size = new System.Drawing.Size(249, 39);
            this.firstnameTxtBox.TabIndex = 9;
            this.firstnameTxtBox.Texts = "";
            this.firstnameTxtBox.UnderlinedStyle = false;
            // 
            // lastnameTxtBox
            // 
            this.lastnameTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.lastnameTxtBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.lastnameTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lastnameTxtBox.BorderRadius = 0;
            this.lastnameTxtBox.BorderSize = 2;
            this.lastnameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.lastnameTxtBox.Location = new System.Drawing.Point(287, 95);
            this.lastnameTxtBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lastnameTxtBox.Multiline = false;
            this.lastnameTxtBox.Name = "lastnameTxtBox";
            this.lastnameTxtBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.lastnameTxtBox.PasswordChar = false;
            this.lastnameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lastnameTxtBox.PlaceholderText = "Last Name";
            this.lastnameTxtBox.Size = new System.Drawing.Size(249, 39);
            this.lastnameTxtBox.TabIndex = 10;
            this.lastnameTxtBox.Texts = "";
            this.lastnameTxtBox.UnderlinedStyle = false;
            // 
            // ageTxtBox
            // 
            this.ageTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.ageTxtBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ageTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ageTxtBox.BorderRadius = 0;
            this.ageTxtBox.BorderSize = 2;
            this.ageTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTxtBox.ForeColor = System.Drawing.Color.Black;
            this.ageTxtBox.Location = new System.Drawing.Point(547, 95);
            this.ageTxtBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ageTxtBox.Multiline = false;
            this.ageTxtBox.Name = "ageTxtBox";
            this.ageTxtBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.ageTxtBox.PasswordChar = false;
            this.ageTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ageTxtBox.PlaceholderText = "Age";
            this.ageTxtBox.Size = new System.Drawing.Size(249, 39);
            this.ageTxtBox.TabIndex = 11;
            this.ageTxtBox.Texts = "";
            this.ageTxtBox.UnderlinedStyle = false;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailTxtBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.emailTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.emailTxtBox.BorderRadius = 0;
            this.emailTxtBox.BorderSize = 2;
            this.emailTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxtBox.ForeColor = System.Drawing.Color.Black;
            this.emailTxtBox.Location = new System.Drawing.Point(807, 95);
            this.emailTxtBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.emailTxtBox.Multiline = false;
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.emailTxtBox.PasswordChar = false;
            this.emailTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.emailTxtBox.PlaceholderText = "Email";
            this.emailTxtBox.Size = new System.Drawing.Size(249, 39);
            this.emailTxtBox.TabIndex = 12;
            this.emailTxtBox.Texts = "";
            this.emailTxtBox.UnderlinedStyle = false;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTxtBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.passwordTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passwordTxtBox.BorderRadius = 0;
            this.passwordTxtBox.BorderSize = 2;
            this.passwordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTxtBox.Location = new System.Drawing.Point(287, 143);
            this.passwordTxtBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.passwordTxtBox.Multiline = false;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.passwordTxtBox.PasswordChar = false;
            this.passwordTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passwordTxtBox.PlaceholderText = "Password";
            this.passwordTxtBox.Size = new System.Drawing.Size(249, 39);
            this.passwordTxtBox.TabIndex = 14;
            this.passwordTxtBox.Texts = "";
            this.passwordTxtBox.UnderlinedStyle = false;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameTxtBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.usernameTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.usernameTxtBox.BorderRadius = 0;
            this.usernameTxtBox.BorderSize = 2;
            this.usernameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.usernameTxtBox.Location = new System.Drawing.Point(27, 143);
            this.usernameTxtBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.usernameTxtBox.Multiline = false;
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.usernameTxtBox.PasswordChar = false;
            this.usernameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.usernameTxtBox.PlaceholderText = "Username";
            this.usernameTxtBox.Size = new System.Drawing.Size(249, 39);
            this.usernameTxtBox.TabIndex = 13;
            this.usernameTxtBox.Texts = "";
            this.usernameTxtBox.UnderlinedStyle = false;
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.registerBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.registerBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.registerBtn.BorderRadius = 0;
            this.registerBtn.BorderSize = 0;
            this.registerBtn.FlatAppearance.BorderSize = 0;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(271, 255);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(175, 40);
            this.registerBtn.TabIndex = 17;
            this.registerBtn.Text = "Register";
            this.registerBtn.TextColor = System.Drawing.Color.White;
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.updateBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.updateBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateBtn.BorderRadius = 0;
            this.updateBtn.BorderSize = 0;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(452, 255);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(175, 40);
            this.updateBtn.TabIndex = 18;
            this.updateBtn.Text = "Update";
            this.updateBtn.TextColor = System.Drawing.Color.White;
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.deleteBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.deleteBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteBtn.BorderRadius = 0;
            this.deleteBtn.BorderSize = 0;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(630, 255);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(175, 40);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextColor = System.Drawing.Color.White;
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // IDTxt
            // 
            this.IDTxt.BackColor = System.Drawing.SystemColors.Window;
            this.IDTxt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.IDTxt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.IDTxt.BorderRadius = 0;
            this.IDTxt.BorderSize = 2;
            this.IDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTxt.ForeColor = System.Drawing.Color.Black;
            this.IDTxt.Location = new System.Drawing.Point(27, 191);
            this.IDTxt.Margin = new System.Windows.Forms.Padding(4);
            this.IDTxt.Multiline = false;
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.IDTxt.PasswordChar = false;
            this.IDTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.IDTxt.PlaceholderText = "ID";
            this.IDTxt.Size = new System.Drawing.Size(250, 35);
            this.IDTxt.TabIndex = 100;
            this.IDTxt.Texts = "";
            this.IDTxt.UnderlinedStyle = false;
            this.IDTxt.Visible = false;
            // 
            // genderComboBox
            // 
            this.genderComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.genderComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.genderComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.genderComboBox.BorderSize = 1;
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.genderComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.genderComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.genderComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.genderComboBox.Location = new System.Drawing.Point(547, 143);
            this.genderComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.genderComboBox.Size = new System.Drawing.Size(249, 39);
            this.genderComboBox.TabIndex = 15;
            this.genderComboBox.Texts = "Male";
            // 
            // roleComboBox
            // 
            this.roleComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Student",
            "Admin"});
            this.roleComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roleComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.roleComboBox.BorderSize = 1;
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.roleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roleComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.roleComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.roleComboBox.Items.AddRange(new object[] {
            "Student",
            "Admin"});
            this.roleComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.roleComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.roleComboBox.Location = new System.Drawing.Point(807, 143);
            this.roleComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.roleComboBox.Size = new System.Drawing.Size(249, 39);
            this.roleComboBox.TabIndex = 16;
            this.roleComboBox.Texts = "Student";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 720);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.ageTxtBox);
            this.Controls.Add(this.lastnameTxtBox);
            this.Controls.Add(this.firstnameTxtBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.greetingslbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetingslbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.CustomButton logoutButton;
        private CustomControls.CustomTextBox firstnameTxtBox;
        private CustomControls.CustomTextBox lastnameTxtBox;
        private CustomControls.CustomTextBox ageTxtBox;
        private CustomControls.CustomTextBox emailTxtBox;
        private CustomControls.CustomTextBox passwordTxtBox;
        private CustomControls.CustomTextBox usernameTxtBox;
        private CustomControls.CustomButton registerBtn;
        private CustomControls.CustomButton updateBtn;
        private CustomControls.CustomButton deleteBtn;
        private CustomControls.CustomTextBox IDTxt;
        private CustomControls.CustomComboBox genderComboBox;
        private CustomControls.CustomComboBox roleComboBox;
    }
}