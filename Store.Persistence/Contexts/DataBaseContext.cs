using Microsoft.EntityFrameworkCore;
using Store.Application.Interfaces.Contexts;
using Store.Domain.Entities.Users;

namespace Store.Persistence.Contexts
{
    public class DataBaseContext:DbContext ,IDataBaseContext
    {
        DataBaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }


        
        
    }

   
}