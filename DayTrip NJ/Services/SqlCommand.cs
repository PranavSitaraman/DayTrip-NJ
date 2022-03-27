using System;
using Microsoft.SqlServer;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DayTrip_NJ.Services
{
    class SqlCommand : IDisposable
    {
        private string sql;
        private SqlConnection connection;
        public SqlCommand(string sql, SqlConnection connection)
        {
            this.sql = sql;
            this.connection = connection;
        }
        public void Dispose()
        {
        }
        static void Main(string[] args)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localpin.database.windows.net";
                builder.UserID = "sitaraman";
                builder.Password = "PranavSit456";
                builder.InitialCatalog = "localpin";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    String sql = "SELECT name, collation_name FROM sys.databases";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }
        private SqlDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }
    }
}