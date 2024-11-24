using _6T25_LoukaConstant_Animaux.Classes;

namespace _6T25_LoukaConstant_Animaux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chien chien = new Chien("Néo", "10/03/2010", 12, 90, false);
            Console.WriteLine(chien.Affiche());
            Chat chat = new Chat("Félix", "14/09/2022", 45, 30, false);
            Console.WriteLine(chat.Affiche());
            Lapin lapin = new Lapin(5, "Otis", "28/07/2023", 23, 20, true);
            Console.WriteLine(lapin.Affiche());




            Animaux[] animaux = new Animaux[5];
            animaux[0] = chien;
            animaux[1] = lapin;
            animaux[2] = chat;
            animaux[3] = new Chat("David", "5 mai 2017", 1, 32, false);
            animaux[4] = new Chien("Sydney", "17 octobre 2015", 0, 50, true);

            for (int i = 0; i < animaux.Length; i++)
            {
                if (animaux[i] is Chat chat1)
                {
                    Console.WriteLine(chat.Miauler());
                }
            }


        }
    }
}
