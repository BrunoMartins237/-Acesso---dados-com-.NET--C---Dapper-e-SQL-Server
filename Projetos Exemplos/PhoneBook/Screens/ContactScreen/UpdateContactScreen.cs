using System;
using phonebook.Repositories;
using PhoneBook.Models;

namespace PhoneBook.Screens.ContactScreen
{
    public class UpdateContactScreen
    {
        public static void Load()
        {
            Console.Clear();
            
            Console.WriteLine("Atualizando Contato");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("Id:");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome:");
            var name = Console.ReadLine();
            Console.WriteLine("Telefone:");
            var phone = Console.ReadLine();

            Update(new Contact
            {
                Id = id,
                Name = name,
                Phone = phone
            });
            Console.ReadKey();
        }

        public static void Update(Contact contact)
        {   try
        {
            var repository = new Repository<Contact>(Database.Connection);
            repository.Update(contact);
            Console.WriteLine("Contato atualizado com sucesso.");
        }catch
        {
            Console.WriteLine("Contato não foi atualizado.");
        }
        }
    }
}