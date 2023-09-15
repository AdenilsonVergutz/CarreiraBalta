using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Models;
using Desafio.Repositories;

namespace Desafio.Screens.PostTagScreen
{
    public class CreatePostTagScreen
    {
      public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Informe a tag que deseja vincular");
            Console.WriteLine("-------------");
            Console.Write("Código do Post: ");
            var postId = Console.ReadLine();

            Console.Write("Código da Tag: ");
            var tagId = Console.ReadLine();

            Create(new PostTag
            {
                PostId = int.Parse(postId),
                TagId = int.Parse(tagId)
            });
            Console.ReadKey();
            MenuPostTagScreen.Load();
        }

        public static void Create(PostTag postTag)
        {
            try
            {
                var repository = new Repository<PostTag>(Database.Connection);
                repository.Create(postTag);
                Console.WriteLine("Vínculo criado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar");
                Console.WriteLine(ex.Message);
            }
        }
    }
}