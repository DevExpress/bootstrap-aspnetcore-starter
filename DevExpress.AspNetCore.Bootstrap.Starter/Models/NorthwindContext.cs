using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DevExpress.AspNetCore.Bootstrap.Starter {
    public class NorthwindContext : DbContext {
        public NorthwindContext(DbContextOptions<NorthwindContext> options)
            : base(options) {
        }
        public DbSet<Invoice> Invoices { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Invoice>()
                .HasKey(t => new { t.OrderID, t.ProductID, t.ProductName, t.UnitPrice, t.Quantity, t.Discount });
        }
    }
    public partial class Invoice {
        public int ProductID { get; set; }
        public int OrderID { get; set; }
        [MaxLength(40)]
        public string ProductName { get; set; }
        [DisplayFormat(DataFormatString = "c")]
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        [DisplayFormat(DataFormatString = "p")]
        public float Discount { get; set; }
    }
}
