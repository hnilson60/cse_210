using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Scripture memorization");
        Console.Write("Enter the book name");
        string book = Console.ReadLine().Trim();
        Console.Write("Enter the chapter number");
        int chapter = int.Parse(Console.ReadLine().Trim());
        Console.Write("Enter the verse start number");
        int verseStart = int.Parse(Console.ReadLine().Trim());
        Console.Write("Enter the verse end number");
        int verseEnd = int.Parse(Console.ReadLine().Trim());
        Reference reference;
        if (verseStart == verseEnd)
            reference = new Reference(book, chapter, verseStart);
        else
            reference = new Reference(book, chapter, verseStart, verseEnd);
        Console.Write("Enter the scripture text");
        string text = Console.ReadLine().Trim();
        Scripture scripture = new Scripture(reference, text);
        while (true)
        {            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to hide words or 'quit' to exit: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            scripture.HideRandomWords(2);
            if (scripture.IsCompletelyHidden())
            {                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("done :)");
                break;
            }
        }
    }
}
