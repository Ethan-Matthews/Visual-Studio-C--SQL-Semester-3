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

                    // Sql Command.
                    cmd.CommandText = "Select * from Genre";

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
    }
}