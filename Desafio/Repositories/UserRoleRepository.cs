using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Desafio.Models;
using Microsoft.Data.SqlClient;

namespace Desafio.Repositories
{
    public class UserRoleRepository : Repository<UserRole>
    {

        private readonly SqlConnection _connection;
        public UserRoleRepository(SqlConnection connection)
            : base(connection)
                => _connection = connection;

        public List<UserRole> ObterUserRole()
        {


            var role = _connection.Query<UserRole>(@$"
         Select
            *,
             (SELECT NAME FROM [USER] WHERE ID = UserRole.UserId) UserName,
             (SELECT NAME FROM Role WHERE ID = UserRole.RoleId) TagName
             from UserRole").ToList();

            return role;
        }
    }
}