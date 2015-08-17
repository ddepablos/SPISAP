using SPISAP.Models;
using SPISAP.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPISAP.Controllers
{

    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            Session["COD_USER"] = "";
            Session["USUARIO"] = "";
            Session["ERROR"] = "";
            return View();
        }

        [HttpPost]
        public ActionResult Login( UserViewModel user )
        {

            if (ModelState.IsValid)
            {

                UserRepository u = new UserRepository(user);

                if ( u.IsValid() )
                {
                    Session["COD_USER"] = user.username;
                    Session["USUARIO"] = user.userdesc;
                    Session["ERROR"] = "";
                    return RedirectToAction("Filter", "Employee");
                }
                else
                {
                    ModelState.AddModelError("Usuario", "El Usuario o Contraseña no son válidas.");
                }

            }

            return View(user);

        }

        public ActionResult Logout()
        { 
            HttpContext.Session.Clear();
            HttpContext.Session.Abandon();
            HttpContext.User = null;
            return RedirectToAction("Login");
        }        

    }
}
