using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChinookUI
{
    public partial class ChinookHomeForm : Form
    {
        private Dictionary<string, Form> childForms 
            = new Dictionary<string, Form>();

        public ChinookHomeForm()
        {
            InitializeComponent();
        }

        private void ChinookHomeForm_Load(object sender, EventArgs e)
        { 
            childForms.Add("genres", new GenreForm());
            childForms.Add("albums", new AlbumForm());
            //childForms.Add("artists", new ArtistForm());
            //childForms.Add("tracks", new TrackForm());

            foreach (KeyValuePair<string, Form> childForm in childForms)
            {
                childForm.Value.MdiParent = this;
                childForm.Value.FormBorderStyle = FormBorderStyle.None;
                childForm.Value.Dock = DockStyle.Fill;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }

        private void GenresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
                ActiveMdiChild.Hide();

            childForms["genres"].Show();
        }

        private void AlbumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
                ActiveMdiChild.Hide();

            childForms["albums"].Show();
        }
    }
}
