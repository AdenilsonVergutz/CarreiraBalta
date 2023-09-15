using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Models;
using Desafio.Repositories;

namespace Desafio.Screens.PostTagScreen
{
    public class ListPostTagScreen:Post
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Víncular Post a uma TAG");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuPostTagScreen.Load();
        }

        private static void List()
        {
            var repository = new PostTagRepository(Database.Connection);
            var postTag = repository.ObterPostTag();

            foreach (var item in postTag)

                Console.WriteLine($" Post: {item.PostId} - {item.PostName} ---  Tag: {item.TagId} - {item.TagName}");
        }
    }
}