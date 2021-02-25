using HappyDeco.Infra;
using HappyDeco.Models;
using HappyDeco.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HappyDeco.Areas.Membre.Controllers
{
    public class ProfilController : Controller
    {
        private string[] valideImageType = { ".png", ".jpg", ".jpeg" };
        // GET: Admin/Profil
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EditPicture()
        {
            return View(SessionUtil.ConnectedProjet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPicture(ProjetModel um, HttpPostedFileBase FilePicture)
        {

            //Juste pour démontrer l'upload de photo 
            //1- vérifier que la photo à une taille supérieure à 0 et pas trop lourde <200Mo
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
            DataContext ctx = new DataContext("");

            return View(SessionUtil.ConnectedProjet);
        }
    }
}
