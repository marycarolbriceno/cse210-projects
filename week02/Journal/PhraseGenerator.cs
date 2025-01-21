public class PhraseGenerator
{
    //Attribute
    public List<string> _phrases;

    //Method
    public void GetRandomPhrase()
    {
        _phrases = new List<string>
        {
            "Consistency is key",
            "Keep going",
            "One day at a time",
            "Small steps matter",
            "Stay committed",
            "Progress, not perfection",
            "Keep pushing",
            "You're on track",
            "Every effort counts",
            "You've got this",
        };

        //get a random number
        Random random = new Random();
        int number = random.Next(_phrases.Count);
        //get the random phrase
        string phrase = _phrases[number];

        Console.WriteLine($"{phrase}, see you tomorrow!");
    }
}
