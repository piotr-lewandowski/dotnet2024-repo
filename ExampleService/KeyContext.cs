using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public record ApiKey(int Id, string Value, string Client);

public class KeyContext(DbContextOptions<KeyContext> options) : DbContext(options)
{
    public DbSet<ApiKey> ApiKeys { get; set; }
}