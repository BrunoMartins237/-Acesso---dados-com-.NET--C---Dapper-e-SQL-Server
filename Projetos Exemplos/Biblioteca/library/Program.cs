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
            using (var connection = new SqlConnection(connectionString))
            {
                //CreateClient(connection);
                ListClient(connection);
            }
             
        }
        static void CreateClient(SqlConnection connection)
            {
                var client = new Client();
                client.Id = Guid.NewGuid();
                client.Nome = "Bruno Martins";
                client.Cpf = "03286941575";
                client.Birthday = new DateTime(1996,12,07);
                client.Email = "brunomartins@gmail.br";
                client.Phone = "888-888-888";
                client.Activated = true;

                var sql =@"INSERT INTO
                        [Client]
                    VALUES(
                        @Id,
                        @Name,
                        @cpf,
                        @Birthday,
                        @Email,
                        @Phone,
                        @Activated)";

                var rows = connection.Execute(sql, new
                {
                    client.Id,
                    client.Nome,
                    client.Cpf,
                    client.Birthday,
                    client.Email,
                    client.Phone,
                    client.Activated
                });
                Console.WriteLine($"{rows} 1 linha inserida");
            }
        
            static void ListClient(SqlConnection connection)
            {
                
                var repository = new ClientRepository();
                var clients = repository.Get();
                foreach(var client in clients)
                    Console.WriteLine($"Id: {client.Id} - Nome: {client.Nome}");
                
            }
    }
}
