using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        //use constructor 1
        Fraction f1 = new Fraction();
        //using setter
        //f1.SetTop(1);
        //f1.SetBottom(1);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        
        //use Constructor 2
        Fraction f2 = new Fraction(5);
        //using setter
        //f2.SetTop(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        //use Constructor 3
        Fraction f3 = new Fraction(3, 4);
        //using setter
        //f3.SetTop(3);
        //f3.SetBottom(4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        //use Constructor 3
        Fraction f4 = new Fraction(1, 3);
        //using setter
        //f4.SetTop(1);
        //f4.SetBottom(3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}