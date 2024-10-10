using System;

int sec;
int min;
int h;
int rest;

Console.WriteLine("Geben Sie eine Anzahl von Sekunden:");
sec = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

h = sec / 3600;
min = sec % 3600 / 60;
rest = sec % 3600 % 60;


Console.WriteLine($"{h:D2} Stunden");
Console.WriteLine($"{min:D2} Minuten");
Console.WriteLine($"{rest:D2} Sekunden");
Console.WriteLine();
Console.ReadLine();

Console.WriteLine($"Ausgabe: {h:D2}:{min:D2}:{rest:D2}");

Console.ReadLine();
