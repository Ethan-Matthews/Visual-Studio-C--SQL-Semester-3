using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
