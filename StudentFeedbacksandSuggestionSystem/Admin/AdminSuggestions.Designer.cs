namespace StudentFeedbacksandSuggestionSystem.Admin
{
    partial class AdminSuggestions
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printReport = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.searchBtn = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.searchByComboBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 615);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 119);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panel3.Size = new System.Drawing.Size(1333, 496);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(27, 56);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1279, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // printReport
            // 
            this.printReport.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.printReport.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.printReport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.printReport.BorderRadius = 0;
            this.printReport.BorderSize = 0;
            this.printReport.FlatAppearance.BorderSize = 0;
            this.printReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReport.ForeColor = System.Drawing.Color.White;
            this.printReport.Location = new System.Drawing.Point(1106, 69);
            this.printReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.printReport.Name = "printReport";
            this.printReport.Size = new System.Drawing.Size(200, 39);
            this.printReport.TabIndex = 2;
            this.printReport.Text = "Print Report";
            this.printReport.TextColor = System.Drawing.Color.White;
            this.printReport.UseVisualStyleBackColor = false;
            this.printReport.Click += new System.EventHandler(this.printReport_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.printReport);
            this.panel2.Controls.Add(this.searchByComboBox);
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Controls.Add(this.searchTxtBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1333, 112);
            this.panel2.TabIndex = 0;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.searchTxtBox.BorderColor = System.Drawing.Color.LightPink;
            this.searchTxtBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.searchTxtBox.BorderRadius = 0;
            this.searchTxtBox.BorderSize = 2;
            this.searchTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtBox.ForeColor = System.Drawing.Color.Black;
            this.searchTxtBox.Location = new System.Drawing.Point(27, 73);
            this.searchTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTxtBox.Multiline = false;
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.searchTxtBox.PasswordChar = false;
            this.searchTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchTxtBox.PlaceholderText = "";
            this.searchTxtBox.Size = new System.Drawing.Size(250, 35);
            this.searchTxtBox.TabIndex = 3;
            this.searchTxtBox.Texts = "";
            this.searchTxtBox.UnderlinedStyle = false;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.LightPink;
            this.searchBtn.BackgroundColor = System.Drawing.Color.LightPink;
            this.searchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchBtn.BorderRadius = 0;
            this.searchBtn.BorderSize = 0;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(490, 73);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(150, 35);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.TextColor = System.Drawing.Color.White;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchByComboBox
            // 
            this.searchByComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Author",
            "Title"});
            this.searchByComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchByComboBox.BorderColor = System.Drawing.Color.LightPink;
            this.searchByComboBox.BorderSize = 1;
            this.searchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.searchByComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchByComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.searchByComboBox.IconColor = System.Drawing.Color.LightPink;
            this.searchByComboBox.Items.AddRange(new object[] {
            "Author",
            "TItle"});
            this.searchByComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.searchByComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.searchByComboBox.Location = new System.Drawing.Point(284, 73);
            this.searchByComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.searchByComboBox.Size = new System.Drawing.Size(200, 35);
            this.searchByComboBox.TabIndex = 5;
            this.searchByComboBox.Texts = "";
            // 
            // AdminSuggestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 615);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminSuggestions";
            this.Text = "AdminSuggestions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminSuggestions_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.CustomButton printReport;
        private CustomControls.CustomComboBox searchByComboBox;
        private CustomControls.CustomButton searchBtn;
        private CustomControls.CustomTextBox searchTxtBox;
    }
}