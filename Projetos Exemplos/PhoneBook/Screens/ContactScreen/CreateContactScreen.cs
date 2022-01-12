using System;
using phonebook.Repositories;
using PhoneBook.Models;

namespace PhoneBook.Screens.ContactScreen
{
    public class CreateContactScreen
    {
        public static void Load()
        {
            Console.Clear();
            
            Console.WriteLine("Adicionando Novo Contato");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("Nome:");
            var name = Console.ReadLine();
            Console.WriteLine("Telefone:");
            var phone = Console.ReadLine();

            Create(new Contact
            {
                Name = name,
                Phone = phone
            });
            Console.ReadKey();
        }

        public static void Create(Contact contact)
        {   try
        {
            var repository = new Repository<Contact>(Database.Connection);
            repository.Create(contact);
            Console.WriteLine("Contato adicionado com sucesso.");
        }catch
        {
            Console.WriteLine("Contato adicionado com sucesso.");
        }
        }
    }
}