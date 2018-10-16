using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bangazon.Models;

namespace Bangazon.Models
{
    public class BangazonContext : DbContext
    {
        public BangazonContext (DbContextOptions<BangazonContext> options)
            : base(options)
        {
        }

        public DbSet<Bangazon.Models.Product> Product { get; set; }

        public DbSet<Bangazon.Models.ProductType> ProductType { get; set; }
    }
}
