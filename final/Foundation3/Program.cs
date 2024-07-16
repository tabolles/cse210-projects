using System;

class Program
{
    static void Main(string[] args)
    {
    
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Springfield", "IL", "USA");
        Address address3 = new Address("789 Oak St", "Springfield", "IL", "USA");
        
        Event[] events = new Event[3];
        events[0] = new Reception("Graduation Party", "Celebrate the class of 2021", "5/15/2021", "6:00 PM", address1, "event@gmail.com");
        events[1] = new OutdoorGathering("Family Picnic", "Enjoy a day in the park", "6/15/2021", "12:00 PM", address2, "Sunny");
        events[2] = new Lecture("Guest Speaker", "Learn from an expert", "7/15/2021", "7:00 PM", address3, "John Doe", 100);

        foreach(Event e in events){
            Console.WriteLine(e.fullDescription());
            Console.WriteLine();
            Console.WriteLine(e.shortDescription());
            Console.WriteLine();
        }
    }
}