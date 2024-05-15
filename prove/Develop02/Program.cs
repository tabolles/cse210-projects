using System;

class Program
{
    static void Main()
    {

        Journal journal = new();
        string entry = journal.todayEntry();

        Entries entries = new();
        entries.AddEntry(entry);
        entries.Save();
        entries.Display();


    }
}