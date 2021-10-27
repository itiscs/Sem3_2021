using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EntityApp.Data;
using EntityApp.Models;

namespace EntityApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MoviesContext _context;

        public IndexModel(MoviesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movies { get;set; }

        public async Task OnGetAsync()
        {
            Movies = await _context.Movies.ToListAsync();
        }
    }
}
