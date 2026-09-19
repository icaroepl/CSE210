using System;

class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
    "What happened of interesting today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "For what am I gratefull for today?",
    "What Impactfull prompt did I had today?"
    };    
    public string GetRandomPrompts()
    {  
        string _randomPrompt = _prompts[Random.Shared.Next(_prompts.Count)];
        return (_randomPrompt);
    }
    
}