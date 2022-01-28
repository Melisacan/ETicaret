using eticaret.DbConfigurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eticaret.DbModels;
using eticaret.Models;

namespace eticaret.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var efBookDal = new EfBookDal();
            var books = efBookDal.GetList();

            
            return View(books);
        }
        public ActionResult GirisYap()
        {
            return View();
        }
        public ActionResult KayitOl()
        {
            return View();
        }
        public ActionResult Sepetim()
        {
            return View();
        }
    }
}