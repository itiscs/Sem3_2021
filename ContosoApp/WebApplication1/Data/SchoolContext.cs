
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class SchoolContext : DbContext
    {

        public SchoolContext(DbContextOptions < SchoolContext > options)
            : base(options)
        {
           // SchoolInitializer.Initialize(this);
            
        }
               

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }


    }
}
