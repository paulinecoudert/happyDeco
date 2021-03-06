﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyDeco.Entities
{
    public class ProjetEntity
    {
        private int _idProjet;
        private string _nom, _description, _piece, _image;
        private double _budget;
        private DateTime _dateDeDebut, _dateDeFin;

        public int IdProjet
        {
            get
            {
                return _idProjet;
            }

            set
            {
                _idProjet = value;
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

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public string Piece
        {
            get
            {
                return _piece;
            }

            set
            {
                _piece = value;
            }
        }

        public string Image
        {
            get
            {
                return _image;
            }

            set
            {
                _image = value;
            }
        }

        public double Budget
        {
            get
            {
                return _budget;
            }

            set
            {
                _budget = value;
            }
        }

        public DateTime DateDeDebut
        {
            get
            {
                return _dateDeDebut;
            }

            set
            {
                _dateDeDebut = value;
            }
        }

        public DateTime DateDeFin
        {
            get
            {
                return _dateDeFin;
            }

            set
            {
                _dateDeFin = value;
            }
        }
    }
}
