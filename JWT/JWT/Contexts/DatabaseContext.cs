using JWT.Controllers;
using JWT.Models;
using Microsoft.EntityFrameworkCore;
using User = JWT.Models.User;

namespace JWT.Contexts;

public class DatabaseContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }

    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}