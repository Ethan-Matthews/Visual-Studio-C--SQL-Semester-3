using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using VideoGameDAL.Models;

namespace VideoGameDAL
{
    public static class DeveloperManager
    {
        public static List<Developer> GetDeveloperList()
        {
            // Create list to hold developer objects.
            List<Developer> developers = new List<Developer>();

            // Get connection from the database calss.
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "GetAllDevelopers";

                    // The reader executes commend text.
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Countines to read line unitl reader returns false.
                    while (reader.Read())
                    {
                        // Generates new developer object populated with the data from the reader.
                        // Adds developer object to list.
                        Developer developer = new Developer();
                        developer.DeveloperID = reader.GetInt32(0);
                        developer.DeveloperName = reader.GetString(1);
                        developer.CountryCode = reader.GetString(2);
                        developers.Add(developer);
                    }
                }
            }
            return developers;
        }

        public static Developer GetDeveloper(int developerID)
        {
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "GetDeveloper";
                    cmd.Parameters.AddWithValue("@DeveloperID", developerID);

                    // The reader executes commend text.
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        Developer developer = new Developer();
                        developer.DeveloperID = reader.GetInt32(0);
                        developer.DeveloperName = reader.GetString(1);
                        developer.CountryCode = reader.GetString(2);
                        return developer;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public static Developer InsertDeveloper(Developer developer)
        {
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "InsertDeveloper";
                    cmd.Parameters.AddWithValue("@developerName", developer.DeveloperName);
                    cmd.Parameters.AddWithValue("@countryCode", developer.CountryCode);

                    //Output Parameter.
                    SqlParameter outParam = new SqlParameter();
                    outParam.SqlDbType = System.Data.SqlDbType.Int;
                    outParam.ParameterName = "@newIdentity";
                    outParam.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(outParam);

                    cmd.ExecuteNonQuery();

                    //set the id
                    developer.DeveloperID = (int)cmd.Parameters["@newIdentity"].Value;

                    return developer;
                }
            }
        }

        public static int UpdateDeveloper(Developer developer)
        {
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateDeveloper";
                    cmd.Parameters.AddWithValue("@developerID", developer.DeveloperID);
                    cmd.Parameters.AddWithValue("@developerName", developer.DeveloperName);
                    cmd.Parameters.AddWithValue("@countryCode", developer.CountryCode);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected;
                }
            }
        }

        public static int DeleteDeveloper(int developerID)
        {
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "DeleteDeveloper";
                    cmd.Parameters.AddWithValue("@developerID", developerID);

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

        public static List<Developer> GetDevelopersWithCountryCode(string countryCode)
        {
            List<Developer> developers = new List<Developer>();

            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;

                    // Sql Command.
                    cmd.CommandText = "GetDevelopersWithCountryCode";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CountryCode", countryCode);

                    // The reader executes commend text.
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        Developer developer = new Developer();
                        developer.DeveloperID = reader.GetInt32(0);
                        developer.DeveloperName = reader.GetString(1);
                        developer.CountryCode = reader.GetString(2);
                        developers.Add(developer);
                    }
                    return developers;
                }
            }
        }
    }
}