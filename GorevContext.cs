using Microsoft.EntityFrameworkCore;

public class GorevContext : DbContext
{
    public GorevContext(DbContextOptions<GorevContext> options) : base(options) { }
 
    public DbSet<Gorev> Gorevler { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Hedef> Hedefler { get; set; }
} 