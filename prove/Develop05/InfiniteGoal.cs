using System.Net.Sockets;
using System.Numerics;

class InfiniteGoal : Goal
{
    private int _timesCompleted;
    public InfiniteGoal(string goal, string desc, int score) : base(goal, desc){_score = score;}
    public override int awardScore(){
        int savedScore = getTotal();
        savedScore += _score * _timesCompleted;
        return savedScore;

    }

    public override void display()
    {
        Console.WriteLine($"Goal: {_title}\nDescription: {_desc}\nTimes Completed: {_timesCompleted}\n");
        Console.Write($"Have you completed this goal today? (y/n): ");
        string response = Console.ReadLine();
        if (response == "y")
        {
            
            _timesCompleted++;
            awardScore();
            Console.WriteLine($"\n your score is now: {_totalScore}\n");

        }
        else
        {
            Console.WriteLine("Well, Better luck next time!");
        }
    }
}