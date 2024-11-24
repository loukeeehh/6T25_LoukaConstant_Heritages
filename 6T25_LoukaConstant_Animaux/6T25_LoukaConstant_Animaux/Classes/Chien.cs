using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_Animaux.Classes
{
    internal class Chien : Animaux
    {
        public Chien(string nom, string dateNaissance, double numeroPuce, decimal taille, bool animalConcours) : base(nom, dateNaissance, numeroPuce, taille, animalConcours)
        {

        }

        public string Abboyer()
        {
            return _nom + " aboie";
        }

        public override string Affiche()
        {
            return "Le chien s'appelle : " + _nom + " il est né le : " + _dateNaissance + " son numéro de puce est : " + _numeroPuce + " il fait : " + _taille + " cm de longueur " + _animalConcours;
        }

        
    }
}
