using CLients.Models;
using Microsoft.EntityFrameworkCore;

namespace CLients.Data;

public class AppDbContext(DbContextOptions<AppDbContext> dbContext):DbContext(dbContext)
{
    public DbSet<Client> Clients { get; set; }
}
