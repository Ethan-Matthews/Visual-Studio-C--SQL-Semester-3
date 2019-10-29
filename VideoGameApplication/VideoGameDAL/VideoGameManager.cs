using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                        videoGame.ReleaseDate = reader.GetDateTime(2);
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
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@gameID", videoGameID);

                    // The reader executes commend text.
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        VideoGame videoGame = new VideoGame();
                        videoGame.GameID = reader.GetInt32(0);
                        videoGame.Title = reader.GetString(1);
                        videoGame.ReleaseDate = reader.GetDateTime(2);
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

                    //Output Parameter.
                    SqlParameter outParam = new SqlParameter();
                    outParam.SqlDbType = System.Data.SqlDbType.Int;
                    outParam.ParameterName = "@newIdentity";
                    outParam.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(outParam);

                    cmd.ExecuteNonQuery();

                    //set the id
                    videoGame.GameID = (int)cmd.Parameters["@newIdentity"].Value;

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
                    cmd.Parameters.AddWithValue("@gameID", videoGame.GameID);
                    cmd.Parameters.AddWithValue("@title", videoGame.Title);
                    cmd.Parameters.AddWithValue("@releaseDate", videoGame.ReleaseDate);
                    cmd.Parameters.AddWithValue("@totalHoursPlayed", videoGame.TotalHoursPlayed);
                    cmd.Parameters.AddWithValue("@numberOfAchievements", videoGame.NumberOfAchievemnets);
                    cmd.Parameters.AddWithValue("@developerID", videoGame.DeveloperID);
                    cmd.Parameters.AddWithValue("@genreID", videoGame.GenreID);

                    int rowsAffected = (int)cmd.ExecuteNonQuery();

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

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Cannot delete this record it is associated with other record.\n\n" + ex.Message + "\n");
                        return 0;
                    }
                }
            }
        }

        public static List<VideoGame> GetGenreGames(int genreID)
        {
            List<VideoGame> videoGames = new List<VideoGame>();

            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;

                    // Sql Command.
                    cmd.CommandText = "GetVideoGameWithGenreID";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@genreID", genreID);

                    // The reader executes commend text.
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        VideoGame videoGame = new VideoGame();
                        videoGame.GameID = reader.GetInt32(0);
                        videoGame.Title = reader.GetString(1);
                        videoGame.ReleaseDate = reader.GetDateTime(2);
                        videoGame.TotalHoursPlayed = reader.GetInt32(3);
                        videoGame.NumberOfAchievemnets = reader.GetInt32(4);
                        videoGame.DeveloperID = reader.GetInt32(5);
                        videoGame.GenreID = reader.GetInt32(6);
                        videoGames.Add(videoGame);
                    }
                    return videoGames;
                }
            }
        }

        public static List<VideoGame> GetDeveloperGames(int developerID)
        {
            List<VideoGame> videoGames = new List<VideoGame>();

            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;

                    // Sql Command.
                    cmd.CommandText = "GetVideoGameWithDeveloperID";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@developerID", developerID);

                    // The reader executes commend text.
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        VideoGame videoGame = new VideoGame();
                        videoGame.GameID = reader.GetInt32(0);
                        videoGame.Title = reader.GetString(1);
                        videoGame.ReleaseDate = reader.GetDateTime(2);
                        videoGame.TotalHoursPlayed = reader.GetInt32(3);
                        videoGame.NumberOfAchievemnets = reader.GetInt32(4);
                        videoGame.DeveloperID = reader.GetInt32(5);
                        videoGame.GenreID = reader.GetInt32(6);
                        videoGames.Add(videoGame);
                    }
                    return videoGames;
                }
            }
        }
    }
}
