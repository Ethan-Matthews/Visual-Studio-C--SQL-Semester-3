namespace VideoGameUI
{
    partial class VideoGameForm
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
            this.VideoGameListBox = new System.Windows.Forms.ListBox();
            this.TitleTB = new System.Windows.Forms.TextBox();
            this.TitleLB = new System.Windows.Forms.Label();
            this.ReleaseDateTB = new System.Windows.Forms.TextBox();
            this.ReleaseDTB = new System.Windows.Forms.Label();
            this.HoursPlayedTB = new System.Windows.Forms.TextBox();
            this.HoursPlayerLB = new System.Windows.Forms.Label();
            this.NumAchievTB = new System.Windows.Forms.TextBox();
            this.SaveBN = new System.Windows.Forms.Button();
            this.DeleteBN = new System.Windows.Forms.Button();
            this.InsertBN = new System.Windows.Forms.Button();
            this.DeveloperCB = new System.Windows.Forms.ComboBox();
            this.DeveloperCBLB = new System.Windows.Forms.Label();
            this.GenreCB = new System.Windows.Forms.ComboBox();
            this.GenreCBLB = new System.Windows.Forms.Label();
            this.GameIDTB = new System.Windows.Forms.TextBox();
            this.GameIDLB = new System.Windows.Forms.Label();
            this.BackBN = new System.Windows.Forms.Button();
            this.NumAchievTBLB = new System.Windows.Forms.Label();
            this.GameListLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VideoGameListBox
            // 
            this.VideoGameListBox.FormattingEnabled = true;
            this.VideoGameListBox.Location = new System.Drawing.Point(19, 54);
            this.VideoGameListBox.Name = "VideoGameListBox";
            this.VideoGameListBox.Size = new System.Drawing.Size(186, 381);
            this.VideoGameListBox.TabIndex = 0;
            this.VideoGameListBox.SelectedIndexChanged += new System.EventHandler(this.VideoGameListBox_SelectedIndexChanged);
            // 
            // TitleTB
            // 
            this.TitleTB.Location = new System.Drawing.Point(230, 138);
            this.TitleTB.Name = "TitleTB";
            this.TitleTB.Size = new System.Drawing.Size(204, 20);
            this.TitleTB.TabIndex = 1;
            // 
            // TitleLB
            // 
            this.TitleLB.AutoSize = true;
            this.TitleLB.Location = new System.Drawing.Point(227, 123);
            this.TitleLB.Name = "TitleLB";
            this.TitleLB.Size = new System.Drawing.Size(30, 13);
            this.TitleLB.TabIndex = 2;
            this.TitleLB.Text = "Title:";
            // 
            // ReleaseDateTB
            // 
            this.ReleaseDateTB.Location = new System.Drawing.Point(230, 206);
            this.ReleaseDateTB.Name = "ReleaseDateTB";
            this.ReleaseDateTB.Size = new System.Drawing.Size(204, 20);
            this.ReleaseDateTB.TabIndex = 3;
            // 
            // ReleaseDTB
            // 
            this.ReleaseDTB.AutoSize = true;
            this.ReleaseDTB.Location = new System.Drawing.Point(227, 190);
            this.ReleaseDTB.Name = "ReleaseDTB";
            this.ReleaseDTB.Size = new System.Drawing.Size(252, 13);
            this.ReleaseDTB.TabIndex = 4;
            this.ReleaseDTB.Text = "Release Date:  (YYYY-MM-DD HH:MM:SS AM/PM)";
            // 
            // HoursPlayedTB
            // 
            this.HoursPlayedTB.Location = new System.Drawing.Point(230, 270);
            this.HoursPlayedTB.Name = "HoursPlayedTB";
            this.HoursPlayedTB.Size = new System.Drawing.Size(204, 20);
            this.HoursPlayedTB.TabIndex = 5;
            // 
            // HoursPlayerLB
            // 
            this.HoursPlayerLB.AutoSize = true;
            this.HoursPlayerLB.Location = new System.Drawing.Point(227, 254);
            this.HoursPlayerLB.Name = "HoursPlayerLB";
            this.HoursPlayerLB.Size = new System.Drawing.Size(73, 13);
            this.HoursPlayerLB.TabIndex = 6;
            this.HoursPlayerLB.Text = "Hours Played:";
            // 
            // NumAchievTB
            // 
            this.NumAchievTB.Location = new System.Drawing.Point(230, 332);
            this.NumAchievTB.Name = "NumAchievTB";
            this.NumAchievTB.Size = new System.Drawing.Size(204, 20);
            this.NumAchievTB.TabIndex = 7;
            // 
            // SaveBN
            // 
            this.SaveBN.Location = new System.Drawing.Point(230, 384);
            this.SaveBN.Name = "SaveBN";
            this.SaveBN.Size = new System.Drawing.Size(99, 23);
            this.SaveBN.TabIndex = 9;
            this.SaveBN.Text = "Save";
            this.SaveBN.UseVisualStyleBackColor = true;
            this.SaveBN.Click += new System.EventHandler(this.SaveBN_Click);
            // 
            // DeleteBN
            // 
            this.DeleteBN.Location = new System.Drawing.Point(230, 413);
            this.DeleteBN.Name = "DeleteBN";
            this.DeleteBN.Size = new System.Drawing.Size(99, 23);
            this.DeleteBN.TabIndex = 10;
            this.DeleteBN.Text = "Delete";
            this.DeleteBN.UseVisualStyleBackColor = true;
            this.DeleteBN.Click += new System.EventHandler(this.DeleteBN_Click);
            // 
            // InsertBN
            // 
            this.InsertBN.Location = new System.Drawing.Point(335, 384);
            this.InsertBN.Name = "InsertBN";
            this.InsertBN.Size = new System.Drawing.Size(99, 23);
            this.InsertBN.TabIndex = 11;
            this.InsertBN.Text = "Insert";
            this.InsertBN.UseVisualStyleBackColor = true;
            this.InsertBN.Click += new System.EventHandler(this.InsertBN_Click);
            // 
            // DeveloperCB
            // 
            this.DeveloperCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeveloperCB.FormattingEnabled = true;
            this.DeveloperCB.Location = new System.Drawing.Point(504, 74);
            this.DeveloperCB.Name = "DeveloperCB";
            this.DeveloperCB.Size = new System.Drawing.Size(221, 21);
            this.DeveloperCB.Sorted = true;
            this.DeveloperCB.TabIndex = 12;
            // 
            // DeveloperCBLB
            // 
            this.DeveloperCBLB.AutoSize = true;
            this.DeveloperCBLB.Location = new System.Drawing.Point(501, 58);
            this.DeveloperCBLB.Name = "DeveloperCBLB";
            this.DeveloperCBLB.Size = new System.Drawing.Size(59, 13);
            this.DeveloperCBLB.TabIndex = 13;
            this.DeveloperCBLB.Text = "Developer:";
            // 
            // GenreCB
            // 
            this.GenreCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreCB.FormattingEnabled = true;
            this.GenreCB.Location = new System.Drawing.Point(504, 137);
            this.GenreCB.Name = "GenreCB";
            this.GenreCB.Size = new System.Drawing.Size(221, 21);
            this.GenreCB.TabIndex = 14;
            // 
            // GenreCBLB
            // 
            this.GenreCBLB.AutoSize = true;
            this.GenreCBLB.Location = new System.Drawing.Point(501, 123);
            this.GenreCBLB.Name = "GenreCBLB";
            this.GenreCBLB.Size = new System.Drawing.Size(39, 13);
            this.GenreCBLB.TabIndex = 15;
            this.GenreCBLB.Text = "Genre:";
            // 
            // GameIDTB
            // 
            this.GameIDTB.Enabled = false;
            this.GameIDTB.Location = new System.Drawing.Point(230, 74);
            this.GameIDTB.Name = "GameIDTB";
            this.GameIDTB.ReadOnly = true;
            this.GameIDTB.Size = new System.Drawing.Size(204, 20);
            this.GameIDTB.TabIndex = 16;
            // 
            // GameIDLB
            // 
            this.GameIDLB.AutoSize = true;
            this.GameIDLB.Location = new System.Drawing.Point(227, 58);
            this.GameIDLB.Name = "GameIDLB";
            this.GameIDLB.Size = new System.Drawing.Size(52, 13);
            this.GameIDLB.TabIndex = 17;
            this.GameIDLB.Text = "Game ID:";
            // 
            // BackBN
            // 
            this.BackBN.Location = new System.Drawing.Point(335, 413);
            this.BackBN.Name = "BackBN";
            this.BackBN.Size = new System.Drawing.Size(99, 23);
            this.BackBN.TabIndex = 18;
            this.BackBN.Text = "Back";
            this.BackBN.UseVisualStyleBackColor = true;
            this.BackBN.Click += new System.EventHandler(this.BackBN_Click);
            // 
            // NumAchievTBLB
            // 
            this.NumAchievTBLB.AutoSize = true;
            this.NumAchievTBLB.Location = new System.Drawing.Point(227, 316);
            this.NumAchievTBLB.Name = "NumAchievTBLB";
            this.NumAchievTBLB.Size = new System.Drawing.Size(129, 13);
            this.NumAchievTBLB.TabIndex = 19;
            this.NumAchievTBLB.Text = "Number of Achievements:";
            // 
            // GameListLB
            // 
            this.GameListLB.AutoSize = true;
            this.GameListLB.Location = new System.Drawing.Point(16, 38);
            this.GameListLB.Name = "GameListLB";
            this.GameListLB.Size = new System.Drawing.Size(57, 13);
            this.GameListLB.TabIndex = 20;
            this.GameListLB.Text = "Game List:";
            // 
            // VideoGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.GameListLB);
            this.Controls.Add(this.NumAchievTBLB);
            this.Controls.Add(this.BackBN);
            this.Controls.Add(this.GameIDLB);
            this.Controls.Add(this.GameIDTB);
            this.Controls.Add(this.GenreCBLB);
            this.Controls.Add(this.GenreCB);
            this.Controls.Add(this.DeveloperCBLB);
            this.Controls.Add(this.DeveloperCB);
            this.Controls.Add(this.InsertBN);
            this.Controls.Add(this.DeleteBN);
            this.Controls.Add(this.SaveBN);
            this.Controls.Add(this.NumAchievTB);
            this.Controls.Add(this.HoursPlayerLB);
            this.Controls.Add(this.HoursPlayedTB);
            this.Controls.Add(this.ReleaseDTB);
            this.Controls.Add(this.ReleaseDateTB);
            this.Controls.Add(this.TitleLB);
            this.Controls.Add(this.TitleTB);
            this.Controls.Add(this.VideoGameListBox);
            this.Name = "VideoGameForm";
            this.Text = "VideoGameForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VideoGameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox VideoGameListBox;
        private System.Windows.Forms.TextBox TitleTB;
        private System.Windows.Forms.Label TitleLB;
        private System.Windows.Forms.TextBox ReleaseDateTB;
        private System.Windows.Forms.Label ReleaseDTB;
        private System.Windows.Forms.TextBox HoursPlayedTB;
        private System.Windows.Forms.Label HoursPlayerLB;
        private System.Windows.Forms.TextBox NumAchievTB;
        private System.Windows.Forms.Button SaveBN;
        private System.Windows.Forms.Button DeleteBN;
        private System.Windows.Forms.Button InsertBN;
        private System.Windows.Forms.ComboBox DeveloperCB;
        private System.Windows.Forms.Label DeveloperCBLB;
        private System.Windows.Forms.ComboBox GenreCB;
        private System.Windows.Forms.Label GenreCBLB;
        private System.Windows.Forms.TextBox GameIDTB;
        private System.Windows.Forms.Label GameIDLB;
        private System.Windows.Forms.Button BackBN;
        private System.Windows.Forms.Label NumAchievTBLB;
        private System.Windows.Forms.Label GameListLB;
    }
}