using System.Collections.Generic;

namespace Bangazon.Models.ProductTypeViewModels
{
    public class OrderDetailViewModel
    {
        public Order Order { get; set; }

        public IEnumerable<OrderLineItem> LineItems { get; set; }
    }
}