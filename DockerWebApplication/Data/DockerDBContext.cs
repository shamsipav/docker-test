using Microsoft.EntityFrameworkCore;

namespace DockerWebApplication.Data
{
    public class DockerDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DockerDBContext(DbContextOptions<DockerDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //OnModelCreating(modelBuilder);
        }
    }
}
