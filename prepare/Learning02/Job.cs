using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display() //Display METHOD. each word is capital ex. DisplayJobDetails
    {
        //sample output: Software Engineer (Microsoft) 2019-2022
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}