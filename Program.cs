using System;
using System.Data.SqlClient;

namespace _2BLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DB();
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB...;";
            var connection = new SqlConnection(connectionString);
            connection.Open();

            db.Select(connection);
            db.Insert(connection, 10, "Bielsko");
            connection.Close();
            Console.ReadKey();
        }
    }
}
