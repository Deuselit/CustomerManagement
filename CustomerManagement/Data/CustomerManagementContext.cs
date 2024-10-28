using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerManagement.Models;

namespace CustomerManagement.Data
{
    public class CustomerManagementContext : DbContext
    {
        public CustomerManagementContext (DbContextOptions<CustomerManagementContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerManagement.Models.Customer> Customer { get; set; } = default!;
        public DbSet<CustomerManagement.Models.Address> Address { get; set; } = default!;
        public DbSet<CustomerManagement.Models.Employee> Employee { get; set; } = default!;
    }
}
