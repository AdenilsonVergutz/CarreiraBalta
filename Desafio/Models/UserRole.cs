using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    

        [Key]

        public int Id { get; set; }
        public int UserId { get; set; }

        public int RoleId { get; set; }

        [Computed]
        public string UserName { get; set; }

        [Computed]
        public string TagName { get; set; }

            [Write(false)]
        public List<User> Users {get; set;}
    
    }
}