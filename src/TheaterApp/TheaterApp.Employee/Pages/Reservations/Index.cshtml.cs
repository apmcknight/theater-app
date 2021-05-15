using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheaterApp.Employee.Data;
using TheaterApp.Employee.Models;
using Microsoft.AspNetCore.Authorization;

namespace TheaterApp.Employee.Pages.Reservations
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly TheaterApp.Employee.Data.ReservationContext _context;

        public IndexModel(TheaterApp.Employee.Data.ReservationContext context)
        {
            _context = context;
        }

        public IList<Reservation> Reservation { get;set; }

        public async Task OnGetAsync()
        {
            Reservation = await _context.Reservation.ToListAsync();
        }
    }
}
