using UsersGroupDal.Models;
using Microsoft.EntityFrameworkCore;

namespace UsersGroupDal
{
    public class UserContext : DbContext
    {
        public DbSet<userEntity> Users { get; set; }

        public DbSet<user_stateEntity> States { get; set; }

        public DbSet<user_groupEntity> Groups { get; set; }

        public UserContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("UsersGroupDbConnect");
        }
    }
}
