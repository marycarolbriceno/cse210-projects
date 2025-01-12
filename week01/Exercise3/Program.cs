using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //random number
        Random random = new Random();
        int number = random.Next(1, 101);

        //initialize guess variable
        int guess = 0;
    
        while (number != guess)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (number < guess)
            {
                Console.WriteLine("lower");
            }
            
            else
            {
                Console.Write("You guessed it!");
                Console.Write(number);
            }
        } 
    }
}
