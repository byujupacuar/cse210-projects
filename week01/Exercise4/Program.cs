using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        double sum = 0;
        int max = 0;
        int smallestPositive = 100000;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.   ");
        while (true)
        {
            Console.Write("Enter Number: ");
            string number = Console.ReadLine();
            int input = int.Parse(number);

            if (input == 0){
                break;
            }
            numbers.Add(input);         
        }
        foreach (int item in numbers)
        {
            sum = sum + item;
            if (item > max)
            {
                max = item;        
            }
            if (item > 0 && item < smallestPositive)
            {
                smallestPositive = item;
            }

        }
        Console.WriteLine($"The sum is: {sum}");
        int con = numbers.Count;
        double average = sum/con;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}