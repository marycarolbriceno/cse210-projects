public class MathAssignment : Assignment
{
    // attributes
    private string _textbookSection;
    private string _problems;

    // constructor
    public MathAssignment (string studentName, string topic, string textbooksection, string problems): base(studentName, topic)
    {
        _textbookSection = textbooksection;
        _problems = problems;
    }

    // method
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}