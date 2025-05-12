using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("Enter your grades");
        string grade = Console.ReadLine();

        int number = int.Parse(grade);
       if (number > 100)
        {
            Console.WriteLine("ERROR");
        }
        else if (number >= 97)
        {
            Console.WriteLine("Your grade is: A");
        }
        else if (number >= 93)
        {
            Console.WriteLine("Your grade is: A-");
        }
        else if (number >= 90)
        {
            Console.WriteLine("Your grade is: B+");
        }
        else if (number >= 87)
        {
            Console.WriteLine("Your grade is: B");
        }
        else if (number >= 83)
        {
            Console.WriteLine("Your grade is: B-");
        }
        else if (number >= 80)
        {
            Console.WriteLine("Your grade is: C+");
        }
        else if (number >= 77)
        {
            Console.WriteLine("Your grade is: C");
        }
        else if (number >= 73)
        {
            Console.WriteLine("Your grade is: C-");
        }
        else if (number >= 70)
        {
            Console.WriteLine("Your grade is: D+");
        }
        else if (number >= 67)
        {
            Console.WriteLine("Your grade is: D");
        }
        else if (number >= 60)
        {
            Console.WriteLine("Your grade is: D-");
        }
        else if (number >= 0)
        {
            Console.WriteLine("Your grade is:F");
        }
        else
        {
            Console.WriteLine("ERROR");
        }


        if (number <=100 && number >=70 )
        {
            Console.WriteLine("Congratulations! You passed the course—keep up the same enthusiasm! ");
        }
        else if (number < 70 && number >=0)
        {
            Console.WriteLine("I'm sorry, you didn't pass the course. Learn, improve, and come back stronger—You can do it!");
        }
        else
        {
            Console.WriteLine("Error");
        }


    }
}