using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    
    //Display method
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}