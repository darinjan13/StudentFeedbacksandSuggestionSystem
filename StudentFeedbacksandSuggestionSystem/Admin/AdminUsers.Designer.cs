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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roleComboBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomComboBox();
            this.genderComboBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomComboBox();
            this.IDTxt = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.passwordTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.usernameTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.emailTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.ageTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.lastnameTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.firstnameTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.updateBtn = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.registerBtn = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.deleteBtn = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(20, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(960, 346);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.registerBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1000, 410);
            this.panel1.TabIndex = 3;
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
            this.roleComboBox.Location = new System.Drawing.Point(598, 52);
            this.roleComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.roleComboBox.MinimumSize = new System.Drawing.Size(150, 24);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.roleComboBox.Size = new System.Drawing.Size(187, 32);
            this.roleComboBox.TabIndex = 16;
            this.roleComboBox.Texts = "Student";
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
            this.genderComboBox.Location = new System.Drawing.Point(403, 52);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.genderComboBox.MinimumSize = new System.Drawing.Size(150, 24);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.genderComboBox.Size = new System.Drawing.Size(187, 32);
            this.genderComboBox.TabIndex = 15;
            this.genderComboBox.Texts = "Male";
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
            this.IDTxt.Location = new System.Drawing.Point(799, 15);
            this.IDTxt.Margin = new System.Windows.Forms.Padding(4);
            this.IDTxt.Multiline = false;
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.IDTxt.PasswordChar = false;
            this.IDTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.IDTxt.PlaceholderText = "ID";
            this.IDTxt.Size = new System.Drawing.Size(188, 29);
            this.IDTxt.TabIndex = 100;
            this.IDTxt.Texts = "";
            this.IDTxt.UnderlinedStyle = false;
            this.IDTxt.Visible = false;
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
            this.passwordTxtBox.Location = new System.Drawing.Point(208, 52);
            this.passwordTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTxtBox.Multiline = false;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.passwordTxtBox.PasswordChar = true;
            this.passwordTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passwordTxtBox.PlaceholderText = "Password";
            this.passwordTxtBox.Size = new System.Drawing.Size(187, 31);
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
            this.usernameTxtBox.Location = new System.Drawing.Point(13, 52);
            this.usernameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTxtBox.Multiline = false;
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.usernameTxtBox.PasswordChar = false;
            this.usernameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.usernameTxtBox.PlaceholderText = "Username";
            this.usernameTxtBox.Size = new System.Drawing.Size(187, 31);
            this.usernameTxtBox.TabIndex = 13;
            this.usernameTxtBox.Texts = "";
            this.usernameTxtBox.UnderlinedStyle = false;
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
            this.emailTxtBox.Location = new System.Drawing.Point(598, 13);
            this.emailTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxtBox.Multiline = false;
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.emailTxtBox.PasswordChar = false;
            this.emailTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.emailTxtBox.PlaceholderText = "Email";
            this.emailTxtBox.Size = new System.Drawing.Size(187, 31);
            this.emailTxtBox.TabIndex = 12;
            this.emailTxtBox.Texts = "";
            this.emailTxtBox.UnderlinedStyle = false;
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
            this.ageTxtBox.Location = new System.Drawing.Point(403, 13);
            this.ageTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.ageTxtBox.Multiline = false;
            this.ageTxtBox.Name = "ageTxtBox";
            this.ageTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ageTxtBox.PasswordChar = false;
            this.ageTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ageTxtBox.PlaceholderText = "Age";
            this.ageTxtBox.Size = new System.Drawing.Size(187, 31);
            this.ageTxtBox.TabIndex = 11;
            this.ageTxtBox.Texts = "";
            this.ageTxtBox.UnderlinedStyle = false;
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
            this.lastnameTxtBox.Location = new System.Drawing.Point(208, 13);
            this.lastnameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastnameTxtBox.Multiline = false;
            this.lastnameTxtBox.Name = "lastnameTxtBox";
            this.lastnameTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.lastnameTxtBox.PasswordChar = false;
            this.lastnameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lastnameTxtBox.PlaceholderText = "Last Name";
            this.lastnameTxtBox.Size = new System.Drawing.Size(187, 31);
            this.lastnameTxtBox.TabIndex = 10;
            this.lastnameTxtBox.Texts = "";
            this.lastnameTxtBox.UnderlinedStyle = false;
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
            this.firstnameTxtBox.Location = new System.Drawing.Point(13, 13);
            this.firstnameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstnameTxtBox.Multiline = false;
            this.firstnameTxtBox.Name = "firstnameTxtBox";
            this.firstnameTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.firstnameTxtBox.PasswordChar = false;
            this.firstnameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.firstnameTxtBox.PlaceholderText = "First Name";
            this.firstnameTxtBox.Size = new System.Drawing.Size(187, 31);
            this.firstnameTxtBox.TabIndex = 9;
            this.firstnameTxtBox.Texts = "";
            this.firstnameTxtBox.UnderlinedStyle = false;
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
            this.updateBtn.Location = new System.Drawing.Point(399, 7);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(131, 32);
            this.updateBtn.TabIndex = 18;
            this.updateBtn.Text = "Update";
            this.updateBtn.TextColor = System.Drawing.Color.White;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
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
            this.registerBtn.Location = new System.Drawing.Point(264, 7);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(131, 32);
            this.registerBtn.TabIndex = 17;
            this.registerBtn.Text = "Register";
            this.registerBtn.TextColor = System.Drawing.Color.White;
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
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
            this.deleteBtn.Location = new System.Drawing.Point(534, 7);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(131, 32);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextColor = System.Drawing.Color.White;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // AdminUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUsers";
            this.Text = "Admin Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashboard_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
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