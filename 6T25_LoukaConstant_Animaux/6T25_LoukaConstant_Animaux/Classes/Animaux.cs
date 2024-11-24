using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_Animaux.Classes
{
    internal class Animaux
    {
        protected string _nom;
        protected string _dateNaissance;
        protected double _numeroPuce;
        protected decimal _taille;
        protected bool _animalConcours;

        public Animaux(string nom, string dateNaissance, double numeroPuce, decimal taille, bool animalConcours)
        {
            _nom = nom;
            _dateNaissance = dateNaissance;
            _numeroPuce = numeroPuce;
            _taille = taille;
            _animalConcours = animalConcours;
        }

        public string Nom
        {
            get { return _nom; }
        }

        public string DateNaissance
        {
            get { return _dateNaissance; }
            set { _dateNaissance = value; }
        }

        public double NumeroPuce
        {
            get { return _numeroPuce; }
            set { _numeroPuce = value; }
        }


        public decimal Taille
        {
            get { return _taille; }
            set { _taille = value; }
        }

        public bool AnimalConcours
        {
            get { return _animalConcours; }
            set { _animalConcours = value; }
        }

        public virtual string Dormir()
        {
            return _nom + " dort";
        }

        public virtual string Manger()
        {
            return _nom + " mange";
        }

        public virtual string Affiche()
        {
            return "L'animal s'appelle : " + _nom + " il est né le : " + _dateNaissance + " son numéro de puce est : " + _numeroPuce + " il fait : " + _taille + " cm de longueur" + _animalConcours;
        }

    }
}
