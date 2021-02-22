using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheaterApp.Employee.Models;

    public class CustomerDataContext : DbContext
    {
        public CustomerDataContext (DbContextOptions<CustomerDataContext> options)
            : base(options)
        {
        }

        public DbSet<TheaterApp.Employee.Models.Customer> Customer { get; set; }
    }
