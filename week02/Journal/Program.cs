using System;
using System.Dynamic;
using System.IO;
using System.Reflection.Metadata;
//exceeds core requirements: I added an extra class that generates a random motivational phrase, which is displayed at the end of the program along with an invitation to the user to write the next day.
class Program
{
    static void Main(string[] args)
    {
        //connect with Journal class
        Journal journal = new Journal();

        //welcome
        Console.WriteLine("Welcome to the Journal Program");

        //Menu
        int userChoice = 0;
        while (userChoice != 5)
        {
            Console.WriteLine("Please select one of the de Following choices");
            //choices
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            //user choice
            Console.Write("What would you like to do? ");
            userChoice = int.Parse(Console.ReadLine());
            //blank space
            Console.WriteLine();

            // Option 1: The user write the entry
            if (userChoice == 1)
            {
                // prompt
                PromptGenerator prompt = new PromptGenerator();
                string promptText = prompt.GetRandomPrompt();
                Console.WriteLine(promptText);

                // get the current date
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                // User entry
                string entryText = Console.ReadLine();

                // connect with entry class
                Entry entry = new Entry();

                // get the text entry
                entry._date = dateText;
                entry._promptText = promptText;
                entry._entryText = entryText;

                //save the user response, date and prompt into a variable
                Entry newEntry = entry;

                //add the entry to the journal list
                journal.AddEntry(newEntry);
            }

            // Option 2: Display the entries
            else if (userChoice == 2)
            {
                journal.DisplayAll();
            }

            // Option 3: Load the entries stored into the file
            else if (userChoice == 3)
            {
                Console.Write("What is the filename? ");
                string userFile = Console.ReadLine();
                journal.LoadFromFile(userFile);
            }

            // Option 4: save the entries in a file
            else if (userChoice == 4)
            {
                Console.Write("What is the filename? ");
                string userFile = Console.ReadLine();
                journal.SaveTofile(userFile);
            }
        }

        //Display a motivational phrase
        PhraseGenerator phrase = new PhraseGenerator();
        phrase.GetRandomPhrase();
    }
}