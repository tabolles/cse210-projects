using System.Net.Sockets;
using System.Numerics;

class InfiniteGoal : Goal
{
    private int _timesCompleted;
    public InfiniteGoal(string goal, string desc, int score) : base(goal, desc, score){}
    public override void awardScore()
    {
        getTotal();
        _totalScore += _score * _timesCompleted;
        saveTotal();
    }

    public override void display()
    {
        Console.WriteLine($"Goal: {_title}\nDescription: {_desc}\nTimes Completed this session: {_timesCompleted}\n");
        Console.Write($"Have you completed this goal today? (y/n): ");
        string response = Console.ReadLine();
        if (response == "y")
        {
            _timesCompleted++;
            awardScore();
            Console.WriteLine($"\nyour score is now: {_totalScore}\n");
        }
        else
        {
            Console.WriteLine("Well, Better luck next time!");
        }
    }
}