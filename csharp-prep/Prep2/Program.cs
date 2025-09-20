using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your grade percentage?");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        if (grade >= 90)
        {
            Console.WriteLine("Congrats you have an A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You are a failure and a dissapiontment you have a B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You have a C did you even try?");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You have a D you should be ashamed of yourself");
        }
        else
        {
            Console.WriteLine("You have an F you are a disgrace to your family");
        }
    }
}