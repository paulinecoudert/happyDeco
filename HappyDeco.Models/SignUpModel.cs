using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyDeco.Models
{
    public class SignUpModel
    {

        private string _nom, _prenom, _login, _password, _email, _salt /*_numero, _rue, _ville, _codePostal*/;
        private DateTime _dateDeNaissance;

        [Required]
        [MaxLength(50)]
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

        [Required]
        [MaxLength(50)]
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

        [Required]
       
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
        [Required]
     
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

        [Required]
        [MaxLength(323)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
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

        [Required]

        public DateTime DateDeNaissance
        {
            get
            {
                return _dateDeNaissance;
            }

            set
            {
                _dateDeNaissance = value;
            }
        }

        //[Required]
        //[MaxLength(5)]
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
        //[Required]
        //[MaxLength(100)]
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
        //[Required]
        //[MaxLength(50)]
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
        //[Required]
        //[MaxLength(5)]
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
    }
}
