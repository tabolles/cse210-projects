using System;

class Journal{
    string _entry;
    DateTime _date = DateTime.Now;
    Prompts prompts = new();

    public string todayEntry(){
        string todayPrompt = prompts.GetPrompt();
        Console.Write($"\nToday's prompt: {todayPrompt}\nPress 'Enter' to finish entry: ");
        _entry = $"{_date}, {todayPrompt}, {Console.ReadLine()}";

        return _entry;
    }

    public void displayToday(string userEntry){
        string[] entry = userEntry.Split(", ",3); // 3 means that it will split everything into 3 strings

        string date = entry[0];
        string prompt = entry[1];
        string response = entry[2];

        Console.WriteLine("-------------------------");
        Console.WriteLine($"\nDate: {date}\nPrompt: {prompt}\nResponse: {response}\n\n");
        Console.WriteLine("-------------------------");
    }
}