using Microsoft.EntityFrameworkCore;

namespace QLSP.Models
{
    public class QLSPContext : DbContext
    {
        public QLSPContext()
        {
        }

        public QLSPContext(DbContextOptions<QLSPContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(e =>
                {
                    e.ToTable("Product");
                    e.HasKey(x => x.Id);
                    e.Property(x => x.Id)
                    .IsRequired()
                    .HasMaxLength(10);

                    e.Property(x => x.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                    e.Property(x => x.Price)
                    .IsRequired()
                    .HasColumnType("decimal(18,2)");

                    e.Property(x => x.Stock)
                    .IsRequired();
                }
            );
        }
    }
}
