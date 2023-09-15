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

        public PostTag()
                => Posts = new List<Post>();
        public int Id { get; set; }

        public int  PostId { get; set; }

        public int TagId { get; set; }

        [Computed]
        public string TagName { get; set; }

        [Computed]
        public string PostName { get; set; }


        [Write(false)]
        public List <Post> Posts {get; set;}
    }
}