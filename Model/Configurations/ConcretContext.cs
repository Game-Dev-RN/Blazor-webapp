using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model.Configurations;

public class ConcretContext: DbContext
{
    public ConcretContext(DbContextOptions<ConcretContext> options): base(options)
    {
        
    }

    public DbSet<User> Users { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .Property(u => u.Role)
            .HasConversion<string>(); // Speichert z. B. "Admin" statt 2
    }



}