using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoRentalSystem.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public DateTime? DateReturned { get; set; }
        public DateTime DateRented { get; set; }

        public int NumberOfMoviesRented { get; set; }

        public DateTime DueDate { get; set; }

        [Required]
        public Movie Movie { get; set; }

        [Required]
        public Customer Customer { get; set; }

    }
}