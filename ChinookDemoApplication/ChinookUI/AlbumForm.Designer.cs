namespace ChinookUI
{
    partial class AlbumForm
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
            this.AlbumListBox = new System.Windows.Forms.ListBox();
            this.AlbumIdTextBox = new System.Windows.Forms.TextBox();
            this.AlbumTitleTextBox = new System.Windows.Forms.TextBox();
            this.AlbumArtistComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AlbumListBox
            // 
            this.AlbumListBox.FormattingEnabled = true;
            this.AlbumListBox.Location = new System.Drawing.Point(12, 64);
            this.AlbumListBox.Name = "AlbumListBox";
            this.AlbumListBox.Size = new System.Drawing.Size(313, 355);
            this.AlbumListBox.TabIndex = 0;
            this.AlbumListBox.SelectedIndexChanged += new System.EventHandler(this.AlbumListBox_SelectedIndexChanged);
            // 
            // AlbumIdTextBox
            // 
            this.AlbumIdTextBox.Location = new System.Drawing.Point(388, 67);
            this.AlbumIdTextBox.Name = "AlbumIdTextBox";
            this.AlbumIdTextBox.ReadOnly = true;
            this.AlbumIdTextBox.Size = new System.Drawing.Size(54, 20);
            this.AlbumIdTextBox.TabIndex = 1;
            // 
            // AlbumTitleTextBox
            // 
            this.AlbumTitleTextBox.Location = new System.Drawing.Point(388, 111);
            this.AlbumTitleTextBox.Name = "AlbumTitleTextBox";
            this.AlbumTitleTextBox.Size = new System.Drawing.Size(391, 20);
            this.AlbumTitleTextBox.TabIndex = 2;
            // 
            // AlbumArtistComboBox
            // 
            this.AlbumArtistComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlbumArtistComboBox.FormattingEnabled = true;
            this.AlbumArtistComboBox.Location = new System.Drawing.Point(388, 153);
            this.AlbumArtistComboBox.Name = "AlbumArtistComboBox";
            this.AlbumArtistComboBox.Size = new System.Drawing.Size(391, 21);
            this.AlbumArtistComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Album Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Artist:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 55);
            this.label4.TabIndex = 7;
            this.label4.Text = "Albums";
            // 
            // AddNewButton
            // 
            this.AddNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewButton.Location = new System.Drawing.Point(614, 196);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(107, 47);
            this.AddNewButton.TabIndex = 10;
            this.AddNewButton.Text = "Add New";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(501, 196);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(107, 47);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(388, 196);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(107, 47);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AlbumArtistComboBox);
            this.Controls.Add(this.AlbumTitleTextBox);
            this.Controls.Add(this.AlbumIdTextBox);
            this.Controls.Add(this.AlbumListBox);
            this.Name = "AlbumForm";
            this.Text = "AlbumForm";
            this.Load += new System.EventHandler(this.AlbumForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AlbumListBox;
        private System.Windows.Forms.TextBox AlbumIdTextBox;
        private System.Windows.Forms.TextBox AlbumTitleTextBox;
        private System.Windows.Forms.ComboBox AlbumArtistComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
    }
}