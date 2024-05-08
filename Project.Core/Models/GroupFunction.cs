using Project.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class GroupFunction : BaseEntity
    {
        [Key]
        public Guid FuncId { get; set; }
        public int FuncName { get; set; }
        public PermissionRole PermissionRole { get; set; }
        public GroupFunction()
        {
            FuncId = Guid.NewGuid();
        }
    }
}
