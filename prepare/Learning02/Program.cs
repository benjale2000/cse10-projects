using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        job job1 = new job();
        job1._jobTitle = "Sofware Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        
        job job2 = new job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Mina Hope";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}