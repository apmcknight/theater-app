using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheaterApp.Employee.Models;

namespace TheaterApp.Employee.Data
{
    public class ReservationContext : DbContext
    {
        public ReservationContext (DbContextOptions<ReservationContext> options)
            : base(options)
        {
        }

        public DbSet<TheaterApp.Employee.Models.Reservation> Reservation { get; set; }
    }
}
