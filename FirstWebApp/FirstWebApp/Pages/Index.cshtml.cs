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

        public void OnGet(string name, int? age)
        {
            if(name != null)
                Name = name;
            if(age != null )
                Age = Convert.ToInt32(age);            
        }

        public IActionResult OnPost(string name, int? age)
        {
            

            Hello = $"Привет {name}, {age}!";
            return Page();

            //string url = Url.Page("About", new { name = name});
            //return Redirect(url);

        }
    }
}
