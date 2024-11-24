using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_Animaux.Classes
{
    internal class Lapin : Animaux
    {
        private decimal _tailleOreilles;

        public Lapin(decimal tailleOreilles, string nom, string dateNaissance, double numeroPuce, decimal taille, bool animalConcours) : base(nom, dateNaissance, numeroPuce, taille, animalConcours)
        {
            _tailleOreilles = tailleOreilles;
        }

        public string FaireBonds()
        {
            return _nom + " saute";
        }

        public override string Manger()
        {
            return _nom + " mange";
        }

        public override string Dormir()
        {
            return _nom + " dort";   
        }

        public override string Affiche()
        {
            return "Le lapin s'appelle : " + _nom + " il a comme taille d'oreilles " + _tailleOreilles + " il est né le : " + _dateNaissance + " son numéro de puce est : " + _numeroPuce + " il fait : " + _taille + " cm de longueur " + _animalConcours;
        }
    }
}
