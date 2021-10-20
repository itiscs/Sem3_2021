using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FirstWebApp.Pages
{
    public class SecondModel : PageModel
    {
        private readonly ILogger<SecondModel> _logger;

        public SecondModel(ILogger<SecondModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
