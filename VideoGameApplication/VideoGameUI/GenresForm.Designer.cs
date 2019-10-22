namespace VideoGameUI
{
    partial class GenresForm
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
            this.GenresLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenreIDLabel = new System.Windows.Forms.Label();
            this.GenreIDTB = new System.Windows.Forms.TextBox();
            this.GenreNameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GenresLB
            // 
            this.GenresLB.FormattingEnabled = true;
            this.GenresLB.ItemHeight = 16;
            this.GenresLB.Location = new System.Drawing.Point(13, 13);
            this.GenresLB.Name = "GenresLB";
            this.GenresLB.Size = new System.Drawing.Size(191, 420);
            this.GenresLB.TabIndex = 0;
            this.GenresLB.SelectedIndexChanged += new System.EventHandler(this.GenreLB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Genre Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GenreIDLabel
            // 
            this.GenreIDLabel.AutoSize = true;
            this.GenreIDLabel.Location = new System.Drawing.Point(239, 19);
            this.GenreIDLabel.Name = "GenreIDLabel";
            this.GenreIDLabel.Size = new System.Drawing.Size(65, 17);
            this.GenreIDLabel.TabIndex = 4;
            this.GenreIDLabel.Text = "Genre ID";
            // 
            // GenreIDTB
            // 
            this.GenreIDTB.Location = new System.Drawing.Point(242, 40);
            this.GenreIDTB.Name = "GenreIDTB";
            this.GenreIDTB.Size = new System.Drawing.Size(100, 22);
            this.GenreIDTB.TabIndex = 5;
            // 
            // GenreNameTB
            // 
            this.GenreNameTB.Location = new System.Drawing.Point(242, 101);
            this.GenreNameTB.Name = "GenreNameTB";
            this.GenreNameTB.Size = new System.Drawing.Size(100, 22);
            this.GenreNameTB.TabIndex = 6;
            // 
            // GenresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.GenreNameTB);
            this.Controls.Add(this.GenreIDTB);
            this.Controls.Add(this.GenreIDLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenresLB);
            this.Name = "GenresForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GenresForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox GenresLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GenreIDLabel;
        private System.Windows.Forms.TextBox GenreIDTB;
        private System.Windows.Forms.TextBox GenreNameTB;
    }
}

