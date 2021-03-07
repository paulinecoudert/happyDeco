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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
 
        public ActionResult Projet()
        {
          
            ViewBag.Contact = "active";
            return View();
        }





    }

       
}