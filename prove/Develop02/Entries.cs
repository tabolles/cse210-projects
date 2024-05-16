using System;

class Entries{

    string _filename = "Journal.csv";
    List<string> _entries = new();

    public void addEntry(string entry){
        _entries.Add(entry);
    }

    public void saveToFile(){
        string[] lines = System.IO.File.ReadAllLines(_filename);
        _entries.AddRange(lines);
        File.WriteAllLines(_filename, _entries);
    }

    public void displayAll(){
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string entry in lines){
            lines = entry.Split(", ",3);
            string date = lines[0];
            string prompt = lines[1];
            string response = lines[2];

            Console.WriteLine("-------------------------");
            Console.WriteLine($"Date: {date}\nPrompt: {prompt}\nResponse: {response}");
        }
    }

}