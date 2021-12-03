using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasonDatabase.Controllers
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

        public ActionResult ApplicationReceived()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Rejected()
        {
            ViewBag.Message = "Your Application has been Denied.";

            return View();
        }


        public ActionResult Academics()
        {
            ViewBag.Message = "Academics";

            return View();
        }
        public ActionResult FinancialAid()
        {
            ViewBag.Message = "Financial Aid";

            return View();
        }
    }
}