using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheaterApp.Employee.Models;
using Microsoft.AspNetCore.Authorization;


namespace TheaterApp.Employee.Pages
{
    [Authorize]
    public class ReportModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
