using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_Employe.Classes
{
    internal class Employe
    {
        protected string _matricule;
        protected string _nom;
        protected string _prenom;
        protected string _dateNaissance;
        protected double _salaire;

        public Employe(string matricule, string nom, string prenom, string dateNaissance)
        {
            _matricule = matricule;
            _nom = nom;
            _prenom = prenom;
            _dateNaissance = dateNaissance;
        }

        public string Matricule
        {
            get { return _matricule; }
        }

        public string Nom
        {
            get { return _nom; }
        }

        public string Prenom
        {
            get { return _prenom; }
        }

        public string DateNaissance
        {
            get { return _dateNaissance; }
        }

        public double Salaire
        {
            get { return _salaire; }
            set { _salaire = value; }
        }


        public virtual string Afficher()
        {
            return "Matricule : " + Matricule + "\n Nom : " + Nom + "\n Prénom : " + Prenom + "\n Date de naissance : " + DateNaissance + "\n Salaire : " + Salaire + " euros";
                    
        }

    }
}
