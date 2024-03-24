using System;
public class ListingActivity : Activity
{
    private Random rand = new Random();

    public ListingActivity() : base("Listing", "Reflect on the good things in your life by listing as many items as you can.")
    {
    }

    public void ListingActivityActivity(int duration)
    {
        base.StartActivity(duration);
        Console.WriteLine("Let's begin listing...\n");
        ListItems(duration);
    }

    private void ListItems(int duration)
    {
        string[] prompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        int itemCount = 0;
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            string prompt = prompts[rand.Next(prompts.Length)];
            Console.WriteLine(prompt);
            Thread.Sleep(3000);
            Console.WriteLine("Begin listing items... (Press Enter after each item, or type 'quit' to finish)");
            while (true)
            {
                string item = Console.ReadLine();
                if (item.ToLower() == "quit")
                    break;
                itemCount++;
            }
            Console.WriteLine($"\nNumber of items listed: {itemCount}");
        }
        base.EndActivity(duration);
    }
}
