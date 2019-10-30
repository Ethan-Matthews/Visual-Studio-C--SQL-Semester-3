using ChinookDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinookDAL
{
    public static class ArtistManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">The is of the artist to update</param>
        /// <param name="name">The name of the artist</param>
        /// <returns>Number of rows affected</returns>
        public static int UpdateArtist(int id, string name)
        {
            using (SqlConnection conn = DB.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UpdateArtist";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@artistId", id);
                    cmd.Parameters.AddWithValue("@name", name);

                    return cmd.ExecuteNonQuery();
                }
            }
        }
        
        /// <summary>
        /// Deletes an Artist from the Database
        /// </summary>
        /// <param name="genreId">The id to delete</param>
        /// <returns>Number of rows affected</returns>
        public static int DeleteArtist(int artistId)
        {
            //get connection
            using (SqlConnection conn = DB.GetConnection())
            {
                //create command
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DeleteArtist";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //the stored proc expects one parameter - id
                    cmd.Parameters.AddWithValue("@artistId", artistId);

                    //run command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected;
                }
            }
        }

        /// <summary>
        /// Creates a new Artist object
        /// </summary>
        /// <param name="artist">The new Artist object</param>
        /// <returns>The created Artist object with new id</returns>
        public static Artist AddArtist(Artist artist)
        {
            using (SqlConnection conn = DB.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "AddArtist";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", artist.Name);

                    // Create the out paramenter, set the properites and add to command).
                    SqlParameter outParam = new SqlParameter();
                    outParam.SqlDbType = System.Data.SqlDbType.Int;
                    outParam.ParameterName = "@newId";
                    outParam.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(outParam);

                    cmd.ExecuteNonQuery();

                    //set the id with the new row id
                    artist.ArtistId = (int)cmd.Parameters["@newId"].Value;

                    return artist;
                }
            }
        }

        /// <summary>
        /// Returns the specified artist by id
        /// </summary>
        /// <param name="id">The id of the artist to retrieve</param>
        /// <returns>The artist object...or null if not found</returns>
        public static Artist GetArtistById(int id)
        {
            using (SqlConnection conn = DB.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "GetArtistById";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@artistId", id);

                    SqlDataReader reader = cmd.ExecuteReader();
                    //read the one row returned
                    if (reader.Read())
                    {
                        Artist a = new Artist();
                        a.ArtistId = reader.GetInt32(0);
                        a.Name = reader.GetString(1);

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
        /// Returns the specified artist by albumId
        /// </summary>
        /// <param name="id">The id of the artist to retrieve</param>
        /// <returns>The artist object...or null if not found</returns>
        public static Artist GetArtistForAlbum(int albumId)
        {
            using (SqlConnection conn = DB.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "GetArtistById";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@artistId", albumId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    //read the one row returned
                    if (reader.Read())
                    {
                        Artist a = new Artist();
                        a.ArtistId = reader.GetInt32(0);
                        a.Name = reader.GetString(1);

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
        /// Returns all artists sorted by name
        /// </summary>
        /// <returns>List of Artist objects</returns>
        public static List<Artist> GetArtistList()
        {
            List<Artist> artists = new List<Artist>();

            using (SqlConnection conn = DB.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "GetAllArtists";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader reader = cmd.ExecuteReader();
                    //read the rows returned and add to list
                    while (reader.Read())
                    {
                        Artist a = new Artist();
                        a.ArtistId = reader.GetInt32(0);
                        a.Name = reader.GetString(1);

                        //add to the list
                        artists.Add(a);
                    }

                    return artists;
                }

            }
        }
    }
}
