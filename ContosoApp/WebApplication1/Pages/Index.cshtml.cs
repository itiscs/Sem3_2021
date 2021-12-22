using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int BackgroundColor { get; set; }

        [BindProperty]
        public string SelectedColor { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            BackgroundColor = 3;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            switch(BackgroundColor)
            {
                case 1:
                    SelectedColor = "aqua";
                    break;
                case 2:
                    SelectedColor = "azure";
                    break;
                case 3:
                    SelectedColor = "cornsilk";
                    break;
            }

            Response.Cookies.Append("color", SelectedColor);

        }
    }
}
