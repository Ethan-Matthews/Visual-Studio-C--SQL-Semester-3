using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                    // Sql Command.
                    cmd.CommandText = "Select * from DeveloperCountry";

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

                    // Sql Command.
                    cmd.CommandText = "Select * from DeveloperCountry where CountryCode = '" + developerCountryCode + "';";

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
    }
}
