using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Trevor", "Multiplication");
        Console.WriteLine(assignment.getSummary());

        MathAssignment assignment2 = new MathAssignment("Trevor Bolles", "Fractions", "7.3", "8-19");
        Console.WriteLine(assignment2.getSummary());
        Console.WriteLine(assignment2.getHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Trevor Bolles", "European History", "The Causes of World War II");
        Console.WriteLine(assignment3.getSummary());
        Console.WriteLine(assignment3.getWritingInformation());

    }
}