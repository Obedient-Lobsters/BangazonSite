namespace Bangazon.Models.ProductTypeViewModels {
    public class OrderLineItem {
        public Product Product { get; set; }
        public int Units { get; set; }
        public double Cost { get; set; }
    }
}