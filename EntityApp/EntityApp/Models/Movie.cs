using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityApp.Models
{
    public class Movie
    {
        
        public int ID { get; set; }
        
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
    }
}
