using SimpleBankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBankApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel loginModel)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index","AccountInfo", new { @userId = loginModel.UserId.Trim() });
            }

            return View(loginModel);
        }
    }
}