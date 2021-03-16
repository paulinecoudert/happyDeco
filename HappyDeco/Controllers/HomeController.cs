using HappyDeco.Infra;
using HappyDeco.Models;
using HappyDeco.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace HappyDeco.Controllers
{
    public class HomeController : Controller
    {



        public ActionResult Index()
        {
            ViewBag.Home = "active";
            HomeViewModel hm = new HomeViewModel();
            Session["messageInfo"] = "ceci est un mesage";
            Session.Abandon();
            return View(hm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Offres()
        {
            ViewBag.Message = "Offres";

            return View();
        }

        public ActionResult Realisations()
        {
            ViewBag.Message = "Realisations";
            ProjetViewModel pm = new ProjetViewModel();

            return View(pm);
        }
 
        public ActionResult Projet()
        {
          
            ViewBag.Contact = "active";
            return View();
        }

        public ActionResult DepotProjet()
        {

            ViewBag.Contact = "active";

            return View();
        }

        //Afficher le formulaire
        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Contact = "active";
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(ContactModel contact)
        {
            if (ModelState.IsValid)
            {
                DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

                if (ctx.SaveContact(contact))
                {
                    ViewBag.SuccessMessage = "Message bien envoyé";
                    return View();
                }
                else
                {
                    ViewBag.ErrorMessage = "Message non enregistré";
                    return View();
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Formulaire error";
                return View();
            }

        }



    }


}