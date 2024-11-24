using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_Employe.Classes
{
    internal class Ouvrier : Employe
    {
        private string _dateEntree;

        public Ouvrier(string dateEntree, double salaire, string matricule, string nom, string prenom, string dateNaissance) : base (matricule, nom, prenom, dateNaissance)
        {
            _dateEntree = dateEntree;
            _salaire = salaire;
        }


        public string DateEntree
        {
            get { return _dateEntree; }
        }

    }
}
