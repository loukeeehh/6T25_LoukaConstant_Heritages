using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_Parallelepipede.Classes
{
    internal class Carre : Parallelepipedes
    {
        private double _cotes;

        public Carre(double cotes, string couleur) : base (couleur)
        {
            _cotes = cotes;
        }

        public double Cotes
        {
            get { return _cotes; }
            set { _cotes = value; }
        }

        public override string CalculePermimetre()
        {
            return "Le carré a un périmetre de : " + 4 * _cotes + " cm";
        }

        public override string CalculeSurface()
        {
            return "Le carré a une surface de : " + _cotes * _cotes + " cm²";
        }
    }
}
