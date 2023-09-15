using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Models;
using Desafio.Repositories;
using System.Globalization;

namespace Desafio.Screens.PostScreen
{
    public class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Criar Novo Post");
            
            Console.WriteLine("-------------");
            Console.Write("Categoria: ");
            var categoryId = Console.ReadLine();
            Console.Write("Autor: ");
            var  authorId = Console.ReadLine();
            Console.Write("Título do post: ");
            var tittle = Console.ReadLine();
            Console.Write("Summany: ");
            var summary = Console.ReadLine();
            Console.Write("Body: ");
            var body = Console.ReadLine();
            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            Console.Write("Código da Tag: ");
            var tagId = Console.ReadLine();
            Console.Write("Nome Tag: ");
            var tagName = Console.ReadLine();
            Console.Write("Data Criação: ");
            var createDate = DateTime.UtcNow;
            System.Console.WriteLine(createDate);
            Console.ReadLine();


            Create(new Post
            {
                CategoryId = int.Parse(categoryId),
                AuthorId = int.Parse(authorId),
                Title = tittle,
                Summary = summary,
                Body = body,
                Slug = slug,
                TagId = int.Parse(tagId),
                TagName = tagName,
                CreateDate = createDate
            });
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void Create(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Create(post);
                Console.WriteLine("Post cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar o usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
