using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoRentalSystem.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required (ErrorMessage ="Please Select Genre")]
        public byte GenreId { get; set; }

        [Required(ErrorMessage = "Please Enter Release Date of the Movie")]
        public DateTime? ReleaseDate { get; set; }
        public DateTime? DateAdded { get; set; }

        [Required (ErrorMessage ="Please Enter Stock Value")]
        [Range(1, 100)]
        public int NumberInStock { get; set; }

        public int NumberAvailable { get; set; }
    }
}