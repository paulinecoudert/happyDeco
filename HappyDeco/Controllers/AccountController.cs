using HappyDeco.Infra;
using HappyDeco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HappyDeco.Controllers
{
    public class AccountController : Controller
    {
        // GET: Acount
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Abandon();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel lm)
        {
            if (ModelState.IsValid)
            {
                if (lm.Login != "Pauline" && lm.Password != "1234")
                {
                    ViewBag.Error = "Erreur Login/Password";
                    return View();
                }
                else
                {
                    SessionUtil.IsLogged = true;
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return View();
            }
        }

    }
}