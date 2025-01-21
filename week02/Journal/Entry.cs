public class Entry
{
    //Attributes
    public string _date;
    public string _promptText;
    public string _entryText;

    //Method
    public void Display()
    {

        //print the entries details
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        //blank space
        Console.WriteLine("");
    }

}