using System;

class Program
{
    static void Main(string[] args)
    {
        InfiniteGoal goal = new("This Goal is a test", "This is a test description", 3);
        goal.getTotal();
        goal.display();
    }
}