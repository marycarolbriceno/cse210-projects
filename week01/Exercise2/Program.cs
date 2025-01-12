using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {   
        //ask the user their grade
        Console.Write("What is your grade percentage? ");
        //define variable
        string userInput = Console.ReadLine();
        //convert user input to int
        int grade = int.Parse(userInput);
        
        // define varibale
        string letter = "";

        //match the grade with letter
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }
        //print the matching
        Console.WriteLine($"{grade} = {letter}");

        //print a encouragement message
        if (grade >= 70)
        {
            Console.Write("Congratulation! You passed the course");
        }
        else 
        {
            Console.Write("You can do it, don't give up!");
        }

    }
}