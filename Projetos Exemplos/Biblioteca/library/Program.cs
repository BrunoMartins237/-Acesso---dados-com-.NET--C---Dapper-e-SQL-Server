using System;
using Microsoft.Data.SqlClient;
using Dapper;
using library.Models;
using library.Repositories;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,1433;Database=library;User ID=sa;Password=1q2w3e4r@#$";
            var connection = new SqlConnection(connectionString);
            
                connection.Open();
                CreateClient(connection);
                ReadClients(connection);

                connection.Close();
        }
        public static void CreateClient(SqlConnection connection)
        {
            var repository = new Repository<Client>(connection);
            var client = new Client();
            client.Nome = "Júnior Filho";
            client.Phone = "8578965178";
            client.Email = "juniorfilhojunior@";
            client.Cpf = "0124568796455";
            client.Birthday = new DateTime(1980, 5, 3);
            client.Activated = true;

            repository.Create(client);

            Console.WriteLine("1 linha alterada");
        }
        public static void ReadClients(SqlConnection connection)
        {
            var repository = new Repository<Client>(connection);
            var clients = repository.Get();

            foreach(var client in clients)
                Console.WriteLine(client.Nome);
        }
    }
}
