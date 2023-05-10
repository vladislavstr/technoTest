using UsersGroupDal.Models;
using Microsoft.EntityFrameworkCore;

namespace UsersGroupDal
{
    public class UserContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public DbSet<UserStateEntity> States { get; set; }

        public DbSet<UserGroupEntity> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("UsersGroupDbConnect"));
            //optionsBuilder.UseInMemoryDatabase("AppealDb");
        }
    }
}
