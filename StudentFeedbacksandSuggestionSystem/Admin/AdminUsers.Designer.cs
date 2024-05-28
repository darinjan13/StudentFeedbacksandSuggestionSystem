namespace StudentFeedbacksandSuggestionSystem
{
    partial class AdminUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printUsers = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.deleteBtn = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.registerBtn = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updateBtn = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.roleComboBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomComboBox();
            this.genderComboBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomComboBox();
            this.IDTxt = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.passwordTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.usernameTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.emailTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.ageTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.lastnameTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.firstnameTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.printUsers);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.registerBtn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 110);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panel1.Size = new System.Drawing.Size(1333, 505);
            this.panel1.TabIndex = 3;
            // 
            // printUsers
            // 
            this.printUsers.BackColor = System.Drawing.Color.PowderBlue;
            this.printUsers.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.printUsers.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.printUsers.BorderRadius = 0;
            this.printUsers.BorderSize = 0;
            this.printUsers.FlatAppearance.BorderSize = 0;
            this.printUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printUsers.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.printUsers.ForeColor = System.Drawing.Color.Black;
            this.printUsers.Location = new System.Drawing.Point(894, 9);
            this.printUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printUsers.Name = "printUsers";
            this.printUsers.Size = new System.Drawing.Size(175, 39);
            this.printUsers.TabIndex = 22;
            this.printUsers.Text = "Print Users";
            this.printUsers.TextColor = System.Drawing.Color.Black;
            this.printUsers.UseVisualStyleBackColor = false;
            this.printUsers.Click += new System.EventHandler(this.printUsers_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.deleteBtn.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.deleteBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteBtn.BorderRadius = 0;
            this.deleteBtn.BorderSize = 0;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(713, 9);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(175, 39);
            this.deleteBtn.TabIndex = 21;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextColor = System.Drawing.Color.Black;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.registerBtn.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.registerBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.registerBtn.BorderRadius = 0;
            this.registerBtn.BorderSize = 0;
            this.registerBtn.FlatAppearance.BorderSize = 0;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.registerBtn.ForeColor = System.Drawing.Color.Black;
            this.registerBtn.Location = new System.Drawing.Point(351, 9);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(175, 39);
            this.registerBtn.TabIndex = 20;
            this.registerBtn.Text = "Register";
            this.registerBtn.TextColor = System.Drawing.Color.Black;
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Pink;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Pink;
            this.dataGridView1.Location = new System.Drawing.Point(27, 93);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(1279, 387);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.updateBtn.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.updateBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateBtn.BorderRadius = 0;
            this.updateBtn.BorderSize = 0;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.Location = new System.Drawing.Point(532, 9);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(175, 39);
            this.updateBtn.TabIndex = 18;
            this.updateBtn.Text = "Update";
            this.updateBtn.TextColor = System.Drawing.Color.Black;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // roleComboBox
            // 
            this.roleComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Student",
            "Admin"});
            this.roleComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roleComboBox.BorderColor = System.Drawing.Color.PowderBlue;
            this.roleComboBox.BorderSize = 1;
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.roleComboBox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.roleComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.roleComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.roleComboBox.Items.AddRange(new object[] {
            "Student",
            "Admin"});
            this.roleComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.roleComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.roleComboBox.Location = new System.Drawing.Point(797, 64);
            this.roleComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roleComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.roleComboBox.Size = new System.Drawing.Size(249, 39);
            this.roleComboBox.TabIndex = 16;
            this.roleComboBox.Texts = "Student";
            // 
            // genderComboBox
            // 
            this.genderComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.genderComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.genderComboBox.BorderColor = System.Drawing.Color.PowderBlue;
            this.genderComboBox.BorderSize = 1;
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.genderComboBox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.genderComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.genderComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.genderComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.genderComboBox.Location = new System.Drawing.Point(537, 64);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genderComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.genderComboBox.Size = new System.Drawing.Size(249, 39);
            this.genderComboBox.TabIndex = 15;
            this.genderComboBox.Texts = "Male";
            // 
            // IDTxt
            // 
            this.IDTxt.BackColor = System.Drawing.SystemColors.Window;
            this.IDTxt.BorderColor = System.Drawing.Color.PowderBlue;
            this.IDTxt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.IDTxt.BorderRadius = 0;
            this.IDTxt.BorderSize = 2;
            this.IDTxt.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.IDTxt.ForeColor = System.Drawing.Color.Black;
            this.IDTxt.IsReadOnly = false;
            this.IDTxt.Location = new System.Drawing.Point(1065, 18);
            this.IDTxt.Margin = new System.Windows.Forms.Padding(5);
            this.IDTxt.Multiline = false;
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.IDTxt.PasswordChar = false;
            this.IDTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.IDTxt.PlaceholderText = "ID";
            this.IDTxt.Size = new System.Drawing.Size(251, 36);
            this.IDTxt.TabIndex = 100;
            this.IDTxt.Texts = "";
            this.IDTxt.UnderlinedStyle = false;
            this.IDTxt.Visible = false;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTxtBox.BorderColor = System.Drawing.Color.PowderBlue;
            this.passwordTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passwordTxtBox.BorderRadius = 0;
            this.passwordTxtBox.BorderSize = 2;
            this.passwordTxtBox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.passwordTxtBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTxtBox.IsReadOnly = false;
            this.passwordTxtBox.Location = new System.Drawing.Point(277, 64);
            this.passwordTxtBox.Margin = new System.Windows.Forms.Padding(5);
            this.passwordTxtBox.Multiline = false;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.passwordTxtBox.PasswordChar = true;
            this.passwordTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passwordTxtBox.PlaceholderText = "Password";
            this.passwordTxtBox.Size = new System.Drawing.Size(249, 40);
            this.passwordTxtBox.TabIndex = 14;
            this.passwordTxtBox.Texts = "";
            this.passwordTxtBox.UnderlinedStyle = false;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameTxtBox.BorderColor = System.Drawing.Color.PowderBlue;
            this.usernameTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.usernameTxtBox.BorderRadius = 0;
            this.usernameTxtBox.BorderSize = 2;
            this.usernameTxtBox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.usernameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.usernameTxtBox.IsReadOnly = false;
            this.usernameTxtBox.Location = new System.Drawing.Point(17, 64);
            this.usernameTxtBox.Margin = new System.Windows.Forms.Padding(5);
            this.usernameTxtBox.Multiline = false;
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.usernameTxtBox.PasswordChar = false;
            this.usernameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.usernameTxtBox.PlaceholderText = "Username";
            this.usernameTxtBox.Size = new System.Drawing.Size(249, 40);
            this.usernameTxtBox.TabIndex = 13;
            this.usernameTxtBox.Texts = "";
            this.usernameTxtBox.UnderlinedStyle = false;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailTxtBox.BorderColor = System.Drawing.Color.PowderBlue;
            this.emailTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.emailTxtBox.BorderRadius = 0;
            this.emailTxtBox.BorderSize = 2;
            this.emailTxtBox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.emailTxtBox.ForeColor = System.Drawing.Color.Black;
            this.emailTxtBox.IsReadOnly = false;
            this.emailTxtBox.Location = new System.Drawing.Point(797, 16);
            this.emailTxtBox.Margin = new System.Windows.Forms.Padding(5);
            this.emailTxtBox.Multiline = false;
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.emailTxtBox.PasswordChar = false;
            this.emailTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.emailTxtBox.PlaceholderText = "Email";
            this.emailTxtBox.Size = new System.Drawing.Size(249, 40);
            this.emailTxtBox.TabIndex = 12;
            this.emailTxtBox.Texts = "";
            this.emailTxtBox.UnderlinedStyle = false;
            // 
            // ageTxtBox
            // 
            this.ageTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.ageTxtBox.BorderColor = System.Drawing.Color.PowderBlue;
            this.ageTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ageTxtBox.BorderRadius = 0;
            this.ageTxtBox.BorderSize = 2;
            this.ageTxtBox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.ageTxtBox.ForeColor = System.Drawing.Color.Black;
            this.ageTxtBox.IsReadOnly = false;
            this.ageTxtBox.Location = new System.Drawing.Point(537, 16);
            this.ageTxtBox.Margin = new System.Windows.Forms.Padding(5);
            this.ageTxtBox.Multiline = false;
            this.ageTxtBox.Name = "ageTxtBox";
            this.ageTxtBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.ageTxtBox.PasswordChar = false;
            this.ageTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ageTxtBox.PlaceholderText = "Age";
            this.ageTxtBox.Size = new System.Drawing.Size(249, 40);
            this.ageTxtBox.TabIndex = 11;
            this.ageTxtBox.Texts = "";
            this.ageTxtBox.UnderlinedStyle = false;
            // 
            // lastnameTxtBox
            // 
            this.lastnameTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.lastnameTxtBox.BorderColor = System.Drawing.Color.PowderBlue;
            this.lastnameTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lastnameTxtBox.BorderRadius = 0;
            this.lastnameTxtBox.BorderSize = 2;
            this.lastnameTxtBox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lastnameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.lastnameTxtBox.IsReadOnly = false;
            this.lastnameTxtBox.Location = new System.Drawing.Point(277, 16);
            this.lastnameTxtBox.Margin = new System.Windows.Forms.Padding(5);
            this.lastnameTxtBox.Multiline = false;
            this.lastnameTxtBox.Name = "lastnameTxtBox";
            this.lastnameTxtBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.lastnameTxtBox.PasswordChar = false;
            this.lastnameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lastnameTxtBox.PlaceholderText = "Last Name";
            this.lastnameTxtBox.Size = new System.Drawing.Size(249, 40);
            this.lastnameTxtBox.TabIndex = 10;
            this.lastnameTxtBox.Texts = "";
            this.lastnameTxtBox.UnderlinedStyle = false;
            // 
            // firstnameTxtBox
            // 
            this.firstnameTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.firstnameTxtBox.BorderColor = System.Drawing.Color.PowderBlue;
            this.firstnameTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.firstnameTxtBox.BorderRadius = 0;
            this.firstnameTxtBox.BorderSize = 2;
            this.firstnameTxtBox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.firstnameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.firstnameTxtBox.IsReadOnly = false;
            this.firstnameTxtBox.Location = new System.Drawing.Point(17, 16);
            this.firstnameTxtBox.Margin = new System.Windows.Forms.Padding(5);
            this.firstnameTxtBox.Multiline = false;
            this.firstnameTxtBox.Name = "firstnameTxtBox";
            this.firstnameTxtBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.firstnameTxtBox.PasswordChar = false;
            this.firstnameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.firstnameTxtBox.PlaceholderText = "First Name";
            this.firstnameTxtBox.Size = new System.Drawing.Size(249, 40);
            this.firstnameTxtBox.TabIndex = 9;
            this.firstnameTxtBox.Texts = "";
            this.firstnameTxtBox.UnderlinedStyle = false;
            // 
            // AdminUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::StudentFeedbacksandSuggestionSystem.Properties.Resources.MainBackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1333, 615);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.ageTxtBox);
            this.Controls.Add(this.lastnameTxtBox);
            this.Controls.Add(this.firstnameTxtBox);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminUsers";
            this.Text = "Admin Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashboard_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private CustomControls.CustomTextBox firstnameTxtBox;
        private CustomControls.CustomTextBox lastnameTxtBox;
        private CustomControls.CustomTextBox ageTxtBox;
        private CustomControls.CustomTextBox emailTxtBox;
        private CustomControls.CustomTextBox passwordTxtBox;
        private CustomControls.CustomTextBox usernameTxtBox;
        private CustomControls.CustomButton updateBtn;
        private CustomControls.CustomTextBox IDTxt;
        private CustomControls.CustomComboBox genderComboBox;
        private CustomControls.CustomComboBox roleComboBox;
        private CustomControls.CustomButton registerBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControls.CustomButton deleteBtn;
        private CustomControls.CustomButton printUsers;
    }
}