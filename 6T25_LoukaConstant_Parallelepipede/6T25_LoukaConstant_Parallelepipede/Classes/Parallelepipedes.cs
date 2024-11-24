using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_Parallelepipede.Classes
{
    internal class Parallelepipedes
    {
        protected string _couleur;

        public Parallelepipedes(string couleur)
        {
            _couleur = couleur;
        }

        public string couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public virtual string CalculeSurface()
        {
            return "";
        }

        public virtual string CalculePermimetre()
        {
            return "";
        }

    }
}
