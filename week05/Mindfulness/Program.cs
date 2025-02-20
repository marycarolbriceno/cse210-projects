using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        while(userChoice != 4)
        {
            Console.Clear();
            Menu menu = new Menu();
            menu.Options();

            userChoice = int.Parse(Console.ReadLine());

            Console.Clear();
            
            // Breathing activity
            if (userChoice == 1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();
            }
            // Reflecting Activity
            else if (userChoice == 2)
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();
            }
            // Listing Activity
            else if (userChoice == 3)
            {
                ListingActivity activity = new ListingActivity();
                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();
            }
        }
    }
}