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

