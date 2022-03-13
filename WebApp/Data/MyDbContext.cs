using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Data.Domain;
namespace WebApp.Data
{
    public class MyDbContext: IdentityDbContext<User>
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string sqlConnectionString= @"Server = YUNUSEMRE\SQLEXPRESS; Database = LibraryManagement; User Id = sa; Password = 83930621; ";
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(sqlConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
