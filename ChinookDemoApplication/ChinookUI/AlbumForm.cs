using ChinookDAL;
using ChinookDAL.Models;
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
    public partial class AlbumForm : Form
    {
        public AlbumForm()
        {
            InitializeComponent();
        }

        private void AlbumForm_Load(object sender, EventArgs e)
        {
            List<Artist> artists = ArtistManager.GetArtistList();
            AlbumArtistComboBox.DataSource = artists;
            AlbumArtistComboBox.DisplayMember = "Name";
            AlbumArtistComboBox.ValueMember = "ArtistId";

            List<Album> albums = AlbumManager.GetAlbumList();
            AlbumListBox.DataSource = albums;
            AlbumListBox.DisplayMember = "Title";
            AlbumListBox.ValueMember = "AlbumId";
        }

        private void AlbumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AlbumListBox.SelectedIndex > -1) // -1 = no selection
            {
                //UPDATE THE TEXTBOXES WITH THE NEW SELECTED ITEM
                Album selectedAlbum = (Album)AlbumListBox.SelectedItem;

                AlbumIdTextBox.Text = selectedAlbum.AlbumId.ToString();
                AlbumTitleTextBox.Text = selectedAlbum.Title;
                AlbumArtistComboBox.SelectedValue = selectedAlbum.ArtistId;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (AlbumIdTextBox.Text == string.Empty)
            {
                //CREATE NEW ALBUM ENTRY

                //new entry .... save as new
                Album a = new Album();
                a.Title = AlbumTitleTextBox.Text;
                a.ArtistId = Convert.ToInt32(AlbumArtistComboBox.SelectedValue);
                Album savedAlbum = AlbumManager.AddAlbum(a);

                //create successful
                MessageBox.Show("Album Added");

                //refresh the listbox
                List<Album> albumList = AlbumManager.GetAlbumList();
                AlbumListBox.DataSource = albumList;
            }
            else
            {
                //UPDATE EXISTING ALBUM ENTRY

                int albumId = int.Parse(AlbumIdTextBox.Text);
                string albumTitle = AlbumTitleTextBox.Text;
                int artistId = Convert.ToInt32(AlbumArtistComboBox.SelectedValue);

                if (AlbumManager.UpdateAlbum(albumId, albumTitle, artistId) == 1)
                {
                    //update successful
                    MessageBox.Show("Album Updated");

                    //refresh the album list
                    List<Album> albumList = AlbumManager.GetAlbumList();
                    AlbumListBox.DataSource = albumList;

                    //re-select the album from the list
                }
                else
                {
                    MessageBox.Show("Not Updated");
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //get currently selected album id to delete
            int albumId = int.Parse(AlbumIdTextBox.Text);

            //execute the delete with the DAL
            int rowsAffected = AlbumManager.DeleteAlbum(albumId);

            //check result
            if (rowsAffected == 1)
            {
                MessageBox.Show(
                    "Album Deleted",
                    "Deleted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //refresh the list box because the album was deleted
                AlbumListBox.DataSource = AlbumManager.GetAlbumList();
            }
            else
            {
                MessageBox.Show(
                    "Unable to delete album. Check log files for details",
                    "Unable to Delete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }



        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            //set the value of id in the textbox to be empty string
            AlbumIdTextBox.Text = string.Empty;

            //clear any value in the title textbox
            AlbumTitleTextBox.Text = string.Empty;

            //clear any selection in the listbox
            AlbumListBox.SelectedIndex = -1;

            //set focus to the name list box
            AlbumTitleTextBox.Focus();

            //select the first item in the artist listbox
            AlbumArtistComboBox.SelectedIndex = 0;
        }

        private void AlbumArtistComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
