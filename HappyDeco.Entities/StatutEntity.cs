using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyDeco.Entities
{
    public class StatutEntity
    {
        private int _idStatut;
        private string _libellé;

        public int IdStatut
        {
            get
            {
                return _idStatut;
            }

            set
            {
                _idStatut = value;
            }
        }

        public string Libellé
        {
            get
            {
                return _libellé;
            }

            set
            {
                _libellé = value;
            }
        }
    }
}
