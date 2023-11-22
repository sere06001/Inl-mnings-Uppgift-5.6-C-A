using System;
namespace Uppgift5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en rad av tal separerade med stjärnor, '*'.");
            string[] allaTal = Console.ReadLine().Split("*");
            long produkt = 1;
            for (int i = 0; i < allaTal.Length; i++)
            {
                produkt = produkt*long.Parse(allaTal[i]);
            }
            Console.WriteLine("Produkten: "+produkt);
            Console.ReadKey();
        }
    }
}