﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bangazon.Data;
using Bangazon.Models;
using Microsoft.AspNetCore.Authorization;

namespace Bangazon.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // This Index() method is currently being used by the ProductDetails view as a redirect when the "Add To Order" button is clicked.
        // Once order functionality has been built and the Home page has been merged, this method and its view will be obsolete and can be deprecated
        public async Task<IActionResult> Index()
        {
            var products = _context.Product.Include(p => p.ProductType);

            return View(await products.ToListAsync());
        }

        //Author: Shu Sajid
        //Purpose: Overloading index method. HttpPost is required because search field on view is
        // a form. Conditional statment is used if user uses se
        // GET: Products
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Index(string searchString, bool notUsed)
        {
            var products = _context.Product.Include(p => p.ProductType);


            if (!String.IsNullOrEmpty(searchString))
            {
                var searchProducts = products.Where(s => s.Title.Contains(searchString));
                return View(await searchProducts.ToListAsync());
            }
            return View(await products.ToListAsync());
        }

        // GET: Products/Details/5
		// Author: Elliot Huck
		/* Description: 
		 * Whenever a link with a product name is clicked, the details page shows more info on the product.
		 * It also queries the database to see how many are still available for sale and displays an 'Add to Order' button that will eventually
		 * allow a user to add the product to an order.
		 * If there are no more remaining, the 'Add' button should be disabled.
		 * Also, the 'Add' button should only function for registered users.
		*/ 
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.ProductType)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

			// Gets the number of intersections of this product on the OrderProduct table, showing how many times this product has been added to an order
			int numOrdered = _context.OrderProduct.Where(op => op.ProductId == product.ProductId).Count();

			// Decreases the quantity of the product available by the number that has already been ordered
			product.Quantity -= numOrdered;

            return View(product);
        }

		// These Create() methods are commented out because they were built by scaffolding, but aren't being implemented yet.
		// I'm leaving them in here because they may be useful for someone working on a different ticket in the future --Elliot
		/*
		// GET: Products/Create
        public IActionResult Create()
        {
            ViewData["ProductTypeId"] = new SelectList(_context.ProductType, "ProductTypeId", "Label");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,DateCreated,Description,Title,Price,Quantity,City,ProductTypeId")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductTypeId"] = new SelectList(_context.ProductType, "ProductTypeId", "Label", product.ProductTypeId);
            return View(product);
        }
		*/

		// These Edit() methods are commented out because they were built by scaffolding, but aren't being implemented yet.
		// I'm leaving them in here because they may be useful for someone working on a different ticket in the future --Elliot
		/*
		// GET: Products/Edit/5
		public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["ProductTypeId"] = new SelectList(_context.ProductType, "ProductTypeId", "Label", product.ProductTypeId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,DateCreated,Description,Title,Price,Quantity,City,ProductTypeId")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductTypeId"] = new SelectList(_context.ProductType, "ProductTypeId", "Label", product.ProductTypeId);
            return View(product);
        }
		*/

		// These Delete() methods are commented out because they were built by scaffolding, but aren't being implemented yet.
		// I'm leaving them in here because they may be useful for someone working on a different ticket in the future --Elliot
		/*
		// GET: Products/Delete/5
		public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.ProductType)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
		*/

		private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ProductId == id);
        }
		
    }
}
