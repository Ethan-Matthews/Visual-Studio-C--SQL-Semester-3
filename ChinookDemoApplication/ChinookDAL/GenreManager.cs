using ChinookDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinookDAL
{
    public static class GenreManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">The is of the genre to update</param>
        /// <param name="name">The name of the genre</param>
        /// <returns>Number of rows affected</returns>
        public static int UpdateGenre(int id, string name)
        {
            using (SqlConnection conn = DB.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UpdateGenre";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@genreId", id);
                    cmd.Parameters.AddWithValue("@name", name);

                    return cmd.ExecuteNonQuery();
                }
            }
        }
        
        /// <summary>
        /// Deletes a Genre from the Database
        /// </summary>
        /// <param name="genreId">The id to delete</param>
        /// <returns>Number of rows affected</returns>
        public static int DeleteGenre(int genreId)
        {
            //get connection
            using (SqlConnection conn = DB.GetConnection())
            {
                //create command
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DeleteGenre";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //the stored proc expects one parameter - id
                    cmd.Parameters.AddWithValue("@genreId", genreId);

                    int rowsAffected = 0;

                    try
                    {
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        //maybe some logging?
                    }

                    return rowsAffected;
                }
            }
        }

        /// <summary>
        /// Creates a new Genre object
        /// </summary>
        /// <param name="genre">The new Genre object</param>
        /// <returns>The created Genre object with new id</returns>
        public static Genre AddGenre(Genre genre)
        {
            using (SqlConnection conn = DB.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "AddGenre";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", genre.Name);

                    // Create the out paramenter, set the properites and add to command).
                    SqlParameter outParam = new SqlParameter();
                    outParam.SqlDbType = System.Data.SqlDbType.Int;
                    outParam.ParameterName = "@newId";
                    outParam.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(outParam);

                    cmd.ExecuteNonQuery();

                    //set the id with the new row id
                    genre.GenreId = (int)cmd.Parameters["@newId"].Value;

                    return genre;
                }
            }
        }

        /// <summary>
        /// Returns the specified genre by id
        /// </summary>
        /// <param name="id">The id of the genre to retrieve</param>
        /// <returns>The genre object...or null if not found</returns>
        public static Genre GetGenreById(int id)
        {
            using(SqlConnection conn = DB.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "GetGenreById";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@genreId", id);

                    SqlDataReader reader = cmd.ExecuteReader();
                    //read the one row returned
                    if (reader.Read())
                    {
                        Genre g = new Genre();
                        g.GenreId = reader.GetInt32(0);
                        g.Name = reader.GetString(1);

                        return g;
                    }
                    else
                    {
                        return null;
                    }

                }

            }
        }

        /// <summary>
        /// Returns all genres
        /// </summary>
        /// <returns>List of Genre objects</returns>
        public static List<Genre> GetGenreList()
        {
            List<Genre> genres = new List<Genre>();

            using (SqlConnection conn = DB.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "GetAllGenres";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader reader = cmd.ExecuteReader();
                    //read the one row returned
                    while (reader.Read())
                    {
                        Genre g = new Genre();
                        g.GenreId = reader.GetInt32(0);
                        g.Name = reader.GetString(1);

                        //add to the list
                        genres.Add(g);
                    }

                    return genres;
                }

            }
        }
    }
}
