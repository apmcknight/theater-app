﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly TheaterApp.Employee.Data.ReservationContext _context;

        public DetailsModel(TheaterApp.Employee.Data.ReservationContext context)
        {
            _context = context;
        }

        public Reservation Reservation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Reservation = await _context.Reservation.FirstOrDefaultAsync(m => m.ID == id);

            if (Reservation == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
