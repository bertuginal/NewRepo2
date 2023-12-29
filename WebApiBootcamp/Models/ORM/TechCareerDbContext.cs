using Microsoft.EntityFrameworkCore;
using WebApiBootcamp.Models.ORM;

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
        public DbSet<BlogCategory> blogCategories { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<WebUser> WebUsers { get; set; }
        public DbSet<Order> orders { get; set; }

    }
}
