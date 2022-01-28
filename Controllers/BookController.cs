using eticaret.DbConfigurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eticaret.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            var context = new EfBookDal();
            var books = context.GetList();
            return View(books);
        }

    }
}