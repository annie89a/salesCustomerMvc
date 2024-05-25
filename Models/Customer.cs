using System.Collections.Generic;

namespace salesCustomerMvc.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<Sales> ProductSold { get; set; } = new List<Sales>();
    }
}
