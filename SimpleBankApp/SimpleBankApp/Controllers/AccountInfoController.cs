using SimpleBankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MockRepository;

namespace SimpleBankApp.Controllers
{
    public class AccountInfoController : Controller
    {
        // GET: AccountInfo
        public ActionResult Index(string userId)
        {
            var accountInfo = MockUserAccountData.GetMockUserAccountData(userId);

            // Typically the code here would extract only required information from the data that the repository returned and create a model
            // to be used in the web application.
            // In this case, because all the data is mocked to what is needed, it could have been unnecessary but 
            // was mimicked anyways to demonstrate the process.
            var userAccountInfo = new UserAccountInfo(accountInfo);
            
            return View(userAccountInfo);
        }
    }
}