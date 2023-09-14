using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Models;
using Desafio.Repositories;

namespace Desafio.Screens.UserRoleScreen
{
    public class DeleteUserRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir um perfil do usuário");
            Console.WriteLine("-------------");
            Console.Write("Qual o código do usuário que deseja exluir o perfil? ");
            var UserId = Console.ReadLine();

            Delete(int.Parse(UserId));
            Console.ReadKey();
            MenuUserRoleScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<UserRole>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Vinculo exluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir");
                Console.WriteLine(ex.Message);
            }
        }
    }
}