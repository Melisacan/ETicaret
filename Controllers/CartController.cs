using eticaret.CartProcesses;
using eticaret.DbConfigurations;
using eticaret.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eticaret.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            
            return View(CartManager.List());
        }
        public ActionResult AddItem()
        {

            var paramId = int.Parse(Request.QueryString["ID"].ToString());
            if(paramId == null || paramId == 0)
                RedirectToAction($"../");

            var context = new EfBookDal();
            var book = context.Get(b => b.Id == paramId);
            CartManager.AddToCart(book);
            
            return View();
        }
        public ActionResult RemoveItem()
        {
            var paramId = int.Parse(Request.QueryString["ID"].ToString());
            CartManager.RemoveFromCart(paramId);
            return View();

        }
        public decimal GetTotalPrice()
        {
            var totalPrice = CartManager.GetCart().Total;
            return totalPrice;
        }

    }
}