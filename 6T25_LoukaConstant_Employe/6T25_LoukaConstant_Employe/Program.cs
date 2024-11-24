using _6T25_LoukaConstant_Employe.Classes;

namespace _6T25_LoukaConstant_Employe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chiffreAffaire = 12000000;

            Employe[] employes = new Employe[10];
            employes[0] = new Ouvrier("10/02/1989", 2000, "EEE", "Vicci", "Sienna", "14/05/1968");
            employes[1] = new Ouvrier("10/02/1989", 2000, "EEE", "De Vinci", "Léonard", "14/05/1968");
            employes[2] = new Ouvrier("10/02/1989", 2000, "EEE", "Parks", "Rosa", "14/05/1968");
            employes[3] = new Ouvrier("10/02/1989", 2000, "EEE", "Kennedy", "John", "14/05/1968");
            employes[4] = new Ouvrier("10/02/1989", 2000, "EEE", "Raegan", "Ronald", "14/05/1968");
            employes[5] = new Directeur(chiffreAffaire, 20, "EEE", "Detier", "Eric", "14/05/1968");
            employes[6] = new Directeur(chiffreAffaire, 15, "EEE", "Parker", "Tony", "14/05/1968");
            employes[7] = new Directeur(chiffreAffaire, 78, "EEE", "Changretta", "Lucas", "14/05/1968");
            employes[8] = new Cadre(2, "EEE", "Remain", "Antoine", "14/05/1968");
            employes[9] = new Cadre(1, "EEE", "Zidane", "Zinedine", "14/05/1968");

            foreach (Employe employe in employes)
            {
                Console.WriteLine(employe.Afficher());
            }
        }
    }
}
