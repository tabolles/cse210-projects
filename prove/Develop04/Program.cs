using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Breathing breathing = new("Breathing", "Breathing exercises are a great way to relax and reduce stress.");
        // breathing.breathingActivity();

//         Reflection reflection = new("Reflection", 
//         @"This activity will help you reflect on times in your life when you have shown strength and resilience.
// This will help you recognize the power you have and how you can use it in other aspects of your life.");

//         reflection.reflectionActivity();

        Listing listing = new("Listing",
        @"This acivity will help you reflect on the good things in your life by having you list
as many things as you can in a certain area");

        listing.listingActivity();
    }
}