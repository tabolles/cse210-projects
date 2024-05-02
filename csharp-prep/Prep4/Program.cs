using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        /*
            this project was completed using the C# documentation provided in the offical documentation
            the use of BIFs to work with lists was a big emphasis in my programming with functions class
            therefore I choose to use the BIFs to make the code look nicer and run more efficiently.
            The ideas were mine but were accelereated by the use of GitHub Copilot hence the lambda in line 30.
        */
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int TAB_number; List<int> TAB_numbers = new();
        do
        {
            Console.Write("Enter a number: ");
            TAB_number = int.Parse(Console.ReadLine());
            if (TAB_number != 0)
            {
                TAB_numbers.Add(TAB_number);
            }
            
        } while (TAB_number != 0);
        
        int TAB_sum = TAB_numbers.Sum();
        double TAB_average = TAB_numbers.Average();
        int TAB_max = TAB_numbers.Max();
        int TAB_smallestPositive = TAB_numbers.Where(n => n > 0).Min();

        Console.WriteLine($"\nThe sum of the numbers is {TAB_sum}.");
        Console.WriteLine($"The average of the numbers is {TAB_average,4}.");
        Console.WriteLine($"The largets number is: {TAB_max}.");
        Console.WriteLine($"The smallest positive number is: {TAB_smallestPositive}.");
        Console.WriteLine("The Sorted List:");
        TAB_numbers.Sort();
        foreach (int n in TAB_numbers)
        {
            Console.WriteLine(n);
        }
    }
}