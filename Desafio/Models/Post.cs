using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Desafio.Models
{
    [Table("[Post]")]
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}