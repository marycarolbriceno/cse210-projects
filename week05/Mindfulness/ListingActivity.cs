using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;

public class ListingActivity : Activity
{
    // attributes
    private int _count;
    private List<string> _prompts;

    // constructor
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    // methods
    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        List<string> list = GetListFromUser();

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine();
            list.Add(entry);
        }

        _count = list.Count;

        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int number = random.Next(_prompts.Count);
        
        string prompt = _prompts[number];

        return prompt;
    }
    
    public List<string> GetListFromUser()
    {  
        List<string> list= new List<string>();

        return list;
    }
}