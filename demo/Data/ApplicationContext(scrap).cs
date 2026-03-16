using demo.Models.temp;
using Microsoft.EntityFrameworkCore;

namespace demo.Data
{
    public class ApplicationContext_2: DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public ApplicationContext_2() 
        {
            if (Database.EnsureCreated())
            {

            }
            Roles.Load();
            Users.Load();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;");
        }
        //Scaffold-Dbcontext "Server=(localdb)\v11.0; Database=tufli; Trusted_Connection=True; TrustServerCertificate=True" -OutputDir Models -provider Microsoft.EntityFrameworkCore.SqlServer

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Role admin = new Role { Id = 1, Name = "админ" };
            Role menager = new Role { Id = 2, Name = "менеджер" };
            Role goust = new Role { Id = 3, Name = "гость" };

            User userAdmin = new User { Id = 1, Name = "1", Password = "1", Login = "1", RoleId = admin.Id };
            User userMagager = new User { Id = 2, Name = "2", Password = "2", Login = "2", RoleId = menager .Id};
            User userGoust = new User { Id = 3, Name = "3", Password = "3", Login = "3", RoleId = goust.Id };

            modelBuilder.Entity<Role>().HasData(admin, menager, goust);
            modelBuilder.Entity<User>().HasData(userAdmin, userGoust, userMagager);
        }
    }
}
