using System;

class Program
{
    static void Main()
    {
        List<Activity> activities = new();

        activities.Add(new Running("2021-01-01", "30", 3));
        activities.Add(new Cycling("2021-01-02", "60", 20));
        activities.Add(new Swimming("2021-01-03", "45", 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.getSummary());
            Console.WriteLine($"Distance: {Math.Round(activity.getDistance(),2)} miles");
            Console.WriteLine($"Speed: {Math.Round(activity.getSpeed(),2)} mph");
            Console.WriteLine($"Pace: {Math.Round(activity.getPace(),2)} min/mile");
            Console.WriteLine();
        }
    }
}