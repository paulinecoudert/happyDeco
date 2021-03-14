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
        IConcreteRepository<SignUpEntity> _signUpRepo;
        IConcreteRepository<MessageEntity> _messRepo;

        public DataContext(string connectionString)
        {
            _projetRepo = new ProjetRepository(connectionString);
            _statutRepository = new StatutRepository(connectionString);
            _userRepository = new UserClientRepository(connectionString);
            _signUpRepo = new SignUpRepository(connectionString);
            _messRepo = new MessageRepository(connectionString);
        }


        #region Contact
        public bool SaveContact(ContactModel cm)
        {
            //MAppers
            MessageEntity me = new MessageEntity();
            me.Nom = cm.Nom;
            me.Email = cm.Email;
            me.Phone = cm.Phone;
            me.Information = cm.Information;
            me.DateEnvoie = cm.DateEnvoie;

            return _messRepo.Insert(me);
        }
        #endregion
        public bool SaveSignUp (SignUpModel sm)
        {
            UserClientEntity signUp = new UserClientEntity();
            //signUp.Rue = sm.Rue;
            //signUp.Numero = sm.Numero;
            //signUp.Ville = sm.Ville;
            //signUp.CodePostal = sm.CodePostal;
            signUp.Nom = sm.Nom;
            signUp.Prenom = sm.Prenom;
            signUp.Email = sm.Email;
            signUp.DateDeNaissance = sm.DateDeNaissance;
            signUp.Password = sm.Password;
            signUp.Login = sm.Login;
            

            return _userRepository.Insert(signUp);

        }

        public List<ProjetModel> GetAllProjet()
        {
            return _projetRepo.Get()
               .Select(m =>
               new ProjetModel()
               {
                   Nom = m.Nom,
                   IdProjet = m.IdProjet,
                   Image = m.Image,
                   Piece = m.Piece,
                   Description = m.Description,
                   Budget = m.Budget,
                   Statut = string.Join(", ", ((StatutRepository)_statutRepository).GetFromProjet(m.IdProjet).Select(p => p.Libellé)),
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
            {
                pm.IdProjet = idProjet;

                return ((StatutRepository)_statutRepository).InsertFromProject(pm.IdStatut, idProjet);
            }
            else
                return false;

      


        }
        #endregion


        #region AddProjet
        public bool SaveUser(UserClientModel uc)
        {
            //MAppers
            UserClientEntity ue = new UserClientEntity();

            ue.Nom = uc.Nom;
            ue.Prenom = uc.Prenom;
            ue.Email = uc.Email;
            ue.Login = uc.Login;
            ue.Password = uc.Password;

            return _userRepository.Insert(ue);

        }








        #endregion
        public UserClientModel UserAuth(LoginModel lm)
        {
            UserClientEntity ue = ((UserClientRepository)_userRepository).GetFromLogin(lm.Login);
            if (ue == null) return null;
            if (ue != null)
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
