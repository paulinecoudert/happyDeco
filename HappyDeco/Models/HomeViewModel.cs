using HappyDeco.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;



namespace HappyDeco.Models
{
    public class HomeViewModel
    {
        private DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

        private List<ProjetModel> _projetModels;
       

        public HomeViewModel()
        {
            _projetModels = ctx.GetAllProjet();
        }

        public List<ProjetModel> ProjetModels
        {
            get
            {
                return _projetModels;
            }

            set
            {
                _projetModels = value;
            }
        }

     
    }
}