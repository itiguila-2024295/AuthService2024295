using AuthServiceIN6BV.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AuthServiceIN6BV.Persistance.Data;

public class AplicationDbContext(DbContextOptions<AplicationDbContext> options) : DbContext(options)
{
    public DbSet<User> Users {get; set;}
    public DbSet<UserProfile> UserProfiles {get; set;}
    public DbSet<Role> Roles {get; set;}
    public DbSet<UserRole> UserRoles {get; set;}
    public DbSet<UserEmail> UserEmails {get; set;}
    public DbSet<UserPasswordReset> userPasswordResets {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public override int SaveChanges()
    {
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSucces, CancellationToken cancelationToken = default)
    {
        return base.SaveChangesAsync(acceptAllChangesOnSucces, cancelationToken);
    }
    public void UpdateTiemstamps()
    {
        
    }

    private static string ToSnakeCase(string input)
    {
        return "";
    }
}