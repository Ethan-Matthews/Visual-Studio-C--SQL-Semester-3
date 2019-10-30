namespace VideoGameUI
{
    partial class Menu
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
            this.GameBN = new System.Windows.Forms.Button();
            this.DeveloperBN = new System.Windows.Forms.Button();
            this.GenreBN = new System.Windows.Forms.Button();
            this.CountryBN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameBN
            // 
            this.GameBN.Location = new System.Drawing.Point(249, 204);
            this.GameBN.Name = "GameBN";
            this.GameBN.Size = new System.Drawing.Size(309, 23);
            this.GameBN.TabIndex = 0;
            this.GameBN.Text = "Edit Games";
            this.GameBN.UseVisualStyleBackColor = true;
            this.GameBN.Click += new System.EventHandler(this.GameBN_Click);
            // 
            // DeveloperBN
            // 
            this.DeveloperBN.Location = new System.Drawing.Point(249, 246);
            this.DeveloperBN.Name = "DeveloperBN";
            this.DeveloperBN.Size = new System.Drawing.Size(99, 23);
            this.DeveloperBN.TabIndex = 1;
            this.DeveloperBN.Text = "Edit Developers";
            this.DeveloperBN.UseVisualStyleBackColor = true;
            this.DeveloperBN.Click += new System.EventHandler(this.DeveloperBN_Click);
            // 
            // GenreBN
            // 
            this.GenreBN.Location = new System.Drawing.Point(354, 246);
            this.GenreBN.Name = "GenreBN";
            this.GenreBN.Size = new System.Drawing.Size(99, 23);
            this.GenreBN.TabIndex = 2;
            this.GenreBN.Text = "Edit Genres";
            this.GenreBN.UseVisualStyleBackColor = true;
            this.GenreBN.Click += new System.EventHandler(this.GenreBN_Click);
            // 
            // CountryBN
            // 
            this.CountryBN.Location = new System.Drawing.Point(459, 246);
            this.CountryBN.Name = "CountryBN";
            this.CountryBN.Size = new System.Drawing.Size(99, 23);
            this.CountryBN.TabIndex = 3;
            this.CountryBN.Text = "Edit Countries";
            this.CountryBN.UseVisualStyleBackColor = true;
            this.CountryBN.Click += new System.EventHandler(this.CountryBN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Game DataBase";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountryBN);
            this.Controls.Add(this.GenreBN);
            this.Controls.Add(this.DeveloperBN);
            this.Controls.Add(this.GameBN);
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GameBN;
        private System.Windows.Forms.Button DeveloperBN;
        private System.Windows.Forms.Button GenreBN;
        private System.Windows.Forms.Button CountryBN;
        private System.Windows.Forms.Label label1;
    }
}