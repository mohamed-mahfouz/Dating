using Dating.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dating.Api.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{ 
    public DbSet<AppUser> Users { get; set; }        
}
