using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SiriBiz.WebApp.Pages
{
    public class ComingSoonModel : PageModel
    {
        private readonly ILogger<ErrorModel> _logger;

        public ComingSoonModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
