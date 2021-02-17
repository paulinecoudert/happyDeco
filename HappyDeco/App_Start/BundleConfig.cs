using System.Web;
using System.Web.Optimization;

namespace HappyDeco
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {


            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/css/plugins.css",
                "~/css/style.css"
                ));

            bundles.Add(new ScriptBundle("~/Bundles/scripts").Include(

                
                "~/js/jquery.min.js",
                "~/js/popper.min.js",
                "~/js/bootstrap.min.js",
                "~/js/jquery.magnific-popup.min.js",
                "~/js/custom.js"


                ));
            
        }
    }
}
