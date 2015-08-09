using SPISAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPISAP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult Login()
        {
        
            return View();

        }

        [HttpPost]
        public ActionResult Login( UserViewModel user )
        {
        
            return RedirectToAction("Filter","Employee");

        }

    }
}
