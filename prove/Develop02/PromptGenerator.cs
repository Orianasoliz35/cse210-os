using System;
//Prompt Generator file - Week 2
public class PromptGenerator 
{
    public List<string> Prompts {get; set;}
    public PromptGenerator() 
    {
        Prompts = new List<string> 
        {
            "What was the best part of your day?: ",
            "If you could name one thing you are grateful for today, what could it be?: ",
            "What are your main strengths?: ",
            "If you had five minutes for everyone to listen to you, what would you say?: ",
            "What has brought you joy this week?: ",
            "What kind of experiences have helped you to grow spiritually?: ",
            "Who has been your greatest inspiration in life?: ",
            "If you had the opportunity to have the perfect day, what kind of activity would you choose to do?: "
        };
    }
    public string GenerateRandomPrompt() 
    {
        Random random = new Random();
        int index = random.Next(Prompts.Count);
        return Prompts[index];
    }

}
