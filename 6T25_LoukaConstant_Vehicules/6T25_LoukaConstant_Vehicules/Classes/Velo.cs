using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_Vehicules.Classes
{
    internal class Velo : Vehicule
    {
        private string _type;
        private bool _electrique;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public bool Electrique
        {
            get { return _electrique; }
            set { _electrique = value; }
        }


        public Velo(string type, bool electrique, string modele, string marque, string couleur, decimal prix) : base(modele, marque, couleur, prix)
        {
            _type = type;
            _electrique = electrique;
        }

        public override string Affiche()
        {
            string info = base.Affiche();

            if (_electrique == true)
            {
                info += "Il est de type : " + Type + " et est éléctrique";
            }

            else
            {
                info += "Il est de type : " + Type + " et n'est pas éléctrique";
            }

            return info;

        }
    }
}
