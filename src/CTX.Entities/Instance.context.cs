using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTX.Entities
{
    public partial class InstanceEntities : DbContext
    {
        public InstanceEntities(DbContextOptions<InstanceEntities> options) : base(options)
        {
        }
        public DbSet<Claim> Claim { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RoleClaim> RoleClaim { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserLoginToken> UserLoginToken { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<UserRole> UserRole { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                 .HasMany(x => x.UserProfiles)
                 .WithOne(x => x.User)
                 .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);
            modelBuilder.Entity<User>()
                .HasMany(x => x.UserRoles)
                .WithOne(x => x.User)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);
            modelBuilder.Entity<User>()
                .HasMany(x => x.UserLoginTokens)
                .WithOne(x => x.User)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);
            modelBuilder.Entity<Claim>()
                .HasMany(x => x.RoleClaims)
                .WithOne(x => x.Claim)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);
            modelBuilder.Entity<Role>()
                .HasMany(x => x.RoleClaims)
                .WithOne(x => x.Role)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);


        }
    }
}
