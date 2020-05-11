using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Dog
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Не указано имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указан возраст")]
        [Range(0, 20, ErrorMessage = "Возраст не может быть больше 20 лет и меньше 0")]
        public int Age { get; set; }
        public string Sex { get; set; }

        [Required(ErrorMessage = "Не указана расцветка")]
        public string Color { get; set; }
    }
}
