using System.Collections.Generic;

namespace Bangazon.Models
{
    public class ProductTypesViewModel
    {
        //public ProductType ProductType { get; set; }

        public IEnumerable<GroupedProducts> GroupedProducts { get; set; }

        //public IEnumerable<ProductLineItem> LineItems { get; set; }
    }
}