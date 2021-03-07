using HappyDeco.Infra;
using HappyDeco.Models;
using HappyDeco.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HappyDeco.Areas.Membre.Controllers
{
    public class HomeController : Controller
    {
        private string[] valideImageType = { ".png", ".jpg", ".jpeg" };
        // GET: Membre/Home
        public ActionResult Index()
        {
            if (!SessionUtil.IsLogged) return RedirectToAction("Login", "Account", new { area = "" });

            return View(SessionUtil.ConnectedProjet);
        }

        public ActionResult Profil()
        {
            ViewBag.Message = " ";
          

            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Abandon();

            return RedirectToAction("Index", "Home", new { area = "" });
        }


        [HttpPost]
        public ActionResult Index(ProjetModel projet) { 

            if (ModelState.IsValid)
            {
                DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
                if (ctx.SaveProjet(projet))
                {
                   

                            return RedirectToAction("Realisations", "Home", new { area = "" });
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

    }
}
