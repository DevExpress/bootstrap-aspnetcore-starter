using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DevExpress.AspNetCore.Bootstrap.Starter {
    public class NorthwindContext : DbContext {
        public NorthwindContext(DbContextOptions<NorthwindContext> options)
            : base(options) {
        }

        public DbSet<Product> Products { get; set; }
    }

    public class Product {
        [Key]
        public int ProductID { get; set; }
        [Required, MaxLength(40)]
        public string ProductName { get; set; }
        [MaxLength(20)]
        public string QuantityPerUnit { get; set; }
        [DisplayFormat(DataFormatString = "c")]
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public bool Discontinued { get; set; }
    }
}
