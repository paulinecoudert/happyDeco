using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyDeco.Entities
{
    public class MessageEntity
    {

        private int _idMessage;
        private string _nom, _email, _phone, _information;
        DateTime _dateEnvoie;
 

        public int IdMessage
        {
            get
            {
                return _idMessage;
            }

            set
            {
                _idMessage = value;
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

        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }

        public string Information
        {
            get
            {
                return _information;
            }

            set
            {
                _information = value;
            }
        }

        public DateTime DateEnvoie
        {
            get
            {
                return _dateEnvoie;
            }

            set
            {
                _dateEnvoie = value;
            }
        }
    }
}
   

     
