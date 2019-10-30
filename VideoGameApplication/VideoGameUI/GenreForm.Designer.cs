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
            this.SuspendLayout();
            // 
            // GenreListBox
            // 
            this.GenreListBox.FormattingEnabled = true;
            this.GenreListBox.Location = new System.Drawing.Point(12, 12);
            this.GenreListBox.Name = "GenreListBox";
            this.GenreListBox.Size = new System.Drawing.Size(175, 420);
            this.GenreListBox.TabIndex = 0;
            this.GenreListBox.SelectedIndexChanged += new System.EventHandler(this.GenreListBox_SelectedIndexChanged);
            // 
            // GenreNameTB
            // 
            this.GenreNameTB.Location = new System.Drawing.Point(221, 94);
            this.GenreNameTB.Name = "GenreNameTB";
            this.GenreNameTB.Size = new System.Drawing.Size(204, 20);
            this.GenreNameTB.TabIndex = 1;
            // 
            // GenreNameLB
            // 
            this.GenreNameLB.AutoSize = true;
            this.GenreNameLB.Location = new System.Drawing.Point(218, 78);
            this.GenreNameLB.Name = "GenreNameLB";
            this.GenreNameLB.Size = new System.Drawing.Size(70, 13);
            this.GenreNameLB.TabIndex = 2;
            this.GenreNameLB.Text = "Genre Name:";
            // 
            // GenreIDTB
            // 
            this.GenreIDTB.Location = new System.Drawing.Point(221, 39);
            this.GenreIDTB.Name = "GenreIDTB";
            this.GenreIDTB.ReadOnly = true;
            this.GenreIDTB.Size = new System.Drawing.Size(204, 20);
            this.GenreIDTB.TabIndex = 3;
            // 
            // GenreIDLB
            // 
            this.GenreIDLB.AutoSize = true;
            this.GenreIDLB.Location = new System.Drawing.Point(221, 20);
            this.GenreIDLB.Name = "GenreIDLB";
            this.GenreIDLB.Size = new System.Drawing.Size(53, 13);
            this.GenreIDLB.TabIndex = 4;
            this.GenreIDLB.Text = "Genre ID:";
            // 
            // SaveBN
            // 
            this.SaveBN.Location = new System.Drawing.Point(221, 142);
            this.SaveBN.Name = "SaveBN";
            this.SaveBN.Size = new System.Drawing.Size(103, 23);
            this.SaveBN.TabIndex = 5;
            this.SaveBN.Text = "Save Genre";
            this.SaveBN.UseVisualStyleBackColor = true;
            this.SaveBN.Click += new System.EventHandler(this.SaveBN_Click);
            // 
            // deleteBN
            // 
            this.deleteBN.Location = new System.Drawing.Point(221, 191);
            this.deleteBN.Name = "deleteBN";
            this.deleteBN.Size = new System.Drawing.Size(103, 23);
            this.deleteBN.TabIndex = 6;
            this.deleteBN.Text = "Delete Genre";
            this.deleteBN.UseVisualStyleBackColor = true;
            this.deleteBN.Click += new System.EventHandler(this.deleteBN_Click);
            // 
            // InsertGenreBN
            // 
            this.InsertGenreBN.Location = new System.Drawing.Point(221, 237);
            this.InsertGenreBN.Name = "InsertGenreBN";
            this.InsertGenreBN.Size = new System.Drawing.Size(103, 23);
            this.InsertGenreBN.TabIndex = 7;
            this.InsertGenreBN.Text = "Insert Genre";
            this.InsertGenreBN.UseVisualStyleBackColor = true;
            this.InsertGenreBN.Click += new System.EventHandler(this.InsertGenreBN_Click);
            // 
            // GenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
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
    }
}