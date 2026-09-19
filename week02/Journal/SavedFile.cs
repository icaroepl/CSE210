using System;

class SavedFile{
    public void SaveFile(Prompt prompt)
    {
        Console.WriteLine($"Enter a FileName");
        string _awnser = Console.ReadLine();
        
        File.WriteAllLines(_awnser, prompt.stored);
    }

    public void LoadFile(Prompt prompt)
    {
        Console.WriteLine($"Enter a FileName");
        string _answer = Console.ReadLine();
        
        if (File.Exists(_answer))
        {
            prompt.stored.Clear();
            string[] lines = File.ReadAllLines(_answer);
            prompt.stored.AddRange(lines);
        }
    }
}