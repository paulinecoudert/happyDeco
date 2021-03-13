using HappyDeco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyDeco.Infra
{
    public static class SessionUtil
    {

        public static bool IsLogged
        {
            get
            {

                if (HttpContext.Current.Session["logged"] == null)
                {
                    HttpContext.Current.Session["logged"] = false;
                }
                return (bool)HttpContext.Current.Session["logged"];
            }

            set { HttpContext.Current.Session["logged"] = value; }
        }

        public static ProjetModel ConnectedProjet
        {
            get
            {
                return (ProjetModel)HttpContext.Current.Session["ConnectedProjet"];
            }

            set { HttpContext.Current.Session["ConnectedProjet"] = value; }

        }

        public static UserClientModel ConnectedUserClient
        {
            get
            {
                return (UserClientModel)HttpContext.Current.Session["ConnectedUserClient"];
            }

            set { HttpContext.Current.Session["ConnectedUserClient"] = value; }

        }


    }
 }

    
