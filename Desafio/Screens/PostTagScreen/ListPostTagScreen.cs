using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Models;
using Desafio.Repositories;

namespace Desafio.Screens.PostTagScreen
{
    public class ListPostTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Consulta de vínculos");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuPostTagScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<PostTag>(Database.Connection);
            var postTag = repository.Get();

            foreach (var item in postTag)

                Console.WriteLine($"Código usuário: {item.PostId} - Perfil código: {item.TagId}");
        }
    }
}