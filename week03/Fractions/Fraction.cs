using System.Diagnostics.Contracts;

public class Fraction
{
    // Attributes
    private int _top;
    private int _bottom;

    // Contructor 1
    public Fraction()
    {
        _top= 1;
        _bottom = 1;
    }
    
    // Contructor 2
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Contructor 3
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //Getters and Setters
    //get top
    public int GetTop()
    {
        int top = _top;
        return top;
    }
    //set top
    public void SetTop(int top)
    {
        _top = top;
    }

    //get bottom
    public int GetBottom()
    {
        int bottom = _bottom;
        return bottom;
    }
    //set bottom
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Methods
    
    public string GetFractionString()
    // return a string with the values in fraction format (numerator/denominator)
    { 
        return $"{_top}/{_bottom}";
    }

    //divide the top number by the bottom number
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}