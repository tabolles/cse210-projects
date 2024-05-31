using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new();

        reference.addSingle("John 3:16", 
        "For God so loved the world that he gave his one and only Son, " +
        "that whoever believes in him shall not perish but have eternal life.");

        reference.addMultiple("John 3:16-17", new string[] {
            "For God so loved the world that he gave his one and only Son, " +
            "that whoever believes in him shall not perish but have eternal life.",
            "For God did not send his Son into the world to condemn the world, " +
            "but to save the world through him."
        });

        reference.displayScripture("John 3:16-17");

        reference.displayScripture("John 3:16");


        
    }
}