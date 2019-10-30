using ChinookDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinookDAL
{
    public static class AlbumManager
    {
        /// <summary>
        /// Updates a specified album with new data
        /// </summary>
        /// <param name="id">The id of the album to update</param>
        /// <param name="name">The name of the album</param>
        /// <param name="artistId">The id of the artist for this album</param>
        /// <returns>Number of rows affected</returns>
        public static int UpdateAlbum(int id, string title, int artistId)
        {
            using (SqlConnection conn = DB.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UpdateAlbum";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@albumId", id);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@artistId", artistId);

                    return cmd.ExecuteNonQuery();
                }
            }
        }
        
        /// <summary>
        /// Deletes an Album from the Database
        /// </summary>
        /// <param name="albumId">The id to delete</param>
        /// <returns>Number of rows affected</returns>
        public static int DeleteAlbum(int albumId)
        {
            //get connection
            using (SqlConnection conn = DB.GetConnection())
            {
                //create command
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DeleteAlbum";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //the stored proc expects one parameter - id
                    cmd.Parameters.AddWithValue("@albumId", albumId);

                    //run command
                    int rowsAffected = 0;
                    try
                    {
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    catch(SqlException ex)
                    {
                        //do some logging here
                    }

                    return rowsAffected;
                }
            }
        }

        /// <summary>
        /// Creates a new Album object
        /// </summary>
        /// <param name="album">The new Album object</param>
        /// <returns>The created Album object with new id</returns>
        public static Album AddAlbum(Album album)
        {
            using (SqlConnection conn = DB.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "AddAlbum";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@title", album.Title);
                    cmd.Parameters.AddWithValue("@artistId", album.ArtistId);

                    // Create the out paramenter, set the properites and add to command).
                    SqlParameter outParam = new SqlParameter();
                    outParam.SqlDbType = System.Data.SqlDbType.Int;
                    outParam.ParameterName = "@newId";
                    outParam.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(outParam);

                    cmd.ExecuteNonQuery();

                    //set the id with the new row id
                    album.AlbumId = (int)cmd.Parameters["@newId"].Value;

                    return album;
                }
            }
        }

        /// <summary>
        /// Returns the specified artist by id
        /// </summary>
        /// <param name="id">The id of the album to retrieve</param>
        /// <returns>The album object...or null if not found</returns>
        public static Album GetAlbumById(int id)
        {
            using(SqlConnection conn = DB.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "GetAlbumById";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@albumId", id);

                    SqlDataReader reader = cmd.ExecuteReader();
                    //read the one row returned
                    if (reader.Read())
                    {
                        Album a = new Album();
                        a.AlbumId = reader.GetInt32(0);
                        a.Title = reader.GetString(1);
                        a.ArtistId = reader.GetInt32(2);

                        return a;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        /// <summary>
        /// Returns all albums sorted by title
        /// </summary>
        /// <returns>List of Album objects</returns>
        public static List<Album> GetAlbumList()
        {
            List<Album> albums = new List<Album>();

            using (SqlConnection conn = DB.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "GetAllAlbums";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader reader = cmd.ExecuteReader();
                    //read the rows returned and add to list
                    while (reader.Read())
                    {
                        Album a = new Album();
                        a.AlbumId = reader.GetInt32(0);
                        a.Title = reader.GetString(1);
                        a.ArtistId = reader.GetInt32(2);

                        //add to the list
                        albums.Add(a);
                    }

                    return albums;
                }

            }
        }
    }
}
