using System.Collections.Generic;
using System.Linq;

namespace eticaret.CartProcesses
{
    public class Cart
    {
        public Cart()
        {
            CartLines = new List<CartLine>();
        }
        public List<CartLine> CartLines { get; set; }
        public decimal Total => CartLines.Sum(c => c.Product.Price * c.Quantity);
    }
}