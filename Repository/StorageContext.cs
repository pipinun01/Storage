using Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Repository
{
    public class StorageContext: DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
        public DbSet<StockOperation> StockOperations { get; set; }

        public StorageContext(DbContextOptions<StorageContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(p => p.SKU).IsUnique();
            });

            modelBuilder.Entity<StockOperation>(entity =>
            {
                entity.HasOne(o => o.Product)
                    .WithMany(p => p.StockOperations)
                    .HasForeignKey(o => o.ProductId);

                entity.HasOne(o => o.FromWarehouse)
                    .WithMany(w => w.FromStockOperations)
                    .HasForeignKey(o => o.FromWarehouseId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(o => o.ToWarehouse)
                    .WithMany(w => w.ToStockOperations)
                    .HasForeignKey(o => o.ToWarehouseId)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
