using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_Vehicules.Classes
{
    internal class Voiture : Vehicule
    {
        private string _motorisation;
        private bool _gps;

        public string Motorisation
        {
            get { return _motorisation; }
            set { _motorisation = value; }
        }

        public bool Gps
        {
            get { return _gps; }
            set { _gps = value; }
        }

        public Voiture(string motorisation, bool gps, string modele, string marque, string couleur, decimal prix) : base(modele, marque, couleur, prix)
        {
            _motorisation = motorisation;
            _gps = gps;
        }

        public override string Affiche()
        {
            string info = base.Affiche();

            if (_gps == true)
            {
                info += " C'est une voiture de motorisation : " + Motorisation + " et possède un gps";
            }

            else
            {
                info += " C'est une voiture de motorisation : " + Motorisation + " et ne possède pas de gps";
            }

            return info;
        }
    }
}
