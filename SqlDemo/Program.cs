using System;
using System.Data.SqlClient;


namespace SqlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=everyloop;Trusted_Connection=True;";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            while (true)
            {
                Console.Write("Enter search string: ");
                string searchString = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(searchString)) break;

                FetchAirports(connection, searchString);
            }

            connection.Close();
        }

        static void FetchAirports(SqlConnection connection, string searchString)
        {
            try
            {
                string query = $"select top 5 Iata, [Airport Name], [Location Served] from Airports where [Airport Name] like '%' + @userInput + '%'";


                Console.WriteLine($"Sending query: {query}");
                Console.WriteLine();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("userInput", System.Data.SqlDbType.NVarChar).Value = searchString;

                SqlDataReader reader = command.ExecuteReader();

                Console.Write(reader.GetName(0).PadRight(10));
                Console.Write(reader.GetName(1).PadRight(50));
                Console.Write(reader.GetName(2).PadRight(50));

                Console.WriteLine();

                while (reader.Read())
                {                    
                    Console.Write(reader.GetValue(0).ToString().PadRight(10));
                    Console.Write(reader.GetValue(1).ToString().PadRight(50));
                    Console.Write(reader.GetValue(2).ToString().PadRight(50));

                    Console.WriteLine();
                }

                Console.WriteLine();

                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
