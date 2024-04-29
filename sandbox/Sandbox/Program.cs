using System;

class Program
{
    static void Main(string[] args)
    {
        // for ( ; ; ) will cause an infinite loop because there is no increment (Ctrl + C to stop)
        for (int x = 0; x < 9; x++)
        {
            Console.WriteLine("The Most Interesting Thing.");
        }
    }
}