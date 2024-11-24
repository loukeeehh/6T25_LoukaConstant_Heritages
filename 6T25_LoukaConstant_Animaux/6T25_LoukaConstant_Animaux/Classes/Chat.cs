using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_Animaux.Classes
{
    internal class Chat : Animaux
    {
        public Chat(string nom, string dateNaissance, double numeroPuce, decimal taille, bool animalConcours) : base(nom, dateNaissance, numeroPuce, taille, animalConcours)
        {

        }

        public string Miauler()
        {
            return _nom + " miaule";
        }

        public string Ronronne()
        {
            return _nom + " ronronne";
        }

        public override string Dormir()
        {
            return _nom + " dort";
        }

        public override string Manger()
        {
            return _nom + " mange";
        }

        public override string Affiche()
        {
            return "Le chat s'appelle : " + _nom + " il est né le : " + _dateNaissance + " son numéro de puce est : " + _numeroPuce + " il fait : " + _taille + " cm de longueur " + _animalConcours;
        }
    }
}
