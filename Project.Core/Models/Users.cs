using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class Users : BaseEntity
    {
        [Key]
        public Guid UserId { get; set; }
        public string Avatar { get; set; }
        public string EmployeeCode  { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RoleId { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public Role Role {  get; set; }
        public Users()
        {
            UserId = Guid.NewGuid();
        }
    }
}
