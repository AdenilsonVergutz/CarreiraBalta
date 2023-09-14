using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio;
using Desafio.Models;
using Desafio.Repositories;

namespace Desafio.Screens.UserRoleScreen
{
    public class UpdateUserRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando um usuário ao perfil");
            Console.WriteLine("-------------");
            Console.Write("Código do usuário: ");
            var userId = Console.ReadLine();

            Console.Write("Código do perfil: ");
            var roleId = Console.ReadLine();

            Update(new UserRole
            {
                UserId = int.Parse(userId),
                RoleId = int.Parse(roleId)
            });
            
            Console.ReadKey();
            MenuUserRoleScreen.Load();
        }

        public static void Update(UserRole userRole)
        {
            try
            {
                var repository = new Repository<UserRole>(Database.Connection);
                repository.Update(userRole);
                Console.WriteLine("Usuário atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar o usuário desejado");
                Console.WriteLine(ex.Message);
            }
        }
    }
}