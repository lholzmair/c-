using System;

string firstName;
string lastName;
string location;

Console.WriteLine("Please enter your first name:");
firstName = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Please enter your last name:");
lastName = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Please tell me the town you live in:");
location = Console.ReadLine();
Console.WriteLine();

Console.WriteLine($"Welcome {firstName} {lastName} from {location} to C#!");
Console.ReadLine();