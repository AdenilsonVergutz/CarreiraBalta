using System;
using Dapper.Contrib.Extensions;
using Desafio.Screens.CategoryScreen;
using Desafio.Screens.RoleScreen;
using Desafio.Screens.TagScreens;
using Desafio.Screens.UserRoleScreen;
using Desafio.Screens.UserScreens;
using Microsoft.Data.SqlClient;

namespace Desafio
{

    public class Program
    {

        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$; TrustServerCertificate=True";

        static void Main(string[] args)
        {

            Database.Connection = new SqlConnection (CONNECTION_STRING);
            Database.Connection.Open();

            Load();
     
            Console.ReadKey();
            Database.Connection.Close();
        }

        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("--------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de perfil");
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão de Tag");
            Console.WriteLine("5 - Vincular perfil/usuário");
            Console.WriteLine("6 - Vincular post/tag");
            Console.WriteLine("7 - Relatórios");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);


            switch (option)
            {
                case 1:
                     MenuUserScreen.Load();
                    break;
                 case 2:
                     MenuRoleScreen.Load();
                     break;
                case 3:
                     MenuCategoryScreen.Load();
                     break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                 case 5:
                     MenuUserRoleScreen.Load();
                     break;
                // case 6:
                //     .Load();
                //     break;
                // case 7:
                //     .Load();
                //     break;
                default: Load(); break;
            }
        }
    }

    


}

// CREATE TABLE [UserRole] (
//     [UserId] INT NOT NULL,
//     [RoleId] INT NOT NULL,
//     [Id] INT NOT NULL IDENTITY(1,1)

//     CONSTRAINT [PK_UserRole] PRIMARY KEY([Id], [UserId], [RoleId])
//     CONSTRAINT [FK_UserRoleUser] FOREIGN KEY (UserId) REFERENCES [User]([Id]),
//     CONSTRAINT [FK_UserRole] FOREIGN KEY (RoleId) REFERENCES [Role]([Id])
// )


// DROP TABLE [UserRole]