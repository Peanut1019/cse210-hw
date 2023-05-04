using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job = new Job();
        job._jobTitle = "Meteor";
        job._company = "Milky Way Galaxy";
        job._startYear = 0;
        job._endYear = 10000;
        job.ShowJob();
        Job job1 = new Job();
        job1._jobTitle = "Dust";
        job1._company = "Milky Way Galaxy";
        job1._startYear = 10000;
        job1._endYear = 100000;
        job1.ShowJob();
        Resume resume = new Resume();
        resume._name = "Fish";
        resume._jobs.Add(job);
        resume._jobs.Add(job1);

        resume.ShowJob();
    }
}