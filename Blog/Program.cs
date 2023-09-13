using System;
using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog;

class Program
{

    private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$; TrustServerCertificate=True";

    static void Main(string[] args)
    {

        var connection = new SqlConnection (CONNECTION_STRING);
        connection.Open();
            
            ReadUserWithRoles(connection);
            //ReadUsers(connection);
           // ReadRoles(connection);
            //ReadTags(connection);


            connection.Close();
    }

    public static void ReadUsers(SqlConnection connection)
    {
        var repository = new Repository<User>(connection);
        var items = repository.Get();


        foreach (var item in items)
                Console.WriteLine(item.Name);
            
    }

public static void ReadUserWithRoles(SqlConnection connection)
{
    var repository = new UserRepository(connection);
    var items = repository.GetWithRoles();

    foreach (var item in items)
    {
        Console.WriteLine(item.Name);
        foreach (var role in item.Roles)
        {
            Console.WriteLine($" - {role.Name}");
        }
        
    }
}

    public static void CreateUser(SqlConnection connection)
    {
        var user = new User()
        {   

            Email = "Adenilson@balta.io",
            Bio = "Bio balta.io",
            Image = "https://imagem",
            Name = "Vergutz",
            PasswordHash = "HASH",
            Slug = "Eslug"
        };

        var repository = new Repository<User>(connection);
        repository.Create(user);

    }

    public static void ReadRoles(SqlConnection connection)
    {
        var repository = new Repository<Role>(connection);
        var items = repository.Get();

        foreach (var item in items)
                Console.WriteLine(item.Name);
            
    }

    public static void ReadTags(SqlConnection connection)
    {
        var repository = new Repository<Tag>(connection);
        var items = repository.Get();

        foreach (var item in items)
                Console.WriteLine(item.Name);
            
    }












    public static void ReadUser()
    {
        using (var connection = new SqlConnection (CONNECTION_STRING))
        {
            var user = connection.Get<User>(1);

                Console.WriteLine(user.Name);
            
        }
    }


    public static void UpdateUser()
    {
        var user = new User()
        {
            Id = 2,
            Bio = "Equipe | balta.io",
            Email = "hello@balta.io",
            Image = "https://..",
            Name = "Equipe de suporte balta.io",
            PasswordHash = "HASH",
            Slug = "Equipe-Balta"
        };

        using (var connection = new SqlConnection (CONNECTION_STRING))
        {
                connection.Update<User>(user);
                Console.WriteLine($"Usuário {user.Name} atualizado com sucesso!");
            
        }
    }

    public static void DeleteUser()
    {


        using (var connection = new SqlConnection (CONNECTION_STRING))
        {       
                var user = connection.Get<User>(2);
                connection.Delete<User>(user);
                Console.WriteLine($"Usuário {user.Name} excluído com sucesso!");
            
        }
    }


}
