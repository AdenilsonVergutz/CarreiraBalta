using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Models;
using Desafio.Repositories;

namespace Desafio.Screens.UserScreens
{
    public class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de usuários cadastrados");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<User>(Database.Connection);
            var users = repository.Get();

            Console.WriteLine("Código   --   Nome    -   Email   -    Bio     -   Perfil");


            foreach (var item in users)
            Console.WriteLine($"{item.Id} - {item.Name} - {item.Email} - {item.Bio} - {item.RoleId} - ({item.RoleName})");
        }
    }
}