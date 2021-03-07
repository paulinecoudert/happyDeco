using HappyDeco.DAL.Repositories;
using HappyDeco.Entities;
using HappyDeco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool;

namespace HappyDeco.Repositories
{
    public class DataContext
    {
        IConcreteRepository<ProjetEntity> _projetRepo;
        IConcreteRepository<StatutEntity> _statutRepository;
        IConcreteRepository<UserClientEntity> _userRepository;
        public DataContext(string connectionString)
        {
            _projetRepo = new ProjetRepository(connectionString);
            _statutRepository = new StatutRepository(connectionString);
            _userRepository = new UserClientRepository(connectionString);
        }

      

        public List<ProjetModel> GetAllProjet()
        {
            return _projetRepo.Get()
               .Select(m =>
               new ProjetModel()
               {
                   Nom = m.Nom,
                   Image = m.Image,
                   Piece = m.Piece,
                   Description = m.Description,
                   Budget = m.Budget,
                   Statut= string.Join(", ", ((StatutRepository)_statutRepository).GetFromProjet(m.IdProjet).Select(p => p.Libellé)),
                   Email = string.Join(", ", ((UserClientRepository)_userRepository).GetFromProjet(m.IdProjet).Select(p => p.Email)),



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

            int idProjet2 = 0;
            bool test2 = ((ProjetRepository)_projetRepo).InsertWithId(pe, out idProjet2);
            if (test2)
                return ((UserClientRepository)_userRepository).InsertFromProject(pm.IdUserClient, idProjet2);
            else
                return false;


        }
        #endregion

        public UserClientModel UserAuth(LoginModel lm)
        {
            UserClientEntity ue = ((UserClientRepository)_userRepository).GetFromLogin(lm.Login);
            if (ue == null) return null;
            SecurityHelper sh = new SecurityHelper();
            if (sh.VerifyHash(lm.Password, ue.Password, ue.Salt))
            {
                return new UserClientModel()
                {
                    IdUserClient = ue.IdUserClient,
                    Nom = ue.Nom,
                    Prenom = ue.Prenom,
                    Login = ue.Login,
                    Email = ue.Email,
                   
                };
            }
            else
            {
                return null;
            }
        }
    }
}
