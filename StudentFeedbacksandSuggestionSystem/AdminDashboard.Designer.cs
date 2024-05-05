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
            this.customTextBox1 = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.customTextBox2 = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.customTextBox3 = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.customTextBox4 = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.customTextBox5 = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.customTextBox6 = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.customTextBox7 = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.customTextBox8 = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // greetingslbl
            // 
            this.greetingslbl.AutoSize = true;
            this.greetingslbl.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingslbl.Location = new System.Drawing.Point(405, 33);
            this.greetingslbl.Name = "greetingslbl";
            this.greetingslbl.Size = new System.Drawing.Size(206, 25);
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 300);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 245);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1070, 340);
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
            this.logoutButton.Location = new System.Drawing.Point(900, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(150, 40);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextColor = System.Drawing.Color.White;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox1.BorderRadius = 0;
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox1.ForeColor = System.Drawing.Color.Black;
            this.customTextBox1.Location = new System.Drawing.Point(20, 77);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "First Name";
            this.customTextBox1.Size = new System.Drawing.Size(187, 31);
            this.customTextBox1.TabIndex = 9;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // customTextBox2
            // 
            this.customTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox2.BorderRadius = 0;
            this.customTextBox2.BorderSize = 2;
            this.customTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox2.ForeColor = System.Drawing.Color.Black;
            this.customTextBox2.Location = new System.Drawing.Point(215, 77);
            this.customTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox2.Multiline = false;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox2.PasswordChar = false;
            this.customTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox2.PlaceholderText = "Last Name";
            this.customTextBox2.Size = new System.Drawing.Size(187, 31);
            this.customTextBox2.TabIndex = 10;
            this.customTextBox2.Texts = "";
            this.customTextBox2.UnderlinedStyle = false;
            // 
            // customTextBox3
            // 
            this.customTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox3.BorderRadius = 0;
            this.customTextBox3.BorderSize = 2;
            this.customTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox3.ForeColor = System.Drawing.Color.Black;
            this.customTextBox3.Location = new System.Drawing.Point(410, 77);
            this.customTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox3.Multiline = false;
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox3.PasswordChar = false;
            this.customTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox3.PlaceholderText = "Age";
            this.customTextBox3.Size = new System.Drawing.Size(187, 31);
            this.customTextBox3.TabIndex = 11;
            this.customTextBox3.Texts = "";
            this.customTextBox3.UnderlinedStyle = false;
            // 
            // customTextBox4
            // 
            this.customTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox4.BorderRadius = 0;
            this.customTextBox4.BorderSize = 2;
            this.customTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox4.ForeColor = System.Drawing.Color.Black;
            this.customTextBox4.Location = new System.Drawing.Point(605, 77);
            this.customTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox4.Multiline = false;
            this.customTextBox4.Name = "customTextBox4";
            this.customTextBox4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox4.PasswordChar = false;
            this.customTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox4.PlaceholderText = "Email";
            this.customTextBox4.Size = new System.Drawing.Size(187, 31);
            this.customTextBox4.TabIndex = 12;
            this.customTextBox4.Texts = "";
            this.customTextBox4.UnderlinedStyle = false;
            // 
            // customTextBox5
            // 
            this.customTextBox5.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox5.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox5.BorderRadius = 0;
            this.customTextBox5.BorderSize = 2;
            this.customTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox5.ForeColor = System.Drawing.Color.Black;
            this.customTextBox5.Location = new System.Drawing.Point(605, 116);
            this.customTextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox5.Multiline = false;
            this.customTextBox5.Name = "customTextBox5";
            this.customTextBox5.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox5.PasswordChar = false;
            this.customTextBox5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox5.PlaceholderText = "Role";
            this.customTextBox5.Size = new System.Drawing.Size(187, 31);
            this.customTextBox5.TabIndex = 16;
            this.customTextBox5.Texts = "";
            this.customTextBox5.UnderlinedStyle = false;
            // 
            // customTextBox6
            // 
            this.customTextBox6.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox6.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox6.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox6.BorderRadius = 0;
            this.customTextBox6.BorderSize = 2;
            this.customTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox6.ForeColor = System.Drawing.Color.Black;
            this.customTextBox6.Location = new System.Drawing.Point(410, 116);
            this.customTextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox6.Multiline = false;
            this.customTextBox6.Name = "customTextBox6";
            this.customTextBox6.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox6.PasswordChar = false;
            this.customTextBox6.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox6.PlaceholderText = "Gender";
            this.customTextBox6.Size = new System.Drawing.Size(187, 31);
            this.customTextBox6.TabIndex = 15;
            this.customTextBox6.Texts = "";
            this.customTextBox6.UnderlinedStyle = false;
            // 
            // customTextBox7
            // 
            this.customTextBox7.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox7.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox7.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox7.BorderRadius = 0;
            this.customTextBox7.BorderSize = 2;
            this.customTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox7.ForeColor = System.Drawing.Color.Black;
            this.customTextBox7.Location = new System.Drawing.Point(215, 116);
            this.customTextBox7.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox7.Multiline = false;
            this.customTextBox7.Name = "customTextBox7";
            this.customTextBox7.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox7.PasswordChar = false;
            this.customTextBox7.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox7.PlaceholderText = "Password";
            this.customTextBox7.Size = new System.Drawing.Size(187, 31);
            this.customTextBox7.TabIndex = 14;
            this.customTextBox7.Texts = "";
            this.customTextBox7.UnderlinedStyle = false;
            // 
            // customTextBox8
            // 
            this.customTextBox8.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox8.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox8.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox8.BorderRadius = 0;
            this.customTextBox8.BorderSize = 2;
            this.customTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox8.ForeColor = System.Drawing.Color.Black;
            this.customTextBox8.Location = new System.Drawing.Point(20, 116);
            this.customTextBox8.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox8.Multiline = false;
            this.customTextBox8.Name = "customTextBox8";
            this.customTextBox8.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox8.PasswordChar = false;
            this.customTextBox8.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox8.PlaceholderText = "Username";
            this.customTextBox8.Size = new System.Drawing.Size(187, 31);
            this.customTextBox8.TabIndex = 13;
            this.customTextBox8.Texts = "";
            this.customTextBox8.UnderlinedStyle = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 585);
            this.Controls.Add(this.customTextBox5);
            this.Controls.Add(this.customTextBox6);
            this.Controls.Add(this.customTextBox7);
            this.Controls.Add(this.customTextBox8);
            this.Controls.Add(this.customTextBox4);
            this.Controls.Add(this.customTextBox3);
            this.Controls.Add(this.customTextBox2);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.greetingslbl);
            this.Name = "AdminDashboard";
            this.Text = "Stock";
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
        private CustomControls.CustomTextBox customTextBox1;
        private CustomControls.CustomTextBox customTextBox2;
        private CustomControls.CustomTextBox customTextBox3;
        private CustomControls.CustomTextBox customTextBox4;
        private CustomControls.CustomTextBox customTextBox5;
        private CustomControls.CustomTextBox customTextBox6;
        private CustomControls.CustomTextBox customTextBox7;
        private CustomControls.CustomTextBox customTextBox8;
    }
}