using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_Parallelepipede.Classes
{
    internal class Rectangle : Parallelepipedes
    {
        private double _longueur;
        private double _largeur;

        public Rectangle (double longueur, double largeur, string couleur) : base (couleur)
        {
            _longueur = longueur;
            _largeur = largeur;
        }

        public double Longueur
        {
            get { return _longueur; }
            set { _largeur = value; }
        }
        public double Largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }


        public override string CalculePermimetre()
        {
            return "Le périmètre du rectangle est : " + 2 * (_longueur + _largeur) + " cm";
        }

        public override string CalculeSurface()
        {
            return "La surface du rectangle est : " + _longueur * _largeur + " cm²";
        }

    }
}
