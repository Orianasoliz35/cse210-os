//Scripture Memorizer File : Week 3
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Moses", 7, 18);
        string scriptureText = "And the Lord called his people Zion, because they were one in heart and will, and lived in righteousness; and there were no poor among them.";
        Scripture scripture = new Scripture(reference, scriptureText);

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
            Console.Clear(); // Clear console screen
            Console.WriteLine(scripture.GetDisplayText());
        }

        Console.WriteLine("All words are hidden. Program ends. See you :).");
    }
}