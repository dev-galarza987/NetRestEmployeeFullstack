using Microsoft.EntityFrameworkCore;
using RestEmployee.Shared.Models;

namespace RestEmployee.Shared.Database;

public class AppDbContext(DbContextOptions<AppDbContext>  options) : DbContext(options)
{
    public DbSet<Employee> Employee { get; set; }
    public DbSet<Position> Position { get; set; }
}