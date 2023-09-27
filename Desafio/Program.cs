using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using Dapper.Contrib.Extensions;
using Desafio.Models;
using Desafio.Screens.CategoryScreen;
using Desafio.Screens.PostScreen;
using Desafio.Screens.PostTagScreen;
using Desafio.Screens.RoleScreen;
using Desafio.Screens.TagScreens;
using Desafio.Screens.UserRoleScreen;
using Desafio.Screens.UserScreens;
using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Desafio
{

    public class Program
    {

        private const string CONNECTION_STRING = @"Server=ADENILSON-PC\SQL2022;Database=Blog;User ID=sa;Password=saroot; TrustServerCertificate=True";

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
            Console.WriteLine("5 - Gestão de Post");
            Console.WriteLine("6 - Vincular perfil/usuário");
            Console.WriteLine("7 - Vincular post/tag");
            Console.WriteLine("8 - Relatórios");
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
                    MenuPostScreen.Load();
                    break;

                case 6:
                    MenuUserRoleScreen.Load();
                    break;
                case 7:
                    MenuPostTagScreen.Load();
                    break;
                // case 8:
                //     .Load();
                //     break;
                default: Load(); break;
            }
        }
    }

    


}



//CREATE DATABASE[Blog]
//GO

//USE [Blog]
//GO

//-- DROP TABLE[User]
//-- DROP TABLE [Role]
//-- DROP TABLE[UserRole]
//-- DROP TABLE [Post]
//-- DROP TABLE[Category]
//-- DROP TABLE [Tag]
//-- DROP TABLE[PostTag]

//CREATE TABLE [User] (
//    [Id] INT NOT NULL IDENTITY(1, 1),
//    [Name] NVARCHAR(80) NOT NULL,
//    [Email] VARCHAR(200) NOT NULL,
//    [PasswordHash] VARCHAR(255) NOT NULL,
//    [Bio] TEXT NOT NULL,
//    [Image] VARCHAR(2000) NOT NULL,
//    [Slug] VARCHAR(80) NOT NULL,

//    CONSTRAINT[PK_User] PRIMARY KEY([Id]),
//    CONSTRAINT[UQ_User_Email] UNIQUE([Email]),
//    CONSTRAINT[UQ_User_Slug] UNIQUE([Slug])
//)
//CREATE NONCLUSTERED INDEX [IX_User_Email] ON[User]([Email])
//CREATE NONCLUSTERED INDEX [IX_User_Slug] ON[User]([Slug])

//CREATE TABLE[Role] (
//    [Id] INT NOT NULL IDENTITY(1, 1),
//    [Name] VARCHAR(80) NOT NULL,
//    [Slug] VARCHAR(80) NOT NULL,

//    CONSTRAINT[PK_Role] PRIMARY KEY([Id]),
//    CONSTRAINT[UQ_Role_Slug] UNIQUE([Slug])
//)
//CREATE NONCLUSTERED INDEX [IX_Role_Slug] ON[Role]([Slug])

//CREATE TABLE[UserRole] (
//     [UserId] INT NOT NULL,
//     [RoleId] INT NOT NULL,
//     [Id] INT NOT NULL IDENTITY(1,1)

//     CONSTRAINT[PK_UserRole] PRIMARY KEY([Id], [UserId], [RoleId])
//     CONSTRAINT[FK_UserRoleUser] FOREIGN KEY(UserId) REFERENCES[User]([Id]),
//     CONSTRAINT[FK_UserRole] FOREIGN KEY(RoleId) REFERENCES[Role]([Id])
// )

//CREATE TABLE[Category] (
//    [Id] INT NOT NULL IDENTITY(1, 1),
//    [Name] VARCHAR(80) NOT NULL,
//    [Slug] VARCHAR(80) NOT NULL,

//    CONSTRAINT[PK_Category] PRIMARY KEY([Id]),
//    CONSTRAINT[UQ_Category_Slug] UNIQUE([Slug])
//)
//CREATE NONCLUSTERED INDEX [IX_Category_Slug] ON[Category]([Slug])

//CREATE TABLE[Post] (
//     [Id] INT NOT NULL IDENTITY(1, 1),
//     [CategoryId] INT NOT NULL,
//     [AuthorId] INT NOT NULL,
//     [Title] VARCHAR(160) NOT NULL,
//     [Summary] VARCHAR(255) NOT NULL,
//     [Body] TEXT NOT NULL,
//     [Slug] VARCHAR(80) NOT NULL,
//     [CreateDate] DATETIME NOT NULL DEFAULT(GETDATE()),
//     [LastUpdateDate] DATETIME NOT NULL DEFAULT(GETDATE()),
//     [TagId] INT NOT NULL,
//     [TagName] VARCHAR(80) NOT NULL,

//     CONSTRAINT[PK_Post] PRIMARY KEY([Id]),
//     CONSTRAINT[FK_Post_Category] FOREIGN KEY([CategoryId]) REFERENCES[Category]([Id]),
//     CONSTRAINT[FK_Post_Author] FOREIGN KEY([AuthorId]) REFERENCES[User]([Id]),
//     CONSTRAINT[FK_Post_Tag] FOREIGN KEY([TagId]) REFERENCES[Tag]([Id]),
//     CONSTRAINT[FK_Post_TagName] FOREIGN KEY([TagName]) REFERENCES[Tag]([Name]),
//     CONSTRAINT[UQ_Post_Slug] UNIQUE([Slug])
// )

//CREATE TABLE[Tag] (
//     [Id] INT NOT NULL IDENTITY(1, 1),
//     [Name] VARCHAR(80) NOT NULL,
//     [Slug] VARCHAR(80) NOT NULL,

//     CONSTRAINT[PK_Tag] PRIMARY KEY([Id]),
//     CONSTRAINT[UQ_TagName] UNIQUE([Name]),
//     CONSTRAINT[UQ_Tag_Slug] UNIQUE([Slug])
// )

//CREATE TABLE[PostTag] (
//      [Id] INT NOT NULL IDENTITY(1,1),
//      [PostId] INT NOT NULL,
//      [TagId] INT NOT NULL,


//      CONSTRAINT[PK_PostTag] PRIMARY KEY([Id], [PostId], [TagId]),
//      CONSTRAINT[FK_Post] FOREIGN KEY(PostId) REFERENCES[Post]([Id]),
//      CONSTRAINT[FK_Tag] FOREIGN KEY(TagId) REFERENCES[Tag]([Id])
//   )

//INSERT INTO[UserRole] VALUES (
//            1,
//            1)

//INSERT INTO[User] VALUES (
//            'Adenilson Vergutz',
//            'Adenilson@mhtec.com.br',
//            'HASH',
//            '8X Microsoft MVP',
//            'https://',
//            'Andre-baltieri')

//INSERT INTO[Role] VALUES (
//            'Autor',
//            'author')


//INSERT INTO[Tag] VALUES (
//            'ASP.NET',
//            'ASPNET')
//
