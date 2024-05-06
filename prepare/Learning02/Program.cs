using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new(); 
        job1._companyName = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2021;

        Job job2 = new();
        job2._companyName = "Google";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2021;
        job2._endYear = 2023;  

        Resume resume = new();
        resume._name = "Trevor Bolles";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}