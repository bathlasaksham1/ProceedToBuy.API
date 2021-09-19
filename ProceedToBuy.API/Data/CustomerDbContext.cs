using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProceedToBuy.API.Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {

        }
        public DbSet<CustomerCart> CustomerCarts  { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<CustomerWishlist> CustomerWishlists { get; set; }

    }
}

