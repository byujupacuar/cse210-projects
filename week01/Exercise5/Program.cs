using System;

class Program
{
    static void Main(string[] args)
    {
        show_welcome();

        string username = name();
        int usernumber = number();

        int squarednumber = squere(usernumber);

        result(username, squarednumber);
    }

    static void show_welcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string name()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int number()
    {
        Console.Write("Please enter your favorite number: ");
        string usernum = Console.ReadLine();
        int number = int.Parse(usernum);

        return number;
    }

    static int squere(int number)
    {
        int square = number * number;
        return square;
    }

    static void result(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    
}