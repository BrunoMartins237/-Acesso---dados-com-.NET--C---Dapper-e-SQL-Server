using System;
using Biblioteca;
using library.Models;
using library.Repositories;

namespace library.Screens.ClientScreen
{
    public static class CreateClientScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Criando um Usuário");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Name:");
            var name = Console.ReadLine();
            Console.WriteLine("CPF:");
            var cpf = Console.ReadLine();
            Console.WriteLine("Data de Nascimento: dd-mm-aaaa");
            var birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("E-mail:");
            var email = Console.ReadLine();
            Console.WriteLine("Telefone:");
            var phone = Console.ReadLine();
            
            Create(new Client
            {
                Nome = name,
                Cpf = cpf,
                Birthday = birthday,
                Email = email,
                Phone = phone

            });
            Console.ReadKey();
            MenuClientScreen.Load();
            
            
        }

        public static void Create(Client client)
        {
            try{
            var repository = new Repository<Client>(Datebase.Connection);
            repository.Create(client);
            Console.WriteLine("Usuário cadastrado com sucesso.");
            } catch(Exception ex)
            {
                Console.WriteLine("Não foi possível salvar usuário.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}