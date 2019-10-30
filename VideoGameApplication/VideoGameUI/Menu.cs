using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGameUI
{
    public partial class Menu : Form
    {
        MainForm main;

        public Menu(MainForm main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e) {}

        private void GameBN_Click(object sender, EventArgs e)
        {
            Form gameForm = new VideoGameForm();
            gameForm.MdiParent = main;
            gameForm.FormBorderStyle = FormBorderStyle.None;
            gameForm.Dock = DockStyle.Fill;
            gameForm.Show();
        }

        private void DeveloperBN_Click(object sender, EventArgs e)
        {
            Form devForm = new DeveloperForm();
            devForm.MdiParent = main;
            devForm.FormBorderStyle = FormBorderStyle.None;
            devForm.Dock = DockStyle.Fill;
            devForm.Show();
        }

        private void GenreBN_Click(object sender, EventArgs e)
        {
            Form genreForm = new GenreForm();
            genreForm.MdiParent = main;
            genreForm.FormBorderStyle = FormBorderStyle.None;
            genreForm.Dock = DockStyle.Fill;
            genreForm.Show();
        }

        private void CountryBN_Click(object sender, EventArgs e)
        {
            Form devCountryForm = new DeveloperCountryForm();
            devCountryForm.MdiParent = main;
            devCountryForm.FormBorderStyle = FormBorderStyle.None;
            devCountryForm.Dock = DockStyle.Fill;
            devCountryForm.Show();
        }
    }
}
