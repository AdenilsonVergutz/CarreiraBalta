using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Models;
using Desafio.Repositories;

namespace Desafio.Screens.PostTagScreen
{
    public class UpdatePostTagScreen
    {


        public static Repository<PostTag> _repository = new Repository<PostTag>(Database.Connection);

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando vinculo");
            Console.WriteLine("-------------");
            Console.Write("Código do Post: ");
            var postId = Console.ReadLine();

            Console.Write("Código da Tag: ");
            var tagId = Console.ReadLine();


            var postTag = _repository.Get().FirstOrDefault(x => x.PostId == Convert.ToInt32(postId));
            if (postTag != null)
                Update(postTag);
            else
                Console.Write("Post Não localizado");


            Console.ReadKey();
            MenuPostTagScreen.Load();
        }

        public static void Update(PostTag postTag)
        {
            try
            {
                var repository = new Repository<PostTag>(Database.Connection);
                repository.Update(postTag);
                Console.WriteLine("Registro atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}