using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        // for ( ; ; ) will cause an infinite loop because there is no increment (Ctrl + C to stop)
        // for (int x = 0; x < 9; x++)
        // {
        //     Console.WriteLine("The Most Interesting Thing.");
        // }

        Prompt prompter = new Prompt();
        string s = prompter.GeneratePrompt();
        WriteLine(s);
        string userResponse = ReadLine();
        //code that gets date,time as a string
    }
}