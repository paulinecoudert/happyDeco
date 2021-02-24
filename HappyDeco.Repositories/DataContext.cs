using HappyDeco.DAL.Repositories;
using HappyDeco.Entities;
using HappyDeco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyDeco.Repositories
{
    public class DataContext
    {
        IConcreteRepository<ProjetEntity> _projetRepo;
        public DataContext(string connectionString)
        {
            _projetRepo = new ProjetRepository(connectionString);
        }

        public List<ProjetModel> GetAllProjet()
        {
            return _projetRepo.Get()
               .Select(m =>
               new ProjetModel()
               {
                   Nom = m.Nom,
                   Image = m.Image
               }).ToList();
        }

        #region AddProjet
        public bool SaveProjet (ProjetModel pm)
        {
            //MAppers
            ProjetEntity pe = new ProjetEntity();
            StatutEntity se = new StatutEntity();
            pe.Nom = pm.Nom;
           pe.Description = pm.Description;
            pe.Piece = pm.Piece;
            pe.Budget = pm.Budget;
            pe.DateDeDebut = DateTime.Now;
            pe.DateDeFin = DateTime.Now;
            pe.Image = pm.Image;
            se.Libellé = pm.Statut;
            


            return _projetRepo.Insert(pe);
        }
        #endregion
    }
}
