using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class Role : BaseEntity
    {
        [Key]
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public ICollection<GroupFunction> GroupFunction  { get; set; }
        public ICollection<Users> Users { get; set; }
        public Role()
        {
            RoleId = Guid.NewGuid();
        }
    }
}
