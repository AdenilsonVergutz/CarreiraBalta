using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Screens.PostScreen
{
    public class MenuPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de publicação");
            Console.WriteLine("--------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar");
            Console.WriteLine("2 - Inserir");
            Console.WriteLine("3 - Atualizar ");
            Console.WriteLine("4 - Excluir ");
            Console.WriteLine();
            Console.WriteLine("5 - Sair");

            var option = short.Parse(Console.ReadLine()!);


            switch (option)
            {
                case 1:
                    ListPostScreen.Load();
                    break;
                case 2:
                    CreatePostScreen.Load();
                    break;
                 case 3:
                    UpdatePostScreen.Load();
                    break;
                case 4:
                    DeletePostScreen.Load();
                    break;
                 case 5:
                    Program.Load();
                    break;
                default: Load(); break;

    

            }
        }
    }
}