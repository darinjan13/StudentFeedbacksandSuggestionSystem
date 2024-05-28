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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printReport = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.searchByComboBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomComboBox();
            this.searchBtn = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.searchTxtBox = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomTextBox();
            this.printMostVotes = new StudentFeedbacksandSuggestionSystem.CustomControls.CustomButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 615);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 119);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panel3.Size = new System.Drawing.Size(1333, 496);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.printMostVotes);
            this.panel2.Controls.Add(this.printReport);
            this.panel2.Controls.Add(this.searchByComboBox);
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Controls.Add(this.searchTxtBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1333, 112);
            this.panel2.TabIndex = 0;
            // 
            // printReport
            // 
            this.printReport.BackColor = System.Drawing.Color.PowderBlue;
            this.printReport.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.printReport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.printReport.BorderRadius = 0;
            this.printReport.BorderSize = 0;
            this.printReport.FlatAppearance.BorderSize = 0;
            this.printReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReport.ForeColor = System.Drawing.Color.Black;
            this.printReport.Location = new System.Drawing.Point(743, 73);
            this.printReport.Margin = new System.Windows.Forms.Padding(4);
            this.printReport.Name = "printReport";
            this.printReport.Size = new System.Drawing.Size(200, 35);
            this.printReport.TabIndex = 2;
            this.printReport.Text = "Print Report";
            this.printReport.TextColor = System.Drawing.Color.Black;
            this.printReport.UseVisualStyleBackColor = false;
            this.printReport.Click += new System.EventHandler(this.printReport_Click);
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
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.LightPink;
            this.searchBtn.BackgroundColor = System.Drawing.Color.LightPink;
            this.searchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchBtn.BorderRadius = 0;
            this.searchBtn.BorderSize = 0;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.Location = new System.Drawing.Point(490, 73);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(150, 35);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.TextColor = System.Drawing.Color.Black;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
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
            this.searchTxtBox.IsReadOnly = false;
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
            // printMostVotes
            // 
            this.printMostVotes.BackColor = System.Drawing.Color.PowderBlue;
            this.printMostVotes.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.printMostVotes.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.printMostVotes.BorderRadius = 0;
            this.printMostVotes.BorderSize = 0;
            this.printMostVotes.FlatAppearance.BorderSize = 0;
            this.printMostVotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printMostVotes.ForeColor = System.Drawing.Color.Black;
            this.printMostVotes.Location = new System.Drawing.Point(951, 73);
            this.printMostVotes.Margin = new System.Windows.Forms.Padding(4);
            this.printMostVotes.Name = "printMostVotes";
            this.printMostVotes.Size = new System.Drawing.Size(200, 35);
            this.printMostVotes.TabIndex = 6;
            this.printMostVotes.Text = "Print Most Votes";
            this.printMostVotes.TextColor = System.Drawing.Color.Black;
            this.printMostVotes.UseVisualStyleBackColor = false;
            this.printMostVotes.Click += new System.EventHandler(this.printMostVotes_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridView1.Location = new System.Drawing.Point(27, 52);
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
            this.dataGridView1.Size = new System.Drawing.Size(1279, 419);
            this.dataGridView1.TabIndex = 3;
            // 
            // AdminSuggestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentFeedbacksandSuggestionSystem.Properties.Resources.MainBackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1333, 615);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminSuggestions";
            this.Text = "AdminSuggestions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminSuggestions_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.CustomButton printReport;
        private CustomControls.CustomComboBox searchByComboBox;
        private CustomControls.CustomButton searchBtn;
        private CustomControls.CustomTextBox searchTxtBox;
        private CustomControls.CustomButton printMostVotes;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}