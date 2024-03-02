using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquaredNumber(userNumber);

        DisplayResult(userName, squaredName);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquaredNumber()
    {
        int square = number * number;
        return square; 
    }
    static void DisplayResult(string name, int square)
    {
        Console.Write($"{name}, the square of your number is {square}");
    }
}