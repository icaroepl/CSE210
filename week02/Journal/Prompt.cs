using System;

class Prompt
{
    public List<string> prompts = new List<string>(); 
    public List<string> stored = new List<string>();
  
    string _randomPrompt;
    public void GetPrompts()
    {
        FillPrompts();
        ShowPrompt();
        GetAwnser();
    }
    
    public void FillPrompts()
    {
        prompts.Add("What happened of interesting today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("For what am I gratefull for today?");
        prompts.Add("What Impactfull prompt did I had today?");
    }

    public void ShowPrompt()
    {
        _randomPrompt = prompts[Random.Shared.Next(prompts.Count)];
        Console.WriteLine($"{_randomPrompt}");
    }
    
    public void GetAwnser()
    {
        string _answer = Console.ReadLine();
        string _date = DateTime.Now.ToString("dd/MM/yyyy");
        stored.Add($"{_date} - {_randomPrompt} \n {_answer}");
    }

    public void DisplayAll()
    {
        foreach (string awnser in stored){
        Console.WriteLine($"{awnser}");           
        }
    }
} 