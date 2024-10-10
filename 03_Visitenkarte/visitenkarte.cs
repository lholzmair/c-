/*so entsteht eine schöne Umrahmung*/
//<Minuszahl in der Nasenklammer macht es auf die genauen Stellen rechtsbündig - eine Plus linksbündig

using System;

string userName;
string userLocation;

Console.WriteLine("Enter your name:");
userName = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Enter your location:");
userLocation = Console.ReadLine();
Console.WriteLine();

        Console.WriteLine("********************");
        Console.WriteLine($"* {userName,-17}*");
        Console.WriteLine("********************");
        Console.WriteLine($"* {userLocation,-17}*");
        Console.WriteLine("********************");
		
Console.ReadLine();