using System;
using System.Data;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        while(response=="yes")
        {
        int guess;
        int cont = 0;
        Console.WriteLine("What is the magic number?");
        string mag_num = Console.ReadLine();
        int num_mag = int.Parse(mag_num);
        
            do
            {
                Console.WriteLine("What is your Guess?");
                string gue_num = Console.ReadLine();
                guess = int.Parse(gue_num);
                if (guess>num_mag)
                {
                    Console.WriteLine("Lower");
                }
                else if (num_mag>guess)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                cont = cont+1;
            }while(guess!=num_mag);
        Console.WriteLine($"you did it in {cont} attempts");
        Console.Write("Do you want to continue? yes or no ");
        response = Console.ReadLine();
        }
    }
}