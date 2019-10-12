using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameDAL
{
    public static class DataBase
    {
        public static string ConnectionString 
        {
            get
            {
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                            Initial Catalog=VideoGameDB;
                                            Integrated Security=True;
                                            Connect Timeout=60;Encrypt=False;
                                            TrustServerCertificate=False;
                                            ApplicationIntent=ReadWrite;
                                            MultiSubnetFailover=False";
                return connectionString;
            }
        }

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            return connection;
        }



    }
}
