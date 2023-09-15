using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Desafio.Models
{
    [Table("[Post]")]
    public class Post
    {
        public Post()
        => Users = new List<User>();
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public int AuthorId { get; set; }

        public string Title { get; set; }

        public  string  Summary { get; set; }

        public string Body { get; set; }

        public string Slug { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? LastUpdateDate { get; set; }

        public int TagId { get; set; }

        public string TagName { get; set; }


            [Write(false)]
        public List<User> Users {get; set;}

    }
}