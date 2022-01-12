using System;
using phonebook.Repositories;
using PhoneBook.Models;

namespace PhoneBook.Screens.ContactScreen
{
    public class DeleteContactScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletando Contato");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("Insira o Id do Contato que deseja excluir:");
            var id = Console.ReadLine();
            Delete(int.Parse(id));
            Console.ReadKey();
        }

        public static void Delete(int id)
        {  try
        {
            var repository = new Repository<Contact>(Database.Connection);
            repository.Delete(id);
            Console.WriteLine("Contato deletado com sucesso.");
        }catch
        {
            Console.WriteLine("Não foi possivel deletar contato.");
        }
            
            
        }
    }
}