using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheaterApp.Employee.Models;

public class ReservationDataContext : DbContext
{
    public ReservationDataContext(DbContextOptions<ReservationDataContext> options)
        : base(options)
    {
    }

    public DbSet<TheaterApp.Employee.Models.Reservation> Reservation { get; set; }
}
