using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Pages.Courses
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly WebApplication1.Data.SchoolContext _context;

        public IndexModel(WebApplication1.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Courses.Include(c=>c.Enrollments)
                .ToListAsync();
        }
        public async Task OnPostAsync(int id)
        {
            Course = await _context.Courses.Include(c => c.Enrollments)
               .ToListAsync();
            string cart = "";
            if(HttpContext.Session.Keys.Contains("cart"))
            {
                cart = HttpContext.Session.GetString("cart");

            }
            var course = _context.Courses.First(c => c.CourseID==id).Title;
            if(!cart.Contains(course))
                HttpContext.Session.SetString("cart", cart + " " + course);
        }
    }
}
