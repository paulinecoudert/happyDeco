using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyDeco.Models
{
    public class UserClientModel
    {
        private int _idUserClient;
        private string _nom, _prenom, _login, _password, _email, _salt;
        private DateTime _dateDeNaissance;



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

        [Required]
        [MaxLength(50)]
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
        [MaxLength(50)]
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

        [EmailAddress]
        [DataType(DataType.EmailAddress)]
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
    }
}
