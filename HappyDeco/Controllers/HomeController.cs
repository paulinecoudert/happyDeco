using HappyDeco.Infra;
using HappyDeco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HappyDeco.Controllers
{
    public class HomeController : Controller
    {


        private void AddPage()
        {
            SessionUtil.Compteur++;

        }
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

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Projet()
        {
            ViewBag.Message = "Your Project page.";

            return View();
        }
    }
}