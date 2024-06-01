using System;

class Program
{
    static List<Reference> initializeReferences()
    {
        List<Reference> references = new List<Reference>();
        
        Reference reference1 = new();
        reference1.addSingle("John 3:16", 
            "For God so loved the world, that he gave his only begotten Son, " + 
            "that whosoever believeth in him should not perish, but have everlasting life.");
        references.Add(reference1);

        Reference reference2 = new();
        reference2.addMultiple("John 3:16-17", new string[] {
            "For God so loved the world that he gave his one and only Son, " +
            "that whoever believes in him shall not perish but have eternal life.",
            "For God did not send his Son into the world to condemn the world, " +
            "but to save the world through him."
        });
        references.Add(reference2);

        Reference reference3 = new();
        reference3.addMultiple("Proverbs 3:5-6", new string[] {
            "Trust in the Lord with all your heart and lean not on your own understanding;",
            "in all your ways submit to him, and he will make your paths straight."
        });
        references.Add(reference3);

        return references;
    }
    static void Main(string[] args)
    {
        List<Reference> references = initializeReferences();
        Random random = new();

        Reference randomReference = references[random.Next(references.Count)];

        Console.Clear();

        randomReference.displayScripture();

        do{
            Console.Write("\nPress 'Enter' to hide a random word. type 'quit' to quit: ");
            var input = Console.ReadLine();
            if(input.ToLower() == "quit"){
                break;
            }
            else{
                randomReference.hideRandom();
            }
        } while(true);
    }
}