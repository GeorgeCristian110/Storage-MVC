using Microsoft.EntityFrameworkCore;
using Storage.Models;

public class StorageContext : DbContext
{
    public DbSet<Product> Product => Set<Product>();

    public StorageContext(DbContextOptions<StorageContext> options) : base(options)
    {
    }
}
