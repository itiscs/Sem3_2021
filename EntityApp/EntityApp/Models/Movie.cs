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
        
        [Display(Name = "Название")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Дата релиза")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Жанр")]
        public string Genre { get; set; }
        [Display(Name = "Цена")]
        public decimal Price { get; set; }
        [Display(Name = "Рейтинг")]
        [Range(0,10,ErrorMessage ="Рейтинг должен быть в интервале [0,10]")]
        public int Rating { get; set; }
    }
}
