using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {

        // create list
        List<int> numbersList = new List<int>();

        //aks the user for a number
        Console.Write("Enter a list of numbers, type 0 when finished.");
        int number = int.Parse(Console.ReadLine());

        do
        {
            //add number to a list
            if (number != 0)
            {
                numbersList.Add(number);
            }

            //aks the user for a number
            Console.Write("Enter a list of numbers, type 0 when finished.");
            number = int.Parse(Console.ReadLine());

        } while (number != 0);

        //sum of the numbers in the list
        int sum = 0;
        //Iterate through the numbersList and add each number
        foreach (int eachnumber in numbersList)
        {
            sum = sum + eachnumber;
        }
        //Print the sum
        Console.WriteLine($"The sum is: {sum}");

        //Average of the numbers in the list
        float average = 0;
        //Divide the sum of all numbers in the list by the count of numbers in the list.
        average = ((float)sum) / numbersList.Count;
        //Print the average
        Console.WriteLine($"The average is: {average}");

        //Largest number in the list.
        int largest = 0;
        //Iterate through the numbersList and store the largest number in a variable
        foreach (int num in numbersList)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        //print the largest num
        Console.WriteLine($"The largest number is: {largest}");
    }
}