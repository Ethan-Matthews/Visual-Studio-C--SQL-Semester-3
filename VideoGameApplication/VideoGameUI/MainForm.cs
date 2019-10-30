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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Form genreForm = new GenreForm();
            genreForm.MdiParent = this;
            genreForm.FormBorderStyle = FormBorderStyle.None;
            genreForm.Dock = DockStyle.Fill;
            genreForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to quit?");
            Application.Exit();
        }
    }
}
