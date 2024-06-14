using System;
using static System.Console;


class Prey
{
    public virtual void Run(){
        WriteLine("The prey is running away.");
    }
}

class Predator : Prey
{
    public override void Run(){
        WriteLine("The predator is running after the prey.");
    }
}


class Program
{
    static void Main(string[] args)
    {
        // for ( ; ; ) will cause an infinite loop because there is no increment (Ctrl + C to stop)
        // for (int x = 0; x < 9; x++)
        // {
        //     Console.WriteLine("The Most Interesting Thing.");
        // }

        List<Prey> animals = new List<Prey>();

        animals.Add(new Prey());
        animals.Add(new Predator());
        animals.Add(new Prey());
        foreach (Prey animal in animals)
        {
            animal.Run();
        }
        
    }
}