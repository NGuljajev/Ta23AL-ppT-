using Microsoft.EntityFrameworkCore;
using Ta23ALõppTöö.Models;

namespace CinemaBackend.Data
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options)
            : base(options) { }

        public DbSet<Ad> Ads { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<GiftCard> GiftCards { get; set; }
        public DbSet<GiftCardTransaction> GiftCardTransactions { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<SeatReservation> SeatReservations { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 👇 Configure composite primary key for Ad
            modelBuilder.Entity<Ad>()
                .HasKey(a => new { a.CinemaId, a.Title });

            // Example: modelBuilder.Entity<User>().ToTable("users");
        }
    }
}
