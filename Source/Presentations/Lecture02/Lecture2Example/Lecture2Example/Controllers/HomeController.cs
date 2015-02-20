using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture2Example.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.PasswordSuccesfullyChanged = false;
            return View();
        }

        [HttpPost]
        public ActionResult Login(string newPassword, string repeatedPassword)
        {
            bool passwordChanged = false;

            bool between6And40Characters = newPassword.Length >= 4 && newPassword.Length <= 60;
            bool containLettersAndNumber = true;  // todo: implement real logic
            bool containCprOrNemIdNumber = false; // todo: implement real logic

            if (between6And40Characters &&
                containLettersAndNumber && 
                !containCprOrNemIdNumber &&
                newPassword == repeatedPassword)
            {
                passwordChanged = true;
            }
            else
            {
                passwordChanged = false;
            }

            ViewBag.PasswordSuccesfullyChanged = passwordChanged;
            return View();
        }
    }
}