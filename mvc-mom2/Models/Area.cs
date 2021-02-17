using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace mvc_mom2.Models
{
    public class Area
    {
        //Preppar med key utifall man skall lägga i en databas längre fram
        [Key]
        public int  Id { get; set; }
        [Required]
        public int width { get; set; }
        [Required(ErrorMessage = "Du ange bredd")]
        public int lenght { get; set; }
        [Required]
        public string dimension { get; set; }
        public int answer { get; set; }

        // konstruktorn kommer att användas av annan kod och behöver vara tom r1
        public Area()
        {

        }
        public Area(int id, int width, int lenght, string dim, int answer)
        {
            this.Id = id;
            this.width = width; 
            this.lenght = lenght; 
            this.dimension = dim;
            this.answer = answer;
        }
    }
}
