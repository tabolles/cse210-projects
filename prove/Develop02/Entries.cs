using System;

class Entries{

    string _filename = "Journal.csv";
    List<string> _entries = new();

    public void AddEntry(string entry){
        _entries.Add(entry);
    }

    public void Save(){
        string[] lines = System.IO.File.ReadAllLines(_filename);
        _entries.AddRange(lines);
        File.WriteAllLines(_filename, _entries);
    }

    public void Display(){
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string entry in lines){
            Console.WriteLine(entry);
        }
    }

}