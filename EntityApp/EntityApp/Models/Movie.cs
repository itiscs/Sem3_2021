using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityApp.Models
{
    public class Movie
    {

        public int ID { get; set; }
        
        [Display(Name = "Название")]
        [StringLength(60, MinimumLength = 3)]
        [MaxLength(60)]
        [Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Дата релиза")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Жанр")]
        [MaxLength(20)]
        [RegularExpression(@"^[А-Я]+[а-яА-Я\s]*$")]
        [Required]
        public string Genre { get; set; }

        [Display(Name = "Цена")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(13, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "Рейтинг")]
        [Range(0,10,ErrorMessage ="Рейтинг должен быть в интервале [0,10]")]
        public int Rating { get; set; }
    }
}
