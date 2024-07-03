using System;

class Program
{
    static void menu()
    {
        List<Goal> goals = new List<Goal>();

        Console.WriteLine("Welcome to the Goal Tracker!");
        Console.WriteLine("1. Create a simple goal");
        Console.WriteLine("2. Create a checklist goal");
        Console.WriteLine("3. Create an infinite goal");
        Console.WriteLine("4. View goals");
        Console.WriteLine("5. View total score");
        Console.WriteLine("6. Exit");
        Console.Write("\nEnter your choice: ");

        string choice = Console.ReadLine();

        do{
            switch (choice)
            {
                case "1":

                    Console.Write("Enter the title of your goal: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter the description of your goal: ");
                    string desc = Console.ReadLine();
                    Console.Write("Enter the score value: ");
                    int score = int.Parse(Console.ReadLine());
                    SimpleGoal simpleGoal = new(title, desc, score);
                    simpleGoal.display();
                    goals.Add(simpleGoal);
                    break;
                case "2":
                    Console.Write("Enter the title of your goal: ");
                    title = Console.ReadLine();
                    Console.Write("Enter the description of your goal: ");
                    desc = Console.ReadLine();
                    Console.Write("Enter the score value: ");
                    score = int.Parse(Console.ReadLine());
                    ChecklistGoal checklistGoal = new(title, desc, score);
                    checklistGoal.display();
                    goals.Add(checklistGoal);
                    break;
                case "3":
                    Console.Write("Enter the title of your goal: ");
                    title = Console.ReadLine();
                    Console.Write("Enter the description of your goal: ");
                    desc = Console.ReadLine();
                    Console.Write("Enter the score value: ");
                    score = int.Parse(Console.ReadLine());
                    InfiniteGoal infiniteGoal = new(title, desc, score);
                    infiniteGoal.display();
                    goals.Add(infiniteGoal);
                    break;
                case "4":
                    foreach (Goal goal in goals)
                    {
                        Console.WriteLine(goal.getTitle());
                    }
                    break;
                case "5":
                    SimpleGoal placeHolder = new("null","null",0);
                    Console.WriteLine($"Your total score is: {placeHolder.getScore()}");
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != "6"); 
    }

    static void Main(string[] args)
    {
        menu();
    }
}