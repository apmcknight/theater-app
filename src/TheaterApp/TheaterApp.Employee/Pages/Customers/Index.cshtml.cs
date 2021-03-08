using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheaterApp.Employee.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;


namespace TheaterApp.Employee.Pages.Customers
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly CustomerDataContext _context;

        public IndexModel(CustomerDataContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
