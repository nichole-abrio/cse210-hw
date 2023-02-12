using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Samuel Bennett");
        assignment1.SetTopic("Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment ma1 = new MathAssignment();
        //I could just set a method that would take all the arguments so I don't have to do the stuff below.
        // ie: MathAssignment ma1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        ma1.SetStudentName("Roberto Rodriguez");
        ma1.SetTopic("Fractions");
        ma1.SetTextBookSection("7.3");
        ma1.SetProblems("8-19");
        Console.WriteLine(ma1.GetSummary());
        Console.WriteLine(ma1.GetHomeWorkList());

        WritingAssignment wa1 = new WritingAssignment();
        wa1.SetStudentName("Mary Waters");
        wa1.SetTopic("European History");
        wa1.SetTitle("The Causes of World War II");
        Console.WriteLine(wa1.GetSummary(), wa1.GetWritingInformation());
        Console.WriteLine(wa1.GetWritingInformation());
    }
}