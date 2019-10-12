using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                    // Sql Command.
                    cmd.CommandText = "Select * from Developer";

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

                    // Sql Command.
                    cmd.CommandText = "Select * from Developer where DeveloperID = " + developerID + ";";

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
    }
}
