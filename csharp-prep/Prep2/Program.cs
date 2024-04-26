using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your current grade percentage?: ");
        string TAB_userInput = Console.ReadLine();
        int TAB_userNum = int.Parse(TAB_userInput);
        string TAB_letter;
        int TAB_lastDigit = TAB_userNum % 10;

        if (TAB_userNum >= 90)
        { 
            if (TAB_lastDigit < 3)
            {
                TAB_letter = "A-";
            }
            else
            {
                TAB_letter = "A";
            }
        }
        else if (TAB_userNum >= 80)
        {
            if (TAB_lastDigit >= 7)
            {
                TAB_letter = "B+";
            }
            else if (TAB_lastDigit < 3)
            {
                TAB_letter = "B-";
            }
            else
            {
                TAB_letter = "B";
            }
        }
        else if (TAB_userNum >= 70)
        {
            if (TAB_lastDigit >= 7)
            {
                TAB_letter = "C+";
            }
            else if (TAB_lastDigit < 3)
            {
                TAB_letter = "C-";
            }
            else
            {
                TAB_letter = "C";
            }
        }
        else if (TAB_userNum >= 60)
        {
            if (TAB_lastDigit >= 7)
            {
                TAB_letter = "D+";
            }
            else if (TAB_lastDigit < 3)
            {
                TAB_letter = "D-";
            }
            else
            {
                TAB_letter = "D";
            }
        }
        else
        {
            TAB_letter = "F";
        }

        Console.WriteLine($"Grade: {TAB_letter}");

        if (TAB_userNum >= 70)
        {
            Console.WriteLine("You passed the class!");
        } else {
            Console.WriteLine("You failed the class.");
        }

    }
}