using System;

class Journal
{
    public List<Entry> _entries = new List<Entry>();

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

    public void SaveToFile(string file)
    {   
        List<string> lines = new List<string>();
        foreach (Entry entry in _entries){
            string _text = $"{entry._date}~|~{entry._promptText}~|~{entry._entryText}";
            lines.Add(_text);
        }
        
        File.WriteAllLines(file, lines);
    }

   public void LoadFromFile(string file)
    {
        // SAFETY MEASURE
        if (File.Exists(file))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split("~|~");

                if (parts.Length == 3)
                {
                    Entry newEntry = new Entry();
                    newEntry._date = parts[0];
                    newEntry._promptText = parts[1];
                    newEntry._entryText = parts[2];

                    _entries.Add(newEntry);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}