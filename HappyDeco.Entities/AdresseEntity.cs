using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyDeco.Entities
{
    public class AdresseEntity
    {
        private int _idAdresse;
        private string _rue, _numero, _codePostal, _ville;
        private List<UserClientEntity> _idUserClient;

        public int IdAdresse
        {
            get
            {
                return _idAdresse;
            }

            set
            {
                _idAdresse = value;
            }
        }

        public string Rue
        {
            get
            {
                return _rue;
            }

            set
            {
                _rue = value;
            }
        }

        public string Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
            }
        }

        public string CodePostal
        {
            get
            {
                return _codePostal;
            }

            set
            {
                _codePostal = value;
            }
        }

        public string Ville
        {
            get
            {
                return _ville;
            }

            set
            {
                _ville = value;
            }
        }

        public List<UserClientEntity> IdUserClient
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
