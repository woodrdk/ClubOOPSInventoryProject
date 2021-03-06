using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClubOOPSInventoryProjectCore.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<ApplicationUserClub>()
                   .HasKey(uc => new { uc.ApplicationUserID, uc.ClubID });

            builder.Entity<ApplicationUserClub>()
                   .HasOne(uc => uc.ApplicationUser)
                   .WithMany(u => u.Clubs)
                   .HasForeignKey(uc => uc.ApplicationUserID);

            builder.Entity<ApplicationUserClub>()
                   .HasOne(uc => uc.Club)
                   .WithMany(c => c.Users)
                   .HasForeignKey(uc => uc.ClubID);
        }

        public virtual DbSet<Club> Clubs { get; set; }
        public virtual DbSet<ApplicationUserClub> ApplicationUserClubs { get; set; }
        public virtual DbSet<InventoryItem> InventoryItems { get; set; }
    }
}
