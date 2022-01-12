using System;
using library.Models;
using library.Repositories;
using library.Screens.ClientScreen;

namespace Biblioteca.Screens.ClientScreen
{
    public abstract class ListClientScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Listando Usuários");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            List();
            Console.ReadKey();
            MenuClientScreen.Load();
        }

        public static void List()
        {
            var repository = new Repository<Client>(Datebase.Connection);
            var clients = repository.Get();
            foreach(var item in clients)
                Console.WriteLine($"{item.Id} - {item.Nome}");
        }
    }
}