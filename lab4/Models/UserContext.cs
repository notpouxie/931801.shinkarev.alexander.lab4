using Microsoft.EntityFrameworkCore;

namespace lab4.Models
{
    public class UserContext : DbContext
    {

        public UserContext(DbContextOptions<UserContext> options)
           : base(options)
        {
            Database.EnsureCreated();   
        }

        public DbSet<UserModel> Users { get; set; }
    }
}
