using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Screens.PostTagScreen
{
    public class MenuPostTagScreen
    {
   public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão");
            Console.WriteLine("--------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar");
            Console.WriteLine("2 - Criar vinculos");
            Console.WriteLine("3 - Atualizar");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine();
            Console.WriteLine("5 - Voltar");

            var option = short.Parse(Console.ReadLine()!);


            switch (option)
            {
                case 1:
                    ListPostTagScreen.Load();
                    break;
                case 2:
                    CreatePostTagScreen.Load();
                    break;
                case 3:
                    UpdatePostTagScreen.Load();
                    break;
                case 4:
                    DeletePostTagScreen.Load();
                    break;
                case 5:
                        Program.Load();
                    break;

                default: Load(); break;
            }
        }
    }
}