//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Uppgift1_Temperaturer
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> temperaturer = new List<int>();

//            Console.Write("Hur många temperaturer vill du mata in? ");

//            int antal;

//            try
//            {
//                antal = int.Parse(Console.ReadLine());
//            }
//            catch
//            {
//                Console.WriteLine("Felaktig inmatning. Du måste skriva ett heltal.");
//                return;
//            }

//            for (int i = 0; i < antal; i++)
//            {
//                try
//                {
//                    Console.Write($"Ange temperatur {i + 1}: ");
//                    int temperatur = int.Parse(Console.ReadLine());

//                    temperaturer.Add(temperatur);
//                }
//                catch
//                {
//                    Console.WriteLine("Felaktig inmatning. Ange ett heltal.");
//                    i--;
//                }
//            }

//            double medeltemperatur = temperaturer.Average();
//            int högsta = temperaturer.Max();
//            int lägsta = temperaturer.Min();

//            int antalÖver25 = 0;

//            foreach (int temperatur in temperaturer)
//            {
//                if (temperatur > 25)
//                {
//                    antalÖver25++;
//                }
//            }

//            Console.WriteLine();
//            Console.WriteLine("----- Resultat -----");
//            Console.WriteLine($"Medeltemperatur: {medeltemperatur:F2} grader");
//            Console.WriteLine($"Högsta temperatur: {högsta} grader");
//            Console.WriteLine($"Lägsta temperatur: {lägsta} grader");
//            Console.WriteLine($"Antal temperaturer över 25 grader: {antalÖver25}");

//            Console.ReadLine();
//        }
//    }
//}

using System;

namespace GissaTalet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secret = rnd.Next(1, 51);

            bool rätt = false;

            Console.WriteLine("Jag har tänkt på ett tal mellan 1 och 50.");
            Console.WriteLine("Du har 7 försök att gissa talet.");

            for (int försök = 1; försök <= 7; försök++)
            {
                try
                {
                    Console.Write($"Försök {försök}/7 - Gissa talet: ");
                    int gissning = int.Parse(Console.ReadLine());

                    if (gissning > secret)
                    {
                        Console.WriteLine("För högt!");
                    }
                    else if (gissning < secret)
                    {
                        Console.WriteLine("För lågt!");
                    }
                    else
                    {
                        Console.WriteLine("Rätt!");
                        rätt = true;
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Felaktig inmatning. Du måste skriva ett heltal.");
                    försök--;
                }
            }

            if (!rätt)
            {
                Console.WriteLine($"Du har slut på försök. Det hemliga talet var {secret}.");
            }

            Console.ReadLine();
        }
    }
}
