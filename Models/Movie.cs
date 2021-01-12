using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pirlea_AlexandraDenisa_Proiect.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Display(Name = "Movie Title")]
        public string Title { get; set; }

        [Display(Name = "Movie Director")]
        public string Director { get; set; }
        public string Genre { get; set; }

        [Column(TypeName = "decimal(2, 1)")]
        public decimal Rating { get; set; }

        [Display(Name = " Release Date")]
        public DateTime ReleaseDate { get; set; }
    }
}
