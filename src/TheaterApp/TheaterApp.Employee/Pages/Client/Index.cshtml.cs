using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TheaterApp.Employee.Pages
{
    public class ClientModel : PageModel
    {
        private readonly ILogger<ClientModel> _logger;

        public ClientModel(ILogger<ClientModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
