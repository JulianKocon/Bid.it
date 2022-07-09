using Bid.it.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bid.it.Data;
public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<PurchaseHistory> PurchaseHistories { get; set; }
    public DbSet<FollowedAuction> FollowedAuctions { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<ApplicationUser>().ToTable("ApplicationUser");
        modelBuilder.Entity<Auction>().ToTable("Auction");
        modelBuilder.Entity<PurchaseHistory>().ToTable("PurchaseHistory");
        modelBuilder.Entity<FollowedAuction>().ToTable("FollowedAuction");

        modelBuilder.Entity<FollowedAuction>()
            .HasKey(x => new { x.IdUser, x.IdAuction });
    }
}
