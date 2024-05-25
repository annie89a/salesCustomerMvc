using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using salesCustomerMvc.Models;

namespace salesCustomerMvc.Data
{
    public class salesCustomerMvcContext : DbContext
    {
        public salesCustomerMvcContext (DbContextOptions<salesCustomerMvcContext> options)
            : base(options)
        {
        }

        public DbSet<salesCustomerMvc.Models.Customer> Customer { get; set; } = default!;
        public DbSet<salesCustomerMvc.Models.Product> Product { get; set; } = default!;
        public DbSet<salesCustomerMvc.Models.Store> Store { get; set; } = default!;
        public DbSet<salesCustomerMvc.Models.Sales> Sales { get; set; } = default!;
    }
}
