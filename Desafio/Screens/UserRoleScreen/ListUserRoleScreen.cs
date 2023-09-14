using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Models;
using Desafio.Repositories;

namespace Desafio.Screens.UserRoleScreen
{
    public class ListUserRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de usuários e perfis vinculados");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuUserRoleScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<UserRole>(Database.Connection);
            var userRole = repository.Get();
            foreach (var item in userRole)
                Console.WriteLine($"Código usuário: {item.UserId} - Perfil código: {item.RoleId}");
        }
    }
}