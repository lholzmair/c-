using System;

Console.WriteLine("Welcome to Word Shuffle!");
Console.WriteLine();

string firstWord;
string secondWord;
string thirdWord;

Console.WriteLine("Bitte geben Sie das erste Wort ein:");
firstWord = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Bitte geben Sie nun das zweite Wort ein:");
secondWord = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Bitte geben Sie abschließend das dritte Wort ein:");
thirdWord = Console.ReadLine();
Console.WriteLine();

Console.WriteLine(firstWord + " " +secondWord + " " + thirdWord);
Console.WriteLine(firstWord + " " + thirdWord + " " + secondWord);
Console.WriteLine(secondWord + " " + firstWord + " " + thirdWord);
Console.WriteLine(secondWord + " " + thirdWord + " " + firstWord);
Console.WriteLine(thirdWord + " " + firstWord + " " + secondWord);
Console.WriteLine(thirdWord + " " + secondWord + " " + firstWord);
Console.WriteLine();

Console.WriteLine("Press enter to close! Thank you!");
Console.ReadLine();