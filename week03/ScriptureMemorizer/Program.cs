using System;
//Exceeding Requirements: the HideRandomWords method randomly select from only those words that are not already hidden
class Program
{
    static void Main(string[] args)
    {
        // available constructors: 
        // Reference (book, chapter, verse)
        // Reference (book, chapter, verse, end verse)
        Reference reference = new Reference("Romans", 8, 38, 39);

        string text = "For I am convinced that neither death nor life, neither angels nor demons, neither the present nor the future, nor any powers, neither height nor depth, nor anything else in all creation, will be able to separate us from the love of God that is in Christ Jesus our Lord.";

        Scripture scr = new Scripture(reference, text);

        // Continue or exit
        string choice = "";
        while (choice != "quit")
        {
            Console.Clear();
            Console.WriteLine($"{reference.GetDisplayText()} {scr.GetDisplayText()}");

            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            choice = Console.ReadLine();

            if (scr.IsCompletelyHidden())
            {
                choice = "quit";
            }
            else
            {
                scr.HideRandomWords(2);
            }
        }
    }
}