using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer"; //job1 is instance
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        //job1.Display();

        //job2
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Microsoft";
        job2._startYear = 2022;
        job2._endYear = 2023;
        //job2.Display();

        //job3
        Job job3 = new Job();
        job3._jobTitle = "Teacher";
        job3._company = "Pola Central School";
        job3._startYear = 2002;
        job3._endYear = 2022;
        //ob3.Display();

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();


    }
}