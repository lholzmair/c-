using System;

public class UhrzeitErweitertKorrekt
{
    public static void Main(string[] args)
    {
        Console.Write("Geben Sie die Anzahl der Sekunden ein: ");
        string eingabe = Console.ReadLine();

        if (int.TryParse(eingabe, out int sekunden))
        {
            int tage = sekunden / (3600 * 24);
            int stunden = (sekunden % (3600 * 24)) / 3600;
            int minuten = ((sekunden % (3600 * 24)) % 3600) / 60;
            int sekundenRest = ((sekunden % (3600 * 24)) % 3600) % 60;

            string tageAusgabe = tage == 1 ? "1 Tag" : $"{tage} Tage";
            Console.WriteLine($"Ausgabe: {tageAusgabe} {stunden:D2}:{minuten:D2}:{sekundenRest:D2}");
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe!");
        }
		
		Console.ReadLine();
    }
	
}
