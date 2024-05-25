using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace salesCustomerMvc.Models
{
    public class Sales
    {
            
        public int Id { get; set; }
        

        // Foreign key for Product
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        // Foreign key for Customer
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        // Foreign key for Store
        [ForeignKey("Store")]
        public int StoreId { get; set; }

        [Display(Name = "Date Sold")]
        [DataType(DataType.Date)]
        public DateTime DateSold { get; set; }

        // Navigation properties
        public Customer customer { get; set; }
        public Product product { get; set; }
        public Store store { get; set; }
    }
}