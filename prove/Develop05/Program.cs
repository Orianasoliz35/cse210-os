//Eternal Quest Program File: Week #5
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");

        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                int goalType = int.Parse(Console.ReadLine());

                Console.Write("What is the name of your goal? ");
                string goalName = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string goalDescription = Console.ReadLine();

                switch (goalType)
                {
                    case 1:
                        SimpleGoal simpleGoal = new SimpleGoal { Name = goalName, Points = 1000 };
                        simpleGoal.RecordEvent();
                        break;
                    case 2:
                        EternalGoal eternalGoal = new EternalGoal { Name = goalName, Points = 100 };
                        eternalGoal.RecordEvent();
                        break;
                    case 3:
                        Console.Write("Enter the target completion count: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Enter the bonus points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        ChecklistGoal checklistGoal = new ChecklistGoal(goalName, 50, target, bonus);
                        checklistGoal.RecordEvent();
                        break;
                    default:
                        Console.WriteLine("Invalid goal type.");
                        break;
                }
                break;
           
            default:
                Console.WriteLine("Goodbye!");
                break;
        }
    }
}