using eticaret.DbConfigurations;
using eticaret.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eticaret.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Customer customer)
        {
            var context = new EfCustomerDal();
            try
            {
                var controlCustomer = context.Get(c => c.Mail == customer.Mail && c.Password == customer.Password);
                if (controlCustomer == null)
                {
                    throw new Exception("Kullanıcı adı veya parola hatalı !");
                }

            }
            catch (Exception ex)
            {
                return Json(new { msg = "Ups ! \nBir şeyler ters gitti" + ex.Message.ToString(), state = false }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { msg = "Başarılı", state = true }, JsonRequestBehavior.AllowGet);
        }
    }
}