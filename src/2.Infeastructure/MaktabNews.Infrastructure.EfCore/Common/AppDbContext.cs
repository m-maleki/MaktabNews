using MaktabNew.Domain.Core.Entities;
using MaktabNews.Infrastructure.EfCore.Configurations;
using Microsoft.EntityFrameworkCore;

namespace MaktabNews.Infrastructure.EfCore.Common;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AdminConfigurations());
        modelBuilder.ApplyConfiguration(new ReporterConfigurations());
        modelBuilder.ApplyConfiguration(new VisitorConfigurations());
        modelBuilder.ApplyConfiguration(new CategoryConfigurations());
        modelBuilder.ApplyConfiguration(new TagConfigurations());
        modelBuilder.ApplyConfiguration(new NewsConfigurations());

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<News> News { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Tag> Tages { get; set; }
    public DbSet<Reporter> Reporters { get; set; }
    public DbSet<Visitor> Visitors { get; set; }
    public DbSet<Admin> Admins { get; set; }
}
