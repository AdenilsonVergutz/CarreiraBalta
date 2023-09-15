using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Desafio.Models;
using Microsoft.Data.SqlClient;

namespace Desafio.Repositories
{
    public class PostTagRepository : Repository<PostTag>
    {

        private readonly SqlConnection _connection;
        public PostTagRepository(SqlConnection connection)
            : base(connection)
                => _connection = connection;

        public List<PostTag> ObterPostTag()
        {


             var postTags = _connection.Query<PostTag>(@$"
             Select
             *,
              (SELECT [Name] FROM [Tag] WHERE ID = PostTag.TagId) TagName,
              (SELECT [Title] FROM [Post] WHERE ID = PostTag.PostId) PostName
              from PostTag").ToList();


            return postTags;
        }
    }
}