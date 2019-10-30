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
    public partial class VideoGameForm : Form
    {
        public VideoGameForm()
        {
            InitializeComponent();
        }

        private void VideoGameForm_Load(object sender, EventArgs e)
        {
            UpdateGameListView();
            VideoGameListBox.DisplayMember = "Title";

            List<Developer> dev = DeveloperManager.GetDeveloperList();
            DeveloperCB.DataSource = dev;
            DeveloperCB.DisplayMember = "DeveloperName";
            DeveloperCB.ValueMember = "DeveloperID";

            List<Genre> genre = GenreManager.GetGenreList();
            GenreCB.DataSource = genre;
            GenreCB.DisplayMember = "GenreName";
            GenreCB.ValueMember = "GenreID";


        }

        private void UpdateGameListView()
        {
            List<VideoGame> gameList = VideoGameManager.GetVideoGameList();
            VideoGameListBox.DataSource = gameList;
        }

        private void VideoGameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VideoGameListBox.SelectedIndex > -1)
            {
                VideoGame game = (VideoGame)VideoGameListBox.SelectedItem;

                GameIDTB.Text = game.GameID.ToString();
                TitleTB.Text = game.Title;
                ReleaseDateTB.Text = game.ReleaseDate.ToString();
                HoursPlayedTB.Text = game.TotalHoursPlayed.ToString();
                NumAchievTB.Text = game.NumberOfAchievemnets.ToString();

                DeveloperCB.SelectedValue = game.DeveloperID;
                GenreCB.SelectedValue = game.GenreID;
            }
        }

        private void SaveBN_Click(object sender, EventArgs e)
        {
            if (GameIDTB.Text == string.Empty)
            {
                VideoGame newGame = new VideoGame();
                newGame.Title = TitleTB.Text;
                newGame.ReleaseDate = DateTime.Parse(ReleaseDateTB.Text);
                newGame.TotalHoursPlayed = int.Parse(HoursPlayedTB.Text);
                newGame.NumberOfAchievemnets = int.Parse(NumAchievTB.Text);
                newGame.DeveloperID = ((Developer)DeveloperCB.SelectedItem).DeveloperID;
                newGame.GenreID = ((Genre)GenreCB.SelectedItem).GenreID;
                VideoGameManager.InsertVideoGame(newGame);

                MessageBox.Show("Game Inserted.");
                UpdateGameListView();
            }
            else
            {
                try
                {
                    VideoGame game = (VideoGame)VideoGameListBox.SelectedItem;
                    game.Title = TitleTB.Text;
                    game.ReleaseDate = DateTime.Parse(ReleaseDateTB.Text);
                    game.TotalHoursPlayed = int.Parse(HoursPlayedTB.Text);
                    game.NumberOfAchievemnets = int.Parse(NumAchievTB.Text);
                    game.DeveloperID = ((Developer)DeveloperCB.SelectedItem).DeveloperID;
                    game.GenreID = ((Genre)GenreCB.SelectedItem).GenreID;
                    int listIndex = VideoGameListBox.SelectedIndex;

                    VideoGameManager.UpdateVideoGame(game);

                    if (VideoGameManager.UpdateVideoGame(game) == 1)
                    {
                        MessageBox.Show("Game Updated.");
                        List<VideoGame> gameList = VideoGameManager.GetVideoGameList();
                        UpdateGameListView();
                        VideoGameListBox.SelectedIndex = listIndex;
                    }
                    else
                    {
                        MessageBox.Show("Warning! Game Not Updated.");
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message.ToString()); 
                    MessageBox.Show("Warning! Game Not Updated.\nCheck your formatting");
                }
            }
        }

        private void DeleteBN_Click(object sender, EventArgs e)
        {
            int id = int.Parse(GameIDTB.Text);
            int rowsaffected = VideoGameManager.DeleteVideoGame(id);

            if (rowsaffected == 1)
            {
                MessageBox.Show("Game Deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateGameListView();
            }
            else
            {
                MessageBox.Show("Unable to delete Game.\nThis Game is in use as a foreign key.",
                                "Error Deleting",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void InsertBN_Click(object sender, EventArgs e)
        {
            GameIDTB.Text = string.Empty;
            TitleTB.Text = string.Empty;
            ReleaseDateTB.Text = string.Empty;
            HoursPlayedTB.Text = string.Empty;
            NumAchievTB.Text = string.Empty;
            DeveloperCB.SelectedIndex = -1;
            GenreCB.SelectedIndex = -1;
            VideoGameListBox.SelectedIndex = -1;
            TitleTB.Focus();
        }

        private void BackBN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
