using System;
public class ReflectionActivity : Activity
{
    public ReflectionActivity() : base("Reflection", "Reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public override void StartActivity(int duration)
    {
        base.StartActivity(duration);
        Console.WriteLine("Let's begin reflecting...\n");
        Reflect(duration);
    }

    private void Reflect(int duration)
    {
        string[] prompts = new string[]
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        string[] questions = new string[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        Random rand = new Random();
        while (duration > 0)
        {
            string prompt = prompts[rand.Next(prompts.Length)];
            Console.WriteLine(prompt);
            Thread.Sleep(3000);

            foreach (string question in questions)
            {
                Console.WriteLine(question);
                Thread.Sleep(5000);
            }
            duration -= (questions.Length * 5);
        }
        base.EndActivity(duration);
    }
}

