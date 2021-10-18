using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string Name { get; set; }
        public int Age { get; set; }

        public string Hello { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            Name = "Tom";
            Age = 30;
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost(string name, int? age)
        {
            Hello = $"Привет {name}, {age}!";

        }
    }
}
