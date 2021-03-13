using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyDeco.Entities
{
    public class SignUpEntity
    {
        private int /*_idAdresse,*/ _idUserClient;
        private string /*_numero, _rue, _ville, _codePostal,*/ _nom, _prenom, _login, _password, _email, _salt;
        //private DateTime _dateDeNaissance;



        public int IdUserClient
        {
            get
            {
                return _idUserClient;
            }

            set
            {
                _idUserClient = value;
            }
        }

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                _prenom = value;
            }
        }

        public string Login
        {
            get
            {
                return _login;
            }

            set
            {
                _login = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string Salt
        {
            get
            {
                return _salt;
            }

            set
            {
                _salt = value;
            }
        }

        //public DateTime DateDeNaissance
        //{
        //    get
        //    {
        //        return _dateDeNaissance;
        //    }

        //    set
        //    {
        //        _dateDeNaissance = value.Date;
        //    }
        //}

        //public string Numero
        //{
        //    get
        //    {
        //        return _numero;
        //    }

        //    set
        //    {
        //        _numero = value;
        //    }
        //}

        //public string Rue
        //{
        //    get
        //    {
        //        return _rue;
        //    }

        //    set
        //    {
        //        _rue = value;
        //    }
        //}

        //public string Ville
        //{
        //    get
        //    {
        //        return _ville;
        //    }

        //    set
        //    {
        //        _ville = value;
        //    }
        //}

        //public string CodePostal
        //{
        //    get
        //    {
        //        return _codePostal;
        //    }

        //    set
        //    {
        //        _codePostal = value;
        //    }
        //}

        //public int IdAdresse
        //{
        //    get
        //    {
        //        return _idAdresse;
        //    }

        //    set
        //    {
        //        _idAdresse = value;
        //    }
        //}
    }
}
