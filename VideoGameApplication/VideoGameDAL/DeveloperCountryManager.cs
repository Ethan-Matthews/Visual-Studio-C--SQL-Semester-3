using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using VideoGameDAL.Models;

namespace VideoGameDAL
{
    public static class DeveloperCountryManager
    {
        public static List<DeveloperCountry> GetDeveloperCountryList()
        {
            // Create list to hold developerCountry objects.
            List<DeveloperCountry> developerCountries = new List<DeveloperCountry>();

            // Get connection from the database calss.
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "GetAllDeveloperCountries";

                    // The reader executes commend text.
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Countines to read line unitl reader returns false.
                    while (reader.Read())
                    {
                        // Generates new developerCountry object populated with the data from the reader.
                        // Adds developerCountry object to list.
                        DeveloperCountry developerCountry = new DeveloperCountry();
                        developerCountry.CountryCode = reader.GetString(0);
                        developerCountry.CountryName = reader.GetString(1);
                        developerCountries.Add(developerCountry);
                    }
                }
            }
            return developerCountries;
        }

        public static DeveloperCountry GetDeveloperCountry(string developerCountryCode)
        {
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "GetDeveloperCountry";
                    cmd.Parameters.AddWithValue("@DeveloperCountryCode", developerCountryCode);


                    // The reader executes commend text.
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        DeveloperCountry developerCountry = new DeveloperCountry();
                        developerCountry.CountryCode = reader.GetString(0);
                        developerCountry.CountryName = reader.GetString(1);
                        return developerCountry;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public static DeveloperCountry InsertDeveloperCountry(DeveloperCountry developerCountry)
        {
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "InsertDeveloperCountry";
                    cmd.Parameters.AddWithValue("@developerCountryCode", developerCountry.CountryCode);
                    cmd.Parameters.AddWithValue("@developerCountryName", developerCountry.CountryName);

                    cmd.ExecuteNonQuery();

                    return developerCountry;
                }
            }
        }

        public static int UpdateDeveloperCountry(DeveloperCountry developerCountry)
        {
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateDeveloperCountry";
                    cmd.Parameters.AddWithValue("@developerCountryCode", developerCountry.CountryCode);
                    cmd.Parameters.AddWithValue("@developerCountryName", developerCountry.CountryName);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected;
                }
            }
        }

        public static int DeleteDeveloperCountry(string developerCountryCode)
        {
            using (SqlConnection connection = DataBase.GetConnection())
            {
                // Create a command using the connection.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "DeleteDeveloperCountry";
                    cmd.Parameters.AddWithValue("@countryCode", developerCountryCode);

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
    }
}
