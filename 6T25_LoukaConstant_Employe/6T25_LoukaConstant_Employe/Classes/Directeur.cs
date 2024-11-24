using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_Employe.Classes
{
    internal class Directeur : Employe
    {
        private double _chiffreAffaire;
        private double _pourcentage;

        public Directeur(double chiffreAffaire, double pourcentage, string matricule, string nom, string prenom, string dateNaissance) : base(matricule, nom, prenom, dateNaissance)
        {
            _chiffreAffaire = chiffreAffaire;
            _pourcentage = pourcentage;
            _salaire = ChiffreAffaire * (Pourcentage / 100);
        }

        public double ChiffreAffaire
        {
            get { return _chiffreAffaire; }
            set { _chiffreAffaire = value; }
        }
        public double Pourcentage
        {
            get { return _pourcentage; }
            set { _pourcentage = value; }
        }


    }
}
