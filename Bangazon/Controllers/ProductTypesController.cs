using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bangazon.Models;
using Bangazon.Data;
using Bangazon.Models.ProductViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Bangazon.Controllers
{
    public class ProductTypesController : Controller
    {
        private ApplicationDbContext context;

        public ProductTypesController(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {

            return View();
        }

        //Author: Aaron Miller
        //Purpose: This will call database when category product is clicked and display all products in that cateory with the title, quanity, and price of the products displayed
        public async Task<IActionResult> Details([FromRoute]int? id)
        {

            // If no id was in the route, return 404
            if (id == null)
            {
                return NotFound();
            }

            var model = new ProductTypeDetailViewModel();

            var productType = await context.ProductType
                                .Where(t => t.ProductTypeId == id)
                                .SingleOrDefaultAsync();

            // If product not found, return 404
            if (productType == null)
            {
                return NotFound();
            }

            model.Products = await (from t in context.Product
                                    where t.ProductTypeId == id
                                    select t).ToListAsync();

            model.ProductTypes = productType;

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}