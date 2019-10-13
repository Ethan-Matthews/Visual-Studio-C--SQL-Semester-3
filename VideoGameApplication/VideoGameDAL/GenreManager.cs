using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameDAL.Models;

namespace VideoGameDAL
{
    public static class GenreManager
    {
        public static List<Genre> GetGenreList()
        {
            // Create list to hold genre objects.
            List<Genre> genres = new List<Genre>();

            // Get connection from the database calss.
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "GetAllGenres";

                    // The reader executes commend text.
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Countines to read line unitl reader returns false.
                    while (reader.Read())
                    {
                        // Generates new genre object populated with the data from the reader.
                        // Adds genre object to list.
                        Genre genre = new Genre();
                        genre.GenreID = reader.GetInt32(0);
                        genre.GenreName = reader.GetString(1);
                        genres.Add(genre);
                    }
                }
            }
            return genres;
        }

        public static Genre GetGenre(int genreID)
        {
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "GetGenre";
                    cmd.Parameters.AddWithValue("@genreID", genreID);

                    // The reader executes commend text.
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        Genre genre = new Genre();
                        genre.GenreID = reader.GetInt32(0);
                        genre.GenreName = reader.GetString(1);
                        return genre;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public static Genre InsertGenre(Genre genre)
        {
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "InsertGenre";
                    cmd.Parameters.AddWithValue("@genreName", genre.GenreName);
                    //Output Parameter.
                    SqlParameter outParam = new SqlParameter();
                    outParam.SqlDbType = System.Data.SqlDbType.Int;
                    outParam.ParameterName = "@newIdentity";
                    outParam.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(outParam);

                    cmd.ExecuteNonQuery();

                    //set the id
                    genre.GenreID = (int)cmd.Parameters["@newIdentity"].Value;

                    return genre;
                }
            }
        }

        public static int UpdateGenre(Genre genre)
        {
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateGenre";
                    cmd.Parameters.AddWithValue("@genreID", genre.GenreID);
                    cmd.Parameters.AddWithValue("@genreName", genre.GenreName);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected;
                }
            }
        }

        public static int DeleteGenre(int genreID)
        {
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "DeleteGenre";
                    cmd.Parameters.AddWithValue("genreID", genreID);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Cannot delete this record this is associated with other record.\n\n" + ex.Message + "\n");
                        return 0;
                    }
                }
            }
        }
    }
}