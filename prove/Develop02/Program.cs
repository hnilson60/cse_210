using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        int choice;

        do
        {
            Console.WriteLine("\n1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Quit");
            Console.Write("Choice: ");
            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    journal.WriteEntry();
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.WriteLine("smell u later");
                    break;
                default:
                    Console.WriteLine("bad");
                    break;
            }

        } while (choice != 3);
    }
}
