using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameDAL.Models;

namespace VideoGameDAL
{
    public static class VideoGameManager
    {
        public static List<VideoGame> GetGenreList()
        {
            // Create list to hold videoGame objects.
            List<VideoGame> videoGames = new List<VideoGame>();

            // Get connection from the database calss.
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;

                    // Sql Command.
                    cmd.CommandText = "Select * from VideoGame";

                    // The reader executes commend text.
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Countines to read line unitl reader returns false.
                    while (reader.Read())
                    {
                        // Generates new videoGame object populated with the data from the reader.
                        // Adds videoGame object to list.
                        VideoGame videoGame = new VideoGame();
                        videoGame.GameID = reader.GetInt32(0);
                        videoGame.Title = reader.GetString(1);
                        videoGame.ReleaseDate = reader.GetString(2);
                        videoGame.TotalHoursPlayed = reader.GetInt32(3);
                        videoGame.NumberOfAchievemnets = reader.GetInt32(4);
                        videoGame.DeveloperID = reader.GetInt32(5);
                        videoGame.GenreID = reader.GetInt32(6);
                        videoGames.Add(videoGame);
                    }
                }
            }
            return videoGames;
        }
    }
}
