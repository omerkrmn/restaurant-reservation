using Microsoft.EntityFrameworkCore;
using RR.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace RR.Repositories.EFCore
{
    public class RestourantReservationDBContext : DbContext
    {
        public RestourantReservationDBContext(DbContextOptions<RestourantReservationDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Payment - Reservation 1:1 ilişki
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Reservation)
                .WithOne(r => r.Payment)
                .HasForeignKey<Payment>(p => p.ReservationId)
                .OnDelete(DeleteBehavior.Cascade);

            // Restaurant - Owner 1:N ilişki
            modelBuilder.Entity<Restaurant>()
                .HasOne(r => r.Owner)
                .WithMany()
                .HasForeignKey(r => r.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MenuItem>()
               .HasOne(mi => mi.Restaurant)
               .WithMany(r => r.MenuItems)
               .HasForeignKey(mi => mi.RestaurantId)
               .OnDelete(DeleteBehavior.Cascade);

            // MenuCategory - MenuItem 1:N ilişki
            modelBuilder.Entity<MenuItem>()
                .HasOne(mi => mi.Category)
                .WithMany(c => c.MenuItems)
                .HasForeignKey(mi => mi.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Reservation>()
              .HasOne(r => r.Table)
              .WithMany(t => t.Reservations)
              .HasForeignKey(r => r.TableId)
              .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}
