
using System.Collections.Generic;
using Bangazon.Models;
using Bangazon.Data;

namespace Bangazon.Models.ProductViewModels
{
    public class ProductTypeDetailViewModel
    {
        public ProductType ProductType { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
