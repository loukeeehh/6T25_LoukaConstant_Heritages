using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_Employe.Classes
{
    internal class Cadre : Employe
    {
        private int _indice;

        public Cadre(int indice, string matricule, string nom, string prenom, string dateNaissance) : base(matricule, nom, prenom, dateNaissance)
        {
            _indice = indice;

            switch (indice)
            {
                case 1:
                    _salaire = 13000;
                    break;

                case 2:
                    _salaire = 15000;
                    break;

                case 3:
                    _salaire = 17000;
                    break;

                case 4:
                    _salaire = 20000;
                    break;
                    
            }
        }
        public double Indice
        {
            get { return _indice; }
        }

    }
}
