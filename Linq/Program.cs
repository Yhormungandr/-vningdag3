using System.Linq;

List<int> temperaturer = new List<int>();
int antalInmatningar = 5; // Bestämmer antalet värden som ska matas in
int gränsVärde = 25;      // temperaturer över 25 grader

Console.WriteLine($"Mata in {antalInmatningar} temperaturer (heltal):");

for (int i = 0; i < antalInmatningar; i++)
{
    try
    {
        Console.Write($"Temperatur {i + 1}: ");
        int temp = int.Parse(Console.ReadLine());
        temperaturer.Add(temp);
    }
    catch (FormatException)
    {
        // Felhantering
        Console.WriteLine("Felaktig inmatning. Ange endast heltal.");
        i--;
    }
}

//Ser om listan är tom 
if (temperaturer.Count > 0)

{
    //Beräkning
    double medel = temperaturer.Average();

    //Högsta och lägsta värdet
    int min = temperaturer.Min();
    int max = temperaturer.Max();

    //Hur många över 25 grader
    int överGräns = temperaturer.Count(t => t > gränsVärde);

    Console.WriteLine("\n--- Resultat ---");
    Console.WriteLine($"Medeltemperatur: {medel:F1} grader");
    Console.WriteLine($"Lägsta temperatur: {min} grader");
    Console.WriteLine($"Högsta temperatur: {max} grader");
    Console.WriteLine($"Antal temperaturer över {gränsVärde} grader: {överGräns} st");
}