using System;

class Program
{
    static void Menu(){
        int userInput;
        string entry = null;
        do{
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Today's Entry");
            Console.WriteLine("3. Save Entry");
            Console.WriteLine("4. Display All Entries");
            Console.WriteLine("-------------------------");
            Console.Write("Enter your choice: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            
            Journal journal = new();
            Entries entries = new();

            switch(userInput){
                case 0:
                    break;
                case 1:
                    entry = journal.todayEntry();
                    break;
                case 2:
                    journal.displayToday(entry);
                    break;
                case 3:
                    if (entry != null){
                        entries.addEntry(entry);
                        entries.saveToFile();
                    }else{
                        Console.WriteLine("Please add an entry first.");
                    }
                    break;
                case 4:
                    entries.displayAll();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }while(userInput != 0);
    }
    static void Main()
    {
        Menu();
    }   
}