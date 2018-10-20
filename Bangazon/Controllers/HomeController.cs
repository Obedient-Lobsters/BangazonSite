using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bangazon.Models;
using Bangazon.Data;
using Microsoft.EntityFrameworkCore;

namespace Bangazon.Controllers
{
    public class HomeController : Controller
    {
        //Author: Shu Sajid 
        //Purpose: This controller is needed for the home page to view latest 
        //twenty products
        
        //This variable is used to make the connection to database
        private ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        //This method gets the top latest creaded objections and passes it into view
        public async Task<IActionResult> Index()
        {
            return View(await _context.Product
                .Include(product=>product.ProductType)
                .OrderByDescending(product => product.DateCreated)
                .Take(20)
                .ToListAsync());
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
