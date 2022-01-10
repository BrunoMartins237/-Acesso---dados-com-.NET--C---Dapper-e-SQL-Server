using System;
using library.Screens.ClientScreen;
using Microsoft.Data.SqlClient;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,1433;Database=library;User ID=sa;Password=1q2w3e4r@#$";
            var connection = new SqlConnection(connectionString);
            
                connection.Open();
                
                Load();
                Console.ReadKey();
                connection.Close();
        }
        private static void Load()
        {
            Console.Clear();
            Console.WriteLine("Biblioteca Virtual");
            Console.WriteLine("------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de Usuário");
            var option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    MenuClientScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
    
