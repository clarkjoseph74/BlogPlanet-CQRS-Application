using BlogPlanet.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlogPlanet.Presistence;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Blog> Blogs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Any" }
            );
        modelBuilder.Entity<Blog>().HasData(
           new Blog
           {
               Id = 1,
               CategoryId = 1,
               Description = "First Blog Description",
               Title = "First Blog",
               ImageUrl = "https://placehold.co/600x400"
           }
           );
        base.OnModelCreating(modelBuilder);
    }
}
