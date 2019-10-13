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
        public static List<VideoGame> GetVideoGameList()
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
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    // Sql Command.
                    cmd.CommandText = "GetAllVideoGames";

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

        public static VideoGame GetVideoGame(int videoGameID)
        {
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;

                    // Sql Command.
                    cmd.CommandText = "GetVideoGame";

                    // The reader executes commend text.
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        VideoGame videoGame = new VideoGame();
                        videoGame.GameID = reader.GetInt32(0);
                        videoGame.Title = reader.GetString(1);
                        videoGame.ReleaseDate = reader.GetString(2);
                        videoGame.TotalHoursPlayed = reader.GetInt32(3);
                        videoGame.NumberOfAchievemnets = reader.GetInt32(4);
                        videoGame.DeveloperID = reader.GetInt32(5);
                        videoGame.GenreID = reader.GetInt32(6);
                        return videoGame;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public static VideoGame InsertVideoGame(VideoGame videoGame)
        {
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "InsertVideoGame";
                    cmd.Parameters.AddWithValue("@title", videoGame.Title);
                    cmd.Parameters.AddWithValue("@releaseDate", videoGame.ReleaseDate);
                    cmd.Parameters.AddWithValue("@totalHoursPlayed", videoGame.TotalHoursPlayed);
                    cmd.Parameters.AddWithValue("@numberOfAchievements", videoGame.NumberOfAchievemnets);
                    // Foreign Keys
                    cmd.Parameters.AddWithValue("@developerID", videoGame.DeveloperID);
                    cmd.Parameters.AddWithValue("@genreID", videoGame.GenreID);

                    videoGame.GameID = cmd.ExecuteNonQuery();

                    return videoGame;
                }
            }
        }

        public static int UpdateVideoGame(VideoGame videoGame)
        {
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateVideoGame";
                    cmd.Parameters.AddWithValue("@gameID", videoGame.GenreID);
                    cmd.Parameters.AddWithValue("@title", videoGame.Title);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected;
                }
            }
        }

        public static int DeleteVideoGame(int gameID)
        {
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "DeleteVideoGame";
                    cmd.Parameters.AddWithValue("gameID", gameID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected;
                }
            }
        }
    }
}
