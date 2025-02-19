using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment object
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine();

        // MathAssignment object
        MathAssignment mAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        Console.WriteLine(mAssignment.GetSummary());
        Console.WriteLine(mAssignment.GetHomeworkList());

        Console.WriteLine();

        // WritingAssignment object
        WritingAssignment wAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(wAssignment.GetSummary());
        Console.WriteLine(wAssignment.GetWritingInformation());
    }
}