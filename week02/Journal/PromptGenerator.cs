using System;
using System.Diagnostics;
public class PromptGenerator
{
    //Attributes
    public List<string> _prompts;

    //Methods
    public string GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "What made me laugh or smile today?",
            "What is something I wish I had done differently today?",
            "Who inspired me today, and how?",
            "How did I spend my free time today, and did it fulfill me?",
            "What are three things I'm grateful for today?",
            "Did I learn something new today? If so, what was it?",
            "How did I show love and gratitude to others today?",
            "What are my goals for tomorrow?",
            "What was the most relaxing part of my day?",
            "Did I step out of my comfort zone today? How did it feel?",
        };

        //get a random number
        Random random = new Random();
        int number = random.Next(_prompts.Count);
        //get the random prompt
        string prompt = _prompts[number];

        return prompt;
    }
}