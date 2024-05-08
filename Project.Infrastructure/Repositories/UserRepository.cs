using Project.Core.Interfaces;
using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<Users> ,IUserRepository
    {
        public UserRepository(DbContextClass dbContext) : base(dbContext)
        {

        }
    }
}
