using _6T25_LoukaConstant_Vehicules.Classes;

namespace _6T25_LoukaConstant_Vehicules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicule vehicule = new Vehicule("panamera", "Porshe", "Bleu cyan", 280000);
            Console.WriteLine(vehicule.Affiche());

            Voiture voiture = new Voiture("motorisé", true, "Aventador", "Porshe", "Rouge", 80000);
            Console.WriteLine(voiture.Affiche());

            Velo velo = new Velo("BMX", true, "Tout-Terrain", "Montana", "Jaune", 150);
            Console.WriteLine(velo.Affiche());
        }
    }
}
