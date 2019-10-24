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
    public partial class GenresForm : Form
    {
        public GenresForm()
        {
            InitializeComponent();
        }

        private void GenresForm_Load(object sender, EventArgs e)
        {
            List<Genre> genres = GenreManager.GetGenreList();
            GenresLB.DataSource = genres;
            GenresLB.DisplayMember = "GenreName";
        }

        private void GenreLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Genre selectedGenre = (Genre)GenresLB.SelectedItem;
            GenreIDTB.Text = selectedGenre.GenreID.ToString();
            GenreNameTB.Text = selectedGenre.GenreName;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Genre genre = new Genre();
            genre.GenreID = int.Parse(GenreIDTB.Text);
            genre.GenreName = GenreNameTB.Text;
            int rowsAffected = GenreManager.UpdateGenre(genre);
            if (rowsAffected > 0)
            {
                List<Genre> genreList = GenreManager.GetGenreList();
                GenresLB.DataSource = genreList;
                MessageBox.Show(rowsAffected + " Genre(s) Updated.");
            }
            else
            {
                MessageBox.Show("Genre(s) Not updated.");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int genreID = int.Parse(GenreIDTB.Text);
            int rowsAffected;
            try
            {
                rowsAffected = GenreManager.DeleteGenre(genreID);
            } 
            catch (SqlException ex)
            {
                // Maybe Log the exception?
                Console.WriteLine(ex.StackTrace);
            }

            //if (rowsAffected > 0)
            //{
            //    MessageBox.Show("Genre Deleted.");
            //}
            //else
            //{
            //    MessageBox.Show("Genre not Deleted.");
            //}
        }
    }
}