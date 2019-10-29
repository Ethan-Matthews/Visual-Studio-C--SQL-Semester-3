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
    public partial class GenreForm : Form
    {
        public GenreForm()
        {
            InitializeComponent();
        }

        private void GenreForm_Load(object sender, EventArgs e)
        {
            
            List<Genre> genres = GenreManager.GetGenreList();
            GenreListBox.DataSource = genres;
            GenreListBox.DisplayMember = "GenreName";

        }

        private void GenreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Genre genre = (Genre)GenreListBox.SelectedItem;

            GenreIDTB.Text = genre.GenreID.ToString();
            GenreNameTB.Text = genre.GenreName;

        }
    }
}
