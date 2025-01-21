using System.IO;

public class Journal
{
    //Attribute
    public List<Entry> _entries = new List<Entry>();

    //methods
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveTofile(string userFile)
    {
        string file = userFile;

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string userFile)
    {
        string file = userFile;
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] part = line.Split("~");
            // part[0] - date
            // part[1] - prompt
            // part[2] - response

            Entry entry = new Entry();
            entry._date = part[0];
            entry._promptText = part[1];
            entry._entryText = part[2];

            AddEntry(entry);
        }
    }
}