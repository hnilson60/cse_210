using System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an activity (1-4): ");
            string choice = Console.ReadLine();
            Activity activity = null;
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    Console.WriteLine("bye");
                    System.Threading.Thread.Sleep(1000);
                    return;
                default:
                    Console.WriteLine("Nope.");
                    System.Threading.Thread.Sleep(1500);
                    continue;
            }
            activity.Start();
            Console.WriteLine("\nPress ENTER to return to the menu.");
            
        }
    }
}
