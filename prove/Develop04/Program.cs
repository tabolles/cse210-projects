using System;
using System.ComponentModel.Design;

class Program
{

    static void Menu(){
        int choice;
        

        do{
            Console.Clear();
            Console.WriteLine(@"Menu Options:
    1. Start breathing acivity
    2. Start reflecting activity
    3. Start Listing activity
    4. Quit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    Breathing breathing = new("Breathing Activity", "Breathing exercises are a great way to relax and reduce stress.");
                    breathing.breathingActivity();
                    break;
                case 2:
                    Reflection reflection = new("Reflection Activity", 
                    @"This activity will help you reflect on times in your life when you have shown strength and resilience. 
This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflection.reflectionActivity();
                    break;
                case 3:
                    Listing listing = new("Listing Acivity",
                    @"This acivity will help you reflect on the good things in your life by having you list 
as many things as you can in a certain area");
                    listing.listingActivity();
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;

            }
        }while(choice != 4);
        
    }
    static void Main(string[] args)
    {
        Menu();
    }
}