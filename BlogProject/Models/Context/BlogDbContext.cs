using Microsoft.EntityFrameworkCore;
using MVC_BlogProject.Models.Entities;

namespace MVC_BlogProject.Models.Context
{
    public class BlogDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<About> Abouts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; Database = BlogProject; Trusted_Connection = True; MultipleActiveResultSets = true; TrustServerCertificate = True;");
        }
    }
}
