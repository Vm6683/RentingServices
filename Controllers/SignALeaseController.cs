using Microsoft.AspNetCore.Mvc;
using RentingServices.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentingServices.Controllers
{
    public class SignALeaseController : Controller
    {
        // add DbContext to use the datbase 

        private readonly ApplicationDbContext _context;

        // constructor that takes an instanse of our db connection.
        public SignALeaseController(ApplicationDbContext context)
        {
            _context = context;  // assign incoming db connection.
        }
        public IActionResult Index()
        {
            var properties = _context.Properties.OrderBy(c => c.City).ToList();
            return View(properties);
        }
    }
}
