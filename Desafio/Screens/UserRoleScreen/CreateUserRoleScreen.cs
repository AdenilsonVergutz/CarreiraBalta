//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Desafio.Models;
//using Desafio.Repositories;

//namespace Desafio.Screens.UserRoleScreen
//{
//    public class CreateUserRoleScreen
//    {
//        public static void Load()
//        {
//            Console.Clear();
//            Console.WriteLine("Informe o usuário e perfil que deseja vincular");
//            Console.WriteLine("-------------");
//            Console.Write("Código do usuário: ");
//            var userId = Console.ReadLine();

//            Console.Write("Código do perfil: ");
//            var roleId = Console.ReadLine();

//            Create(new UserRole
//            {
//                UserId = int.Parse(userId),
//                RoleId = int.Parse(roleId)
//            });
//            Console.ReadKey();
//            MenuUserRoleScreen.Load();
//        }

//        public static void Create(UserRole userRole)
//        {
//            try
//            {
//                var repository = new Repository<UserRole>(Database.Connection);
//                repository.Create(userRole);
//                Console.WriteLine("Vínculo criado com sucesso!");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Não foi possível salvar");
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }
//}