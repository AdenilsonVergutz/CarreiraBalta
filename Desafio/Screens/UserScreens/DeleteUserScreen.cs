using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Models;
using Desafio.Repositories;

namespace Desafio.Screens.UserScreens
{
    public class DeleteUserScreen
    {

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir um cadastro de usuário");
            Console.WriteLine("-------------");
            Console.Write("Qual o código do Usuário que deseja exluir? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Usuário exluído com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir  o usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}