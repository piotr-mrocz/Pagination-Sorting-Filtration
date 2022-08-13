using Microsoft.EntityFrameworkCore;
using WebApi.Models.Entities;

namespace WebApi.Data;

public interface IApplicationDbContext
{
    public DbSet<Country> Countries { get; set; }
}
