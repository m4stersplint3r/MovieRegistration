using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "You must enter a Title")]
        [StringLength(50, ErrorMessage = "The Title is too long.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You must select a Genre")]
        public Genre MovieGenre { get; set; }
        [Range(1880, 2020, ErrorMessage = "The year chosen is impossible. Try again.")]
        [Required(ErrorMessage = "You must enter a Year")]
        public int Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }
    }
}