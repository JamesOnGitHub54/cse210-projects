using System;

public class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Superstar";
        job2._company = "World Wrestling Entertainment";
        job2._startYear = 1990;
        job2._endYear = 2020;

        Resume resume1 = new Resume();
        resume1._name = "Mark Calaway";

        resume1._Jobs.Add(job1);
        resume1._Jobs.Add(job2);

        resume1.Display();
    }
}