using eticaret.DbConfigurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eticaret.Controllers
{
    public class BookDetailController : Controller
    {
        // GET: BookDetail
        public ActionResult Index()
        {
            var paramId = int.Parse(Request.QueryString["ID"].ToString());
            if (paramId == null || paramId == 0)
                RedirectToAction("/");
            var context = new EfBookDal();
            var book = context.Get(b => b.Id == paramId);

            return View(book);
        }

   
    }
}