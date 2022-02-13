using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using VideoRentalSystem.Models;

namespace VideoRentalSystem.Controllers
{
    public class RentalsController : Controller
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Rentals
        public ActionResult New()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult AllRentals()
        {
            var rentals = _context.Rentals.Include(m => m.Customer).Include(m => m.Movie).ToList();

            return View(rentals);
        }
    }
}