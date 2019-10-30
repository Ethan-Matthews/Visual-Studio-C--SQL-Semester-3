namespace VideoGameUI
{
    partial class GenreForm
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
            this.GenreListBox = new System.Windows.Forms.ListBox();
            this.GenreNameTB = new System.Windows.Forms.TextBox();
            this.GenreNameLB = new System.Windows.Forms.Label();
            this.GenreIDTB = new System.Windows.Forms.TextBox();
            this.GenreIDLB = new System.Windows.Forms.Label();
            this.SaveBN = new System.Windows.Forms.Button();
            this.deleteBN = new System.Windows.Forms.Button();
            this.InsertGenreBN = new System.Windows.Forms.Button();
            this.BackBN = new System.Windows.Forms.Button();
            this.GenreListLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenreListBox
            // 
            this.GenreListBox.FormattingEnabled = true;
            this.GenreListBox.Location = new System.Drawing.Point(24, 52);
            this.GenreListBox.Name = "GenreListBox";
            this.GenreListBox.Size = new System.Drawing.Size(183, 368);
            this.GenreListBox.TabIndex = 0;
            this.GenreListBox.SelectedIndexChanged += new System.EventHandler(this.GenreListBox_SelectedIndexChanged);
            // 
            // GenreNameTB
            // 
            this.GenreNameTB.Location = new System.Drawing.Point(230, 137);
            this.GenreNameTB.Name = "GenreNameTB";
            this.GenreNameTB.Size = new System.Drawing.Size(212, 20);
            this.GenreNameTB.TabIndex = 1;
            // 
            // GenreNameLB
            // 
            this.GenreNameLB.AutoSize = true;
            this.GenreNameLB.Location = new System.Drawing.Point(227, 121);
            this.GenreNameLB.Name = "GenreNameLB";
            this.GenreNameLB.Size = new System.Drawing.Size(70, 13);
            this.GenreNameLB.TabIndex = 2;
            this.GenreNameLB.Text = "Genre Name:";
            // 
            // GenreIDTB
            // 
            this.GenreIDTB.Enabled = false;
            this.GenreIDTB.Location = new System.Drawing.Point(230, 82);
            this.GenreIDTB.Name = "GenreIDTB";
            this.GenreIDTB.ReadOnly = true;
            this.GenreIDTB.Size = new System.Drawing.Size(212, 20);
            this.GenreIDTB.TabIndex = 3;
            // 
            // GenreIDLB
            // 
            this.GenreIDLB.AutoSize = true;
            this.GenreIDLB.Location = new System.Drawing.Point(227, 66);
            this.GenreIDLB.Name = "GenreIDLB";
            this.GenreIDLB.Size = new System.Drawing.Size(53, 13);
            this.GenreIDLB.TabIndex = 4;
            this.GenreIDLB.Text = "Genre ID:";
            // 
            // SaveBN
            // 
            this.SaveBN.Location = new System.Drawing.Point(230, 185);
            this.SaveBN.Name = "SaveBN";
            this.SaveBN.Size = new System.Drawing.Size(103, 23);
            this.SaveBN.TabIndex = 5;
            this.SaveBN.Text = "Save Genre";
            this.SaveBN.UseVisualStyleBackColor = true;
            this.SaveBN.Click += new System.EventHandler(this.SaveBN_Click);
            // 
            // deleteBN
            // 
            this.deleteBN.Location = new System.Drawing.Point(230, 214);
            this.deleteBN.Name = "deleteBN";
            this.deleteBN.Size = new System.Drawing.Size(103, 23);
            this.deleteBN.TabIndex = 6;
            this.deleteBN.Text = "Delete Genre";
            this.deleteBN.UseVisualStyleBackColor = true;
            this.deleteBN.Click += new System.EventHandler(this.deleteBN_Click);
            // 
            // InsertGenreBN
            // 
            this.InsertGenreBN.Location = new System.Drawing.Point(339, 185);
            this.InsertGenreBN.Name = "InsertGenreBN";
            this.InsertGenreBN.Size = new System.Drawing.Size(103, 23);
            this.InsertGenreBN.TabIndex = 7;
            this.InsertGenreBN.Text = "Insert Genre";
            this.InsertGenreBN.UseVisualStyleBackColor = true;
            this.InsertGenreBN.Click += new System.EventHandler(this.InsertGenreBN_Click);
            // 
            // BackBN
            // 
            this.BackBN.Location = new System.Drawing.Point(339, 214);
            this.BackBN.Name = "BackBN";
            this.BackBN.Size = new System.Drawing.Size(103, 23);
            this.BackBN.TabIndex = 8;
            this.BackBN.Text = "Back";
            this.BackBN.UseVisualStyleBackColor = true;
            this.BackBN.Click += new System.EventHandler(this.BackBN_Click);
            // 
            // GenreListLB
            // 
            this.GenreListLB.AutoSize = true;
            this.GenreListLB.Location = new System.Drawing.Point(21, 36);
            this.GenreListLB.Name = "GenreListLB";
            this.GenreListLB.Size = new System.Drawing.Size(58, 13);
            this.GenreListLB.TabIndex = 9;
            this.GenreListLB.Text = "Genre List:";
            // 
            // GenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.GenreListLB);
            this.Controls.Add(this.BackBN);
            this.Controls.Add(this.InsertGenreBN);
            this.Controls.Add(this.deleteBN);
            this.Controls.Add(this.SaveBN);
            this.Controls.Add(this.GenreIDLB);
            this.Controls.Add(this.GenreIDTB);
            this.Controls.Add(this.GenreNameLB);
            this.Controls.Add(this.GenreNameTB);
            this.Controls.Add(this.GenreListBox);
            this.Name = "GenreForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GenreForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox GenreListBox;
        private System.Windows.Forms.TextBox GenreNameTB;
        private System.Windows.Forms.Label GenreNameLB;
        private System.Windows.Forms.TextBox GenreIDTB;
        private System.Windows.Forms.Label GenreIDLB;
        private System.Windows.Forms.Button SaveBN;
        private System.Windows.Forms.Button deleteBN;
        private System.Windows.Forms.Button InsertGenreBN;
        private System.Windows.Forms.Button BackBN;
        private System.Windows.Forms.Label GenreListLB;
    }
}