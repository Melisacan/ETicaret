using eticaret.DbConfigurations;
using eticaret.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eticaret.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
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
                var controlCustomer = context.Get(c=>c.Mail==customer.Mail);
                if (controlCustomer != null)
                {
                    throw new Exception("Böyle bir kullanıcı var");
                }
                if (ModelState.IsValid)
                {
                    

                    context.Add(new Customer
                    {
                        Name = customer.Name,
                        Address = customer.Address,
                        Mail = customer.Mail,
                        Password = customer.Password,
                        PhoneNumber = customer.PhoneNumber,
                        Surname = customer.Surname
                    });
                    
                }
            }
            catch (Exception ex)
            {
                return Json(new { msg = "Hatalı Üyelik" + ex.Message.ToString(), state = false }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { msg = "Başarılı Üyelik", state = true }, JsonRequestBehavior.AllowGet);
        }
    }
}