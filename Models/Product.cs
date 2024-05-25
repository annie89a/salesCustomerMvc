using System.ComponentModel.DataAnnotations.Schema;

namespace salesCustomerMvc.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public double Price { get; set; }

        public ICollection<Sales> ProductSold { get; set; } = new List<Sales>();
    }
}
