using eticaret.DbModels;

namespace eticaret.CartProcesses
{
    public class CartLine
    {
        public Book Product { get; set; }
        public int Quantity { get; set; }
    }
}