using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int square = SquareNumber(userNumber);

        DisplayResult(userName, square);
    }

    //Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    //Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }

    //Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int userNumber)
    {
        int square = userNumber * userNumber;

        return square;
    }

    // Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string userName, int square)
    {
        Console.Write($"{userName}, the square of your number is {square}");
    }

}