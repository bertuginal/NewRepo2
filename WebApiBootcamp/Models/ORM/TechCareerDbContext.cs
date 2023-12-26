using Microsoft.EntityFrameworkCore;
using TechCareerWebApiTutorial.Models.ORM;

namespace WebApiBootcamp.Models.ORM
{
    public class TechCareerDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string
           optionsBuilder.UseSqlServer("Server=Siccin; Database=TechCareerDb; trusted_connection=true");
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
