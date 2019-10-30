namespace VideoGameUI
{
    partial class DeveloperCountryForm
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
            this.DeveloperCountryListBox = new System.Windows.Forms.ListBox();
            this.CountryCodeTB = new System.Windows.Forms.TextBox();
            this.CountryCodeLB = new System.Windows.Forms.Label();
            this.CountryNameTB = new System.Windows.Forms.TextBox();
            this.CountryNameLB = new System.Windows.Forms.Label();
            this.SaveCountryBN = new System.Windows.Forms.Button();
            this.DeleteCountryBN = new System.Windows.Forms.Button();
            this.InsertCountryBN = new System.Windows.Forms.Button();
            this.BackBN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeveloperCountryListBox
            // 
            this.DeveloperCountryListBox.FormattingEnabled = true;
            this.DeveloperCountryListBox.Location = new System.Drawing.Point(23, 52);
            this.DeveloperCountryListBox.Name = "DeveloperCountryListBox";
            this.DeveloperCountryListBox.Size = new System.Drawing.Size(174, 368);
            this.DeveloperCountryListBox.TabIndex = 0;
            this.DeveloperCountryListBox.SelectedIndexChanged += new System.EventHandler(this.DeveloperCountryListBox_SelectedIndexChanged);
            // 
            // CountryCodeTB
            // 
            this.CountryCodeTB.Location = new System.Drawing.Point(231, 79);
            this.CountryCodeTB.MaxLength = 3;
            this.CountryCodeTB.Name = "CountryCodeTB";
            this.CountryCodeTB.ReadOnly = true;
            this.CountryCodeTB.Size = new System.Drawing.Size(200, 20);
            this.CountryCodeTB.TabIndex = 1;
            // 
            // CountryCodeLB
            // 
            this.CountryCodeLB.AutoSize = true;
            this.CountryCodeLB.Location = new System.Drawing.Point(228, 63);
            this.CountryCodeLB.Name = "CountryCodeLB";
            this.CountryCodeLB.Size = new System.Drawing.Size(74, 13);
            this.CountryCodeLB.TabIndex = 2;
            this.CountryCodeLB.Text = "Country Code:";
            // 
            // CountryNameTB
            // 
            this.CountryNameTB.Location = new System.Drawing.Point(231, 139);
            this.CountryNameTB.Name = "CountryNameTB";
            this.CountryNameTB.Size = new System.Drawing.Size(200, 20);
            this.CountryNameTB.TabIndex = 3;
            // 
            // CountryNameLB
            // 
            this.CountryNameLB.AutoSize = true;
            this.CountryNameLB.Location = new System.Drawing.Point(228, 123);
            this.CountryNameLB.Name = "CountryNameLB";
            this.CountryNameLB.Size = new System.Drawing.Size(77, 13);
            this.CountryNameLB.TabIndex = 4;
            this.CountryNameLB.Text = "Country Name:";
            // 
            // SaveCountryBN
            // 
            this.SaveCountryBN.Location = new System.Drawing.Point(231, 191);
            this.SaveCountryBN.Name = "SaveCountryBN";
            this.SaveCountryBN.Size = new System.Drawing.Size(93, 23);
            this.SaveCountryBN.TabIndex = 5;
            this.SaveCountryBN.Text = "Save";
            this.SaveCountryBN.UseVisualStyleBackColor = true;
            this.SaveCountryBN.Click += new System.EventHandler(this.SaveCountryBN_Click);
            // 
            // DeleteCountryBN
            // 
            this.DeleteCountryBN.Location = new System.Drawing.Point(231, 242);
            this.DeleteCountryBN.Name = "DeleteCountryBN";
            this.DeleteCountryBN.Size = new System.Drawing.Size(93, 23);
            this.DeleteCountryBN.TabIndex = 6;
            this.DeleteCountryBN.Text = "Delete";
            this.DeleteCountryBN.UseVisualStyleBackColor = true;
            this.DeleteCountryBN.Click += new System.EventHandler(this.DeleteCountryBN_Click);
            // 
            // InsertCountryBN
            // 
            this.InsertCountryBN.Location = new System.Drawing.Point(231, 294);
            this.InsertCountryBN.Name = "InsertCountryBN";
            this.InsertCountryBN.Size = new System.Drawing.Size(93, 23);
            this.InsertCountryBN.TabIndex = 7;
            this.InsertCountryBN.Text = "Insert";
            this.InsertCountryBN.UseVisualStyleBackColor = true;
            this.InsertCountryBN.Click += new System.EventHandler(this.InsertCountryBN_Click);
            // 
            // BackBN
            // 
            this.BackBN.Location = new System.Drawing.Point(231, 347);
            this.BackBN.Name = "BackBN";
            this.BackBN.Size = new System.Drawing.Size(93, 23);
            this.BackBN.TabIndex = 8;
            this.BackBN.Text = "Back";
            this.BackBN.UseVisualStyleBackColor = true;
            this.BackBN.Click += new System.EventHandler(this.BackBN_Click);
            // 
            // DeveloperCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BackBN);
            this.Controls.Add(this.InsertCountryBN);
            this.Controls.Add(this.DeleteCountryBN);
            this.Controls.Add(this.SaveCountryBN);
            this.Controls.Add(this.CountryNameLB);
            this.Controls.Add(this.CountryNameTB);
            this.Controls.Add(this.CountryCodeLB);
            this.Controls.Add(this.CountryCodeTB);
            this.Controls.Add(this.DeveloperCountryListBox);
            this.Name = "DeveloperCountryForm";
            this.Text = "DeveloperCountryForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DeveloperCountryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DeveloperCountryListBox;
        private System.Windows.Forms.TextBox CountryCodeTB;
        private System.Windows.Forms.Label CountryCodeLB;
        private System.Windows.Forms.TextBox CountryNameTB;
        private System.Windows.Forms.Label CountryNameLB;
        private System.Windows.Forms.Button SaveCountryBN;
        private System.Windows.Forms.Button DeleteCountryBN;
        private System.Windows.Forms.Button InsertCountryBN;
        private System.Windows.Forms.Button BackBN;
    }
}