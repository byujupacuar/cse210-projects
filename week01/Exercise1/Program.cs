using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¿What is your first name?");
        string first_name = Console.ReadLine();

        Console.WriteLine("¿What is your last name.");
        string surname = Console.ReadLine();

        Console.WriteLine($"My name is {surname}, {first_name} {surname}.");

    }
}