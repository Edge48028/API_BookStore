using API_BookStore.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyApiNetCore6.Data
{
    public class BookStoreContext : IdentityDbContext<ApplicationUser>
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {
        }

        #region DbSet
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Order>(e =>
            {
                e.ToTable("Orders");
                e.HasKey(dh => dh.IdOrder);
                e.Property(dh => dh.OrderDate).HasDefaultValueSql("getutcdate()");
                e.Property(dh => dh.Receiver).IsRequired().HasMaxLength(100);
            });
            builder.Entity<OrderDetail>(e =>
            {
                e.ToTable("OrderDetails"); // Fixed the table name
                e.HasKey(e => new { e.IdOrder, e.Id });
                e.HasOne(e => e.Order)
                .WithMany(e => e.OrderDetails) // Define the navigation property
                .HasForeignKey(e => e.IdOrder) // Fixed the foreign key
                .HasConstraintName("FK_OrderCT_Order"); // Fixed the constraint name

                e.HasOne(e => e.Book)
                .WithMany(e => e.OrderDetails) // Define the navigation property
                .HasForeignKey(e => e.Id) // Fixed the foreign key
                .HasConstraintName("FK_OrderCT_Book"); // Fixed the constraint name
            });
        }
    }
}
