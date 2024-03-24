using System;
using System.Threading;
public class Activity
{
    private string _name;
    private string _description;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public virtual void StartActivity(int duration)
    {
        Console.WriteLine($"Starting {_name} Activity:");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {duration} seconds\n");
        Console.WriteLine("Get ready to begin...\n");
        Thread.Sleep(3000);
    }
    public void EndActivity(int duration)
    {
        Console.WriteLine("\n\n");
        Console.WriteLine($"Congratulations! You have completed the {_name} Activity.");
        Console.WriteLine($"Total Duration: {duration} seconds\n");
        Thread.Sleep(3000);
    }
}
