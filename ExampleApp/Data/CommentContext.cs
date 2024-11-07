using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data;

public class CommentContext(DbContextOptions<CommentContext> options) : DbContext(options)
{
    public DbSet<Comment> Comments { get; set; }
    public DbSet<User> Users { get; set; }
}