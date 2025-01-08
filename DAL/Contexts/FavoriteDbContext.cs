using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace DAL.Contexts
{
    public class FavoriteDbContext : DbContext
    {
        public FavoriteDbContext(DbContextOptions<FavoriteDbContext> options) : base(options) { }
        public DbSet<GitHubRepository> Favorite { get; set; }

    }
}