using eticaret.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eticaret.CartProcesses
{
    public static class CartManager 
    {
        private static Cart _cart = new Cart();
        public static void AddToCart(Book product)
        {
            CartLine cartLine = _cart.CartLines.FirstOrDefault(c => c.Product.Id == product.Id);
            if (cartLine != null)
            {
                cartLine.Quantity++;
                return;
            }
            _cart.CartLines.Add(new CartLine { Product = product, Quantity = 1 });
        }

        public static List<CartLine> List()
        {
            return _cart.CartLines;
        }
        public static Cart GetCart()
        {
            return _cart;
        }

        public static void RemoveFromCart(int productId)
        {
            _cart.CartLines.Remove(_cart.CartLines.FirstOrDefault(c => c.Product.Id == productId));
        }
    }
}