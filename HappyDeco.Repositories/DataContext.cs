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
        IConcreteRepository<StatutEntity> _statutRepository;
        public DataContext(string connectionString)
        {
            _projetRepo = new ProjetRepository(connectionString);
            _statutRepository = new StatutRepository(connectionString);
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

        public ProjetModel GetOneProjet (ProjetEntity pe)
        {
            ProjetModel pm = new ProjetModel();
            pm.Nom = pe.Nom;
            pm.Description = pe.Description;
            pm.Piece = pe.Piece;
            pm.Budget = pe.Budget;
            pm.DateDeDebut = DateTime.Now;
            pm.DateDeFin = DateTime.Now;
            pm.Image = pe.Image;

            return pm;
        }

        #region AddProjet
        public bool SaveProjet (ProjetModel pm)
        {
            //MAppers
            ProjetEntity pe = new ProjetEntity();
           
            pe.Nom = pm.Nom;
           pe.Description = pm.Description;
            pe.Piece = pm.Piece;
            pe.Budget = pm.Budget;
            pe.DateDeDebut = DateTime.Now;
            pe.DateDeFin = DateTime.Now;
            pe.Image = pm.Image;


            int idProjet = 0;
            bool test =     ((ProjetRepository)_projetRepo).InsertWithId(pe, out idProjet);
            if (test)
                return ((StatutRepository)_statutRepository).InsertFromProject(pm.IdStatut, idProjet);
            else
                return false;
        }
        #endregion
    }
}
