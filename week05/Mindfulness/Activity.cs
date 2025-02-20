public class Activity
{
    //attributes
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructor
    public Activity()
    {
        _name = "empty";
        _description = "empty";
        _duration = 0;
    }

    // methods
    public void DisplayStartingMessage()
    {   // activity name
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        
        // description
        Console.WriteLine(_description);
        Console.WriteLine();
        
        // duration
        Console.Write("how long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
        ShowSpinner(5);
    }

    public void ShowSpinner( int seconds)
    {
        List<string> spinnerAnimation = new List<string>()
        {
            "|",
            "/",
            "―",
            "\\",
            "|",
            "/",
            "―",
            "\\"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerAnimation[i];
            
            Console.Write(s);
            Thread.Sleep(700);
            Console.Write("\b \b");

            i ++;

            if (i >= spinnerAnimation.Count)
            {
                i = 0;
            }
        }
        
    }
    
    public void ShowCountDown(int seconds)
    {
        
        for (int i = seconds; i > 0; i --)
        {
            Console.Write(i);

            Thread.Sleep(1000);

            Console.Write("\b \b");
        }
    }
}