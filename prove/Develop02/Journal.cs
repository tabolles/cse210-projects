using System;

class Journal{
    string _entry;
    DateTime _date = DateTime.Now;

    public string todayEntry(){
        Prompts prompts = new();
        string todayPrompt = prompts.GetPrompt();
        Console.Write($"Today's prompt: {todayPrompt}\nPress 'Enter' to finish entry: ");
        _entry = $"{_date}, {todayPrompt}, {Console.ReadLine()}";

        return _entry;
    }


}