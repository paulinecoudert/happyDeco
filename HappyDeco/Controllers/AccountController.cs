using HappyDeco.Infra;
using HappyDeco.Models;
using HappyDeco.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HappyDeco.Controllers
{
    public class AccountController : Controller
    {
        DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
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
            return View(new LoginModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel lm)
        {
            if (ModelState.IsValid)
            {
                UserClientModel um = ctx.UserAuth(lm);
                if (um == null)
                {
                    ViewBag.Error = "Erreur Login/Password";
                    return View();
                }
                else
                {
                    SessionUtil.IsLogged = true;
                    SessionUtil.ConnectedUserClient = um;
                    return RedirectToAction("Index", "Home", new { area = "Membre" });
                }
            }
            else
            {
                return View();
            }

        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View(new SignUpModel());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp  (SignUpModel sm)
        {
            if (ModelState.IsValid)
            {
                DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

            if (ctx.SaveSignUp(sm))
            {
                SessionUtil.IsLogged = true;
               //ViewBag.SuccessMessage = "Hello, you're a member of Foodsharing community!";
                return RedirectToAction("Index", "Home", new { area = "Membre" });
            }
            else
            {
                ViewBag.ErrorMessage = "Try once again!";
                return View();
            }
        }
            else
            {
                ViewBag.ErrorMessage = "Sign Up error";
                return View();
           }

    }

       
    }
}