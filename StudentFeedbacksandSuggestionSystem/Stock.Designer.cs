namespace TESTING
{
    partial class Stock
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
            this.greetingslbl = new System.Windows.Forms.Label();
            this.userlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // greetingslbl
            // 
            this.greetingslbl.AutoSize = true;
            this.greetingslbl.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingslbl.Location = new System.Drawing.Point(281, 41);
            this.greetingslbl.Name = "greetingslbl";
            this.greetingslbl.Size = new System.Drawing.Size(206, 25);
            this.greetingslbl.TabIndex = 0;
            this.greetingslbl.Text = "WELCOME ADMIN!";
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.Location = new System.Drawing.Point(12, 9);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(49, 23);
            this.userlbl.TabIndex = 1;
            this.userlbl.Text = "User";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.greetingslbl);
            this.Name = "Stock";
            this.Text = "Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetingslbl;
        private System.Windows.Forms.Label userlbl;
    }
}