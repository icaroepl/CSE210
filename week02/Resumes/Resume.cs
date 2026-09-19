using System;

public class Resume
{
    public string _name = "Allison Rose";
    public List<Job> _jobs = new List<Job>(); 

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs){
            job.DisplayJobDetails();
        }

    }

}