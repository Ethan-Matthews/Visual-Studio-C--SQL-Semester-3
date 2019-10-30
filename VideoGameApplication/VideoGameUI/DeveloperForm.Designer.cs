namespace VideoGameUI
{
    partial class DeveloperForm
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
            this.DeveloperListBox = new System.Windows.Forms.ListBox();
            this.DeveloperIDTB = new System.Windows.Forms.TextBox();
            this.DeveloperIDLabel = new System.Windows.Forms.Label();
            this.DeveloperNameLB = new System.Windows.Forms.Label();
            this.DeveloperNameTB = new System.Windows.Forms.TextBox();
            this.SaveBN = new System.Windows.Forms.Button();
            this.DeleteBN = new System.Windows.Forms.Button();
            this.InsertBN = new System.Windows.Forms.Button();
            this.CountryCodeCB = new System.Windows.Forms.ComboBox();
            this.CountryCBLB = new System.Windows.Forms.Label();
            this.BackBN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeveloperListBox
            // 
            this.DeveloperListBox.FormattingEnabled = true;
            this.DeveloperListBox.Location = new System.Drawing.Point(22, 39);
            this.DeveloperListBox.Name = "DeveloperListBox";
            this.DeveloperListBox.Size = new System.Drawing.Size(192, 407);
            this.DeveloperListBox.TabIndex = 0;
            this.DeveloperListBox.SelectedIndexChanged += new System.EventHandler(this.DeveloperListBox_SelectedIndexChanged);
            // 
            // DeveloperIDTB
            // 
            this.DeveloperIDTB.Location = new System.Drawing.Point(237, 79);
            this.DeveloperIDTB.Name = "DeveloperIDTB";
            this.DeveloperIDTB.ReadOnly = true;
            this.DeveloperIDTB.Size = new System.Drawing.Size(174, 20);
            this.DeveloperIDTB.TabIndex = 1;
            // 
            // DeveloperIDLabel
            // 
            this.DeveloperIDLabel.AutoSize = true;
            this.DeveloperIDLabel.Location = new System.Drawing.Point(234, 63);
            this.DeveloperIDLabel.Name = "DeveloperIDLabel";
            this.DeveloperIDLabel.Size = new System.Drawing.Size(73, 13);
            this.DeveloperIDLabel.TabIndex = 2;
            this.DeveloperIDLabel.Text = "Developer ID:";
            // 
            // DeveloperNameLB
            // 
            this.DeveloperNameLB.AutoSize = true;
            this.DeveloperNameLB.Location = new System.Drawing.Point(234, 134);
            this.DeveloperNameLB.Name = "DeveloperNameLB";
            this.DeveloperNameLB.Size = new System.Drawing.Size(90, 13);
            this.DeveloperNameLB.TabIndex = 3;
            this.DeveloperNameLB.Text = "Developer Name:";
            // 
            // DeveloperNameTB
            // 
            this.DeveloperNameTB.Location = new System.Drawing.Point(237, 150);
            this.DeveloperNameTB.Name = "DeveloperNameTB";
            this.DeveloperNameTB.Size = new System.Drawing.Size(174, 20);
            this.DeveloperNameTB.TabIndex = 4;
            // 
            // SaveBN
            // 
            this.SaveBN.Location = new System.Drawing.Point(237, 213);
            this.SaveBN.Name = "SaveBN";
            this.SaveBN.Size = new System.Drawing.Size(101, 23);
            this.SaveBN.TabIndex = 5;
            this.SaveBN.Text = "Save";
            this.SaveBN.UseVisualStyleBackColor = true;
            this.SaveBN.Click += new System.EventHandler(this.SaveBN_Click);
            // 
            // DeleteBN
            // 
            this.DeleteBN.Location = new System.Drawing.Point(237, 269);
            this.DeleteBN.Name = "DeleteBN";
            this.DeleteBN.Size = new System.Drawing.Size(101, 23);
            this.DeleteBN.TabIndex = 6;
            this.DeleteBN.Text = "Delete";
            this.DeleteBN.UseVisualStyleBackColor = true;
            this.DeleteBN.Click += new System.EventHandler(this.DeleteBN_Click);
            // 
            // InsertBN
            // 
            this.InsertBN.Location = new System.Drawing.Point(237, 326);
            this.InsertBN.Name = "InsertBN";
            this.InsertBN.Size = new System.Drawing.Size(101, 23);
            this.InsertBN.TabIndex = 7;
            this.InsertBN.Text = "Insert";
            this.InsertBN.UseVisualStyleBackColor = true;
            this.InsertBN.Click += new System.EventHandler(this.InsertBN_Click);
            // 
            // CountryCodeCB
            // 
            this.CountryCodeCB.FormattingEnabled = true;
            this.CountryCodeCB.Location = new System.Drawing.Point(488, 78);
            this.CountryCodeCB.Name = "CountryCodeCB";
            this.CountryCodeCB.Size = new System.Drawing.Size(263, 21);
            this.CountryCodeCB.TabIndex = 8;
            // 
            // CountryCBLB
            // 
            this.CountryCBLB.AutoSize = true;
            this.CountryCBLB.Location = new System.Drawing.Point(485, 62);
            this.CountryCBLB.Name = "CountryCBLB";
            this.CountryCBLB.Size = new System.Drawing.Size(46, 13);
            this.CountryCBLB.TabIndex = 9;
            this.CountryCBLB.Text = "Country:";
            // 
            // BackBN
            // 
            this.BackBN.Location = new System.Drawing.Point(237, 379);
            this.BackBN.Name = "BackBN";
            this.BackBN.Size = new System.Drawing.Size(101, 23);
            this.BackBN.TabIndex = 10;
            this.BackBN.Text = "Back";
            this.BackBN.UseVisualStyleBackColor = true;
            this.BackBN.Click += new System.EventHandler(this.BackBN_Click);
            // 
            // DeveloperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BackBN);
            this.Controls.Add(this.CountryCBLB);
            this.Controls.Add(this.CountryCodeCB);
            this.Controls.Add(this.InsertBN);
            this.Controls.Add(this.DeleteBN);
            this.Controls.Add(this.SaveBN);
            this.Controls.Add(this.DeveloperNameTB);
            this.Controls.Add(this.DeveloperNameLB);
            this.Controls.Add(this.DeveloperIDLabel);
            this.Controls.Add(this.DeveloperIDTB);
            this.Controls.Add(this.DeveloperListBox);
            this.Name = "DeveloperForm";
            this.Text = "DeveloperForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DeveloperForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DeveloperListBox;
        private System.Windows.Forms.TextBox DeveloperIDTB;
        private System.Windows.Forms.Label DeveloperIDLabel;
        private System.Windows.Forms.Label DeveloperNameLB;
        private System.Windows.Forms.TextBox DeveloperNameTB;
        private System.Windows.Forms.Button SaveBN;
        private System.Windows.Forms.Button DeleteBN;
        private System.Windows.Forms.Button InsertBN;
        private System.Windows.Forms.ComboBox CountryCodeCB;
        private System.Windows.Forms.Label CountryCBLB;
        private System.Windows.Forms.Button BackBN;
    }
}