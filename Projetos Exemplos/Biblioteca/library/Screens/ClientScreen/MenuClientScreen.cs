using System;
using Biblioteca.Screens.ClientScreen;

namespace library.Screens.ClientScreen
{
    public static class MenuClientScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Usuário");
            Console.WriteLine("-----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar novo usuário");
            Console.WriteLine("2 - Listar usuários");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    CreateClientScreen.Load();
                    break;
                case 2:
                    ListClientScreen.Load();
                    break;
                default: Load(); break;
            }  
        }
    }
}