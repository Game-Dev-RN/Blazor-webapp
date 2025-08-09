using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model.Configurations;

public class ConcretContext: DbContext
{
    public ConcretContext(DbContextOptions<ConcretContext> options): base(options)
    {
        
    }

    public DbSet<User> Users { get; set; }







}