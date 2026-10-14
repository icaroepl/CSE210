using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Activity> activities = new List<Activity>();

        float length = 20.0f;  
        float distance = 5.0f;
        Running running = new Running(distance, length);
        float RunningSpeed = running.GetSpeed();
        float runningPace = running.GetPace();  
        activities.Add(running);

        float cyclingSpeed = 15.0f;
        Cycling cycling = new Cycling(cyclingSpeed, length);
        activities.Add(cycling);

        float swimmingLaps = 20.0f;
        Swimming swimming = new Swimming(swimmingLaps, length);
        activities.Add(swimming);


        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
} 