using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio;
using Desafio.Models;
using Desafio.Repositories;
using Microsoft.VisualBasic;

namespace Desafio.Screens.UserRoleScreen
{
    public class UpdateUserRoleScreen
    {

        public static Repository<UserRole> _repository = new Repository<UserRole>(Database.Connection);
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando um usuário ao perfil");
            Console.WriteLine("-------------");


            Console.Write("Código do usuário: ");
            var userId = Console.ReadLine();


            Console.Write("Código do perfil: ");
            var roleId = Console.ReadLine();

            var userRole = _repository.Get().FirstOrDefault(x => x.UserId == Convert.ToInt32(userId));
            if (userRole != null)
                Update(userRole);
            else
                Console.Write("UserRole Não achado");

            Console.ReadKey();
            MenuUserRoleScreen.Load();
        }

        public static void Update(UserRole userRole)
        {
            try
            {
                _repository.Update(userRole);
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