using System;
using phonebook.Repositories;
using PhoneBook.Models;

namespace PhoneBook.Screens.ContactScreen
{
    public class ListContactScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Listando Contatos");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            List();
            Console.ReadKey();
        }

        public static void List()
        {  
            var repository = new Repository<Contact>(Database.Connection);
            var contacts = repository.Get();
            foreach(var item in contacts)
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Phone}");
            
        }
    }
}