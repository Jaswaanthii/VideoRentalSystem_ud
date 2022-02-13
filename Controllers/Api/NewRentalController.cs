using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VideoRentalSystem.Dtos;
using VideoRentalSystem.Models;

namespace VideoRentalSystem.Controllers.Api
{

    public class NewRentalController : ApiController
    {
        private ApplicationDbContext _context;
        public NewRentalController()
        {
            _context = new ApplicationDbContext();
        }

        
        public IEnumerable<NewRentalDto> GetRentals()
        {
            return _context.Rentals.Include(m => m.Customer).Include(m => m.Movie).ToList().Select(Mapper.Map<Rental, NewRentalDto>);
            
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);
            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id));

            foreach(var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now,
                    DueDate = DateTime.Now.AddDays(14)
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
