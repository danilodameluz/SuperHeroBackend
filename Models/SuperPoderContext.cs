using Microsoft.EntityFrameworkCore;

namespace SuperHero.Models;

public class SuperPoderContext : DbContext
{
    public SuperPoderContext(DbContextOptions<SuperPoderContext> options)
        : base(options)
    {
    }

    public DbSet<SuperPoder> SuperPoderes { get; set; } = null!;
}
