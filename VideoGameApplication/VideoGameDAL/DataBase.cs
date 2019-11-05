using System.Data.SqlClient;
using System.Configuration;

namespace VideoGameDAL
{
    public static class DataBase
    {
        public static string ConnectionString 
        {
            get
            {
                //string connectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VideoGameDB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                string connectionString = "Data Source=videogamedb-server.database.windows.net;Initial Catalog=VideoGameDB(Azure);User ID=w0420789;Password=student1!;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                return connectionString;
            }
        }

        public static SqlConnection GetConnection()
        {
            string activeCS = ConfigurationManager.AppSettings["activeConnectionString"];
            string conString = ConfigurationManager.ConnectionStrings[activeCS].ConnectionString;
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            return connection;
        }
    }
}