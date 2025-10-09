using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to the program!");
        Console.WriteLine("please enter ur name ");
        string name = Console.ReadLine();
        Console.WriteLine($"what is ur favorite number {name}?");
        string fnum = Console.ReadLine();
        int fnum2 = int.Parse(fnum);
        int total = fnum2 * fnum2;
        Console.WriteLine($"what year where you born {name}?");
        string year = Console.ReadLine();
        Console.WriteLine($"Thank you {name}, the square of your favorite number {fnum2} is {total}.");
        int age = 2025 - int.Parse(year);
        Console.WriteLine($"you are {age} years old");

    }
}