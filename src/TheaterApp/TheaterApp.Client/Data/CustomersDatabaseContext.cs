using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheaterApp.Client.Models;

    public class CustomersDatabaseContext : DbContext
    {
        public CustomersDatabaseContext (DbContextOptions<CustomersDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<TheaterApp.Client.Models.Customers> Customers { get; set; }

    public static implicit operator CustomersDatabaseContext(Customers v)
    {
        throw new NotImplementedException();
    }
}
