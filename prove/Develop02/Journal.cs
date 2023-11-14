using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        Entry entry = new Entry();
    }

    public void DisplayAll()
    {
        //displaying the entries
    }

    public void SaveToFile()
    {
        string fileName = "Journal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            //stuff to put into file
        }
    }

    public void LoadFromFile()
    {
        string fileName = "Journal.txt";

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
        }
    }
}