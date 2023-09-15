using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Desafio.Models
{

    [Table("[PostTag]")]
    public class PostTag
    {
        public int Id { get; set; }

        public int  PostId { get; set; }

        public int TagId { get; set; }
    }
}