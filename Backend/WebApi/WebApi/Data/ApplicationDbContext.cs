using Microsoft.EntityFrameworkCore;
using WebApi.Models.Entities;

namespace WebApi.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Country> Countries { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Country>()
            .HasKey(x => x.Id);

        base.OnModelCreating(builder);
    }
}
