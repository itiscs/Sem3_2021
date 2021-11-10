using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EntityApp.Data;
using EntityApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }

        public async Task OnGetAsync()
        {

            var movies = _context.Movies.Select(m => m);

            Genres = new SelectList(await movies
                .Select(m => m.Genre).Distinct().ToListAsync());
                       

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }

            Movies = await movies.ToListAsync();
        }
    }
    
}
