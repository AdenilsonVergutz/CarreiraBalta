using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Desafio.Models
{

    [Table("[UserRole]")]
    public class UserRole
    {
        public UserRole()
                    => Users = new List<User>();
    
        public int UserId { get; set; }

        public int RoleId { get; set; }
    
    
            [Write(false)]
        public List<User> Users {get; set;}
    
    }
}