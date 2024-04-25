using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?: ");
        string TAB_FirstName = Console.ReadLine();

        Console.Write("What is your last name?: ");
        string TAB_LastName = Console.ReadLine();

        Console.WriteLine($"Your name is {TAB_LastName}, {TAB_FirstName} {TAB_LastName}.");


    }
}