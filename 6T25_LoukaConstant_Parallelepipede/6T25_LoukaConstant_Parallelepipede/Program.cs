using _6T25_LoukaConstant_Parallelepipede.Classes;

namespace _6T25_LoukaConstant_Parallelepipede
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Carre carre = new Carre(4,"rouge");
            Console.WriteLine(carre.CalculePermimetre());
            Console.WriteLine(carre.CalculeSurface());

            Rectangle rectangle = new Rectangle(4,3,"bleu");
            Console.WriteLine(rectangle.CalculePermimetre());
            Console.WriteLine(rectangle.CalculeSurface());
        }
    }
}
