using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace _2BLab1
{
    class DB
    {
        public void Select(SqlConnection connection)
        {
            var query = "SELECT * FROM Customers";
            var command = new SqlCommand(query, connection);

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["CompanyName"]);
            }

            reader.Close();
        }

        public void Insert(SqlConnection connection, int id, string description)
        {
            var query = "INSERT INTO region(regionId, regionDescription)" + "VALUES (@id, @description)";

            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id",id);
            command.Parameters.AddWithValue("@description",description);

            var affected = command.ExecuteNonQuery();
            Console.WriteLine($"{affected} rows affected");
        }

        public void Delete(SqlConnection connection, int id, string description)
        {
            var query = "DELETE FROM region WHERE regionId = @id AND regionDescription = @description";

            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@description", description); // dodawanie parametrow do komendy

            var affected = command.ExecuteNonQuery();
            Console.WriteLine($"{affected} rows affected");
        }
    }
}
