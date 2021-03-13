using HappyDeco.Infra;
using HappyDeco.Models;
using HappyDeco.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HappyDeco.Areas.Membre.Controllers
{
    public class HomeController : Controller
    {
        private string[] valideImageType = { ".png", ".PNG", ".jpg", ".jpeg" };
        // GET: Membre/Home
        public ActionResult Index()
        {
            if (!SessionUtil.IsLogged) return RedirectToAction("Login", "Account", new { area = "" });

            return View(SessionUtil.ConnectedProjet);
        }



        [HttpGet]
        public ActionResult Logout()
        {
            Session.Abandon();

            return RedirectToAction("Index", "Home", new { area = "" });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UploadPicture(ProjetModel um, HttpPostedFileBase FilePicture)
        {


            if (FilePicture.ContentLength > 0 && FilePicture.ContentLength < 20000)
            {

                //2 Vérifier le type
                string extension = Path.GetExtension(FilePicture.FileName);
                if (valideImageType.Contains(extension))
                {
                    //3 vérifier si le dossier de destination existe
                    //D:\Cours\Wad20\NetFlask\images\Users\1
                    string destFolder = Path.Combine(Server.MapPath("~/images/portfolio"), SessionUtil.ConnectedProjet.IdProjet.ToString());
                    if (!Directory.Exists(destFolder))
                    {
                        Directory.CreateDirectory(destFolder);
                    }

                    //4 - Upload de l'image
                    FilePicture.SaveAs(Path.Combine(destFolder, FilePicture.FileName));

                    //5 Mise à jour de l'objet User
                    SessionUtil.ConnectedProjet.Image = FilePicture.FileName;
                    return RedirectToAction("Index", "Home");
                }
            }
            //Remarque : il faudra également sauvegarder dans la DB
            DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

            return View(SessionUtil.ConnectedProjet);
        }


        [HttpPost]
        public ActionResult Index(ProjetModel projet, HttpPostedFileBase FilePicture)
        {


            if (ModelState.IsValid)
            {

                if (FilePicture.ContentLength > 0 && FilePicture.ContentLength < 200000000)
                {

                    //2 Vérifier le type
                    string extension = Path.GetExtension(FilePicture.FileName);
                    if (valideImageType.Contains(extension))
                    {
           
                        //1- DB
                        projet.Image = FilePicture.FileName;

                        DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
                        if (ctx.SaveProjet(projet))
                        {
                            //3 vérifier si le dossier de destination existe
                            //D:\Cours\Wad20\NetFlask\images\Users\1
                            string destFolder = Path.Combine(Server.MapPath("~/images/portfolio"), projet.IdProjet.ToString());
                            if (!Directory.Exists(destFolder))
                            {
                                Directory.CreateDirectory(destFolder);
                            }

                            //4 - Upload de l'image
                            FilePicture.SaveAs(Path.Combine(destFolder, FilePicture.FileName));

                            //5 Mise à jour de l'objet User
                            SessionUtil.ConnectedProjet=projet;


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