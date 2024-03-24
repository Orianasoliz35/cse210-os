using System;
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void StartActivity(int duration)
    {
        base.StartActivity(duration);
        Console.WriteLine("Let's begin...\n");
        Breathe(duration);
    }

    private void Breathe(int duration)
    {
        while (duration > 0)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(2000); 
            duration -= 4; 
        }
        base.EndActivity(duration);
    }
}
