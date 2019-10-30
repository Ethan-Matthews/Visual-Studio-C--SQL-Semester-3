using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoGameDAL;
using VideoGameDAL.Models;

namespace VideoGameUI
{
    public partial class GenreForm : Form
    {
        public GenreForm()
        {
            InitializeComponent();
        }

        private void GenreForm_Load(object sender, EventArgs e)
        {

            UpdateGenreListView();
            GenreListBox.DisplayMember = "GenreName";

        }

        private void GenreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GenreListBox.SelectedIndex > -1)
            {
                Genre genre = (Genre)GenreListBox.SelectedItem;

                GenreIDTB.Text = genre.GenreID.ToString();
                GenreNameTB.Text = genre.GenreName;

            }
        }

        private void SaveBN_Click(object sender, EventArgs e)
        {
            if (GenreIDTB.Text == string.Empty)
            {
                Genre newGenre = new Genre();
                newGenre.GenreName = GenreNameTB.Text;
                GenreManager.InsertGenre(newGenre);

                MessageBox.Show("Genre Inserted.");
                UpdateGenreListView();
            }
            else
            {
                Genre genre = (Genre)GenreListBox.SelectedItem;
                genre.GenreName = GenreNameTB.Text;
                int listIndex = GenreListBox.SelectedIndex;

                GenreManager.UpdateGenre(genre);

                if (GenreManager.UpdateGenre(genre) == 1)
                {
                    MessageBox.Show("Genre Updated.");
                    List<Genre> genreList = GenreManager.GetGenreList();
                    UpdateGenreListView();
                    GenreListBox.SelectedIndex = listIndex;
                }
                else
                {
                    MessageBox.Show("Warning! Genre Not Updated.");
                }
            }
        }

        private void deleteBN_Click(object sender, EventArgs e)
        {
            int id = int.Parse(GenreIDTB.Text);
            int rowsaffected = GenreManager.DeleteGenre(id);

            if (rowsaffected == 1)
            {
                MessageBox.Show("Genre Deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateGenreListView();
            }
            else
            {
                MessageBox.Show("Unable to delete genre.\nThis genre is in use as a foreign key.",
                                "Error Deleting", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }

        private void InsertGenreBN_Click(object sender, EventArgs e)
        {

            GenreIDTB.Text = string.Empty;
            GenreNameTB.Text = string.Empty;
            GenreListBox.SelectedIndex = -1;
            GenreNameTB.Focus();
        }

        private void UpdateGenreListView() 
        {
            List<Genre> genreList = GenreManager.GetGenreList();
            GenreListBox.DataSource = genreList;
        }
    }
}
