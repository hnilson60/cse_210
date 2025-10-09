using System;


class Program

{                 
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            int guess = 0;

            Console.WriteLine("Try to guess my number!");

            while (guess != number)
            {
                Console.Write("WHATS UR GUESS? ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out guess))
                {
                    if (guess < number)
                    {
                        Console.WriteLine("UPPER!");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("LOWER!");
                    }
                    else
                    {
                        Console.WriteLine("YEP!");
                    }
                }
                else
                {
                    Console.WriteLine(" Please enter a number.");
                }
            }

            Console.WriteLine("play again? (yes/no)");
            playAgain = Console.ReadLine();
        }
    }     
}
