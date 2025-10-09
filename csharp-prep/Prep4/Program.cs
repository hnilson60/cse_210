using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        int number;
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter a number (0 to end): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out number))
            {
                if (number != 0)
                {
                    numbers.Add(number); 
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a number.");
                number = -1; 
            }
        } while (number != 0);

        Console.WriteLine("\nYou entered:");
        int SUM = 0;
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
            SUM += num;
        }
        Console.WriteLine($"Total sum: {SUM}");

        float average = ((float)SUM) / numbers.Count;
        Console.WriteLine($"Average: {average}");

        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;

            }
            

        }
        Console.WriteLine($"the max is: {max}");
    }
}
