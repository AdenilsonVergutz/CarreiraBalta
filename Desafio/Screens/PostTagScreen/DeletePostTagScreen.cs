using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Models;
using Desafio.Repositories;

namespace Desafio.Screens.PostTagScreen
{
    public class DeletePostTagScreen
    {
  public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir o vinculo");
            Console.WriteLine("-------------");
            Console.Write("Qual o código do Post que deseja excluir?");
            var PostId = Console.ReadLine();

            Delete(int.Parse(PostId));
            Console.ReadKey();
            MenuPostTagScreen.Load();
        }

        public static void Delete(int postId)
        {
            try
            {
                var repository = new Repository<PostTag>(Database.Connection);
                repository.Delete(postId);
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