using Microsoft.EntityFrameworkCore;
using SliceArchitectureDemoCore.Domain;

namespace SliceArchitectureDemoCore.Infrastructure;

public class AppDBContext(DbContextOptions<AppDBContext> options) : DbContext(options)
{
  public DbSet<Product> Products => Set<Product>();
  public DbSet<Category> Categories => Set<Category>();
}