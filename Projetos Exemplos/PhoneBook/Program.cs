using System;
using Microsoft.Data.SqlClient;
using PhoneBook.Screens.ContactScreen;

namespace PhoneBook
{
    class Program
    {
        private const string connectionString = @"Server=localhost,1433;Database=phonebook;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";
        static void Main(string[] args)
        {
            
            Database.Connection = new SqlConnection(connectionString);
            Database.Connection.Open();
            Load();
            Console.ReadKey();
            Database.Connection.Close();
        }

        private static void Load()
        {
            Console.Clear();
            Console.WriteLine("Agenda Telefônica");
            Console.WriteLine("-----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Adicionar novo Contato");
            Console.WriteLine("2 - Visualizar Todos os Contatos");
            Console.WriteLine("3 - Atualizar Contato");
            Console.WriteLine("4 - Deletar Contato");
            var option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    CreateContactScreen.Load();
                    break;
                case 2:
                    ListContactScreen.Load();
                    break;
                case 3:
                    UpdateContactScreen.Load();
                    break;
                case 4:
                    DeleteContactScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
